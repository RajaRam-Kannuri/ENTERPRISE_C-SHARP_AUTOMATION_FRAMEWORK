using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class ElectronicConsentPage : ApplicationWizardPage
    {
        public string ReceivePreRecordedMessagesPartialName { get; private set; }

        public Radio ReceivePreRecordedMessagesYes { get; private set; }

        public Radio ReceivePreRecordedMessagesNo { get; private set; }

        public Radio IAgree{ get; private set; }

        public ElectronicConsentPage(IWebDriver driver)
            : base(driver)
        {
            ReceivePreRecordedMessagesPartialName = "rblPreRecordedConsent";
            ReceivePreRecordedMessagesYes = new Radio(Driver, By.CssSelector("input[name$=\"rblPreRecordedConsent\"][value=\"No\"]"));
            ReceivePreRecordedMessagesNo = new Radio(Driver, By.CssSelector("input[name$=\"rblPreRecordedConsent\"][value=\"No\"]"));
            IAgree = new Radio(Driver, By.Id("RPMainPanel_controls_household_householdconsent_ascx372_rbCertifyAccurateInfo"));
        }
    }
}
