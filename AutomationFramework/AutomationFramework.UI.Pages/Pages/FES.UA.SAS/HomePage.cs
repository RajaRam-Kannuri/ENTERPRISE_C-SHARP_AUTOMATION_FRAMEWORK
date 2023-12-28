using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class HomePage : BasePage
    {
        public Text Username { get; private set; }

        public Dropdown LanguageSelection { get; private set; }

        public Link SignOut { get; private set; }

        public Tab ApplicationTab { get; private set; }

        public EditField AppFirstName { get; private set; }

        public EditField AppLastName { get; private set; }

        public EditField AppId { get; private set; }

        public EditField AppSSN { get; private set; }

        public EditField AppPersonId { get; private set; }

        public Dropdown AppYear { get; private set; }

        public Button AppSearch { get; private set; }

        public Button AppAdvancedSearch { get; private set; }

        public Tab StudentTab { get; private set; }

        public EditField StudentSSN { get; private set; }

        public EditField StudentFirstName { get; private set; }

        public EditField StudentLastName { get; private set; }

        public EditField StudentPersonId { get; private set; }

        public EditField StudentSchoolCode { get; private set; }

        public EditField StudentApplicationId { get; private set; }

        public EditField StudentPrimaryParentSSN { get; private set; }

        public Dropdown StudentYear { get; private set; }

        public Button StudentSearch { get; private set; }

        public Button StudentAdvancedSearch { get; private set; }

        public Tab ReimbursementTab { get; private set; }

        public EditField ReimbursementId { get; private set; }

        public EditField ReimbursementStudentFirstName { get; private set; }

        public EditField ReimbursementStudentLastName { get; private set; }

        public EditField ReimbursementPLSAId { get; private set; }

        public EditField ReimbursementStudentSSN { get; private set; }

        public EditField ReimbursementApplicationId { get; private set; }

        public Dropdown ReimbursementSchoolYear { get; private set; }

        public Button ReimbursementSearch { get; private set; }

        public Button ReimbursementAdvancedSearch { get; private set; }

        public Tab ProviderTab { get; private set; }

        public EditField ProviderIdQuickSearch { get; private set; }

        public EditField ProviderNameQuickSearch { get; private set; }

        public EditField ProviderLicenseNumberQuickSearch { get; private set; }

        public Dropdown ProviderLicenseTypeQuickSearch { get; private set; }

        public EditField ProviderTaxIdQuickSearch { get; private set; }

        public Dropdown ProviderStatusQuickSearch { get; private set; }

        public Button ProviderSearch { get; private set; }

        public Button ProviderAdvancedSearch { get; private set; }

        public Text ContextStudentName { get; private set; }

        public Text ContextApplicationId { get; private set; }

        public Text ContextSchoolYear { get; private set; }

        public Text ContextSchoolName { get; private set; }

        public Text ContextSchoolCode { get; private set; }

        public Link CloseSchoolContext { get; private set; }

        public Link CloseApplicationContext { get; private set; }

        public Link CloseProviderContext { get; private set; }

        public Table CSTDashboardTable { get; private set; }

        public Table TodaysAssignments { get; private set; }

        public Table AssignedDocumentsTable { get; private set; }

        public Table StudentQuickSearchResultsTable { get; private set; }

        public Table ProviderSearchResultsTable { get; private set; }

        public EditField ApplicationQuickSearchId { get; private set; }

        public Button ApplicationQuickSearchSearchButton { get; private set; }

        public Table ApplicationQuickSearchResultsTable { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            Username = new Text(driver, By.Id("LblUsername"));
            LanguageSelection = new Dropdown(driver, By.Id("LblLanguage"));
            SignOut = new Link(driver, By.Id("LBSignOut"));
            ApplicationTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Application\"]"));
            AppFirstName = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbFirstName"));
            AppLastName = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbLastName"));
            AppId = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            AppSSN = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbSSN"));
            AppPersonId = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbPersonId"));
            AppYear = new Dropdown(driver, By.Id("qsSeachControl_qsApplication_ddlApplicationYear"));
            AppSearch = new Button(driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            AppAdvancedSearch = new Button(driver, By.Id("qsSeachControl_qsApplication_btnAdvSearch"));
            StudentTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Student\"]"));
            StudentSSN = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbSSN"));
            StudentFirstName = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbFirstName"));
            StudentLastName = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbLastName"));
            StudentPersonId = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbStudentPersonId"));
            StudentSchoolCode = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbSchoolCode"));
            StudentApplicationId = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbApplicationID"));
            StudentPrimaryParentSSN = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbParentSSN"));
            StudentYear = new Dropdown(driver, By.Id("qsSeachControl_qsStudent_ddlApplicationYear"));
            StudentSearch = new Button(driver, By.Id("qsSeachControl_qsStudent_btnSearch"));
            StudentAdvancedSearch = new Button(driver, By.Id("qsSeachControl_qsStudent_btnAdvSearch"));
            StudentQuickSearchResultsTable = new Table(driver, By.Id("tblResults"));
            ReimbursementTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Claim\"]"));
            ReimbursementId = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbClaimID"));
            ReimbursementStudentFirstName = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbFirstName"));
            ReimbursementStudentLastName = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbLastName"));
            ReimbursementPLSAId = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbStudentID"));
            ReimbursementStudentSSN = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbSSN"));
            ReimbursementApplicationId = new EditField(driver, By.Id("qsSeachControl_qsClaim_tbApplicationID"));
            ReimbursementSchoolYear = new Dropdown(driver, By.Id("qsSeachControl_qsClaim_ddlOrganizationYear"));
            ReimbursementSearch = new Button(driver, By.Id("qsSeachControl_qsClaim_btnSearch"));
            ReimbursementAdvancedSearch = new Button(driver, By.Id("qsSeachControl_qsClaim_btnAdvSearch"));
            ProviderTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Provider\"]"));
            ProviderIdQuickSearch = new EditField(driver, By.Id("qsSeachControl_qsProvider_tbProviderID"));
            ProviderNameQuickSearch = new EditField(driver, By.Id("qsSeachControl_qsProvider_tbProviderName"));
            ProviderLicenseNumberQuickSearch = new EditField(driver, By.Id("qsSeachControl_qsProvider_tbLicenseNumber"));
            ProviderLicenseTypeQuickSearch = new Dropdown(driver, By.Id("qsSeachControl_qsProvider_ddlLicenseType"));
            ProviderTaxIdQuickSearch = new EditField(driver, By.Id("qsSeachControl_qsProvider_tbTaxID"));
            ProviderStatusQuickSearch = new Dropdown(driver, By.Id("qsSeachControl_qsProvider_ddlProviderStatus"));
            ProviderSearch = new Button(driver, By.Id("qsSeachControl_qsProvider_btnSearch"));
            ProviderAdvancedSearch = new Button(driver, By.Id("qsSeachControl_qsProvider_btnAdvSearch"));
            ContextStudentName = new Text(driver, By.Id("cdContextDisplay_lblStudentName"));
            ContextApplicationId = new Text(driver, By.Id("cdContextDisplay_lblApplicationID"));
            ContextSchoolYear = new Text(driver, By.Id("cdContextDisplay_lblOrganizationYear"));
            ContextSchoolName = new Text(driver, By.Id("cdContextDisplay_lblSchoolName"));
            ContextSchoolCode = new Text(driver, By.Id("cdContextDisplay_lblSchoolDOECode"));
            CloseSchoolContext = new Link(driver, By.Id("cdContextDisplay_imgBtnClearContext"));
            CloseApplicationContext = new Link(driver, By.Id("cdContextDisplay_imgBtnSchoolContext"));
            CloseProviderContext = new Link(driver, By.Id("cdContextDisplay_imgBtnClearProviderContext"));
            CSTDashboardTable = new Table(driver, By.Id("tblCSTDashboard"));
            TodaysAssignments = new Table(driver, By.Id("gvAssignedApplications"));
            AssignedDocumentsTable = new Table(driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            ProviderSearchResultsTable = new Table(driver, By.Id("tblResults"));
            ApplicationQuickSearchId = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            ApplicationQuickSearchSearchButton = new Button(driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            ApplicationQuickSearchResultsTable = new Table(driver, By.Id("tblResults"));
        }
    }
}