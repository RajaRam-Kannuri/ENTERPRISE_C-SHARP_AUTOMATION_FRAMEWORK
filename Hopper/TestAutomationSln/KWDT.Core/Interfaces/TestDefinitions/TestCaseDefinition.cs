using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System;

namespace KWDT.Core.TestDefinitions
{
    public class TestCaseDefinition : BaseTestArtifact
    {
        private List<TestStepDefinition> _testSteps;

        public List<TestStepDefinition> TestSteps
        {
            get
            {
                return _testSteps;
            }

            set
            {
                if (_testSteps != value)
                {
                    _testSteps = value;
                    RaisePropertyChanged(nameof(TestSteps));
                }
            }
        }

        private string _testType = "Test Case";

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

        private string _runType = "Automated";

        public string RunType
        {
            get
            {
                return _runType;
            }

            set
            {
                if (_runType != value)
                {
                    _runType = value;
                    RaisePropertyChanged(nameof(RunType));
                }
            }
        }

        private bool _standalone = true;

        public bool Standalone
        {
            get
            {
                return _standalone;
            }

            set
            {
                if (_standalone != value)
                {
                    _standalone = value;
                    RaisePropertyChanged(nameof(Standalone));
                }
            }
        }

        private bool _productionSafe = true;

        public bool ProductionSafe
        {
            get
            {
                return _productionSafe;
            }

            set
            {
                if (_productionSafe != value)
                {
                    _productionSafe = value;
                    RaisePropertyChanged(nameof(ProductionSafe));
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

        private string _injectionString = String.Empty;

        public string InjectionString
        {
            get
            {
                return _injectionString;
            }

            set
            {
                if (_injectionString != value)
                {
                    _injectionString = value;
                    RaisePropertyChanged(nameof(InjectionString));
                }
            }
        }

        public List<TestParameter> Parameters { get; set; }

        public TestCaseDefinition(TestCaseDefinition copyFrom)
        {
            TestSteps = copyFrom.TestSteps.Select(step => new TestStepDefinition(step)).ToList();
            Parameters = copyFrom.Parameters.Select(parameter => new TestParameter(parameter)).ToList();
        }

        public TestCaseDefinition()
        {
            TestSteps = new List<TestStepDefinition>();
            Parameters = new List<TestParameter>();
        }

        public void AddStep(TestStepDefinition step)
        {
            TestSteps.Add(step);
        }
    }
}
