using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;


namespace GAR.PLI.Automation.Pages
{
    public class GuardianInformationPage : ApplicationWizardPage
    {
        public EditField FirstName { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField LastName { get; private set; }

        public EditField EmailAddress { get; private set; }

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

        public Modal GuardianLocatedWizard { get; private set; }

        public Modal GuardianNotLocatedWizard { get; private set; }

        public Button GuardianLocatedWizardOKButton { get; private set; }

        public Button GuardianNotLocatedWizardOKButton { get; private set; }

        public InvalidInfoButton InvalidInformationOkbtn { get; private set; }

        public GuardianInformationPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtFirstName\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"_txtMiddleName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtLastName\"]"));
            EmailAddress = new EditField(Driver, By.CssSelector("input[id$=\"_txtEmail\"]"));
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
            GuardianLocatedWizard = new Modal(Driver, By.Id("GuardianPersonFound"));
            GuardianNotLocatedWizard = new Modal(Driver, By.Id("GuardianPersonNotFound"));
            GuardianLocatedWizardOKButton = new Button(Driver, By.CssSelector("button[onclick='SubmitWizard(true)']"));
            GuardianNotLocatedWizardOKButton = new Button(Driver, By.CssSelector("button[onclick='SubmitWizard(false)']"));
            InvalidInformationOkbtn = new InvalidInfoButton(driver, By.Id("ValidationPopup_btnOk"));
        }
    }
}
