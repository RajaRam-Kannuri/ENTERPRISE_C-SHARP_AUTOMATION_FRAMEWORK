using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TestData
    {
        public string FormattedLogMessage { get; set; }

        public bool Compare<T>(T actual, T expected, string logMessage)
        {
            if (expected == null) return true;
            bool result = Equals(actual, expected);
            if (!result)
                FormattedLogMessage = String.Format("\t" + logMessage + " did not match. Actual: {0}, Expected: {1}", actual, expected);

            return result;
        }
    }
}
