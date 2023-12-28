using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class ClassDetailsPage : CommonPage
    {
        public WebElement SaveStatusMessage { get; private set; }
        public ClassDetailsPage(IWebDriver driver)
            : base(driver)
        {
            SaveStatusMessage = new WebElement(Driver, By.ClassName("toast-message"));
        }
    }
}
