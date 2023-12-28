using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWDT.Core.TestDefinitions;

namespace KWDT.Data.SerializedTestArtifacts
{
    public class SerializedTestSet : BaseSerializedTestArtifact
    {
        private string _status;

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

        private List<string> _testCases;

        public List<string> TestCases
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

        public SerializedTestSet()
        {
            TestCases = new List<string>();
        }

        public SerializedTestSet(TestSetDefinition copyFrom)
        {
            Name = copyFrom.Name;
            Status = copyFrom.Status;
            Description = copyFrom.Description;
            TestCases = copyFrom.TestCases.Select(kase => kase.Name).ToList();
        }
    }
}
