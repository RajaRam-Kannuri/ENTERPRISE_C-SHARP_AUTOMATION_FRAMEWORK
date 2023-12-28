using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentSSNPage : ApplicationWizardPage
    {
        public EditField SSN { get; private set; }
        public EditField SSNVerification { get; private set; }
        public Text SNNDoesNotMatchCorrectPatternMessage { get; private set; }
        public Text SSNEnteredNumbersDoNotMatchMessage { get; private set; }
        public Text WhyAreWeAskingLink{ get; private set; }
        public Modal WhyAreWeAskingModal { get; private set; }
        public Button OKButton { get; private set; }
        public Button AddTheSSN { get; private set; }
        public Button ContinueWithoutSSN { get; private set; }

        public ParentSSNPage(IWebDriver driver)
            : base(driver)
        {
            SSN = new EditField(Driver, By.Id("ssn"));
            SSNVerification = new EditField(Driver, By.Id("ssnVerification"));
            SNNDoesNotMatchCorrectPatternMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(1) > div"));
            SSNEnteredNumbersDoNotMatchMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
            //WhyAreWeAskingLink = new Text(Driver, By.XPath("//*[contains(@a, 'Why are we asking for this?')]"));
            WhyAreWeAskingLink = new Text(Driver, By.XPath("//span[text() = 'Why are we asking for this?']"));
            WhyAreWeAskingModal = new Modal(Driver, By.Id("fesSsnModalId"));
            OKButton = new Button(Driver, By.CssSelector("#fesSsnModalId > div.modal-footer > a"));
            AddTheSSN = new Button(Driver, By.XPath("//a[text() = 'Add the SSN']"));
            ContinueWithoutSSN = new Button(Driver, By.XPath("//a[text() = 'Continue without SSN']"));
        }
    }
}
