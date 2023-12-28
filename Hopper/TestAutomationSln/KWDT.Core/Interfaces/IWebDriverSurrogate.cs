using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWDT.Core.TestDefinitions;
using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace KWDT.Core.Interfaces
{
    public interface IWebDriverSurrogate
    {
        void Execute(TestStepDefinition step);

        void Dispose();
    }
}
