using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class HomePage : BasePage
    {
        public Text Username { get; private set; }

        public Dropdown LanguageSelection { get; private set; }

        public Link SignOut { get; private set; }

        public Tab ApplicationQuickSearchTab { get; private set; }

        public EditField ApplicationQuickSearchFirstName { get; private set; }

        public EditField ApplicationQuickSearchLastName { get; private set; }

        public EditField ApplicationQuickSearchId { get; private set; }

        public EditField ApplicationQuickSearchSSN { get; private set; }

        public EditField ApplicationQuickSearchPersonId { get; private set; }

        public Dropdown ApplicationQuickSearchYear { get; private set; }

        public Button ApplicationQuickSearchSearchButton { get; private set; }

        public Button ApplicationAdvancedSearchButton { get; private set; }

        public Table ApplicationSearchResults { get; private set; }

        public Table ApplicationQuickSearchResultsTable { get; private set; }

        public Tab SchoolQuickSearchTab { get; private set; }

        public EditField SchoolQuickSearchCode { get; private set; }

        public EditField SchoolQuickSearchName { get; private set; }

        public Dropdown SchoolQuickSearchCity { get; private set; }

        public Dropdown SchoolQuickSearchDistrict { get; private set; }

        public EditField SchoolQuickSearchZipCode { get; private set; }

        public Dropdown SchoolQuickSearchRegion { get; private set; }

        public Dropdown SchoolQuickSearchFTCParticipant { get; private set; }

        public Dropdown SchoolQuickSearchSUFSParticipant { get; private set; }

        public Dropdown SchoolQuickSearchHasSUFSStudents { get; private set; }

        public Dropdown SchoolQuickSearchDenomination { get; private set; }

        public Dropdown SchoolQuickSearchSearchSchoolYear { get; private set; }

        public Button SchoolQuickSearchButton { get; private set; }

        public Button SchoolAdvancedSearchButton { get; private set; }

        public Table SchoolQuickSearchResultsTable { get; private set; }

        public Tab StudentQuickSearchTab { get; private set; }

        public EditField StudentQuickSearchSSN { get; private set; }

        public EditField StudentQuickSearchFirstName { get; private set; }

        public EditField StudentQuickSearchLastName { get; private set; }

        public EditField StudentQuickSearchPersonId { get; private set; }

        public EditField StudentQuickSearchSchoolCode { get; private set; }

        public EditField StudentQuickSearchApplicationId { get; private set; }

        public EditField StudentQuickSearchPrimaryParentSSN { get; private set; }

        public Dropdown StudentQuickSearchYear { get; private set; }

        public Button StudentQuickSearchButton { get; private set; }

        public Button StudentAdvancedSearchButton { get; private set; }

        public Table StudentSearchResults { get; private set; }

        public Table StudentQuickSearchResultsTable { get; private set; }

        public Text ContextStudentName { get; private set; }

        public Text ContextApplicationId { get; private set; }

        public Text ContextSchoolYear { get; private set; }

        public Text ContextSchoolName { get; private set; }

        public Text ContextSchoolCode { get; private set; }

        public Link CloseSchoolContext { get; private set; }

        public Link CloseApplicationContext { get; private set; }

        public Table CSTDashboardTable { get; private set; }

        public Table AssignedDocumentsTable { get; private set; }

        public Link ContactLink { get; private set; }


        public HomePage(IWebDriver driver)
            : base(driver)
        {
            Username = new Text(driver, By.Id("LblUsername"));
            LanguageSelection = new Dropdown(driver, By.Id("LblLanguage"));
            SignOut = new Link(driver, By.Id("LBSignOut"));
            ApplicationQuickSearchTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Application\"]"));
            ApplicationQuickSearchFirstName = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbFirstName"));
            ApplicationQuickSearchLastName = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbLastName"));
            ApplicationQuickSearchId = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            ApplicationQuickSearchSSN = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbSSN"));
            ApplicationQuickSearchPersonId = new EditField(driver, By.Id("qsSeachControl_qsApplication_tbPersonId"));
            ApplicationQuickSearchYear = new Dropdown(driver, By.Id("qsSeachControl_qsApplication_ddlApplicationYear"));
            ApplicationQuickSearchSearchButton = new Button(driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            ApplicationAdvancedSearchButton = new Button(driver, By.Id("qsSeachControl_qsApplication_btnAdvSearch"));
            ApplicationQuickSearchResultsTable = new Table(driver, By.Id("tblResults"));
            SchoolQuickSearchTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-School\"]"));
            SchoolQuickSearchCode = new EditField(driver, By.Id("qsSeachControl_qsSchool_tbSchoolCode"));
            SchoolQuickSearchName = new EditField(driver, By.Id("qsSeachControl_qsSchool_tbSchoolName"));
            SchoolQuickSearchCity = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlCityID"));
            SchoolQuickSearchDistrict = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlDistrictID"));
            SchoolQuickSearchZipCode = new EditField(driver, By.Id("qsSeachControl_qsSchool_tbZipcode"));
            SchoolQuickSearchRegion = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlRegionID"));
            SchoolQuickSearchFTCParticipant = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlIsFTC"));
            SchoolQuickSearchSUFSParticipant = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlIsSUFS"));
            SchoolQuickSearchHasSUFSStudents = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlHasSUFSStudents"));
            SchoolQuickSearchDenomination = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlDenominationID"));
            SchoolQuickSearchSearchSchoolYear = new Dropdown(driver, By.Id("qsSeachControl_qsSchool_ddlApplicationYear"));
            SchoolQuickSearchButton = new Button(driver, By.Id("qsSeachControl_qsSchool_btnSearch"));
            SchoolAdvancedSearchButton = new Button(driver, By.Id("qsSeachControl_qsSchool_btnAdvSearch"));
            SchoolQuickSearchResultsTable = new Table(driver, By.Id("tblSchoolSearch"));
            StudentQuickSearchTab = new Tab(driver, By.CssSelector("a[href=\"#QuickSearch-Student\"]"));
            StudentQuickSearchSSN = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbSSN"));
            StudentQuickSearchFirstName = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbFirstName"));
            StudentQuickSearchLastName = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbLastName"));
            StudentQuickSearchPersonId = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbStudentPersonId"));
            StudentQuickSearchSchoolCode = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbSchoolCode"));
            StudentQuickSearchApplicationId = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbApplicationID"));
            StudentQuickSearchPrimaryParentSSN = new EditField(driver, By.Id("qsSeachControl_qsStudent_tbParentSSN"));
            StudentQuickSearchYear = new Dropdown(driver, By.Id("qsSeachControl_qsStudent_ddlApplicationYear"));
            StudentQuickSearchResultsTable = new Table(driver, By.Id("tblResults"));
            StudentQuickSearchButton = new Button(driver, By.Id("qsSeachControl_qsStudent_btnSearch"));
            StudentAdvancedSearchButton = new Button(driver, By.Id("qsSeachControl_qsStudent_btnAdvSearch"));
            ContextStudentName = new Text(driver, By.Id("cdContextDisplay_lblStudentName"));
            ContextApplicationId = new Text(driver, By.Id("cdContextDisplay_lblApplicationID"));
            ContextSchoolYear = new Text(driver, By.Id("cdContextDisplay_lblOrganizationYear"));
            ContextSchoolName = new Text(driver, By.Id("cdContextDisplay_lblSchoolName"));
            ContextSchoolCode = new Text(driver, By.Id("cdContextDisplay_lblSchoolDOECode"));
            CloseSchoolContext = new Link(driver, By.Id("cdContextDisplay_imgBtnClearContext"));
            CloseApplicationContext = new Link(driver, By.Id("cdContextDisplay_imgBtnSchoolContext"));
            CSTDashboardTable = new Table(driver, By.Id("tblCSTDashboard"));
            AssignedDocumentsTable = new Table(driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            ContactLink = new Link(driver, By.Id("controls_search_searchresults_ascx111_rptResults_ctl01_lbContact"));
        }
    }
}
