using System.Collections.Generic;
using System.Linq;

namespace KWDT.Core.TestDefinitions
{
    public class TestSetDefinition : BaseTestArtifact
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

        private List<TestCaseDefinition> _testCases;

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

        private string _testType = "Test Set";

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

        private string _testPointID;

        public string TestPointID
        {
            get
            {
                return _testPointID;
            }

            set
            {
                if (_testPointID != value)
                {
                    _testPointID = value;
                    RaisePropertyChanged(nameof(TestPointID));
                }
            }
        }

        private string _testPlanID;

        public string TestPlanID
        {
            get
            {
                return _testPlanID;
            }

            set
            {
                if (_testPlanID != value)
                {
                    _testPlanID = value;
                    RaisePropertyChanged(nameof(TestPlanID));
                }
            }
        }

        public TestSetDefinition()
        {
            TestCases = new List<TestCaseDefinition>();
        }

        public TestSetDefinition(TestSetDefinition copyFrom)
        {
            //TestCases = copyFrom.TestCases.Select(kase => new TestCaseDefinition(kase)).ToList();
            TestCases = new List<TestCaseDefinition> (copyFrom.TestCases);
        }
    }
}
