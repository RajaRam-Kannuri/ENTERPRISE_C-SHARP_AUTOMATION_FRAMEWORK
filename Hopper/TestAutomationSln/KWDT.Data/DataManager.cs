using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KWDT.Core;
using KWDT.Core.TestDefinitions;
using KWDT.Core.Interfaces;
using AutomationFramework;

namespace KWDT.Data
{
    public class DataManger : IDataManager
    {
        private string RepositoryPath => SetupFolder(StringConstants.RepositoryPath);

        private string TestCaseFolder => SetupFolder(StringConstants.TestCaseFolder);

        //private string SharedStepsFolder => SetupFolder(StringConstants.SharedStepsFolder);

        private string TestSetFolder => SetupFolder(StringConstants.TestSetFolder);

        private string TestSuiteFolder => SetupFolder(StringConstants.TestSuiteFolder);

        private string TestResultsFolder => SetupFolder(StringConstants.TestResultsFolder);

        private string GlobalVariablesFolder => SetupFolder(StringConstants.GlobalVariablesFolder);

        private string TestCasesResultsFolder => SetupFolder(StringConstants.TestCasesResultsFolder);

        private string TestSetsResultsFolder => SetupFolder(StringConstants.TestSetsResultsFolder);

        private string TestSuitesResultsFolder => SetupFolder(StringConstants.TestSuitesResultsFolder);

        private List<TestCaseDefinition> savedTestCases { get; set; }

        private List<TestSetDefinition> savedTestSets { get; set; }

        private List<TestSuiteDefinition> savedTestSuites { get; set; }

        private string SetupFolder(string path)
        {
            Directory.CreateDirectory(path);
            return path;
        }

        public List<TestCaseDefinition> LoadAllTestCases()
        {
            List<TestCaseDefinition> testCases = new List<TestCaseDefinition>();
            foreach (string fileName in Directory.EnumerateFiles(TestCaseFolder))
            {
                testCases.Add(LoadTestCase(fileName));
            }

            return testCases;
        }

        public List<TestResultDefinition> LoadAllTestResults()
        {
            int index = 0;
            List<TestResultDefinition> testResults = new List<TestResultDefinition>();

            foreach (string fileName in Directory.EnumerateFiles(TestCasesResultsFolder))
            {
                string sourceFile = fileName;
                testResults.Add(LoadTestResult(fileName));
                DateTime lastModified = File.GetLastWriteTime(fileName);
                testResults[index].DateModified = lastModified.ToString("MM/dd/yy HH:mm");
                testResults[index].Name = TrimFileName(fileName);
                testResults[index].TestType = "Test Case";
                index++;
            }

            foreach (string fileName in Directory.EnumerateFiles(TestSetsResultsFolder))
            {
                string sourceFile = fileName;
                testResults.Add(LoadTestResult(fileName));
                DateTime lastModified = File.GetLastWriteTime(fileName);
                testResults[index].DateModified = lastModified.ToString("MM/dd/yy HH:mm");
                testResults[index].Name = TrimFileName(fileName);
                testResults[index].TestType = "Test Set";
                index++;
            }

            foreach (string fileName in Directory.EnumerateFiles(TestSuitesResultsFolder))
            {
                string sourceFile = fileName;
                testResults.Add(LoadTestResult(fileName));
                DateTime lastModified = File.GetLastWriteTime(fileName);
                testResults[index].DateModified = lastModified.ToString("MM/dd/yy HH:mm");
                testResults[index].Name = TrimFileName(fileName);
                testResults[index].TestType = "Test Suite";
                index++;
            }

            return testResults;
        }

        public List<TestSetDefinition> LoadAllTestSets()
        {
            List<TestSetDefinition> testSets = new List<TestSetDefinition>();
            foreach (string fileName in Directory.EnumerateFiles(TestSetFolder))
            {
                TestSetDefinition tempDef = LoadTestSet(fileName);
                if (tempDef.TestCases.Count > 0)
                    testSets.Add(tempDef);
                else
                    Delete(tempDef);
            }

            return testSets;
        }

        public List<TestSuiteDefinition> LoadAllTestSuites()
        {
            List<TestSuiteDefinition> testSuites = new List<TestSuiteDefinition>();
            foreach (string fileName in Directory.EnumerateFiles(TestSuiteFolder))
            {
                TestSuiteDefinition tempDef = LoadTestSuite(fileName);
                if (tempDef.TestSets.Count > 0)
                    testSuites.Add(tempDef);
                else
                    Delete(tempDef);
            }

            return testSuites;
        }

        public List<GlobalVariableDefinition> LoadAllGlobalVariables()
        {
            List<GlobalVariableDefinition> globalVariables = new List<GlobalVariableDefinition>();
            foreach (string fileName in Directory.EnumerateFiles(GlobalVariablesFolder))
            {
                globalVariables.Add(LoadGlobalVariable(fileName));
            }

            return globalVariables;
        }

