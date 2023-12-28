using System.Collections.Generic;

namespace KWDT.Core.TestDefinitions
{
    public class TestResultDefinition : TestRunDefinition
    {
        protected List<TestSuiteDefinition> _testSuites;

        public List<TestSuiteDefinition> TestSuites
        {
            get
            {
                return _testSuites;
            }

            set
            {
                if (_testSuites != value)
                {
                    _testSuites = value;
                    RaisePropertyChanged(nameof(TestSuites));
                }
            }
        }

        private string _testType;

        public string TestType
        {
            get
            {
                return _testType;
            }

            set
            {
                if (_testType != value)
                {
                    _testType = value;
                    RaisePropertyChanged(nameof(TestType));
                }
            }
        }

        public TestResultDefinition()
        {
            TestSuites = new List<TestSuiteDefinition>();
        }

        public TestResultDefinition(TestRunDefinition testRun)
        {
            TestSuites = new List<TestSuiteDefinition>();
            PopulateFromRunData(testRun);
        }

        public void PopulateFromRunData(TestRunDefinition testRun)
        {
            _environment = testRun.Environment;
            _testSuite = testRun.TestSuite;
            _runDate = testRun.RunDate;
            _elapsedTime = testRun.ElapsedTime;
            TestSuites.Add(_testSuite);
        }
    }
}
