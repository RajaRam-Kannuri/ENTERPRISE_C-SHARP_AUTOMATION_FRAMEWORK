using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.Interfaces
{
    public interface IDataManager
    {
        #region Artifact list loaders

        List<TestStepDefinition> LoadAllSharedTestSteps();

        List<TestCaseDefinition> LoadAllTestCases();

        List<TestSetDefinition> LoadAllTestSets();

        List<TestSuiteDefinition> LoadAllTestSuites();

        List<TestResultDefinition> LoadAllTestResults();

        List<GlobalVariableDefinition> LoadAllGlobalVariables();

        List<string> LoadStatuses();

        List<string> LoadBrowsers();

        List<string> LoadRunTypes();

        List<string> LoadEnvironments();

        List<string> LoadServerEnvironments();

        List<string> LoadPrograms();

        #endregion Artifact list loaders

        #region Single artifact loaders

        TestCaseDefinition LoadTestCase(string testCaseFile);

        TestSetDefinition LoadTestSet(string testSetName);

        TestSuiteDefinition LoadTestSuite(string testSuiteName);

        TestResultDefinition LoadTestResult(string testResultName);

        GlobalVariableDefinition LoadGlobalVariable(string GlobalVariableName);

        #endregion Single artifact loaders

        #region Artifact savers

        void Save(TestCaseDefinition testCase);

        void Save(TestSetDefinition testSet);

        void Save(TestSuiteDefinition testSuite);

        void Save(TestResultDefinition testResult);

        void Save(GlobalVariableDefinition globalVariable);
        
        #endregion Artifact savers

        #region Artifact deleters

        void Delete(TestCaseDefinition testCase);

        void Delete(TestSetDefinition testSet);

        void Delete(TestSuiteDefinition testSuite);

        void Delete(GlobalVariableDefinition globalVariable);

        #endregion Artifact deleters
    }
}
