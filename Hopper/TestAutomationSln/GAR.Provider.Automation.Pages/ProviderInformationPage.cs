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
    public class ProviderInformationPage : HomePage
    {
        public Text ProviderName { get; private set; }

        public Text TaxId { get; private set; }

        public Text LicenseType { get; private set; }

        public Text LicenseNumber { get; private set; }

        public Text ExpirationDate { get; private set; }

        public Text PhysicalAddress1 { get; private set; }

        public Text PhysicalAddress2 { get; private set; }

        public Text PhysicalCity { get; private set; }

        public Text PhysicalState { get; private set; }

        public Text PhysicalZip { get; private set; }

        public Text PhysicalCounty { get; private set; }

        public Text AccountType { get; private set; }

        public Text AccountUsage { get; private set; }

        public Text AccountName { get; private set; }

        public Text InstitutionName { get; private set; }

        public Text State { get; private set; }

        public Text City { get; private set; }

        public Text RoutingNumber { get; private set; }

        public Text AccountNumber { get; private set; }

        public Text ConfirmAccountNumber { get; private set; }

        public Checkbox AuthorizeACH { get; private set; }

        public Button EditACHInformation { get; private set; }

        public Radio EditAccountTypeSavings { get; private set; }

        public Radio EditAccountTypeChecking { get; private set; }

        public Radio EditAccountUsageBusiness { get; private set; }

        public Radio EditAccountUsagePersonal { get; private set; }

        public EditField EditAccountName { get; private set; }

        public EditField EditBank { get; private set; }

        public Dropdown EditACHState { get; private set; }

        public Dropdown EditACHCity { get; private set; }

        public EditField EditRoutingNumber { get; private set; }

        public EditField EditAccountNumber { get; private set; }

        public EditField EditConfirmAccountNumber { get; private set; }

        public Button SaveACHInformationButton { get; private set; }

        public Button CancelEditingACHButton { get; private set; }

        public Text PrimaryContactName { get; private set; }

        public Text PrimaryContactEmail { get; private set; }

        public Text PrimaryContactPhone { get; private set; }

        public Button EditPrimaryContactButton { get; private set; }

        public EditField NewPrimarcyContactName { get; private set; }

        public EditField NewPrimaryContactEmail { get; private set; }

        public EditField NewPrimaryContactPhone { get; private set; }

        public Button SaveUpdatedPrimaryContactInformation { get; private set; }

        public Button CancelEditingPrimaryContactInformation { get; private set; }

        public ProviderInformationPage(IWebDriver driver)
            : base(driver)
        {
            ProviderName = new Text(Driver, By.CssSelector("span[id$=\"lblProviderName\"]"));
            TaxId = new Text(Driver, By.CssSelector("span[id$=\"lblTaxId\"]"));
            LicenseType = new Text(Driver, By.CssSelector("span[id$=\"lblLicenseType\"]"));
            LicenseNumber = new Text(Driver, By.CssSelector("span[id$=\"lblLicenseNumber\"]"));
            ExpirationDate = new Text(Driver, By.CssSelector("span[id$=\"lblExpirationDate\"]"));
            PhysicalAddress1 = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalAddress\"]"));
            PhysicalAddress2 = new Text(Driver, By.CssSelector("span[id$=\"lblAddressLineTwo\"]"));
            PhysicalCity = new Text(Driver, By.CssSelector("span[id*=\"providerinformation\"][id$=\"lblCity\"]"));
            PhysicalState = new Text(Driver, By.CssSelector("span[id*=\"providerinformation\"][id$=\"lblState\"]"));
            PhysicalZip = new Text(Driver, By.CssSelector("span[id*=\"providerinformation\"][id$=\"lblZipCode\"]"));
            PhysicalCounty = new Text(Driver, By.CssSelector("span[id*=\"providerinformation\"][id$=\"lblCounty\"]"));
            AccountType = new Text(Driver, By.CssSelector("span[id$=\"lblAccountType\"]"));
            AccountUsage = new Text(Driver, By.CssSelector("span[id$=\"lblAccountPurpose\"]"));
            AccountName = new Text(Driver, By.CssSelector("span[id$=\"lblAccountName\"]"));
            InstitutionName = new Text(Driver, By.CssSelector("span[id$=\"lblInstitutionName\"]"));
            State = new Text(Driver, By.CssSelector("span[id*=\"bankinformation\"][id$=\"lblState\"]"));
            City = new Text(Driver, By.CssSelector("span[id*=\"bankinformation\"][id$=\"lblCity\"]"));
            RoutingNumber = new Text(Driver, By.CssSelector("span[id$=\"lblRoutingNumber\"]"));
            AccountNumber = new Text(Driver, By.CssSelector("span[id$=\"lblAccountNumber\"]"));
            ConfirmAccountNumber = new Text(Driver, By.CssSelector("span[id$=\"lblAccountNumberConfirm\"]"));
            AuthorizeACH = new Checkbox(Driver, By.CssSelector("input[id$=\"chkTerms\"]"));
            EditACHInformation = new Button(Driver, By.CssSelector("input[id$=\"btnEditBankAccount\"]"));
            EditAccountTypeSavings = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_0\"]"));
            EditAccountTypeChecking = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_1\"]"));
            EditAccountUsageBusiness = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_0\"]"));
            EditAccountUsagePersonal = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_1\"]"));
            EditAccountName = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountName\"]"));
            EditBank = new EditField(Driver, By.CssSelector("input[id$=\"txtInstitutionName\"]"));
            EditACHState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlState\"]"));
            EditACHCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlCity\"]"));
            EditRoutingNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtRoutingNumber\"]"));
            EditAccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumber\"]"));
            EditConfirmAccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumberConfirm\"]"));
            SaveACHInformationButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveBankAccount\"]"));
            CancelEditingACHButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancelBankAccount\"]"));
            PrimaryContactName = new Text(Driver, By.CssSelector("span[id$=\"lblPrimaryContactName\"]"));
            PrimaryContactEmail = new Text(Driver, By.CssSelector("span[id$=\"lblEmailAddress\"]"));
            PrimaryContactPhone = new Text(Driver, By.CssSelector("span[id$=\"lblPhoneNumber\"]"));
            EditPrimaryContactButton = new Button(Driver, By.CssSelector("input[]id$=\"btnEditContactInformation\"]"));
            NewPrimarcyContactName = new EditField(Driver, By.CssSelector("input[id$=\"txtPrimaryContactName\"]"));
            NewPrimaryContactEmail = new EditField(Driver, By.CssSelector("input[id$=\"txtEmailAddress\"]"));
            NewPrimaryContactPhone = new EditField(Driver, By.CssSelector("input[id$=\"txtPhoneNumber\"]"));
            SaveUpdatedPrimaryContactInformation = new Button(Driver, By.CssSelector("input[id$=\"btnSaveContactInformation\"]"));
            CancelEditingPrimaryContactInformation = new Button(Driver, By.CssSelector("input[id$=\"btnCancelContactInformation\"]"));
        }
    }
}
