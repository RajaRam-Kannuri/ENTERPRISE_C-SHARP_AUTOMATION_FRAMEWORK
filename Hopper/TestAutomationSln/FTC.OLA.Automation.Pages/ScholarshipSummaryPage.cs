using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ScholarshipSummaryPage : ApplicationWizardPage
    {
        public Button StudentButton { get; private set; }
        public Button SummaryButton { get; private set; }
        public Button StartButton { get; private set; }
        public Link NoIncomeFormLink { get; private set; }

        public ScholarshipSummaryPage(IWebDriver driver)
            : base(driver)
        {
            StudentButton = new Button(Driver, By.XPath("//span[text() = 'Student']"));
            SummaryButton = new Button(Driver, By.CssSelector("#question-next-button"));
            StartButton = new Button(Driver, By.XPath("//span[text() = 'Start']"));
            NoIncomeFormLink = new Link(Driver, By.XPath("//*[contains(@href, 'scholarship/no-income;returnUrl=%2Fscholarship%2Fscholarship-summary')]"));
        }
    }
}
