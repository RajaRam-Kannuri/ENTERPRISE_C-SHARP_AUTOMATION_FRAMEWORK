using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDT.Core.TestDefinitions
{
    public class TestRunDefinition :  BaseTestArtifact
    {
        protected string _environment = "Test";

        public string Environment
        {
            get
            {
                return _environment;
            }

            set
            {
                if (_environment != value)
                {
                    _environment = value;
                    RaisePropertyChanged(nameof(Environment));
                }
            }
        }

        protected string _type;

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged(nameof(Type));
                }
            }
        }

        protected TestSuiteDefinition _testSuite;

        public TestSuiteDefinition TestSuite
        {
            get
            {
                return _testSuite;
            }

            set
            {
                if (_testSuite != value)
                {
                    _testSuite = value;
                    RaisePropertyChanged(nameof(TestSuite));
                }
            }
        }


        protected List<TestCaseDefinition> _testCases;

        public List<TestCaseDefinition> TestCases
        {
            get
            {
                return _testCases;
            }

            set
            {
                if (_testCases != value)
                {
                    _testCases = value;
                    RaisePropertyChanged(nameof(TestCases));
                }
            }
        }

        public TestRunDefinition()
        {
            TestCases = new List<TestCaseDefinition>();
        }

        protected DateTime _runDate;

        public DateTime RunDate
        {
            get
            {
                return _runDate;
            }

            set
            {
                if (_runDate != value)
                {
                    _runDate = value;
                    RaisePropertyChanged(nameof(RunDate));
                }
            }
        }

        protected TimeSpan _elapsedTime;

        public TimeSpan ElapsedTime
        {
            get
            {
                return _elapsedTime;
            }

            set
            {
                if (_elapsedTime != value)
                {
                    _elapsedTime = value;
                    RaisePropertyChanged(nameof(ElapsedTime));
                }
            }
        }
    }
}
