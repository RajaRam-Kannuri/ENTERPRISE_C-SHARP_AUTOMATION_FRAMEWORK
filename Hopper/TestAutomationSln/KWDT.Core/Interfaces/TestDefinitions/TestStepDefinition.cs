namespace KWDT.Core.TestDefinitions
{
    public class TestStepDefinition : BaseTestArtifact
    {
        private string _program;

        public string Program
        {
            get
            {
                return _program;
            }

            set
            {
                if (_program != value)
                {
                    _program = value;
                    RaisePropertyChanged(nameof(Program));
                }
            }
        }

        private string _entity { get; set; }

        public string Entity
        {
            get
            {
                return _entity;
            }

            set
            {
                if (_entity != value)
                {
                    _entity = value;
                    RaisePropertyChanged(nameof(Entity));
                }
            }
        }

        private string _element { get; set; }

        public string Element
        {
            get
            {
                return _element;
            }

            set
            {
                if (_element != value)
                {
                    _element = value;
                    RaisePropertyChanged(nameof(Element));
                }
            }
        }

        private string _elementType { get; set; }

        public string ElementType
        {
            get
            {
                return _elementType;
            }

            set
            {
                if (_elementType != value)
                {
                    _elementType = value;
                    RaisePropertyChanged(nameof(ElementType));
                }
            }
        }

        private string _action { get; set; }

        public string Action
        {
            get
            {
                return _action;
            }

            set
            {
                if (_action != value)
                {
                    _action = value;
                    RaisePropertyChanged(nameof(Action));
                }
            }
        }

		private string _data = string.Empty;

        public string Data
        {
            get
            {
                return _data;
            }

            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged(nameof(Data));
                }
            }
        }

		private string _data2 = string.Empty;

		public string Data2
		{
			get
			{
				return _data2;
			}

			set
			{
				if (_data2 != value)
				{
					_data2 = value;
					RaisePropertyChanged(nameof(Data2));
				}
			}
		}

		private string _note { get; set; }

        public string Note
        {
            get
            {
                return _note;
            }

            set
            {
                if (_note != value)
                {
                    _note = value;
                    RaisePropertyChanged(nameof(Note));
                }
            }
        }

        private bool? _passed { get; set; }

        public bool? Passed
        {
            get
            {
                return _passed;
            }

            set
            {
                if (_passed != value)
                {
                    _passed = value;
                    RaisePropertyChanged(nameof(Passed));
                }
            }
        }

        private bool? _saveVariable = false;

        public bool? SaveVariable
        {
            get
            {
                return _saveVariable;
            }

            set
            {
                if (_saveVariable != value)
                {
                    _saveVariable = value;
                    RaisePropertyChanged(nameof(SaveVariable));
                }
            }
        }

        private string _variableName = "";

        public string VariableName
        {
            get
            {
                return _variableName;
            }

            set
            {
                if (_variableName != value)
                {
                    _variableName = value;
                    RaisePropertyChanged(nameof(VariableName));
                }
            }
        }

        private bool? _breakpoint = false;

        public bool? Breakpoint
        {
            get
            {
                return _breakpoint;
            }

            set
            {
                if (_breakpoint != value)
                {
                    _breakpoint = value;
                    RaisePropertyChanged(nameof(Breakpoint));
                }
            }
        }

        private bool? _delete = false;

        public bool? Delete
        {
            get
            {
                return _delete;
            }

            set
            {
                if (_delete != value)
                {
                    _delete = value;
                    RaisePropertyChanged(nameof(Delete));
                }
            }
        }

        private bool _sharedStep = false;

        public bool SharedStep
        {
            get
            {
                return _sharedStep;
            }

            set
            {
                if (_sharedStep != value)
                {
                    _sharedStep = value;
                    RaisePropertyChanged(nameof(SharedStep));
                }
            }
        }

        public TestStepDefinition()
        {
            Passed = null;
        }

        public TestStepDefinition(TestStepDefinition copyFrom)
        {
            Entity = copyFrom.Entity;
            Element = copyFrom.Element;
            ElementType = copyFrom.ElementType;
            Action = copyFrom.Action;
            Data = copyFrom.Data;
			Data2 = copyFrom.Data2;
			Note = copyFrom.Note;
            SaveVariable = copyFrom.SaveVariable;
            VariableName = copyFrom.VariableName;
            SharedStep = copyFrom.SharedStep;
            Passed = null;
            Program = copyFrom.Program;
        }
    }
}
