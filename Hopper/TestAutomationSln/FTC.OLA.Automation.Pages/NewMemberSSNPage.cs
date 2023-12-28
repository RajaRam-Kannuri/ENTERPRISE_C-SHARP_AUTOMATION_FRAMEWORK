using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberSSNPage : ApplicationWizardPage
    {
        public EditField SSN { get; private set; }
        public EditField SSNVerification { get; private set; }
        public Text SNNDoesNotMatchCorrectPatternMessage { get; private set; }
        public Text SSNEnteredNumbersDoNotMatchMessage { get; private set; }
        public Button ContinueWithoutSSN { get; private set; }

        public NewMemberSSNPage(IWebDriver driver)
            : base(driver)
        {
            SSN = new EditField(Driver, By.Id("ssn"));
            SSNVerification = new EditField(Driver, By.Id("householdMemberSSNVerification"));
            SNNDoesNotMatchCorrectPatternMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div"));
            SSNEnteredNumbersDoNotMatchMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
            ContinueWithoutSSN = new Button(Driver, By.XPath("//a[text() = 'Continue without SSN']"));
        }
    }
}
