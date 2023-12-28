using KWDT.Core.Interfaces;
using KWDT.Core.TestExecution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using KWDT.Core.TestDefinitions;
using System.IO;
using AutomationFramework;
using Newtonsoft.Json;

namespace KWDT.Core
{
	public static class Utilities
    {
        public static string browserType;
        public static string environment;
        public static string serverEnvironment;
        public static int? VSTSID;
        public static int? TestPlanID;
        public static int? TestPointID;
        public static int? PageWaitTime;
        public static bool executedByCommandLine;
        static SqlConnection sqlCon;
        static SqlDataReader reader;
        static SqlCommand cmd;

		public static GlobalVariableDefinition LoadGlobalVariable(string globalVariableName)
		{
			GlobalVariableDefinition globalVariable = new GlobalVariableDefinition();
			string fileContents = File.ReadAllText(globalVariableName);
			globalVariable = JsonConvert.DeserializeObject<GlobalVariableDefinition>(fileContents);
			return globalVariable;
		}

		public static List<GlobalVariableDefinition> LoadAllGlobalVariables()
		{
			List<GlobalVariableDefinition> globalVariables = new List<GlobalVariableDefinition>();
			foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
			{
				globalVariables.Add(LoadGlobalVariable(fileName));
			}

			return globalVariables;
		}

		public static TestCaseDefinition LoadTestCase(string testCaseFile)
		{
			TestCaseDefinition testCase = new TestCaseDefinition();
			string fileContents = File.ReadAllText(testCaseFile);
			testCase = JsonConvert.DeserializeObject<TestCaseDefinition>(fileContents);
			return testCase;
		}

		public static List<TestCaseDefinition> LoadAllTestCases()
		{
			List<TestCaseDefinition> testCases = new List<TestCaseDefinition>();
			foreach (string fileName in Directory.EnumerateFiles(StringConstants.TestCaseFolder))
			{
				testCases.Add(LoadTestCase(fileName));
			}

			return testCases;
		}

		public static bool IsValidFilename(string testName)
        {
            string strTheseAreInvalidFileNameChars = new string(System.IO.Path.GetInvalidFileNameChars());
            Regex regInvalidFileName = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars + "'") + "]");

            if (regInvalidFileName.IsMatch(testName)) { return false; };

