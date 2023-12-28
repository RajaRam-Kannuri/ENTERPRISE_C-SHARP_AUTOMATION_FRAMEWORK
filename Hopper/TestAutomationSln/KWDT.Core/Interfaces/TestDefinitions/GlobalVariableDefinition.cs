using System.Collections.Generic;
using System.Linq;

namespace KWDT.Core.TestDefinitions
{
    public class GlobalVariableDefinition : BaseTestArtifact
    {
        private string _value;

        public string Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (_value != value)
                {
                    _value = value;
                    RaisePropertyChanged(nameof(Value));
                }
            }
        }

        private int _variableID = 0;

        public int VariableID
        {
            get
            {
                return _variableID;
            }

            set
            {
                if (_variableID != value)
                {
                    _variableID = value;
                    RaisePropertyChanged(nameof(VariableID));
                }
            }
        }

        private bool _favorite = false;

        public bool Favorite
        {
            get
            {
                return _favorite;
            }

            set
            {
                if (_favorite != value)
                {
                    _favorite = value;
                    RaisePropertyChanged(nameof(Favorite));
                }
            }
        }

        private bool _usesSQL = false;

        public bool UsesSQL
        {
            get
            {
                return _usesSQL;
            }

            set
            {
                if (_usesSQL != value)
                {
                    _usesSQL = value;
                    RaisePropertyChanged(nameof(UsesSQL));
                }
            }
        }

        private string _sqlScript;

        public string SqlScript
        {
            get
            {
                return _sqlScript;
            }

            set
            {
                if (_sqlScript != value)
                {
                    _sqlScript = value;
                    RaisePropertyChanged(nameof(SqlScript));
                }
            }
        }

		private string _sqlServer;

		public string SqlServer
		{
			get
			{
				return _sqlServer;
			}

			set
			{
				if (_sqlServer != value)
				{
					_sqlServer = value;
					RaisePropertyChanged(nameof(SqlServer));
				}
			}
		}

        private string _sqlServerUAT;

        public string SqlServerUAT
        {
            get
            {
                return _sqlServerUAT;
            }

            set
            {
                if (_sqlServerUAT != value)
                {
                    _sqlServerUAT = value;
                    RaisePropertyChanged(nameof(SqlServerUAT));
                }
            }
        }

        private string _sqlServerTraining;

        public string SqlServerTraining
        {
            get
            {
                return _sqlServerTraining;
            }

            set
            {
                if (_sqlServerTraining != value)
                {
                    _sqlServerTraining = value;
                    RaisePropertyChanged(nameof(SqlServerTraining));
                }
            }
        }

        private string _sqlColumn;

        public string SqlColumn
        {
            get
            {
                return _sqlColumn;
            }

            set
            {
                if (_sqlColumn != value)
                {
                    _sqlColumn = value;
                    RaisePropertyChanged(nameof(SqlColumn));
                }
            }
        }

        private int _sqlRow = 1;

        public int SqlRow
        {
            get
            {
                return _sqlRow;
            }

            set
            {
                if (_sqlRow != value)
                {
                    _sqlRow = value;
                    RaisePropertyChanged(nameof(SqlRow));
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

		public GlobalVariableDefinition()
        {
        }

        public GlobalVariableDefinition(GlobalVariableDefinition copyFrom)
        {
            //GlobalVariables = copyFrom.TestSets.Select(set => new GlobalVariableDefinition(set)).ToList();
        }
    }
}
