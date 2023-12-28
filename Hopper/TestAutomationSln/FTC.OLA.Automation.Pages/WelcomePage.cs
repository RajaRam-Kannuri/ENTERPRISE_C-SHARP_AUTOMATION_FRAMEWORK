using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class WelcomePage :
        BasePage
    {
        public Button GoToIncomeBasedScholarshipButton { get; private set; }
        public Button GoToReadingHelpScholarshipButton { get; private set; }

        public WelcomePage(IWebDriver driver)
            : base(driver)
        {
            GoToIncomeBasedScholarshipButton = new Button(Driver, By.XPath("//*[contains(@href, 'scholarships/ftc')]"));
            GoToReadingHelpScholarshipButton = new Button(Driver, By.XPath("//*[contains(@href, 'scholarships/reading')]"));
        }
    }
}