            return true;
        }

        public static int GenerateID()
        {
            Random rnd = new Random();

            String rndNum = rnd.Next(999).ToString();
            int id = Int32.Parse(DateTime.Now.ToString("HHmmss") + rndNum);

            return id;
        }

        public static void cleanUpConsole()
        {
            foreach (var proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.CloseMainWindow();
            }

            foreach (var proc in Process.GetProcessesByName("geckodriver"))
            {
                proc.CloseMainWindow();

                foreach (var browser in Process.GetProcessesByName("Firefox"))
                {
                    browser.CloseMainWindow();
                }
            }
        }

        public static void SetBrowser(String browser)
        {
            browserType = browser;
        }

        public static String GetBrowser()
        {
            return browserType;
        }

        public static void SetExecutedByCommandLine(bool commandLineBool)
        {
            executedByCommandLine = commandLineBool;
            AutomationFramework.PageMinder.SetCommandLineFlag(commandLineBool);
        }

        public static bool GetExecutedByCommandLine()
        {
            return executedByCommandLine;
        }

        public static void SetEnvironment(String env)
        {
            environment = env;
        }

        public static String GetEnvironment()
        {
            return environment;
        }

        public static void SetServerEnvironment(String env)
        {
            serverEnvironment = env;
        }

        public static String GetServerEnvironment()
        {
            return serverEnvironment;
        }

        public static void SetVSTSItemID(int? id)
        {
            VSTSID = id;
        }

        public static int? GetVSTSItemID()
        {
            return VSTSID;
        }

        public static void SetTestPlanID(int? id)
        {
            TestPlanID = id;
        }

        public static int? GetTestPlanID()
        {
            return TestPlanID;
        }

        public static void SetTestPointID(int? id)
        {
            TestPointID = id;
        }

        public static int? GetTestPointID()
        {
            return TestPointID;
        }

        public static void SetPageWaitTime(int waitTime = 10)
        {
            AutomationUtilities.SetPageWaitTime(waitTime);
        }

        public static void SetStringInjectionText(string text)
        {
            AutomationUtilities.SetStringInjectionText(text);
        }

        public static string GetUrl(string programName)
        {
            String pgmUrl = null;
            String env = GetEnvironment();

            switch (programName)
            {
                case "FTC_PLI":
                    if (env.Equals("Test"))
                        pgmUrl = "https://fltestapp.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://fltestapp.sufs.local/";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://login.sufs.org/";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://fltrainapp.sufs.local/SmartApp/Control.aspx";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://fldevapp.sufs.local/";
                    break;
                case "FTC_SAS":
                    if (env.Equals("Test"))
                        pgmUrl = "http://fltestsas.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://fluatsas.sufs.org/Login.aspx";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://sas.sufs.local/Login.aspx";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://fltrainsas.sufs.local/Login.aspx";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://fldevsas.sufs.local/";
                    break;
                case "FTC_SLI":
                    if (env.Equals("Test"))
                        pgmUrl = "https://fltestschool.sufs.local/Control.aspx?OSP=48";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://fluatschool.sufs.org/Control.aspx?OSP=48&ReturnUrl=%2f";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://schools.sufs.org/Control.aspx?OSP=48";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://fltrainschool.sufs.local/Control.aspx?OSP=48&ReturnUrl=%2f";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://fldevschool.sufs.local/";
                    break;
                case "TLE":
                    if (env.Equals("Test"))
                        pgmUrl = "https://fltesttle.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://fluattle.sufs.org/Account/Login?ReturnUrl=%2f";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://pep.sufs.org/Account/Login?ReturnUrl=%2f";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://peptraining.sufs.org/Account/Login?ReturnUrl=%2f";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://fldevtle.sufs.local/";
                    break;
                case "GAR_PLI":
                    if (env.Equals("Test"))
                        pgmUrl = "https://gardinertestapp.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://gardineruatapp.sufs.org/";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://gardiner.sufs.org/SmartApp/Control.aspx?OSP=5&ReturnUrl=%2f";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://gardinertrainapp.sufs.local/SmartApp/Control.aspx?OSP=5&ReturnUrl=%2f";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://plsadevapp.sufs.local/";
                    break;
                case "GAR_SAS":
                    if (env.Equals("Test"))
                        pgmUrl = "https://gardinertestsas.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://gardineruatsas.sufs.org/";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://gardinersas.sufs.local/Login.aspx";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://gardinertrainsas.sufs.local/";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://gardinerdevsas.sufs.local/";
                    break;
                case "GAR_Provider":
                    if (env.Equals("Test"))
                        pgmUrl = "https://gardinertestproviders.sufs.local/";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://gardineruatproviders.sufs.org/";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://providers.sufs.org/Control.aspx?OSP=173&ReturnUrl=%2f";
                    else if (env.Equals("Training"))
                        pgmUrl = "http://gardinertrainproviders.sufs.local/Control.aspx?OSP=173&ReturnUrl=%2f";
                    else if (env.Equals("Development"))
                        pgmUrl = "http://plsadevproviders.sufs.local/";
                    break;
                case "FTC_OLA":
                    if (env.Equals("Test"))
                        pgmUrl = "https://sufsidentityservertest.azurewebsites.net/Account/Login";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://login.sufs.org/";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://sufsidentityserverdev.azurewebsites.net/Account/Login";
                    break;
                case "MyScholarShop":
                    if (env.Equals("Test"))
                        pgmUrl = "https://s1.ariba.com/gb/?realm=SUFS-T";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://s1.ariba.com/gb/?realm=SUFS-T";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://s1.ariba.com/gb/?realm=SUFS-T";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://s1.ariba.com/gb/?realm=SUFS-T";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://s1.ariba.com/gb/?realm=SUFS-T";
                    break;
                case "Reading":
                    if (env.Equals("Test"))
                        pgmUrl = "https://sufsidentityservertest.azurewebsites.net/Account/Login";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://sufsidentityserverdev.azurewebsites.net/Account/Login";
                    break;
                case "Portal":
                    if (env.Equals("Test"))
                        pgmUrl = "https://sufsidentityservertest.azurewebsites.net/Account/Login";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://login.sufs.org/";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://sufsidentityserveruat.azurewebsites.net/Account/Login";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://sufsidentityserverdev.azurewebsites.net/Account/Login";
                    break;
                case "PowerBI":
                    if (env.Equals("Test"))
                        pgmUrl = "https://app.powerbi.com/home";
                    else if (env.Equals("UAT"))
                        pgmUrl = "https://app.powerbi.com/home";
                    else if (env.Equals("Production"))
                        pgmUrl = "https://app.powerbi.com/home";
                    else if (env.Equals("Training"))
                        pgmUrl = "https://app.powerbi.com/home";
                    else if (env.Equals("Development"))
                        pgmUrl = "https://app.powerbi.com/home";
                    break;
            }

            return pgmUrl;
        }
        
        public static string DBConnect(String sqlCmd, int row, String column, String server)
        {
			String connectionString;

            if (server == string.Empty || server == null)
                connectionString = @"Data Source=.;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;Server=dev-sqlc1n1\test; Database=SUFS";
            else if (server.Contains("AZ-TC"))
                //connectionString = @"Data Source=.;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;;Server=" + server + "; Database=Epicor102300";
                connectionString = @"Data Source=.;Initial Catalog=SUFS;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;;Server=" + server + "; Database=EpicorERP";

            else
                connectionString = @"Data Source=.;User ID=JenkinsQA_SQLUser;password=sdenGD-34!snY;Integrated Security=false;;Server=" + server + "";

            string tableValue = null;
            int counter = 1;

            if (sqlCmd.Contains("$["))
            {
                var splitString = sqlCmd.Split(' ');

                foreach (var subString in splitString)
                {
                    //if (subString.Length > 2 && subString[0].Equals('$') && subString[1].Equals('[') && subString.Trim().EndsWith(@"]"))
                    if (subString.Length > 2 && subString.Contains('$') && subString.Contains('[') && subString.Contains(']'))
                    {
                        string globalVariableName = string.Empty;
                        string newSubString = string.Empty;

                        try
                        {
                            int startPos = subString.LastIndexOf("$") + "$".Length + 1;
                            int length = subString.IndexOf("]") - startPos;
                            newSubString = subString.Substring(startPos, length);
                        }
                        catch { }
                        //load all global variables then try to match name to whatever variable was passed with step.Data
                        List<GlobalVariableDefinition> globalVariables = new List<GlobalVariableDefinition>();

                        foreach (string fileName in Directory.EnumerateFiles(StringConstants.GlobalVariablesFolder))
                        {
                            globalVariables.Add(Utilities.LoadGlobalVariable(fileName));
                        }

                        foreach (var globalVariable in globalVariables)
                        {
                            //globalVariableName = "$[" + globalVariable.Name + "]";
                            globalVariableName = globalVariable.Name;

                            if (globalVariableName.Equals(newSubString))
                            {
                                //Check for UsesSQL flag, if true then execute query in place of variable value
                                if (globalVariable.UsesSQL)
                                {
                                    var returnValue = Utilities.DBConnect(globalVariable.SqlScript.Replace("\r\n", " "), globalVariable.SqlRow, globalVariable.SqlColumn, Utilities.GetSqlServer(globalVariable));
                                    if (returnValue == null)
                                        throw new Exception();

                                    sqlCmd = sqlCmd.Replace(subString, returnValue);
                                    break;
                                }
                                else
                                {
                                    sqlCmd = sqlCmd.Replace("$[" + newSubString + "]", globalVariable.Value);
                                    break;
                                }
                            }
                        }
                    }
                    else if (subString.Length > 2 && subString[0].Equals('\'') && subString[1].Equals('$') && subString.Trim().EndsWith("'"))
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
                            globalVariableName = "'$[" + globalVariable.Name + "]'";

                            if (globalVariableName.Equals(subString))
                            {
                                //Check for UsesSQL flag, if true then execute query in place of variable value
                                if (globalVariable.UsesSQL)
                                {
                                    var returnValue = Utilities.DBConnect(globalVariable.SqlScript.Replace("\r\n", " "), globalVariable.SqlRow, globalVariable.SqlColumn, Utilities.GetSqlServer(globalVariable));
                                    if (returnValue == null)
                                        throw new Exception();

                                    sqlCmd = sqlCmd.Replace(subString, returnValue);
                                    break;
                                }
                                else
                                {
                                    sqlCmd = sqlCmd.Replace(subString, "'" + globalVariable.Value + "'");
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                cmd = new SqlCommand(sqlCmd, sqlCon);
                cmd.CommandTimeout = 60;
                reader = cmd.ExecuteReader();

                if (column == null || column == "" || row < 1)
                {
                    return string.Empty;
                }

                while (reader.Read())
                {
                    tableValue = reader[column].ToString();

                    if (counter == row)
                        break;

                    counter++;

                    //break loop if number of iterations exceeds 100 - will use value of 100th row
                    if (counter > 100)
                        break;
                }
            }

            return tableValue;
        }

		public static String GetSubstring(String text, String start, String end)
		{
			int p1 = text.IndexOf(start) + start.Length;
			int p2 = text.IndexOf(end, p1);

			if (end == "") return (text.Substring(p1));
			else return text.Substring(p1, p2 - p1);
		}

        public static String GetSqlServer(GlobalVariableDefinition globalVariable)
        {
            switch (GetServerEnvironment())
            {
                case "Test":
                    return globalVariable.SqlServer;
                case "UAT":
                    return globalVariable.SqlServerUAT;
                case "Training":
                    return globalVariable.SqlServerTraining;
            }

            return globalVariable.SqlServer;
        }
    }
}
