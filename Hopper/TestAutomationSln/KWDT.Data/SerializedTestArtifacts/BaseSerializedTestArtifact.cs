using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace KWDT.Data.SerializedTestArtifacts
{
    public class BaseSerializedTestArtifact : INotifyPropertyChanged
    {
        protected string _name;

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
