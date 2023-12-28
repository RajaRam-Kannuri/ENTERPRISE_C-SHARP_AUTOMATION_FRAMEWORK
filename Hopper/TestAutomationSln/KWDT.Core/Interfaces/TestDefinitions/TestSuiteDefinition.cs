using System.Collections.Generic;
using System.Linq;

namespace KWDT.Core.TestDefinitions
{
    public class TestSuiteDefinition : BaseTestArtifact
    {
        private string _status = "New";

        public string Status
        {
            get
            {
                return _status;
            }

            set
            {
                if (_status != value)
                {
                    _status = value;
                    RaisePropertyChanged(nameof(Status));
                }
            }
        }

        private List<TestSetDefinition> _testSets;

        public List<TestSetDefinition> TestSets
        {
            get
            {
                return _testSets;
            }

            set
            {
                if (_testSets != value)
                {
                    _testSets = value;
                    RaisePropertyChanged(nameof(TestSets));
                }
            }
        }

        private string _testType = "Test Suite";

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

        private bool _newTest = true;

        public bool NewTest
        {
            get
            {
                return _newTest;
            }

            set
            {
                if (_newTest != value)
                {
                    _newTest = value;
                    RaisePropertyChanged(nameof(NewTest));
                }
            }
        }

        private int _testID = 0;

        public int TestID
        {
            get
            {
                return _testID;
            }

            set
            {
                if (_testID != value)
                {
                    _testID = value;
                    RaisePropertyChanged(nameof(TestID));
                }
            }
        }

        public TestSuiteDefinition()
        {
            TestSets = new List<TestSetDefinition>();
        }

        public TestSuiteDefinition(TestSuiteDefinition copyFrom)
        {
            //TestSets = copyFrom.TestSets.Select(set => new TestSetDefinition(set)).ToList();
            TestSets = new List<TestSetDefinition>(copyFrom.TestSets);
        }
    }
}
