using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Portal.Automation.Pages
{
    public class TermsAndConditionsPage : PortalBasePage
    {
        public Button ConsentToReceivePrerecordedMessagesYES_Button { get; private set; }
        public Button ConsentToReceivePrerecordedMessagesNO_Button { get; private set; }
        public Button ConsentToShareInformationYES_Button { get; private set; }
        public Button ConsentToShareInformationNO_Button { get; private set; }
        public Button ContinueButton { get; private set; }
        public Link TermsAndConditionsLink { get; private set; }
        public Text ThisFieldIsRequiredMessage1 { get; private set; }
        public Text ThisFieldIsRequiredMessage2 { get; private set; }

        public TermsAndConditionsPage(IWebDriver driver)
            : base(driver)
        {
            ConsentToReceivePrerecordedMessagesYES_Button = new Button(Driver, By.CssSelector("label[for$=\"ConsentToPrerecordedMessagesTrue\"]"));
            ConsentToReceivePrerecordedMessagesNO_Button = new Button(Driver, By.CssSelector("label[for$=\"ConsentToPrerecordedMessagesFalse\"]"));
            ConsentToShareInformationYES_Button = new Button(Driver, By.CssSelector("label[for$=\"ConsentToShareInfoTrue\"]"));
            ConsentToShareInformationNO_Button = new Button(Driver, By.CssSelector("label[for$=\"ConsentToShareInfoFalse\"]"));
            ContinueButton = new Button(Driver, By.CssSelector("#terms-form > div > div:nth-child(4) > button"));
            TermsAndConditionsLink = new Link(Driver, By.XPath("//a[text() = 'Terms & Conditions']"));
            ThisFieldIsRequiredMessage1 = new Text(Driver, By.CssSelector("#terms-form > div > div:nth-child(2) > div > p > span"));
            ThisFieldIsRequiredMessage2 = new Text(Driver, By.CssSelector("#terms-form > div > div:nth-child(3) > div > p > span"));
        }
    }
}
