using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class ElectronicSignaturePage : ApplicationWizardPage
    {
        public GardinerApplicationID ApplicationID { get; private set;}

        public Radio CertifyInformation { get; private set; }

        public Radio CertifyRules { get; private set; }

        public Radio YesToMessages { get; private set; }

        public Radio NoToMessages { get; private set; }

        public Radio YesToMarketingPurposes { get; private set; }

        public Radio NoToMarketingPurposes { get; private set; }

        public Radio YesToParentalEmpowerment { get; private set; }

        public Radio NoToParentalEmpowerment { get; private set; }

        public Radio YesToShareContactInformation { get; private set; }

        public Radio NoToShareContactInformation { get; private set; }

        public Radio YesToTextSMSInformation { get; private set; }

        public Radio NoToTextSMSInformation { get; private set; }

        public EditField PrimaryParentSignature { get; private set;}

        public Text PrimaryParentName { get; private set; }

        public EditField SecondaryParentSignature { get; private set; }

        public Text SecondaryParentName { get; private set; }

        public ElectronicSignaturePage(IWebDriver driver)
            : base(driver)
        {
            ApplicationID = new GardinerApplicationID(Driver, By.CssSelector("span[id$=\"_lblApplicationNumber\"]"));
            YesToMessages = new Radio(Driver, By.CssSelector("input[id$=\"_rbMessagesYes\"]"));
            NoToMessages = new Radio(Driver, By.CssSelector("input[id$=\"_rbMessagesNo\"]"));
            YesToMarketingPurposes = new Radio(Driver, By.CssSelector("input[id$=\"_rbMarketingYes\"]"));
            NoToMarketingPurposes = new Radio(Driver, By.CssSelector("input[id$=\"_rbMarketingNo\"]"));
            YesToParentalEmpowerment = new Radio(Driver, By.CssSelector("input[id$=\"_rbParentalEmpowermentYes\"]"));
            NoToParentalEmpowerment = new Radio(Driver, By.CssSelector("input[id$=\"_rbParentalEmpowermentNo\"]"));
            YesToShareContactInformation = new Radio(Driver, By.CssSelector("input[id$=\"_rbShareContactInformationYes\"]"));
            NoToShareContactInformation = new Radio(Driver, By.CssSelector("input[id$=\"_rbShareContactInformationNo\"]"));
            YesToTextSMSInformation = new Radio(Driver, By.CssSelector("input[id$=\"_rbSMSInformationYes\"]"));
            NoToTextSMSInformation = new Radio(Driver, By.CssSelector("input[id$=\"_rbSMSInformationNo\"]"));
            CertifyInformation = new Radio(Driver, By.CssSelector("input[id$=\"_rbAccuracyCertify\"]"));
            CertifyRules = new Radio(Driver, By.CssSelector("input[id$=\"_rbTermsCertify\"]"));
            PrimaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtPrimaryParentSignature\"]"));
            PrimaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblPrimaryParentName\"]"));
            SecondaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtSecondaryParentSignature\"]"));
            SecondaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblSecondaryParentName\"]"));
        }
    }
}
