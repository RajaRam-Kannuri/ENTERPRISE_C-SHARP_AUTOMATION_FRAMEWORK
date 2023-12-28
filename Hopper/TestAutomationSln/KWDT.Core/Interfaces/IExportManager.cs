using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWDT.Core.TestDefinitions;

namespace KWDT.Core.Interfaces
{
    public interface IExportManager
    {
        bool Export(TestCaseDefinition testCase);

        bool Export(TestSetDefinition testSet);

        bool Export(TestSuiteDefinition testSuite);

        bool Export(TestResultDefinition testResult);
    }
}