        public List<TestStepDefinition> LoadAllSharedTestSteps()
        {
            List<TestStepDefinition> sharedTestSteps = new List<TestStepDefinition>();
            List<TestCaseDefinition> savedTestCases = new List<TestCaseDefinition>();

            savedTestCases = LoadAllTestCases();

            foreach (var savedTestCase in savedTestCases)
            {
                foreach (var testStep in savedTestCase.TestSteps)
                {
                    if (testStep.SharedStep)
                    {
                        sharedTestSteps.Add(testStep);
                    }
                }
            }

            return sharedTestSteps;
        }

        public String TrimFileName(String fileName)
        {
            string[] subString = fileName.Split('\\');
            string newSubString = subString[4];
            string newFileName = newSubString.Replace(".html", "");
            return newFileName;
        }

        public List<string> LoadStatuses()
        {
            return new List<string>
            {
                { "New" },
                { "In progress" },
                { "Ready" },
                { "Needs updating" }
            };
        }

        public List<string> LoadBrowsers()
        {
            return new List<string>
            {
                { "Chrome" },
                { "Firefox" }
            };
        }

        public List<string> LoadRunTypes()
        {
            return new List<string>
            {
                { "Automated" },
                { "Manual" }
            };
        }

        public List<string> LoadEnvironments()
        {
            return new List<string>
            {
                { "Test" },
                { "UAT" },
                { "Production" },
                { "Training" },
                { "Development" }                
            };
        }

        public List<string> LoadServerEnvironments()
        {
            return new List<string>
            {
                { "Test" },
                { "UAT" },
                { "Training" }
            };
        }

        public List<string> LoadPrograms()
        {
            return new List<string>
            {
                { "FTC" },
                { "Gardiner" },
                { "TLE" },
                { "MyScholarShop" },
                { "Epicore" },
                { "Portal" },
                { "PowerBI" },
                { "Reading" }
            };
        }

        public TestCaseDefinition LoadTestCase(string testCaseFile)
        {
            TestCaseDefinition testCase = new TestCaseDefinition();
            string fileContents = File.ReadAllText(testCaseFile);
            testCase = JsonConvert.DeserializeObject<TestCaseDefinition>(fileContents);
            return testCase;
        }

        public TestResultDefinition LoadTestResult(string testResultName)
        {
            TestResultDefinition testResult = new TestResultDefinition();
            return testResult;
        }

        public TestSetDefinition LoadTestSet(string testSetName)
        {
            TestSetDefinition testSet = new TestSetDefinition();
            string fileContents = File.ReadAllText(testSetName);
            testSet = JsonConvert.DeserializeObject<TestSetDefinition>(fileContents);
            return testSet;
        }

        public TestSuiteDefinition LoadTestSuite(string testSuiteName)
        {
            TestSuiteDefinition testSuite = new TestSuiteDefinition();
            string fileContents = File.ReadAllText(testSuiteName);
            testSuite = JsonConvert.DeserializeObject<TestSuiteDefinition>(fileContents);
            return testSuite;
        }

        public GlobalVariableDefinition LoadGlobalVariable(string globalVariableName)
        {
            GlobalVariableDefinition globalVariable = new GlobalVariableDefinition();
            string fileContents = File.ReadAllText(globalVariableName);
            globalVariable = JsonConvert.DeserializeObject<GlobalVariableDefinition>(fileContents);
            return globalVariable;
        }

        public void Save(TestSuiteDefinition testSuite)
        {
            string jsonData = JsonConvert.SerializeObject(testSuite);
            File.WriteAllText(TestSuiteFolder + testSuite.Name + ".json", jsonData);
        }

        public void Save(TestSetDefinition testSet)
        {
            string jsonData = JsonConvert.SerializeObject(testSet);
            File.WriteAllText(TestSetFolder + testSet.Name + ".json", jsonData);
        }

        public void Save(TestCaseDefinition testCase)
        {
            string jsonData = JsonConvert.SerializeObject(testCase);
            //string folder = testCase.Standalone ? TestCaseFolder : SharedStepsFolder;
            string folder = TestCaseFolder;
            File.WriteAllText(folder + testCase.Name + ".json", jsonData);
        }

        public void Save(TestResultDefinition testResult)
        {
            string jsonData = JsonConvert.SerializeObject(testResult);
            File.WriteAllText(TestResultsFolder + testResult.Name + ".json", jsonData);
        }

        public void Save(GlobalVariableDefinition globalVariable)
        {
            string jsonData = JsonConvert.SerializeObject(globalVariable);
            File.WriteAllText(GlobalVariablesFolder + globalVariable.Name + ".json", jsonData);
        }

        public void Delete(TestSuiteDefinition testSuite)
        {
            File.Delete(TestSuiteFolder + testSuite.Name + ".json");
        }

        public void Delete(TestSetDefinition testSet)
        {
            File.Delete(TestSetFolder + testSet.Name + ".json");
        }

        public void Delete(TestCaseDefinition testCase)
        {
            //string folder = testCase.Standalone ? TestCaseFolder : SharedStepsFolder;
            string folder = TestCaseFolder;
            File.Delete(folder + testCase.Name + ".json");
        }

        public void Delete(GlobalVariableDefinition globalVariable)
        {
            File.Delete(GlobalVariablesFolder + globalVariable.Name + ".json");
        }
    }
}
