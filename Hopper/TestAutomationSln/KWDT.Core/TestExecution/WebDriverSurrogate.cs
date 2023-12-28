using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutomationFramework;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;
using System.IO;
using OpenQA.Selenium;
using System.Text;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NCalc;
using AventStack.ExtentReports;
using Newtonsoft.Json;

namespace KWDT.Core.TestExecution
{
    public class WebDriverSurrogate : IWebDriverSurrogate
    {
        private readonly IMinderFactory _minderFactory;

        private IDictionary<string, object> _testData;

        private readonly Lazy<PageMinder> _minder;

        private List<GlobalVariableDefinition> savedGlobalVariables { get; set; }

        private readonly string _programName;

        private readonly IAutomationFrameworkExaminer _frameworkExaminer;

        private string curPage;

        private string prevPage = string.Empty;

        public string pageLoadTime;

        public string currentUrl;

        public Stopwatch sw = null;

        public WebDriverSurrogate(IMinderFactory minderFactory, string programName, IAutomationFrameworkExaminer frameworkExaminer)
        {
            if (frameworkExaminer == null)
                throw new ArgumentNullException(nameof(frameworkExaminer));

            _frameworkExaminer = frameworkExaminer;

            if (minderFactory == null)
                throw new ArgumentNullException(nameof(minderFactory));

            _minderFactory = minderFactory;

            if (programName == null)
                throw new ArgumentNullException(nameof(programName));

            _programName = programName;

            _minder = new Lazy<PageMinder>(() => _minderFactory.Create(_programName));

            _testData = new Dictionary<string, object>();
        }

        public void Dispose()
        {
            if (_minder.IsValueCreated)
            {
                _minder.Value.Dispose();
            }
        }

        public String GetPageLoadTime()
        {
            return pageLoadTime;
        }

