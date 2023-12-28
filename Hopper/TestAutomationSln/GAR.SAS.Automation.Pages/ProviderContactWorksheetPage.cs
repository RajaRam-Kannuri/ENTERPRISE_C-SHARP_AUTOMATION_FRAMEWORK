using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class ProviderContactWorksheetPage : HomePage
    {
        public Text ProviderName { get; private set; }

        public Text GroupName { get; private set; }

        public Text ProviderId { get; private set; }

        public Text GroupId { get; private set; }

        public Text ProviderTaxId { get; private set; }

        public Text GroupTaxId { get; private set; }

        public Table GroupMemberTable { get; private set; }

        public Text LicenseNumber { get; private set; }

        public Text LicenseType { get; private set; }

        public Text LicenseExpirationDate { get; private set; }

        public Text ProviderApproval { get; private set; }

        public Text PrimaryContactName { get; private set; }

        public Text PrimaryContactEmail { get; private set; }

        public Text PrimaryContactPhone { get; private set; }

        public Dropdown ReimbursementInformationYearDropdown { get; private set; }

        public Dropdown ReimbursementInformationStudentDropdown { get; private set; }

        public ReimbursementInformationTable ReimbursementInformationTable { get; private set; }

        public ProviderContactWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            ProviderName = new Text(Driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblProviderName\"]"));
            GroupName = new Text(Driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblGroupProviderName\"]"));
            ProviderId = new Text(Driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblProviderID\"]"));
            GroupId = new Text(Driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblGroupProviderID\"]"));
            ProviderTaxId = new Text(Driver, By.CssSelector("span[id$=\"lblProviderTaxID\"]"));
            GroupTaxId = new Text(Driver, By.CssSelector("span[id$=\"lblGroupProviderTaxID\"]"));
            GroupMemberTable = new Table(Driver, By.CssSelector("div[id$=\"GroupProviderPanel\"] .dataTable"));
            LicenseNumber = new Text(Driver, By.CssSelector("span[id$=\"lblLicenseNumber\"]"));
            LicenseType = new Text(Driver, By.CssSelector("span[id$=\"lblLicenseType\"]"));
            LicenseExpirationDate = new Text(Driver, By.CssSelector("span[id$=\"lblExpirationDate\"]"));
            ProviderApproval = new Text(Driver, By.CssSelector("span[id$=\"lblProviderStatus\"]"));
            PrimaryContactName = new Text(Driver, By.CssSelector("span[id$=\"lblPrimaryContact\"]"));
            PrimaryContactEmail = new Text(Driver, By.CssSelector("span[id$=\"lblEmailAddress\"]"));
            PrimaryContactPhone = new Text(Driver, By.CssSelector("span[id$=\"lblPhoneNumber\"]"));
            ReimbursementInformationYearDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlOrgYear\"]"));
            ReimbursementInformationStudentDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            ReimbursementInformationTable = new ReimbursementInformationTable(Driver, By.CssSelector("#controls_providers_providercontactworksheet_ascx1009_MainPanel > table > tbody > tr > td:nth-child(1) > fieldset:nth-child(7) > div > table"));
        }
    }
}
