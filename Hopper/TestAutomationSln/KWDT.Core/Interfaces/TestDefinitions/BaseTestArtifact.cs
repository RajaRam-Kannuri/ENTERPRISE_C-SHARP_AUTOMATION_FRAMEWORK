using System.ComponentModel;

namespace KWDT.Core.TestDefinitions
{
    public abstract class BaseTestArtifact : INotifyPropertyChanged
    {
        protected string _name = "";

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(nameof(Name));
                }
            }
        }

        private string _dateModified;

        public string DateModified
        {
            get
            {
                return _dateModified;
            }

            set
            {
                if (_dateModified != value)
                {
                    _dateModified = value;
                    RaisePropertyChanged(nameof(DateModified));
                }
            }
        }

        protected string _description;

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged(nameof(Description));
                }
            }
        }

        private string _program = "FTC";

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

        private string _browser = "Chrome";

        public string Browser
        {
            get
            {
                return _browser;
            }

            set
            {
                if (_browser != value)
                {
                    _browser = value;
                    RaisePropertyChanged(nameof(Browser));
                }
            }
        }

        private string _environment = "Test";

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

        private string _serverEnvironment = "Test";

        public string ServerEnvironment
        {
            get
            {
                return _serverEnvironment;
            }

            set
            {
                if (_serverEnvironment != value)
                {
                    _serverEnvironment = value;
                    RaisePropertyChanged(nameof(ServerEnvironment));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
