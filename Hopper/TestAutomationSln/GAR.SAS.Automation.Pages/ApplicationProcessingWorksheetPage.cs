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
    [KeywordTestingOpensPDFViewer]
    public class ApplicationProcessingWorksheetPage : HomePage
    {
        public WebElement MainInformationPanel { get; private set; }

        public Text ApplicationId { get; private set; }

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

        //public Text StudentName { get; private set; }

        //public Text StudentPersonIdApp { get; private set; }

        //public Text DirectCertification { get; private set; }

        //public EditField SSN { get; private set; }

        //public EditField DateOfBirth { get; private set; }

        //public Text RelationshipToPrimaryParent { get; private set; }

        //public Checkbox StudentType_New { get; private set; }

        //public Checkbox StudentType_Renewal { get; private set; }

        //public Dropdown Gender { get; private set; }

        //public WebElement Grade { get; private set; }

        //public WebElement DocumentsValidated { get; private set; }

        //public WebElement PaymentHistory { get; private set; }

        //public Radio IEP_Yes { get; private set; }

        //public Radio IEP_No { get; private set; }

        //public EditField IEPDate { get; private set; }

        //public Dropdown IEPSchoolDistrict { get; private set; }

        //public Radio Diagnosis_Yes { get; private set; }

        //public Radio Diagnosis_No { get; private set; }

        //public EditField DoctorName { get; private set; }

        //public EditField DoctorLicense { get; private set; }

        //public Dropdown ScholarshipStatus { get; private set; }

        //public Dropdown MatrixScore { get; private set; }

        public Text CurrentWorkflowStatus { get; private set; }

        public Dropdown WorkflowStatusList { get; private set; }

        public Button SaveWorkflowStatusButton { get; private set; }

        public Dropdown HoldReason { get; private set; }

        public Dropdown HoldHouseholdMember { get; private set; }

        public EditField HoldNote { get; private set; }

        public Button AddHoldReasonButton { get; private set; }

        public PLSAHoldReasonsTable HoldReasonsTable { get; private set; }

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

        public StudentInformationTables StudentInformationTables { get; private set; }

        public SASPopupButton WorksheetPopupYES { get; private set; }

        public SASPopupButton WorksheetPopupNO { get; private set; }

        public Button OKButton { get; private set; }

        public Radio FirstStudentIEPYes { get; private set; }

        public Radio FirstStudentIEPNo { get; private set; }

        public EditField FirstStudentIEPDate { get; private set; }

        public EditField FirstStudentIEPSchoolDistrict { get; private set; }

        public Dropdown FirstStudentEligibilityStatusDropdown { get; private set; }

        public Dropdown FirstStudentMatrixScoreDropdown { get; private set; }

        public Radio SecondStudentIEPYes { get; private set; }

        public Radio SecondStudentIEPNo { get; private set; }

        public EditField SecondStudentIEPDate { get; private set; }

        public EditField SecondStudentIEPSchoolDistrict { get; private set; }

        public Dropdown SecondStudentEligibilityStatusDropdown { get; private set; }

        public Dropdown SecondStudentMatrixScoreDropdown { get; private set; }

        public ApplicationProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            MainInformationPanel = new WebElement(Driver, By.Id("PanelForScrollBar"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            ApplicationSubmissionType = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationSubmissionTypeValue\"]"));
            ApplicationSubmissionDate = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationSubmissionDateValue\"]"));
            ApplicationType_New = new Checkbox(Driver, By.CssSelector("input[id$=\"cblApplicationType_0\"]"));
            ApplicationType_Renewal = new Checkbox(Driver, By.CssSelector("input[id$=\"cblApplicationType_1\"]"));
            SaveApplicationType = new Button(Driver, By.CssSelector("input[id$=\"btnSaveApplicationType\"]"));
            HouseholdLanguage = new Text(Driver, By.CssSelector("span[id$=\"lblHouseholdLanguageValue\"]"));
            PhysicalAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalAddress1\"]"));
            PhysicalAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalAddress2\"]"));
            PhysicalCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalCity\"]"));
            PhysicalState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalState\"]"));
            PhysicalZip = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalZip\"]"));
            PhysicalCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalCounty\"]"));
            MailingAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress1\"]"));
            MailingAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress2\"]"));
            MailingCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCity\"]"));
            MailingState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingState\"]"));
            MailingZip = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingZip\"]"));
            MailingCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCounty\"]"));
            HomePhoneNumber = new Text(Driver, By.CssSelector("span[id$=\"lblHomePhoneNumber\"]"));
            WorkPhoneNumber = new Text(Driver, By.CssSelector("span[id$=\"lblWorkPhoneNumber\"]"));
            MobilePhoneNumber = new Text(Driver, By.CssSelector("span[id$=\"lblMobilePhoneNumber\"]"));
            EmailAddress = new Text(Driver, By.CssSelector("span[id$=\"lblEmailAddressValue\"]"));
            //StudentName = new Text(Driver, By.CssSelector("span[id$=\"lblStudentName\"]"));
            //StudentPersonIdApp = new Text(Driver, By.CssSelector("span[id$=\"StudentPersonId\"]"));
            //DirectCertification = new Text(Driver, By.CssSelector("span[id$=\"lblDirectCertificationAnswer\"]"));
            //SSN = new EditField(Driver, By.CssSelector("input[id$=\"tbSSN\"]"));
            //DateOfBirth = new EditField(Driver, By.CssSelector("input[id$=\"tbDateOfBirth\"]"));
            //RelationshipToPrimaryParent = new Text(Driver, By.CssSelector("span[id$=\"lblRelationshipPPValue\"]"));
            //StudentType_New = new Checkbox(Driver, By.CssSelector("input[id$=\"cblStudentType_0\"]"));
            //StudentType_Renewal = new Checkbox(Driver, By.CssSelector("input[id$=\"cblStudentType_1\"]"));
            //Gender = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGender\"]"));
            //Grade = new WebElement(Driver, By.CssSelector("table[id$=\"cblGrade\"]"));
            //DocumentsValidated = new WebElement(Driver, By.CssSelector("table[id$=\"cblDocumentsValidated\"]"));
            //PaymentHistory = new WebElement(Driver, By.CssSelector("input[id$=\"cbPaymentHistory\"]"));
            //IEP_Yes = new Radio(Driver, By.CssSelector("input[id$=\"rblIEP_0\"]"));
            //IEP_No = new Radio(Driver, By.CssSelector("input[id$=\"rblIEP_1\"]"));
            //IEPDate = new EditField(Driver, By.CssSelector("input[id$=\"tbIEPDate\"]"));
            //IEPSchoolDistrict = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlIEPSchoolDistrict\"]"));
            //Diagnosis_Yes = new Radio(Driver, By.CssSelector("input[id$=\"rblDiagnosis_0\"]"));
            //Diagnosis_No = new Radio(Driver, By.CssSelector("input[id$=\"rblDiagnosis_1\"]"));
            //DoctorName = new EditField(Driver, By.CssSelector("input[id$=\"tbDoctorName\"]"));
            //DoctorLicense = new EditField(Driver, By.CssSelector("input[id$=\"tbDoctorLicense\"]"));
            //ScholarshipStatus = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipStatus\"]"));
            //MatrixScore = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMatrix\"]"));
            CurrentWorkflowStatus = new Text(Driver, By.CssSelector("span[id$=\"lblCurrentStatus\"]"));
            WorkflowStatusList = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationWorkflowStatus\"]"));
            SaveWorkflowStatusButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveApplicationWorkflowStatus\"]"));
            HoldReason = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationHoldReason\"]"));
            HoldHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationonholdreason\"][id$=\"ddlHouseholdMember\"]"));
            HoldNote = new EditField(Driver, By.CssSelector("textarea[id*=\"applicationonholdreason\"][id$=\"tbHoldNote\"]"));
            HoldReasonsTable = new PLSAHoldReasonsTable(Driver, By.CssSelector("div[id$=\"divReasonList\"]"));
            AddHoldReasonButton = new Button(Driver, By.CssSelector("input[id$=\"btnAddHoldReason\"]"));
            DenialReason = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationDenialReason\"]"));
            DenialHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationdenialreason\"][id$=\"ddlHouseholdMember\"]"));
            DenialNote = new EditField(Driver, By.CssSelector("textarea[id*=\"applicationdenialreason\"][id$=\"tbHoldNote\"]"));
            DenialReasonsTable = new Table(Driver, By.CssSelector("table[id^=\"tblDenialReasonList\"]"));
            AddDenialReasonButton = new Button(Driver, By.CssSelector("input[id$=\"btnAddDenialReason\"]"));
            NoteType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationProcessingNoteType\"]"));
            NoteHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationprocessingnotes\"][id$=\"ddlHouseholdMember\"]"));
            IsSensitiveNote = new Checkbox(Driver, By.CssSelector("input[id$=\"chkIsSensitiveNote\"]"));
            Note = new EditField(Driver, By.CssSelector("textarea[id$=\"tbProcessingNote\"]"));
            AddNoteButton = new Button(Driver, By.CssSelector("input[id$=\"btnAddProcessingNote\"]"));
            NotesTable = new Table(Driver, By.Id("tblNoteList"));
            SaveEntireWorksheetButton = new Button(Driver, By.Id("btnSave"));
            ScholarshipStatusModal = new Modal(Driver, By.CssSelector("div[aria-labelledby^=\"ui-dialog-title\"][style*=\"block\"]"));
            RemoveMatrixReviewRequestButton = new Button(Driver, By.CssSelector("input[id$=\"btnRemoveMatrixRequest\"]"));
            RemoveMatrixReviewRequestMessage = new Text(Driver, By.CssSelector("span[id$=\"lblRemoveMatrixConfirmMessage\"]"));
            ConfirmRemoveMatrixReviewRequest = new Button(Driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestConfirmed\"]"));
            CancelRemoveMatrixReviewRequest = new Button(Driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestCancel\"]"));
            RequiredDocumentsSection = new Table(Driver, By.CssSelector("table[id$=\"rblEvidenceType\"]"));
            MaritalStatusSingle = new Checkbox(Driver, By.CssSelector("input[id$=\"rblMaritalStatus_0\"]"));
            StudentInformationTables = new StudentInformationTables(Driver, By.CssSelector("div[id$=\"upIncome\"]"));
            WorksheetPopupYES = new SASPopupButton(Driver, By.XPath("//button[text() = 'Yes']"));
            WorksheetPopupNO = new SASPopupButton(Driver, By.XPath("//button[text() = 'No']"));
            OKButton = new Button(Driver, By.XPath("//a[text() = 'OK']"));
            FirstStudentIEPYes = new Radio(Driver, By.CssSelector("input[id$=\"ctl00_rblIEP_0\"]"));
            FirstStudentIEPNo = new Radio(Driver, By.CssSelector("input[id$=\"ctl00_rblIEP_1\"]"));
            FirstStudentIEPDate = new EditField(Driver, By.CssSelector("input[id$=\"ctl00_tbIEPDate\"]"));
            FirstStudentIEPSchoolDistrict = new EditField(Driver, By.CssSelector("select[id$=\"ctl00_ddlIEPSchoolDistrict\"]"));
            FirstStudentEligibilityStatusDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ctl00_ddlStudentEligibilityStatus\"]"));
            FirstStudentMatrixScoreDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ctl00_ddlMatrix\"]"));
            SecondStudentIEPYes = new Radio(Driver, By.CssSelector("input[id$=\"ctl01_rblIEP_0\"]"));
            SecondStudentIEPNo = new Radio(Driver, By.CssSelector("input[id$=\"ctl01_rblIEP_1\"]"));
            SecondStudentIEPDate = new EditField(Driver, By.CssSelector("input[id$=\"ctl01_tbIEPDate\"]"));
            SecondStudentIEPSchoolDistrict = new EditField(Driver, By.CssSelector("select[id$=\"ctl01_ddlIEPSchoolDistrict\"]"));
            SecondStudentEligibilityStatusDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ctl01_ddlStudentEligibilityStatus\"]"));
            SecondStudentMatrixScoreDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ctl01_ddlMatrix\"]"));
        }
    }
}
