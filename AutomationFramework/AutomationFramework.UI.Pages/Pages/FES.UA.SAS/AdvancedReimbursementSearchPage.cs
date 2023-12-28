using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class AdvancedReimbursementSearchPage : HomePage
    {
        public EditField AdvReimbursementID { get; private set; }

        public EditField AdvStudentFirstName { get; private set; }

        public EditField AdvStudentLastName { get; private set; }

        public EditField InvoiceNumber { get; private set; }

        public EditField GardinerStudentID { get; private set; }

        public EditField AdvStudentSSN { get; private set; }

        public EditField ApplicationId { get; private set; }

        public EditField PhoneNumber { get; private set; }

        public EditField PrimaryGuardianEmailAddress { get; private set; }

        public EditField PrimaryGuardianFirstName { get; private set; }

        public EditField PrimaryGuardianLastName { get; private set; }

        public EditField SecondaryGuardianFirstName { get; private set; }

        public EditField SecondaryGuardianLastName { get; private set; }

        public EditField PhysicalAddressStreet { get; private set; }

        public Dropdown PhysicalAddressState { get; private set; }

        public Dropdown PhysicalAddressCity { get; private set; }

        public EditField PhysicalAddressZipCode { get; private set; }

        public Dropdown Year { get; private set; }

        public Button SearchButton { get; private set; }

        public Table ApplicationTable { get; private set; }

		public Table SearchTable { get; private set; }

		public AdvancedReimbursementSearchPage(IWebDriver driver)
            : base(driver)
        {
            AdvReimbursementID = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtClaimID"));
            AdvStudentFirstName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtStudentFirstName"));
            AdvStudentLastName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtStudentLastName"));
            InvoiceNumber = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtInvoiceNumber"));
            GardinerStudentID = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtStudentPLSAID"));
            AdvStudentSSN = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtStudentSSN"));
            ApplicationId = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtApplicationID"));
            PhoneNumber = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtPhoneNumber"));
            PrimaryGuardianEmailAddress = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtPrimaryGuardianEmail"));
            PrimaryGuardianFirstName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtPrimaryGuardianFirstName"));
            PrimaryGuardianLastName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtPrimaryGuardianLastName"));
            SecondaryGuardianFirstName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtSecondaryGuardianFirstName"));
            SecondaryGuardianLastName = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtSecondaryGuardianLastName"));
            PhysicalAddressStreet = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtPhysicalAddressStreet"));
            PhysicalAddressState = new Dropdown(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_ddlState"));
            PhysicalAddressCity = new Dropdown(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_ddlCity"));
            PhysicalAddressZipCode = new EditField(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_txtZipCode"));
            Year = new Dropdown(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_ddlOrganizationYear"));
            SearchButton = new Button(driver, By.Id("controls_search_claimadvancedsearch_ascx1005_btnRunAdvancedSearch"));
            ApplicationTable = new Table(driver, By.Id("tblResults"));
			SearchTable = new Table(driver, By.Id("tblResults"));
		}
	}
}
