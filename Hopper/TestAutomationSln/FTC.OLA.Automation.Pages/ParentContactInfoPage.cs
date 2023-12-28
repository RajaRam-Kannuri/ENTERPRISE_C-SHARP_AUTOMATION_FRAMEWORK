using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentContactInfoPage : ApplicationWizardPage
    {
        public EditField HomePhone { get; private set; }
        public EditField WorkPhone { get; private set; }
        public EditField MobilePhone { get; private set; }
        public Text PleaseEnterPhoneNumberMessage { get; private set; }
        public Text PhoneNumberInvalidFormatMessage { get; private set; }
        public Text SpecifiedConditionNotMetForMobilePhoneMessage { get; private set; }

        public ParentContactInfoPage(IWebDriver driver)
            : base(driver)
        {
            HomePhone = new EditField(Driver, By.Id("homePhone"));
            WorkPhone = new EditField(Driver, By.Id("workPhone"));
            MobilePhone = new EditField(Driver, By.Id("mobilePhone"));
            PleaseEnterPhoneNumberMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
            PhoneNumberInvalidFormatMessage = new Text(Driver, By.CssSelector("#question-form > div > div:nth-child(3) > div"));
            SpecifiedConditionNotMetForMobilePhoneMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > ftc-question-screen > div > div > div > div > div.card-content > error-messages > div > ul > li > p"));
        }
    }
}
