using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework
{
    public static class Logger
    {
        private static TestContext _testContext;

        static Logger()
        {
        }

        public static void SetContext(TestContext context = null)
        {
            _testContext = context;
        }

        public static void Log(string format, params string[] args)
        {
            if(_testContext != null)
                _testContext.WriteLine(format, args);
        }

        public static void Log(string message)
        {
            if (_testContext != null)
                _testContext.WriteLine(message);
        }
    }
}
