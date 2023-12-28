using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWDT.Core.TestDefinitions;

namespace KWDT.Data.SerializedTestArtifacts
{
    public class SerializedTestSuite : BaseSerializedTestArtifact
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

        private List<string> _testSets;

        public List<string> TestSets
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

        public SerializedTestSuite()
        {
            TestSets = new List<string>();
        }

        public SerializedTestSuite(TestSuiteDefinition copyFrom)
        {
            Name = copyFrom.Name;
            Status = copyFrom.Status;
            Description = copyFrom.Description;
            TestSets = copyFrom.TestSets.Select(set => set.Name).ToList();
        }
    }
}
