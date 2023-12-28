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

        //public ApplicationSearchResultsPage ApplicationSearchResults { get; private set; }

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

        public StudentSearchResultsSection StudentSearchResults { get; private set; }

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

        //public ProviderSearchResultsSection ProviderSearchResults { get; private set; }

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

        //public string ApplicationProcessingWorksheet2011MenuItem { get { return "Control.aspx?OSP=81"; } }

        //public string ApplicationSummaryMenuItem { get { return "Control.aspx?OSP=87"; } }

        //public string ApplicationDetailMenuItem { get { return "Control.aspx?OSP=88"; } }

        //public string StudentSummaryMenuItem { get { return "Control.aspx?OSP=89"; } }

        //public string StudentDetailMenuItem { get { return "Control.aspx?OSP=90"; } }

        //public string ApplicationProcessingWorksheetMenuItem { get; private set; }

        //public string DocumentFormAdministrationMenuItem { get { return "Control.aspx?OSP=57"; } }

        //public string SitePageSiteControlRichTextAdministrationMenuItem { get { return "Control.aspx?OSP=58"; } }

        //public string SearchResultsMenuItem { get { return "Control.aspx?OSP=59"; } }

        //public string AdvancedSearchMenuItem { get { return "Control.aspx?OSP=71"; } }

        //public Text ApplicationQueueAssignmentMenuItem { get { return new Text(Driver, By.CssSelector("a[href$=\"Control.aspx?OSP=77\"]")); } }

        //public string ConfigureFeatureSettingsMenuItem { get { return "Control.aspx?OSP=165"; } }

        //public string MaintainVRandSurveyPeriodsMenuItem { get { return "Control.aspx?OSP=122"; } }

        //public string MaintainVROpenMessageMenuItem { get { return "Control.aspx?OSP=123"; } }

        //public string RemoveApplicationMenuItem { get { return "Control.aspx?OSP=138"; } }

        //public string UpdateWaitListMenuItem { get { return "Control.aspx?OSP=145"; } }

        //public string SettingsMenuItem { get { return "Control.aspx?OSP=164"; } }

        //public string MessageAdministrationMenuItem { get { return "Control.aspx?OSP=93"; } }

        //public string ApplicationFeeTransactionsMenuItem { get { return "Control.aspx?OSP=94"; } }

        //public string StudentSearchResultsMenuItem { get { return "Control.aspx?OSP=109"; } }

        //public string AdvancedStudentSearchMenuItem { get { return "Control.aspx?OSP=119"; } }

        //public string ReportMenuMenuItem { get { return "Control.aspx?OSP=84"; } }

        //public string ExceptionLoggingMenuItem { get { return "Control.aspx?OSP=85"; } }

        //public string VerificationReportMenuItem { get { return "Control.aspx?OSP=128"; } }

        //public string StudentDetailsMenuItem { get { return "Control.aspx?OSP=106"; } }

        //public string ScholarshipStatusMenuItem { get { return "Control.aspx?OSP=134"; } }

        //public string SettingTypeMenuItem { get { return "Control.aspx?OSP=78"; } }

        //public string SitePageEditingMenuItem { get { return "Control.aspx?OSP=80"; } }

        //public string SitePageSiteControlEditingMenuItem { get { return "Control.aspx?OSP=129"; } }

        //public string ProviderContactWorksheetMenuItem { get { return "Control.aspx?OSP=192"; } }

        //public string ProviderClaimActivityMenuItem { get { return "Control.aspx?OSP=194"; } }

        //public string ProviderContactLogsMenuItem { get { return "Control.aspx?OSP=195"; } }

        //public string ProviderApprovalWorksheetMenuItem { get { return "Control.aspx?OSP=200"; } }

        //public string ReimbursementRequestProcessingMenuItem { get { return "Control.aspx?OSP=182"; } }

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

        public FTCSASSearchResultsTable StudentQuickSearchResultsTable { get; private set; }

        public ProviderTable ProviderSearchResultsTable { get; private set; }

        public EditField ApplicationQuickSearchId { get; private set; }

        public Button ApplicationQuickSearchSearchButton { get; private set; }

        public GARSASApplicationTable ApplicationQuickSearchResultsTable { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            Username = new Text(Driver, By.Id("LblUsername"));
            LanguageSelection = new Dropdown(Driver, By.Id("LblLanguage"));
            SignOut = new Link(Driver, By.Id("LBSignOut"));
            ApplicationTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Application\"]"));
            AppFirstName = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbFirstName"));
            AppLastName = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbLastName"));
            AppId = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            AppSSN = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbSSN"));
            AppPersonId = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbPersonId"));
            AppYear = new Dropdown(Driver, By.Id("qsSeachControl_qsApplication_ddlApplicationYear"));
            AppSearch = new Button(Driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            AppAdvancedSearch = new Button(Driver, By.Id("qsSeachControl_qsApplication_btnAdvSearch"));
            //ApplicationSearchResults = new ApplicationSearchResultsPage(Driver);
            StudentTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Student\"]"));
            StudentSSN = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbSSN"));
            StudentFirstName = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbFirstName"));
            StudentLastName = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbLastName"));
            StudentPersonId = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbStudentPersonId"));
            StudentSchoolCode = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbSchoolCode"));
            StudentApplicationId = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbApplicationID"));
            StudentPrimaryParentSSN = new EditField(Driver, By.Id("qsSeachControl_qsStudent_tbParentSSN"));
            StudentYear = new Dropdown(Driver, By.Id("qsSeachControl_qsStudent_ddlApplicationYear"));
            StudentSearch = new Button(Driver, By.Id("qsSeachControl_qsStudent_btnSearch"));
            StudentAdvancedSearch = new Button(Driver, By.Id("qsSeachControl_qsStudent_btnAdvSearch"));
            StudentQuickSearchResultsTable = new FTCSASSearchResultsTable(Driver, By.Id("tblResults"));
            ReimbursementTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Claim\"]"));
            ReimbursementId = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbClaimID"));
            ReimbursementStudentFirstName = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbFirstName"));
            ReimbursementStudentLastName = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbLastName"));
            ReimbursementPLSAId = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbStudentID"));
            ReimbursementStudentSSN = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbSSN"));
            ReimbursementApplicationId = new EditField(Driver, By.Id("qsSeachControl_qsClaim_tbApplicationID"));
            ReimbursementSchoolYear = new Dropdown(Driver, By.Id("qsSeachControl_qsClaim_ddlOrganizationYear"));
            ReimbursementSearch = new Button(Driver, By.Id("qsSeachControl_qsClaim_btnSearch"));
            ReimbursementAdvancedSearch = new Button(Driver, By.Id("qsSeachControl_qsClaim_btnAdvSearch"));
            ProviderTab = new Tab(Driver, By.CssSelector("a[href=\"#QuickSearch-Provider\"]"));
            ProviderIdQuickSearch = new EditField(Driver, By.Id("qsSeachControl_qsProvider_tbProviderID"));
            ProviderNameQuickSearch = new EditField(Driver, By.Id("qsSeachControl_qsProvider_tbProviderName"));
            ProviderLicenseNumberQuickSearch = new EditField(Driver, By.Id("qsSeachControl_qsProvider_tbLicenseNumber"));
            ProviderLicenseTypeQuickSearch = new Dropdown(Driver, By.Id("qsSeachControl_qsProvider_ddlLicenseType"));
            ProviderTaxIdQuickSearch = new EditField(Driver, By.Id("qsSeachControl_qsProvider_tbTaxID"));
            ProviderStatusQuickSearch = new Dropdown(Driver, By.Id("qsSeachControl_qsProvider_ddlProviderStatus"));
            ProviderSearch = new Button(Driver, By.Id("qsSeachControl_qsProvider_btnSearch"));
            ProviderAdvancedSearch = new Button(Driver, By.Id("qsSeachControl_qsProvider_btnAdvSearch"));
            //ProviderSearchResults = new ProviderSearchResultsSection(Driver);
            MenuItems = new MenuItems(Driver, By.Id("sas-nav-menu"));
            ContextStudentName = new Text(Driver, By.Id("cdContextDisplay_lblStudentName"));
            ContextApplicationId = new Text(Driver, By.Id("cdContextDisplay_lblApplicationID"));
            ContextSchoolYear = new Text(Driver, By.Id("cdContextDisplay_lblOrganizationYear"));
            ContextSchoolName = new Text(Driver, By.Id("cdContextDisplay_lblSchoolName"));
            ContextSchoolCode = new Text(Driver, By.Id("cdContextDisplay_lblSchoolDOECode"));
            CloseSchoolContext = new Link(Driver, By.Id("cdContextDisplay_imgBtnClearContext"));
            CloseApplicationContext = new Link(Driver, By.Id("cdContextDisplay_imgBtnSchoolContext"));
            CloseProviderContext = new Link(Driver, By.Id("cdContextDisplay_imgBtnClearProviderContext"));
            CSTDashboardTable = new Table(Driver, By.Id("tblCSTDashboard"));
            TodaysAssignments = new Table(Driver, By.Id("gvAssignedApplications"));
            AssignedDocumentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvDocuments\"]"));
            ProviderSearchResultsTable = new ProviderTable(Driver, By.Id("tblResults"));
            ApplicationQuickSearchId = new EditField(Driver, By.Id("qsSeachControl_qsApplication_tbApplicationID"));
            ApplicationQuickSearchSearchButton = new Button(Driver, By.Id("qsSeachControl_qsApplication_btnSearch"));
            ApplicationQuickSearchResultsTable = new GARSASApplicationTable(Driver, By.Id("tblResults"));
        }
    }
}
