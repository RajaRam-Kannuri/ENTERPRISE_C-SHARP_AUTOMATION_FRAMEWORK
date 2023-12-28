using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.Provider.Automation.Pages
{
    public class SubmitNewProviderPage : LoggedOutPage
    {
        public Dropdown PartOfAGroup { get; private set; }

        public EditField ProviderName { get; private set; }

        public EditField LicenseNumber { get; private set; }

        public Dropdown LicenseType { get; private set; }

        public EditField LicenseExpirationDate { get; private set; }

        public EditField GroupName { get; private set; }

        public EditField ChildName { get; private set; }

        public EditField ChildLicenseNumber { get; private set; }

        public Dropdown ChildLicenseType { get; private set; }

        public EditField ChildLicenseExpirationDate { get; private set; }

        public Button AddAnotherChildButton { get; private set; }

        public Table ChildProviderTable { get; private set; }

        public Radio AccountTypeChecking { get; private set; }

        public Radio AccountTypeSavings { get; private set; }

        public Radio AccountUsageBusiness { get; private set; }

        public Radio AccountUsagePersonal { get; private set; }

        public EditField AccountName { get; private set; }

        public EditField Bank { get; private set; }

        public Dropdown BankState { get; private set; }

        public Dropdown BankCity { get; private set; }

        public EditField ACHRoutingNumber { get; private set; }

        public EditField AccountNumber { get; private set; }

        public EditField ConfirmAccountNumber { get; private set; }

        public EditField ContactAddress { get; private set; }

        public Dropdown ContactState { get; private set; }

        public Dropdown ContactCity { get; private set; }

        public Dropdown ContactCounty { get; private set; }

        public EditField ContactZip { get; private set; }

        public Radio DifferentMailingAddressYes { get; private set; }

        public Radio DifferentMailingAddressNo { get; private set; }

        public EditField MailingAddress { get; private set; }

        public Dropdown MailingState { get; private set; }

        public Dropdown MailingCity { get; private set; }

        public Dropdown MailingCounty { get; private set; }

        public EditField MailingZip { get; private set; }

        public EditField ContactName { get; private set; }

        public EditField ContactEmail { get; private set; }

        public EditField ConfirmContactEmail { get; private set; }

        public EditField ContactPhoneNumber { get; private set; }

        public EditField TaxId { get; private set; }

        public Dropdown ConflictOfInterest { get; private set; }

        public Checkbox AuthorizeBankAccess { get; private set; }

        public Checkbox CertifyApplication { get; private set; }

        public Button SubmitButton { get; private set; }

        public Button UploadDocumentsButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public Text Checkbox3ProviderHandbookText { get; private set; }

        public Link Checkbox3ProviderHandbookLink { get; private set; }

        public SubmitNewProviderPage(IWebDriver driver)
            : base(driver)
        {
            PartOfAGroup = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGroupQuestion\"]"));
            ProviderName = new EditField(Driver, By.CssSelector("input[id$=\"txtDescription\"]"));
            LicenseNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtLicenseNumber\"]"));
            LicenseType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlLicenseType\"]"));
            LicenseExpirationDate = new EditField(Driver, By.CssSelector("input[id$=\"txtExpirationDate\"]"));
            GroupName = new EditField(Driver, By.CssSelector("input[id$=\"txtGroupDescription\"]"));
            ChildName = new EditField(Driver, By.CssSelector("input[id$=\"txtChildDescription\"]"));
            ChildLicenseNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtChildLicenseNumber\"]"));
            ChildLicenseType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlChildLicenseType\"]"));
            ChildLicenseExpirationDate = new EditField(Driver, By.CssSelector("input[id$=\"txtChildExpirationDate\"]"));
            AddAnotherChildButton = new Button(Driver, By.CssSelector("input[id$=\"btnAddChild\"]"));
            ChildProviderTable = new Table(Driver, By.Id("tblChildProviders"));
            AccountTypeChecking = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_0\"]"));
            AccountTypeSavings = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_1\"]"));
            AccountUsageBusiness = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_0\"]"));
            AccountUsagePersonal = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_1\"]"));
            AccountName = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountName\"]"));
            Bank = new EditField(Driver, By.CssSelector("input[id$=\"txtInstitutionName\"]"));
            BankState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlState\"]"));
            BankCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlCity\"]"));
            ACHRoutingNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtRoutingNumber\"]"));
            AccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumber\"]"));
            ConfirmAccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumberConfirm\"]"));
            ContactAddress = new EditField(Driver, By.CssSelector("input[id$=\"txtPhysicalAddressLine1\"]"));
            ContactState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalAddressState\"]"));
            ContactCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalAddressCity\"]"));
            ContactCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalAddressCounty\"]"));
            ContactZip = new EditField(Driver, By.CssSelector("input[id$=\"txtPhysicalAddressZipCode\"]"));
            DifferentMailingAddressYes = new Radio(Driver, By.CssSelector("input[id$=\"rblHasMailingAddress_0\"]"));
            DifferentMailingAddressNo = new Radio(Driver, By.CssSelector("input[id$=\"rblHasMailingAddress_1\"]"));
            MailingAddress = new EditField(Driver, By.CssSelector("input[id$=\"txtMailingAddressLine1\"]"));
            MailingState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingAddressState\"]"));
            MailingCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingAddressCity\"]"));
            MailingCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingAddressCounty\"]"));
            MailingZip = new EditField(Driver, By.CssSelector("input[id$=\"txtMailingAddressZipCode\"]"));
            ContactName = new EditField(Driver, By.CssSelector("input[id$=\"txtPrimaryContact\"]"));
            ContactEmail = new EditField(Driver, By.CssSelector("input[id$=\"txtEmail\"]"));
            ConfirmContactEmail = new EditField(Driver, By.CssSelector("input[id$=\"txtEmailConfirm\"]"));
            ContactPhoneNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtPhoneNumber\"]"));
            TaxId = new EditField(Driver, By.CssSelector("input[id$=\"txtTaxID\"]"));
            ConflictOfInterest = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlConflictOfInterest\"]"));
            AuthorizeBankAccess = new Checkbox(Driver, By.CssSelector("input[id$=\"chkACHTerms\"]"));
            CertifyApplication = new Checkbox(Driver, By.CssSelector("input[id$=\"chkTerms\"]"));
            SubmitButton = new Button(Driver, By.CssSelector("input[id$=\"btnSubmit\"]"));
            UploadDocumentsButton = new Button(Driver, By.CssSelector("input[id$=\"btnUploadDocument\"]"));
            StatusMessage = new Text(Driver, By.CssSelector("span[id$=\"lblUploadInformation\"]"));
            Checkbox3ProviderHandbookText = new Text(Driver, By.CssSelector("label[id$=\"lblProviderHandbook\"]"));
            Checkbox3ProviderHandbookLink = new Link(Driver, By.CssSelector("#RPMainPanel_controls_providerlogin_becomeaprovider_ascx1003_lblProviderHandbook > a"));
        }
    }
}
