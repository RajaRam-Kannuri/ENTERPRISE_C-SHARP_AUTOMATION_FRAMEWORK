using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDT.Core.TestDefinitions
{
    public class TestVariable : BaseTestArtifact
    {
        public Type Type { get; set; }

        public bool UseDefaultValue { get; set; }

        protected object DefaultValue { get; set; }

        public object Value { get; set; }
    }
}
