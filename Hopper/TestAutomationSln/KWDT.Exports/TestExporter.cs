using System;
using KWDT.Core.Interfaces;
using KWDT.Core.TestDefinitions;

namespace KWDT.Exports
{
    public class TestExporter : IExportManager
    {
        public bool Export(TestSuiteDefinition testSuite)
        {
            throw new NotImplementedException();
        }

        public bool Export(TestResultDefinition testResult)
        {
            throw new NotImplementedException();
        }

        public bool Export(TestSetDefinition testSet)
        {
            throw new NotImplementedException();
        }

        public bool Export(TestCaseDefinition testCase)
        {
            throw new NotImplementedException();
        }
    }
}
