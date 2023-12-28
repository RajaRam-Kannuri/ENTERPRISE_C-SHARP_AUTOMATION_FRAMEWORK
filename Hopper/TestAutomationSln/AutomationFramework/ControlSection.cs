using System;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class ControlSection
    {
        public IWebDriver Driver { get; }

        public ControlSection(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