        public void Execute(TestStepDefinition step)
        {
            string data = "";
            object pageElement = null;

            //initiate stopwatch to track page load times
            if (sw != null)
            {
                sw.Stop();
                pageLoadTime = sw.Elapsed.TotalSeconds.ToString("0.#######");
                TestResultLogger.SetPageLoadTime(pageLoadTime);
            }
            sw = null;

            sw = Stopwatch.StartNew();

            object page = _minder.Value.GetType().GetProperty(step.Entity).GetValue(_minder.Value, null);
            PropertyInfo elementAsPageProperty = page.GetType().GetProperty(step.Element);
            currentUrl = ((BasePage)page).Driver.Url;

            if (elementAsPageProperty == null)
            {
                List<PropertyInfo> sectionElements = page.GetType().GetProperties().Where(prop => prop.PropertyType.BaseType == typeof(ControlSection)).ToList();
                foreach (PropertyInfo sectionElement in sectionElements)
                {
                    var section = sectionElement.GetValue(page, null);
                    elementAsPageProperty = section.GetType().GetProperty(step.Element);
                    if (elementAsPageProperty != null)
                        pageElement = elementAsPageProperty.GetValue(section, null);

                    if (pageElement != null) break;
                }
            }
            else
            {
                pageElement = elementAsPageProperty.GetValue(page, null);
            }

            if (pageElement == null)
            {
                TestResultLogger.Fail("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Unable to locate the element", step.Program, step.Entity);

                throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Unable to locate the element");
            }

            MethodInfo action = _frameworkExaminer.GetMethodsByControlType(step.ElementType).FirstOrDefault(method => method.Name == step.Action);
            if (action == null)
                action = _frameworkExaminer.GetKeywordTestingExtensionMethods(step.ElementType).FirstOrDefault(method => method.Name == step.Action);

            if (action == null)
            {
                TestResultLogger.Fail("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Invalid element type '" + step.ElementType + "'" + " and/or action '" + step.Action + "'", step.Program, step.Entity);

                throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Invalid element type '" + step.ElementType + "'" + " and/or action '" + step.Action + "'");
            }

            List<object> stepParameters = new List<object>();

            List<ParameterInfo> actionParameters = action.GetParameters().ToList();
            actionParameters.ForEach(actionParam =>
            {
                if (actionParam.ParameterType.FullName.Contains("IWebElement"))
                    stepParameters.Add(pageElement);
                else
                {
                    //sets data value depending on how many parameters are expected by the action
                    if (actionParameters.IndexOf(actionParam) == 2)
                    {
                        data = step.Data2;
                    }
                    else
                        data = step.Data;

                    if (data != null && data.Length > 3)
                    {
                        if (data[0].Equals('$') && data[1].Equals('[') && data.Trim().EndsWith(@"]"))
                        {
                            string globalVariableName;

                            //load all global variables then try to match name to whatever variable was passed with step.Data
                            List<GlobalVariableDefinition> globalVariables = new List<GlobalVariableDefinition>();

                            foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
                            {
                                globalVariables.Add(Utilities.LoadGlobalVariable(fileName));
                            }

                            foreach (var globalVariable in globalVariables)
                            {
                                globalVariableName = "$[" + globalVariable.Name + "]";

                                if (globalVariableName.Equals(data))
                                {
                                    //Check for UsesSQL flag, if true then execute query in place of variable value
                                    if (globalVariable.UsesSQL)
                                    {
                                        try
                                        {
                                            if (step.Action.Equals("VerifyDropdownListWithSQLResults") || step.Action.Equals("VerifyTableColumnBySQLQuery"))
                                            {
                                                string[] sqlAtt = new string[] { globalVariable.SqlScript, globalVariable.SqlColumn, Utilities.GetSqlServer(globalVariable) };
                                                data = string.Join("+,&", sqlAtt.ToArray());
                                            }
                                            else
                                            {
                                                data = Utilities.DBConnect(globalVariable.SqlScript.Replace("\r\n", " "), globalVariable.SqlRow, globalVariable.SqlColumn, Utilities.GetSqlServer(globalVariable));
                                                if (data == null && step.Action.Equals("ExecuteSqlQueryUseSecondaryDataIfQueryNull"))
                                                    data = step.Data2;
                                                else if (data == null)
                                                    throw new Exception();
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error: " + e.Message);
                                        }

                                        break;
                                    }
                                    else
                                    {
                                        data = globalVariable.Value;
                                        break;
                                    }
                                }
                            }
                        }

                        if (data.Length > 2 && data[0].Equals('(') && data.Trim().EndsWith(@")"))
                        {
                            if (data.IndexOfAny("+-/*".ToCharArray()) != -1)
                            {
                                var equation = data;

                                if (equation.Contains("$[") && equation.Contains("]"))
                                {
                                    //load all global variables then try to match name to whatever variable was passed with step.Data
                                    List<GlobalVariableDefinition> globalVariables = new List<GlobalVariableDefinition>();
                                    List<string> files = new List<string>();

                                    foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
                                    {
                                        globalVariables.Add(Utilities.LoadGlobalVariable(fileName));
                                        string[] substrings = fileName.Split('\\');
                                        files.Add(substrings[3].Replace(".json", ""));
                                    }

                                    while (equation.Contains("$[") && equation.Contains("]"))
                                    {
                                        var globalVar = Utilities.GetSubstring(equation, "$[", "]");

                                        if (!files.Contains(globalVar))
                                        {
                                            throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + equation + "<br>" + "Error: One or more of the Global Variables in the Data field do not exist");
                                        }

                                        foreach (var globalVariable in globalVariables)
                                        {
                                            if (globalVariable.Name.Equals(globalVar))
                                            {
                                                //Check for UsesSQL flag, if true then execute query in place of variable value
                                                if (globalVariable.UsesSQL)
                                                {
                                                    try
                                                    {
                                                        data = Utilities.DBConnect(globalVariable.SqlScript.Replace("\r\n", " "), globalVariable.SqlRow, globalVariable.SqlColumn, globalVariable.SqlServer);
                                                        if (data == null)
                                                            throw new Exception();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error: " + ex.Message);
                                                    }

                                                    break;
                                                }
                                                else
                                                {
                                                    data = globalVariable.Value;
                                                    break;
                                                }
                                            }
                                        }

                                        equation = equation.Replace("$[" + globalVar + "]", data);
                                    }
                                }

                                Expression e = new Expression(equation);
                                data = e.Evaluate().ToString();
                            }
                        }
                    }

                    if (data == "")
                        stepParameters.Add(data);
                    else
                    {
                        if (AutomationUtilities.GetStringInjectionText() == "")
                            stepParameters.Add(data);
                        else
                            stepParameters.Add(data + AutomationUtilities.GetStringInjectionText());
                    }
                }
            });

            //check if current page equals previous page. If not then execute page load method
            curPage = page.ToString();

            if (!curPage.Equals(prevPage))
                UIElementManager.WaitForPageLoad(((BasePage)page).Driver);

            prevPage = curPage;

            //var tryAgain = 0;
            ////execute action again if first try fails. 0 and 1 represent first two executions
            //while (tryAgain < 2)
            //{
            try
            {
                (((BasePage)page).Driver).Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                var returnedValue = action.Invoke(pageElement, stepParameters.ToArray());

                if (returnedValue != null && step.SaveVariable == true)
                {
                    GlobalVariableDefinition globalVariable = new GlobalVariableDefinition();
                    globalVariable.Name = step.VariableName;
                    globalVariable.Value = (string)returnedValue;

                    if (globalVariable.VariableID == 0)
                    {
                        globalVariable.VariableID = Utilities.GenerateID();
                    }

                    string jsonData = JsonConvert.SerializeObject(globalVariable);
                    File.WriteAllText(StringConstants.GlobalVariablesFolder + globalVariable.Name + ".json", jsonData);
                }

                if (returnedValue != null && returnedValue is Boolean && !(bool)returnedValue)
                {
                    //throw new Exception("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: " + step.Element + " does not match or contain the expected value.");
                    string errorMessage;

                    errorMessage = "URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: " + step.Element + " does not match or contain the expected value.";


                    TestResultLogger.Screenshot(((BasePage)page).Driver, step.Program, step.Entity);

                    TestResultLogger.Fail(errorMessage, step.Program, step.Entity);
                    throw new Exception("End test");
                    //return;
                }

                TestResultLogger.Screenshot(((BasePage)page).Driver, step.Program, step.Entity);

                TestResultLogger.Pass("URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data, step.Program, step.Entity);
            }
            //    tryAgain = 2;
            //}
            catch (Exception E)
            {
                //if (tryAgain < 1)
                //{
                //    Thread.Sleep(2000);
                //    tryAgain++;
                //    continue;
                //}
                //else
                //    tryAgain++;

                if(E.Message.Equals("End test"))
                    throw new Exception("Logged");

                string errorMessage;

                //if (E.Message.Equals("Exception has been thrown by the target of an invocation."))
                //    errorMessage = "URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Unable to locate element";
                //else
                //    errorMessage = E.Message;
                errorMessage = "URL: " + currentUrl + "<br>" + "Page: " + step.Entity + "<br>" + "Element: " + step.Element + "<br>" + "Action: " + step.Action + "<br>" + "Data: " + data + "<br>" + "Error Message: Unable to locate element" + E.Message;


                TestResultLogger.Screenshot(((BasePage)page).Driver, step.Program, step.Entity);

                TestResultLogger.Fail(errorMessage, step.Program, step.Entity);

                //throwing another exception here tells Hopper to close out current test case and move on to the next --"Logged" means logger doesn't have to log the error again
                throw new Exception("Logged");
            }
            //}
        }
    }
}
