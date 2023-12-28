using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
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

        public Table ReimbursementInformationTable { get; private set; }

        public ProviderContactWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            ProviderName = new Text(driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblProviderName\"]"));
            GroupName = new Text(driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblGroupProviderName\"]"));
            ProviderId = new Text(driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblProviderID\"]"));
            GroupId = new Text(driver, By.CssSelector("span[id*=\"providercontactworksheet\"][id$=\"lblGroupProviderID\"]"));
            ProviderTaxId = new Text(driver, By.CssSelector("span[id$=\"lblProviderTaxID\"]"));
            GroupTaxId = new Text(driver, By.CssSelector("span[id$=\"lblGroupProviderTaxID\"]"));
            GroupMemberTable = new Table(driver, By.CssSelector("div[id$=\"GroupProviderPanel\"] .dataTable"));
            LicenseNumber = new Text(driver, By.CssSelector("span[id$=\"lblLicenseNumber\"]"));
            LicenseType = new Text(driver, By.CssSelector("span[id$=\"lblLicenseType\"]"));
            LicenseExpirationDate = new Text(driver, By.CssSelector("span[id$=\"lblExpirationDate\"]"));
            ProviderApproval = new Text(driver, By.CssSelector("span[id$=\"lblProviderStatus\"]"));
            PrimaryContactName = new Text(driver, By.CssSelector("span[id$=\"lblPrimaryContact\"]"));
            PrimaryContactEmail = new Text(driver, By.CssSelector("span[id$=\"lblEmailAddress\"]"));
            PrimaryContactPhone = new Text(driver, By.CssSelector("span[id$=\"lblPhoneNumber\"]"));
            ReimbursementInformationYearDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ddlOrgYear\"]"));
            ReimbursementInformationStudentDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            ReimbursementInformationTable = new Table(driver, By.CssSelector("#controls_providers_providercontactworksheet_ascx1009_MainPanel > table > tbody > tr > td:nth-child(1) > fieldset:nth-child(7) > div > table"));
        }
    }
}
