using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDT.Core.TestDefinitions
{
    public class TestParameter : BaseTestArtifact
    {
        public TestParameter()
        {
        }

        public TestParameter(TestParameter copyFrom)
        {
            Name = copyFrom.Name;
        }
    }
}
