using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationGuardianInformationPage : ApplicationWizardPage
    {
        public EditField SSN { get; private set; }

        public EditField VerifySSN { get; private set; }

        public Radio DifferentMailingAddressYes { get; private set; }

        public Radio DifferentMailingAddressNo { get; private set; }

        public EditField PhysicalAddress1 { get; private set; }

        public EditField PhysicalAddress2 { get; private set; }

        public Dropdown PhysicalAddressCity { get; private set; }

        public Dropdown PhysicalAddressState { get; private set; }

        public EditField PhysicalAddressZip { get; private set; }

        public Dropdown PhysicalAddressCounty { get; private set; }

        public EditField MailingAddress1 { get; private set; }

        public EditField MailingAddress2 { get; private set; }

        public Dropdown MailingCity { get; private set; }

        public Dropdown MailingState { get; private set; }

        public EditField MailingZip { get; private set; }

        public Dropdown MailingCounty { get; private set; }

        public EditField HomePhone { get; private set; }

        public EditField WorkPhone { get; private set; }

        public EditField MobilePhone { get; private set; }

        public Dropdown MaritalStatus { get; private set; }

        public Dropdown HouseholdLanguage { get; private set; }

        public Radio FoodStampsYes { get; private set; }

        public Radio FoodStampsNo { get; private set; }

        public Text AddressVerification { get; private set; }

        public Radio VerificationYes { get; private set; }
        public Button OkBtn { get; private set; }

        public CommonAdultInformationSection CommonAdultInformationSection { get; private set; }

        public ApplicationGuardianInformationPage(IWebDriver driver)
            : base(driver)
        {
            SSN = new EditField(Driver, By.CssSelector("input[id$=\"_txtSocial1\"]"));
            VerifySSN = new EditField(Driver, By.CssSelector("input[id$=\"_txtSocial2\"]"));
            DifferentMailingAddressYes = new Radio(Driver, By.CssSelector("input[id$=\"_rblAddressType_0\"]"));
            DifferentMailingAddressNo = new Radio(Driver, By.CssSelector("input[id$=\"_rblAddressType_1\"]"));
            PhysicalAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"_tbPrimaryAddress1\"]"));
            PhysicalAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"_tbPrimaryAddress2\"]"));
            PhysicalAddressCity = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPrimaryCity\"]"));
            PhysicalAddressState = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPrimaryState\"]"));
            PhysicalAddressZip = new EditField(Driver, By.CssSelector("input[id$=\"_tbPrimaryZip\"]"));
            PhysicalAddressCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPrimaryCounty\"]"));
            MailingAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"_tbMailingAddress1\"]"));
            MailingAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"_tbMailingAddress2\"]"));
            MailingCity = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlMailingCity\"]"));
            MailingState = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlMailingState\"]"));
            MailingZip = new EditField(Driver, By.CssSelector("input[id$=\"_tbMailingZip\"]"));
            MailingCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlMailingCounty\"]"));
            HomePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtHomePhone\"]"));
            WorkPhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtWorkPhone\"]"));
            MobilePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtMobilePhone\"]"));
            MaritalStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlMaritalStatus\"]"));
            HouseholdLanguage = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlHouseholdLanguage\"]"));
            FoodStampsYes = new Radio(Driver, By.CssSelector("input[id$=\"_rbFoodStamps_0\"]"));
            FoodStampsNo = new Radio(Driver, By.CssSelector("input[id$=\"_rbFoodStamps_1\"]"));
            AddressVerification = new Text(Driver, By.Id("ValidationPopup_PWH-1T"));
            VerificationYes = new Radio(Driver, By.Name("0"));
            OkBtn = new Button(Driver, By.Name("ValidationPopup$btnOk"));
            CommonAdultInformationSection = new CommonAdultInformationSection(Driver);
        }
    }
}
