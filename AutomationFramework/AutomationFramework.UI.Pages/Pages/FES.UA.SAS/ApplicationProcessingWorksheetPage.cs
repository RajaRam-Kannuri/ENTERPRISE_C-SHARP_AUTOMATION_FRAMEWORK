using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ApplicationProcessingWorksheetPage : HomePage
    {        public Text ApplicationId { get; private set; }

        public Text ApplicationSubmissionType { get; private set; }

        public Text ApplicationSubmissionDate { get; private set; }

        public Checkbox ApplicationType_New { get; private set; }

        public Checkbox ApplicationType_Renewal { get; private set; }

        public Button SaveApplicationType { get; private set; }

        public Text HouseholdLanguage { get; private set; }

        public EditField PhysicalAddress1 { get; private set; }

        public EditField PhysicalAddress2 { get; private set; }

        public Dropdown PhysicalCity { get; private set; }

        public Dropdown PhysicalState { get; private set; }

        public EditField PhysicalZip { get; private set; }

        public Dropdown PhysicalCounty { get; private set; }

        public EditField MailingAddress1 { get; private set; }

        public EditField MailingAddress2 { get; private set; }

        public Dropdown MailingCity { get; private set; }

        public Dropdown MailingState { get; private set; }

        public EditField MailingZip { get; private set; }

        public Dropdown MailingCounty { get; private set; }

        public Text HomePhoneNumber { get; private set; }

        public Text WorkPhoneNumber { get; private set; }

        public Text MobilePhoneNumber { get; private set; }

        public Text EmailAddress { get; private set; }

        public Text CurrentWorkflowStatus { get; private set; }

        public Dropdown WorkflowStatusList { get; private set; }

        public Button SaveWorkflowStatusButton { get; private set; }

        public Dropdown HoldReason { get; private set; }

        public Dropdown HoldHouseholdMember { get; private set; }

        public EditField HoldNote { get; private set; }

        public Button AddHoldReasonButton { get; private set; }

        public Table HoldReasonsTable { get; private set; }

        public Dropdown DenialReason { get; private set; }

        public Dropdown DenialHouseholdMember { get; private set; }

        public EditField DenialNote { get; private set; }

        public Button AddDenialReasonButton { get; private set; }

        public Table DenialReasonsTable { get; private set; }

        public Dropdown NoteType { get; private set; }

        public Dropdown NoteHouseholdMember { get; private set; }

        public Checkbox IsSensitiveNote { get; private set; }

        public EditField Note { get; private set; }

        public Button AddNoteButton { get; private set; }

        public Table NotesTable { get; private set; }

        public Button SaveEntireWorksheetButton { get; private set; }

        public Modal ScholarshipStatusModal { get; private set; }

        public Modal DeniedConfirmationModal { get; private set; }

        public Button RemoveMatrixReviewRequestButton { get; private set; }

        public Text RemoveMatrixReviewRequestMessage { get; private set; }

        public Button ConfirmRemoveMatrixReviewRequest { get; private set; }

        public Button CancelRemoveMatrixReviewRequest { get; private set; }

        public Table RequiredDocumentsSection { get; private set; }

        public Checkbox MaritalStatusSingle { get; private set; }

        public Table StudentInformationTables { get; private set; }

        public Button WorksheetPopupYES { get; private set; }

        public Button WorksheetPopupNO { get; private set; }

        public Button OKButton { get; private set; }

        public RadioButton FirstStudentIEPYes { get; private set; }

        public RadioButton FirstStudentIEPNo { get; private set; }

        public EditField FirstStudentIEPDate { get; private set; }

        public EditField FirstStudentIEPSchoolDistrict { get; private set; }

        public Dropdown FirstStudentEligibilityStatusDropdown { get; private set; }

        public Dropdown FirstStudentMatrixScoreDropdown { get; private set; }

        public RadioButton SecondStudentIEPYes { get; private set; }

        public RadioButton SecondStudentIEPNo { get; private set; }

        public EditField SecondStudentIEPDate { get; private set; }

        public EditField SecondStudentIEPSchoolDistrict { get; private set; }

        public Dropdown SecondStudentEligibilityStatusDropdown { get; private set; }

        public Dropdown SecondStudentMatrixScoreDropdown { get; private set; }

        public ApplicationProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationId = new Text(driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            ApplicationSubmissionType = new Text(driver, By.CssSelector("span[id$=\"lblApplicationSubmissionTypeValue\"]"));
            ApplicationSubmissionDate = new Text(driver, By.CssSelector("span[id$=\"lblApplicationSubmissionDateValue\"]"));
            ApplicationType_New = new Checkbox(driver, By.CssSelector("input[id$=\"cblApplicationType_0\"]"));
            ApplicationType_Renewal = new Checkbox(driver, By.CssSelector("input[id$=\"cblApplicationType_1\"]"));
            SaveApplicationType = new Button(driver, By.CssSelector("input[id$=\"btnSaveApplicationType\"]"));
            HouseholdLanguage = new Text(driver, By.CssSelector("span[id$=\"lblHouseholdLanguageValue\"]"));
            PhysicalAddress1 = new EditField(driver, By.CssSelector("input[id$=\"tbPhysicalAddress1\"]"));
            PhysicalAddress2 = new EditField(driver, By.CssSelector("input[id$=\"tbPhysicalAddress2\"]"));
            PhysicalCity = new Dropdown(driver, By.CssSelector("select[id$=\"ddlPhysicalCity\"]"));
            PhysicalState = new Dropdown(driver, By.CssSelector("select[id$=\"ddlPhysicalState\"]"));
            PhysicalZip = new EditField(driver, By.CssSelector("input[id$=\"tbPhysicalZip\"]"));
            PhysicalCounty = new Dropdown(driver, By.CssSelector("select[id$=\"ddlPhysicalCounty\"]"));
            MailingAddress1 = new EditField(driver, By.CssSelector("input[id$=\"tbMailingAddress1\"]"));
            MailingAddress2 = new EditField(driver, By.CssSelector("input[id$=\"tbMailingAddress2\"]"));
            MailingCity = new Dropdown(driver, By.CssSelector("select[id$=\"ddlMailingCity\"]"));
            MailingState = new Dropdown(driver, By.CssSelector("select[id$=\"ddlMailingState\"]"));
            MailingZip = new EditField(driver, By.CssSelector("input[id$=\"tbMailingZip\"]"));
            MailingCounty = new Dropdown(driver, By.CssSelector("select[id$=\"ddlMailingCounty\"]"));
            HomePhoneNumber = new Text(driver, By.CssSelector("span[id$=\"lblHomePhoneNumber\"]"));
            WorkPhoneNumber = new Text(driver, By.CssSelector("span[id$=\"lblWorkPhoneNumber\"]"));
            MobilePhoneNumber = new Text(driver, By.CssSelector("span[id$=\"lblMobilePhoneNumber\"]"));
            EmailAddress = new Text(driver, By.CssSelector("span[id$=\"lblEmailAddressValue\"]"));
            CurrentWorkflowStatus = new Text(driver, By.CssSelector("span[id$=\"lblCurrentStatus\"]"));
            WorkflowStatusList = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationWorkflowStatus\"]"));
            SaveWorkflowStatusButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveApplicationWorkflowStatus\"]"));
            HoldReason = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationHoldReason\"]"));
            HoldHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationonholdreason\"][id$=\"ddlHouseholdMember\"]"));
            HoldNote = new EditField(driver, By.CssSelector("textarea[id*=\"applicationonholdreason\"][id$=\"tbHoldNote\"]"));
            HoldReasonsTable = new Table(driver, By.CssSelector("div[id$=\"divReasonList\"]"));
            AddHoldReasonButton = new Button(driver, By.CssSelector("input[id$=\"btnAddHoldReason\"]"));
            DenialReason = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationDenialReason\"]"));
            DenialHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationdenialreason\"][id$=\"ddlHouseholdMember\"]"));
            DenialNote = new EditField(driver, By.CssSelector("textarea[id*=\"applicationdenialreason\"][id$=\"tbHoldNote\"]"));
            DenialReasonsTable = new Table(driver, By.CssSelector("table[id^=\"tblDenialReasonList\"]"));
            AddDenialReasonButton = new Button(driver, By.CssSelector("input[id$=\"btnAddDenialReason\"]"));
            NoteType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationProcessingNoteType\"]"));
            NoteHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationprocessingnotes\"][id$=\"ddlHouseholdMember\"]"));
            IsSensitiveNote = new Checkbox(driver, By.CssSelector("input[id$=\"chkIsSensitiveNote\"]"));
            Note = new EditField(driver, By.CssSelector("textarea[id$=\"tbProcessingNote\"]"));
            AddNoteButton = new Button(driver, By.CssSelector("input[id$=\"btnAddProcessingNote\"]"));
            NotesTable = new Table(driver, By.Id("tblNoteList"));
            SaveEntireWorksheetButton = new Button(driver, By.Id("btnSave"));
            ScholarshipStatusModal = new Modal(driver, By.CssSelector("div[aria-labelledby^=\"ui-dialog-title\"][style*=\"block\"]"));
            RemoveMatrixReviewRequestButton = new Button(driver, By.CssSelector("input[id$=\"btnRemoveMatrixRequest\"]"));
            RemoveMatrixReviewRequestMessage = new Text(driver, By.CssSelector("span[id$=\"lblRemoveMatrixConfirmMessage\"]"));
            ConfirmRemoveMatrixReviewRequest = new Button(driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestConfirmed\"]"));
            CancelRemoveMatrixReviewRequest = new Button(driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestCancel\"]"));
            RequiredDocumentsSection = new Table(driver, By.CssSelector("table[id$=\"rblEvidenceType\"]"));
            MaritalStatusSingle = new Checkbox(driver, By.CssSelector("input[id$=\"rblMaritalStatus_0\"]"));
            StudentInformationTables = new Table(driver, By.CssSelector("div[id$=\"upIncome\"]"));
            WorksheetPopupYES = new Button(driver, By.XPath("//button[text() = 'Yes']"));
            WorksheetPopupNO = new Button(driver, By.XPath("//button[text() = 'No']"));
            OKButton = new Button(driver, By.XPath("//a[text() = 'OK']"));
            FirstStudentIEPYes = new RadioButton(driver, By.CssSelector("input[id$=\"ctl00_rblIEP_0\"]"));
            FirstStudentIEPNo = new RadioButton(driver, By.CssSelector("input[id$=\"ctl00_rblIEP_1\"]"));
            FirstStudentIEPDate = new EditField(driver, By.CssSelector("input[id$=\"ctl00_tbIEPDate\"]"));
            FirstStudentIEPSchoolDistrict = new EditField(driver, By.CssSelector("select[id$=\"ctl00_ddlIEPSchoolDistrict\"]"));
            FirstStudentEligibilityStatusDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ctl00_ddlStudentEligibilityStatus\"]"));
            FirstStudentMatrixScoreDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ctl00_ddlMatrix\"]"));
            SecondStudentIEPYes = new RadioButton(driver, By.CssSelector("input[id$=\"ctl01_rblIEP_0\"]"));
            SecondStudentIEPNo = new RadioButton(driver, By.CssSelector("input[id$=\"ctl01_rblIEP_1\"]"));
            SecondStudentIEPDate = new EditField(driver, By.CssSelector("input[id$=\"ctl01_tbIEPDate\"]"));
            SecondStudentIEPSchoolDistrict = new EditField(driver, By.CssSelector("select[id$=\"ctl01_ddlIEPSchoolDistrict\"]"));
            SecondStudentEligibilityStatusDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ctl01_ddlStudentEligibilityStatus\"]"));
            SecondStudentMatrixScoreDropdown = new Dropdown(driver, By.CssSelector("select[id$=\"ctl01_ddlMatrix\"]"));
        }
    }
}
