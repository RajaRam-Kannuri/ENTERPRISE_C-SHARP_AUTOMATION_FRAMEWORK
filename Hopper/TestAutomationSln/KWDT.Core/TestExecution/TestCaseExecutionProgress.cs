using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDT.Core.TestExecution
{
    public class TestCaseExecutionProgress
    {
        public int PassedValidations { get; set; }

        public int FailedValidations { get; set; }

        public int TotalValidations { get; set; }
    }
}
