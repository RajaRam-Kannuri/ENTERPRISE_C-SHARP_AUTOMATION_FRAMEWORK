using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class LoggedOutHomePage : WizardPage
    {
        public WebElement WelcomeVideo { get; private set; }

        public LoggedOutHomePage(IWebDriver driver)
            : base(driver)
        {
            WelcomeVideo = new WebElement(Driver, By.Id("videoContent"));
        }
    }
}
