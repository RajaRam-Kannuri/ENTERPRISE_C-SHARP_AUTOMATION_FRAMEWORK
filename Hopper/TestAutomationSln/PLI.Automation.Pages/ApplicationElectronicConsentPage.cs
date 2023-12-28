using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationElectronicConsentPage : ApplicationWizardPage
    {
        public string ShareContactInformationPartialName { get; private set; }

        public string ReceivePreRecordedMessagesPartialName { get; private set; }

        public Radio ShareContactInformationYes { get; private set; }

        public Radio ReceivePreRecordedMessagesYes { get; private set; }

        public Radio ShareContactInformationNo { get; private set; }

        public Radio ReceivePreRecordedMessagesNo { get; private set; }

        public Radio CertifyInformationAccuracy { get; private set; }

        public ApplicationElectronicConsentPage(IWebDriver driver)
            : base(driver)
        {
            ShareContactInformationPartialName = "rblShareContactInfoConsent";
            ReceivePreRecordedMessagesPartialName = "rblPreRecordedConsent";
            ShareContactInformationYes = new Radio(Driver, By.CssSelector("input[name$=\"rblShareContactInfoConsent\"][value=\"Yes\"]"));
            ReceivePreRecordedMessagesYes = new Radio(Driver, By.CssSelector("input[name$=\"rblPreRecordedConsent\"][value=\"Yes\"]"));
            ShareContactInformationNo = new Radio(Driver, By.CssSelector("input[name$=\"rblShareContactInfoConsent\"][value=\"No\"]"));
            ReceivePreRecordedMessagesNo = new Radio(Driver, By.CssSelector("input[name$=\"rblPreRecordedConsent\"][value=\"No\"]"));
            CertifyInformationAccuracy = new Radio(Driver, By.CssSelector("input[name$=\"rbCertifyAccurateInfo\"]"));
        }
    }
}
