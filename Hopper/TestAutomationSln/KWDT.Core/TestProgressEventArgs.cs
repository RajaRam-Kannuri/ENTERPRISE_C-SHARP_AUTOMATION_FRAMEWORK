using System;
using KWDT.Core.TestExecution;

namespace KWDT.Core
{
    public class TestProgressEventArgs : EventArgs
    {
        public TestCaseExecutionProgress TestProgress { get; set; }
    }
}
