using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
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

        public ApplicationSearchResultsSection ApplicationSearchResults { get; private set; }

        public FTCSASApplicationTable ApplicationQuickSearchResultsTable { get; private set; }

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

        //public SchoolSearchResultsSection SchoolSearchResults { get; private set; }

        public FTCSASSearchResultsTable SchoolQuickSearchResultsTable { get; private set; }

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

        public StudentSearchResultsSection StudentSearchResults { get; private set; }

        public FTCSASSearchResultsTable StudentQuickSearchResultsTable { get; private set; }

        public MenuItems MenuItems { get; set; }

        //public string DashboardMenuItem { get { return "Control.aspx?OSP=51"; } }

        //public string ViewContactLogDetailsMenuItem { get { return "Control.aspx?OSP=75"; } }

        //public string CustomerServiceTicketMenuItem { get { return "Control.aspx?OSP=161"; } }

        //public string CallCenterWorksheetMenuItem { get { return "Control.aspx?OSP=67"; } }

        //public string AddApplicationNoteMenuItem { get { return "Control.aspx?OSP=95"; } }

        //public string ViewContactLogsMenuItem { get { return "Control.aspx?OSP=74"; } }

        //public string DocumentScanningWorksheetMenuItem { get { return "Control.aspx?OSP=72"; } }

        //public string DocumentScanningSearchResultMenuItem { get { return "Control.aspx?OSP=73"; } }

        //public string ScannedDocumentsMenuItem { get { return "Control.aspx?OSP=79"; } }

        //public string UnattachedDocumentsMenuItem { get { return "Control.aspx?OSP=140"; } }

        //public string DocumentProcessingWorksheetMenuItem { get { return "Control.aspx?OSP=66"; } }

        //public string HouseholdCompositionMenuItem { get { return "Control.aspx?OSP=98"; } }

        //public string PrintApplicationMenuItem { get { return "Control.aspx?OSP=86"; } }

        //public string DisplayDocumentsMenuItem { get { return "Control.aspx?OSP=91"; } }

        //public string ViewPDFsMenuItem { get { return "Control.aspx?OSP=83"; } }

        //public string ApplicationFormPrintingMenuItem { get { return "Control.aspx?OSP=82"; } }

        public Link ApplicationProcessingWorksheetMenuItem { get; private set; }

        //public string ApplicationProcessingWorksheet2011MenuItem { get { return "Control.aspx?OSP=81"; } }

        //public string ApplicationSummaryMenuItem { get { return "Control.aspx?OSP=87"; } }

        //public string ApplicationDetailMenuItem { get { return "Control.aspx?OSP=88"; } }

        //public string StudentSummaryMenuItem { get { return "Control.aspx?OSP=89"; } }

        //public string StudentDetailMenuItem { get { return "Control.aspx?OSP=90"; } }

        //public string DocumentFormAdministrationMenuItem { get { return "Control.aspx?OSP=57"; } }

        //public string SitePageSiteControlRichTextAdministrationMenuItem { get { return "Control.aspx?OSP=58"; } }

        //public string SearchResultsMenuItem { get { return "Control.aspx?OSP=59"; } }

        //public string AdvancedSearchMenuItem { get { return "Control.aspx?OSP=71"; } }

        //public string ApplicationQueueAssignmentMenuItem { get { return "Control.aspx?OSP=77"; } }

        //public string CheckFileProcessMenuItem { get { return "Control.aspx?OSP=162"; } }

        //public string RemoveApplicationMenuItem { get { return "Control.aspx?OSP=138"; } }

        //public string UpdateWaitListMenuItem { get { return "Control.aspx?OSP=145"; } }

        //public string MaintainGraduationSurveyOpenMessageMenuItem { get { return "Control.aspx?OSP=146"; } }

        //public string MaintainGraduationSurveySubmittedMessageMenuItem { get { return "Control.aspx?OSP=147"; } }

        //public string MaintainGraduationSurveyClosedMessageMenuItem { get { return "Control.aspx?OSP=148"; } }

        //public string MaintainVRandSurveyPeriodsMenuItem { get { return "Control.aspx?OSP=122"; } }

        //public string MaintainVROpenMessageMenuItem { get { return "Control.aspx?OSP=123"; } }

        //public string MaintainVRClosedMessageMenuItem { get { return "Control.aspx?OSP=125"; } }

        //public string SchoolSearchMenuItem { get { return "Control.aspx?OSP=117"; } }

        //public string MessageAdministrationMenuItem { get { return "Control.aspx?OSP=93"; } }

        //public string ApplicationFeeTransactionsMenuItem { get { return "Control.aspx?OSP=94"; } }

        //public string StudentSearchResultsMenuItem { get { return "Control.aspx?OSP=109"; } }

        //public string AdvancedSchoolSearchMenuItem { get { return "Control.aspx?OSP=118"; } }

        //public string AdvancedStudentSearchMenuItem { get { return "Control.aspx?OSP=119"; } }

        //public string ReportMenuMenuItem { get { return "Control.aspx?OSP=84"; } }

        //public string CreateApplicationMenuItem { get { return "Control.aspx?OSP=151"; } }

        //public string ExceptionLoggingMenuItem { get { return "Control.aspx?OSP=85"; } }

        //public string SchoolProfileMenuItem { get { return "Control.aspx?OSP=108"; } }

        //public string SchoolContactsMenuItem { get { return "Control.aspx?OSP=114"; } }

        //public string ApplicationStatusMenuItem { get { return "Control.aspx?OSP=116"; } }

        //public string VerificationReportMenuItem { get { return "Control.aspx?OSP=128"; } }

        //public string VRViewMenuItem { get { return "Control.aspx?OSP=132"; } }

        //public string GraduationSurveyViewMenuItem { get { return "Control.aspx?OSP=142"; } }

        //public string TLEParticipationAuthorizationMenuItem { get { return "Control.aspx?OSP=143"; } }

        //public string SchoolFeeScheduleMenuItem { get { return "Control.aspx?OSP=115"; } }

        //public string ParticipationAuthorizationMenuItem { get { return "Control.aspx?OSP=121"; } }

        //public string SchoolPasswordResetMenuItem { get { return "Control.aspx?OSP=126"; } }

        //public string ConfirmEnrollmentMenuItem { get { return "Control.aspx?OSP=104"; } }

        //public string StudentDetailsMenuItem { get { return "Control.aspx?OSP=106"; } }

        //public string ExitConfirmationFormMenuItem { get { return "Control.aspx?OSP=110"; } }

        //public string SchoolCommitmentFormMenuItem { get { return "Control.aspx?OSP=111"; } }

        //public string ScholarshipStatusMenuItem { get { return "Control.aspx?OSP=134"; } }

        //public string SubmitExitConfirmationFormMenuItem { get { return "Control.aspx?OSP=149"; } }

        //public string SettingTypeMenuItem { get { return "Control.aspx?OSP=78"; } }

        //public string SitePageEditingMenuItem { get { return "Control.aspx?OSP=80"; } }

        //public string SitePageSiteControlEditingMenuItem { get { return "Control.aspx?OSP=129"; } }

        //#endregion Menu Items

        public Text ContextStudentName { get; private set; }

        public Text ContextApplicationId { get; private set; }

        public Text ContextSchoolYear { get; private set; }

        public Text ContextSchoolName { get; private set; }

        public Text ContextSchoolCode { get; private set; }

        public Link CloseSchoolContext { get; private set; }

        public Link CloseApplicationContext { get; private set; }

        public Table CSTDashboardTable { get; private set; }

        //public Table TodaysAssignmentsTable { get; private set; }

        public Table AssignedDocumentsTable { get; private set; }

        public WebElement PDFViewer { get; private set; }


        public HomePage(IWebDriver driver)
            : base(driver)
        {
            Username = new Text(Driver, By.Id("LblUsername"));
            LanguageSelection = new Dropdown(Driver, By.Id("LblLanguage"));
            SignOut = new Link(Driver, By.Id("LBSignOut"));
            ApplicationQuickSearchTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Application\"]"));
            ApplicationQuickSearchFirstName = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbFirstName"));
            ApplicationQuickSearchLastName = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbLastName"));
            ApplicationQuickSearchId = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            ApplicationQuickSearchSSN = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbSSN"));
            ApplicationQuickSearchPersonId = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbPersonId"));
            ApplicationQuickSearchYear = new Dropdown(Driver, By.Id("qsSeachControl_qsApplication_ddlApplicationYear"));
            ApplicationQuickSearchSearchButton = new Button(Driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            ApplicationAdvancedSearchButton = new Button(Driver, By.Id("qsSeachControl_qsApplication_btnAdvSearch"));
            ApplicationSearchResults = new ApplicationSearchResultsSection(Driver);
            ApplicationQuickSearchResultsTable = new FTCSASApplicationTable(Driver, By.Id("tblResults"));
            SchoolQuickSearchTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-School\"]"));
            SchoolQuickSearchCode = new EditField(Driver, By.Id("qsSeachControl_qsSchool_tbSchoolCode"));
            SchoolQuickSearchName = new EditField(Driver, By.Id("qsSeachControl_qsSchool_tbSchoolName"));
            SchoolQuickSearchCity = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlCityID"));
            SchoolQuickSearchDistrict = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlDistrictID"));
            SchoolQuickSearchZipCode = new EditField(Driver, By.Id("qsSeachControl_qsSchool_tbZipcode"));
            SchoolQuickSearchRegion = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlRegionID"));
            SchoolQuickSearchFTCParticipant = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlIsFTC"));
            SchoolQuickSearchSUFSParticipant = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlIsSUFS"));
            SchoolQuickSearchHasSUFSStudents = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlHasSUFSStudents"));
            SchoolQuickSearchDenomination = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlDenominationID"));
            SchoolQuickSearchSearchSchoolYear = new Dropdown(Driver, By.Id("qsSeachControl_qsSchool_ddlApplicationYear"));
            SchoolQuickSearchButton = new Button(Driver, By.Id("qsSeachControl_qsSchool_btnSearch"));
            SchoolAdvancedSearchButton = new Button(Driver, By.Id("qsSeachControl_qsSchool_btnAdvSearch"));
            SchoolQuickSearchResultsTable = new FTCSASSearchResultsTable(Driver, By.Id("tblSchoolSearch"));
            StudentQuickSearchTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Student\"]"));
            StudentQuickSearchSSN = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbSSN"));
            StudentQuickSearchFirstName = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbFirstName"));
            StudentQuickSearchLastName = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbLastName"));
            StudentQuickSearchPersonId = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbStudentPersonId"));
            StudentQuickSearchSchoolCode = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbSchoolCode"));
            StudentQuickSearchApplicationId = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbApplicationID"));
            StudentQuickSearchPrimaryParentSSN = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbParentSSN"));
            StudentQuickSearchYear = new Dropdown(Driver, By.Id("qsSeachControl_qsStudent_ddlApplicationYear"));
            StudentQuickSearchResultsTable = new FTCSASSearchResultsTable(Driver, By.Id("tblResults"));
            StudentQuickSearchButton = new Button(Driver, By.Id("qsSeachControl_qsStudent_btnSearch"));
            StudentAdvancedSearchButton = new Button(Driver, By.Id("qsSeachControl_qsStudent_btnAdvSearch"));
            ContextStudentName = new Text(Driver, By.Id("cdContextDisplay_lblStudentName"));
            ContextApplicationId = new Text(Driver, By.Id("cdContextDisplay_lblApplicationID"));
            ContextSchoolYear = new Text(Driver, By.Id("cdContextDisplay_lblOrganizationYear"));
            ContextSchoolName = new Text(Driver, By.Id("cdContextDisplay_lblSchoolName"));
            ContextSchoolCode = new Text(Driver, By.Id("cdContextDisplay_lblSchoolDOECode"));
            CloseSchoolContext = new Link(Driver, By.Id("cdContextDisplay_imgBtnClearContext"));
            CloseApplicationContext = new Link(Driver, By.Id("cdContextDisplay_imgBtnSchoolContext"));
            CSTDashboardTable = new Table(Driver, By.Id("tblCSTDashboard"));
            //TodaysAssignmentsTable = new Table(Driver, By.Id("gvAssignedApplications"));
            AssignedDocumentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            PDFViewer = new WebElement(Driver, By.CssSelector("embed[id=\"plugin\"]"));
            ApplicationProcessingWorksheetMenuItem = new Link(Driver, By.LinkText("Application Processing Worksheet"));
            MenuItems = new MenuItems(Driver, By.Id("sas-nav-menu"));
        }
    }
}
