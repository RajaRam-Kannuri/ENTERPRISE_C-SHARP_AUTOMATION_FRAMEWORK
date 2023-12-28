using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class ApplicationProcessingWorksheetPage : BasePage
    {
        public WebElement MainInformationPanel { get; private set; }

        public WebElement TabPanel { get; private set; }

        public WebElement ApplicationDetails { get; private set; }

        public Text ApplicationId { get; private set; }

        public Text SchoolYear { get; private set; }

        public Text SubmissionDate { get; private set; }

        public Radio New { get; private set; }

        public Radio Renewal { get; private set; }

        public Button SaveApplicationTypeButton { get; private set; }

        public Text DirectCertificationHousehold { get; private set; }

        public Radio AssistanceProgramYes { get; private set; }

        public Radio AssistanceProgramNo { get; private set; }

        public Radio AuthorizationToCheckAgencies { get; private set; }

        public Text HouseholdLanguage { get; private set; }

        public Text HomePhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text MobilePhone { get; private set; }

        public Text Email { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text PhysicalCity { get; private set; }

        public Text PhysicalState { get; private set; }

        public Text PhysicalZip { get; private set; }

        public Button EditPhysicalAddress { get; private set; }

        public Button EditMailingAddress { get; private set; }

        public Modal EditAddressModal { get; private set; }

        public EditField EditAddress1 { get; private set; }

        public EditField EditAddress2 { get; private set; }

        public Dropdown EditCity { get; private set; }

        public Dropdown EditState { get; private set; }

        public EditField EditZip { get; private set; }

        public Dropdown EditCounty { get; private set; }

        public Button CloseModal { get; private set; }

        public Button SaveModalChangesButton { get; private set; }

        public Text CurrentWorkflowStatus { get; private set; }

        public Dropdown WorkflowStatusList { get; private set; }

        public Button SaveStatusOnlyButton { get; private set; }

        public Tab ProcessorNotesTab { get; private set; }

        public Dropdown NoteType { get; private set; }

        public Dropdown NoteForHouseholdMember { get; private set; }

        public Checkbox SensitiveNote { get; private set; }

        public EditField NoteBody { get; private set; }

        public Button AddNoteButton { get; private set; }

        public Tab OnHoldTab { get; private set; }

        public Button AddHoldReasonButton { get; private set; }

        public Modal AddHoldReasonModal { get; private set; }

        public Dropdown OnHoldReason { get; private set; }

        public Dropdown OnHoldRelatedHouseholdMember { get; private set; }

        public EditField OnHoldNotes { get; private set; }

        public Tab DenialTab { get; private set; }

        public Button AddDenialReasonButton { get; private set; }

        public Dropdown DenialReason { get; private set; }

        public Dropdown DenialRelatedHouseholdMember { get; private set; }

        public EditField DenialNotes { get; private set; }

        public Tab StudentTab { get; private set; }

        public RepeatedControlGroup StudentDataPane { get; private set; }

        public Tab HouseholdCompTab { get; private set; }

        public SASTabInformation HouseholdCompInformation { get; private set; }

        public Table HouseholdCompositionTable { get; private set; }

        public WebElement NumberOfGuardians { get; private set; }

        public WebElement NumberOfStudents { get; private set; }

        public WebElement NumberOfChildren { get; private set; }

        public WebElement NumberOfAdults { get; private set; }

        public Text TotalInHousehold { get; private set; }

        public Text PrimaryParentHasRoommate { get; private set; }

        public Text NumberOfRoommates { get; private set; }

        public Text HousingPaymentType { get; private set; }

        public WebElement MaritalStatus { get; private set; }

        public Tab IncomeTab { get; private set; }

        public Table EmploymentStatusTable { get; private set; }

        public FTCSASIncomeTable AnnualIncomeTable { get; private set; }

        public Text TotalHouseholdIncome { get; private set; }

        public Text AnnualIncomeCap { get; private set; }

        public Text FTCAnnualIncomeCap { get; private set; }

        public Text FESAnnualIncomeCap { get; private set; }

        public Text ScholarshipLevel { get; private set; }

        public Text ScholarshipLevelZeroPercent { get; private set; }
        
        public Dropdown IncomeEligibilityStatus { get; private set; }

        public Dropdown FTCIncomeEligibilityStatus { get; private set; }

        public Dropdown FESIncomeEligibilityStatus { get; private set; }

        public Tab RequiredDocumentsTab { get; private set; }

        public Tab ContactLogTab { get; private set; }

        public FTCSASContactLog ContactLogTable { get; private set; }

        public Tab TransactionsTab { get; private set; }

        public Table PaymentHistoryTable { get; private set; }

        public EditField MoneyOrderNumber { get; private set; }

        public EditField MoneyOrderAmount { get; private set; }

        public EditField MoneyOrderDate { get; private set; }

        public Button SavePaymentButton { get; private set; }

        public Tab HistoricalDocumentsTab { get; private set; }

        public Tab AppealTab { get; private set; }

        public Dropdown AppealReasonDropdown { get; private set; }

        public EditField AppealExplanationTextbox { get; private set; }

        public Button SaveAppealButton { get; private set; }

        public Button StartAppealButton { get; private set; }

        public Button RemoveAppealButton { get; private set; }

        public Button SaveEntireWorksheetButton { get; private set; }

        public Modal NotificationModal { get; private set; }

        public Text NotificationMessage { get; private set; }

        public Button NotificationOKButton { get; private set; }

        public Button NotificationYesButton { get; private set; }

        public Button NotificationNoButton { get; private set; }

        public Text ValidationErrors { get; private set; }

        public Text FullName { get; private set; }

        public Text PersonId { get; private set; }

        public Text DirectCertification { get; private set; }

        public EditField SSN { get; private set; }

        public EditField DOB { get; private set; }

        public Text RelationshipToPrimaryGuardian { get; private set; }

        public Radio StudentTypeNew { get; private set; }

        public Radio StudentTypeRenewal { get; private set; }

        public Radio FosterChildYes { get; private set; }

        public Radio FosterChildNo { get; private set; }

        public Radio OutOfHomeCareYes { get; private set; }

        public Radio OutOfHomeCareNo { get; private set; }

        public Dropdown Gender { get; private set; }

        public Radio Kindergarten { get; private set; }

        public Radio FirstGrade { get; private set; }

        public Radio SecondGrade { get; private set; }

        public Radio ThirdGrade { get; private set; }

        public Radio FourthGrade { get; private set; }

        public Radio FifthGrade { get; private set; }

        public Radio SixthGrade { get; private set; }

        public Radio SeventhGrade { get; private set; }

        public Radio EighthGrade { get; private set; }

        public Radio NinthGrade { get; private set; }

        public Radio TenthGrade { get; private set; }

        public Radio EleventhGrade { get; private set; }

        public Radio TwelfthGrade { get; private set; }

        public EditField ScholarshipStatus { get; private set; }

        public Dropdown StudentEligibilityStatus { get; private set; }

        public Dropdown CategoricallyEligibleStatus { get; private set; }

        public Text HouseholdIncomeLevel { get; private set; }

        public Button SaveWorkflowStatusButton { get; private set; }

        public Dropdown HoldReason { get; private set; }

        public Dropdown HoldHouseholdMember { get; private set; }

        public EditField HoldNote { get; private set; }

        public PLSAHoldReasonsTable HoldReasonsTable { get; private set; }

        public Dropdown DenialHouseholdMember { get; private set; }

        public EditField DenialNote { get; private set; }

        public Table DenialReasonsTable { get; private set; }

        public Dropdown NoteHouseholdMember { get; private set; }

        public Checkbox IsSensitiveNote { get; private set; }

        public EditField Note { get; private set; }

        public Table NotesTable { get; private set; }

        public FTCSASScholarshipStatusConfirmationModal ScholarshipStatusModal { get; private set; }

        public Modal DeniedConfirmationModal { get; private set; }

        public Button RemoveMatrixReviewRequestButton { get; private set; }

        public Text RemoveMatrixReviewRequestMessage { get; private set; }

        public Button ConfirmRemoveMatrixReviewRequest { get; private set; }

        public Button CancelRemoveMatrixReviewRequest { get; private set; }

        public Table RequiredDocumentsSection { get; private set; }

        public Checkbox MaritalStatusSingle { get; private set; }

        public FTCSASStudentInformationTables StudentInformationTables { get; private set; }

        public SASPopupButton WorksheetPopupYES { get; private set; }

        public SASPopupButton WorksheetPopupNO { get; private set; }

        public EditField ParentPaycheckAmount_Textbox { get; private set; }

        public Text OnceInAlwaysInText { get; private set; }

        public Button CloseWorksheetButton { get; private set; }

        public ApplicationProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            MainInformationPanel = new WebElement(Driver, By.Id("dvContents"));
            TabPanel = new WebElement(Driver, By.ClassName("tab-content"));
            ApplicationDetails = new WebElement(Driver, By.Id("dvApplicationDetails"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id*=\"pplicationId\"]"));
            SchoolYear = new Text(Driver, By.Id("spOrganizationYearId"));
            SubmissionDate = new Text(Driver, By.Id("spAppSubmissionDate"));
            New = new Radio(Driver, By.Id("rbApplicationType1"));
            Renewal = new Radio(Driver, By.Id("rbApplicationType2"));
            SaveApplicationTypeButton = new Button(Driver, By.Id("btnSaveAppType"));
            DirectCertificationHousehold = new Text(Driver, By.Id("spDirectCertHousehold"));
            AssistanceProgramYes = new Radio(Driver, By.XPath("//*[@id='tblAssistanceProgramHousehold']/tbody/tr/td/span[2]/label/input"));
            AssistanceProgramNo = new Radio(Driver, By.XPath("//*[@id='tblAssistanceProgramHousehold']/tbody/tr/td/span[3]/label/input"));
            AuthorizationToCheckAgencies = new Radio(Driver, By.Id("rbAuthorization"));
            HouseholdLanguage = new Text(Driver, By.Id("spHouseholdLanguage"));
            HomePhone = new Text(Driver, By.Id("spHomePhone"));
            WorkPhone = new Text(Driver, By.Id("spWorkPhone"));
            MobilePhone = new Text(Driver, By.Id("spMobilePhone"));
            Email = new Text(Driver, By.Id("spEmailAddress"));
            PhysicalAddress = new Text(Driver, By.Id("spPhysicalAddress"));
            PhysicalCity = new Text(Driver, By.Id("spPhysicalAddressCity"));
            PhysicalState = new Text(Driver, By.Id("spPhysicalAddressState"));
            PhysicalZip = new Text(Driver, By.Id("spPhysicalAddressZip"));
            EditPhysicalAddress = new Button(Driver, By.Id("btnEditPhysicalAddress"));
            EditMailingAddress = new Button(Driver, By.Id("btnMailingAddress"));
            EditAddressModal = new Modal(Driver, By.CssSelector("div[ng-form=\"addressForm\"]"));
            EditAddress1 = new EditField(Driver, By.CssSelector("input[ng-model=\"addressModel.AddressFirstLine\"]"));
            EditAddress2 = new EditField(Driver, By.CssSelector("input[ng-model=\"addressModel.AddressSecondLine\"]"));
            EditCity = new Dropdown(Driver, By.CssSelector("select[ng-model=\"addressModel.CityId\"]"));
            EditState = new Dropdown(Driver, By.CssSelector("select[ng-model=\"addressModel.StateId\"]"));
            EditZip = new EditField(Driver, By.CssSelector("input[ng-model=\"addressModel.ZipCode\"]"));
            EditCounty = new Dropdown(Driver, By.CssSelector("select[ng-model=\"addressModel.CountyId\"]"));
            CloseModal = new Button(Driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveModalChangesButton = new Button(Driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            CurrentWorkflowStatus = new Text(Driver, By.Id("spApplicationStatus"));
            WorkflowStatusList = new Dropdown(Driver, By.Id("sctAppWorkflowStatus"));
            SaveStatusOnlyButton = new Button(Driver, By.Id("btnSaveStatus"));
            ProcessorNotesTab = new Tab(Driver, By.CssSelector("a[href=\"#processorNotes\"]"));
            NoteType = new Dropdown(Driver, By.Id("sctNoteTypes"));
            NoteForHouseholdMember = new Dropdown(Driver, By.Id("sctHouseholdMembers"));
            SensitiveNote = new Checkbox(Driver, By.Id("chkIsSensitiveNote"));
            NoteBody = new EditField(Driver, By.Id("taNotes"));
            AddNoteButton = new Button(Driver, By.Id("btnAddNotes"));
            OnHoldTab = new Tab(Driver, By.CssSelector("a[href=\"#onHold\"]"));
            AddHoldReasonButton = new Button(Driver, By.Id("btnAddHoldReason"));
            AddHoldReasonModal = new Modal(Driver, By.CssSelector("div[ng-form=\"holdReasonForm\"]"));
            OnHoldReason = new Dropdown(Driver, By.CssSelector("select[ng-model=\"holdReasonModel.holdReasonId\"]"));
            OnHoldRelatedHouseholdMember = new Dropdown(Driver, By.CssSelector("select[ng-model=\"holdReasonModel.householdMemberId\"]"));
            OnHoldNotes = new EditField(Driver, By.Name("taOHNotes"));
            DenialTab = new Tab(Driver, By.CssSelector("a[href=\"#denial\"]"));
            AddDenialReasonButton = new Button(Driver, By.CssSelector("button[data-ng-click=\"vm.addDenialReason();\"]"));
            DenialReason = new Dropdown(Driver, By.CssSelector("select[ng-model=\"denialReasonModel.denialReasonId\"]"));
            DenialRelatedHouseholdMember = new Dropdown(Driver, By.CssSelector("select[ng-model=\"denialReasonModel.householdMemberId\"]"));
            DenialNotes = new EditField(Driver, By.Name("taDenialNotes"));
            StudentTab = new Tab(Driver, By.CssSelector("a[href=\"#student\"]"));
            //StudentDataPane = new RepeatedControlGroup(Driver, By.XPath("//*[@id='student']/div/div/div/div[1]/fieldset[1]/legend"));
            StudentDataPane = new RepeatedControlGroup(Driver, By.CssSelector("div[ng-form=\"studentForm\"]"));
            HouseholdCompTab = new Tab(Driver, By.CssSelector("a[href=\"#application\"]"));
            HouseholdCompInformation = new SASTabInformation(Driver, By.Id("application"));
            HouseholdCompositionTable = new Table(Driver, By.Id("tblHHComposition"));
            NumberOfGuardians = new WebElement(Driver, By.Id("rbGuardianCount"));
            NumberOfStudents = new WebElement(Driver, By.Id("rbStudentCount"));
            NumberOfChildren = new WebElement(Driver, By.Id("rbChildrenCount"));
            NumberOfAdults = new WebElement(Driver, By.Id("rbAdultcount"));
            TotalInHousehold = new Text(Driver, By.Id(""));
            PrimaryParentHasRoommate = new Text(Driver, By.Id("spHasRoommate1"));
            NumberOfRoommates = new Text(Driver, By.Id("spRoommateCount1"));
            HousingPaymentType = new Text(Driver, By.Id("spHouseholdPayemntType1"));
            MaritalStatus = new WebElement(Driver, By.Id("rbMaritalStatus"));
            IncomeTab = new Tab(Driver, By.CssSelector("a[href=\"#income\"]"));
            EmploymentStatusTable = new Table(Driver, By.Id("dvEmploymentStatus"));
            AnnualIncomeTable = new FTCSASIncomeTable(Driver, By.Id("tblHouseholdIncomeAnnual"));
            TotalHouseholdIncome = new Text(Driver, By.Id("spFormattedTotal"));
            AnnualIncomeCap = new Text(Driver, By.Id("spFtcIncomeCap"));
            FTCAnnualIncomeCap = new Text(Driver, By.Id("spFtcIncomeCap"));
            FESAnnualIncomeCap = new Text(Driver, By.Id("spFesIncomeCap"));
            ScholarshipLevel = new Text(Driver, By.Id("spScholarshipLevel2"));
            ScholarshipLevelZeroPercent = new Text(Driver, By.Id("spScholarshipLevel1"));
            HouseholdIncomeLevel = new Text(Driver, By.Id("spHouseholdIncomeLevel"));
            IncomeEligibilityStatus = new Dropdown(Driver, By.Id("sctFTCHouseholdEligibilityStatus"));
            FTCIncomeEligibilityStatus = new Dropdown(Driver, By.Id("sctFTCHouseholdEligibilityStatus"));
            FESIncomeEligibilityStatus = new Dropdown(Driver, By.Id("sctFESHouseholdEligibilityStatus"));
            RequiredDocumentsTab = new Tab(Driver, By.CssSelector("a[href=\"#householdDoc\"]"));
            ContactLogTab = new Tab(Driver, By.CssSelector("a[href=\"#contactLogs\"]"));
            ContactLogTable = new FTCSASContactLog(Driver, By.Id("tblContactLogs"));
            TransactionsTab = new Tab(Driver, By.CssSelector("a[href=\"#transactions\"]"));
            PaymentHistoryTable = new Table(Driver, By.Id("tblTransactions"));
            MoneyOrderNumber = new EditField(Driver, By.Id("txtMONumber"));
            MoneyOrderAmount = new EditField(Driver, By.Id("txtMOAmount"));
            MoneyOrderDate = new EditField(Driver, By.Id("txtMODate"));
            SavePaymentButton = new Button(Driver, By.CssSelector("button[data-ng-click=\"vm.savePayment();\"]"));
            HistoricalDocumentsTab = new Tab(Driver, By.CssSelector("a[href=\"#historicalDoc\"]"));
            AppealTab = new Tab(Driver, By.CssSelector("a[href=\"#appeal\"]"));
            SaveEntireWorksheetButton = new Button(Driver, By.Id("btnSaveWorksheet"));
            NotificationModal = new Modal(Driver, By.ClassName("modal-dialog"));
            NotificationMessage = new Text(Driver, By.CssSelector("div[ng-bind-html=\"confirmationMessage\"]"));
            NotificationOKButton = new Button(Driver, By.Id("divOK"));
            NotificationYesButton = new Button(Driver, By.Id("btnYes"));
            NotificationNoButton = new Button(Driver, By.Id("btnNo"));
            ValidationErrors = new Text(Driver, By.Id("validationDiv"));
            FullName = new Text(Driver, By.Id("spFullName"));
            PersonId = new Text(Driver, By.Id("spPersonId"));
            DirectCertification = new Text(Driver, By.Id("spReceivesFreeOrReducedLunch"));
            SSN = new EditField(Driver, By.Id("txtSocialSecurityNumber"));
            DOB = new EditField(Driver, By.Id("spDateOfBirth"));
            RelationshipToPrimaryGuardian = new Text(Driver, By.Id("spRelationshipToPP"));
            StudentTypeNew = new Radio(Driver, By.CssSelector("#rbStudentType input[value=\"1\"]"));
            StudentTypeRenewal = new Radio(Driver, By.CssSelector("#rbStudentType input[value=\"2\"]"));
            FosterChildYes = new Radio(Driver, By.CssSelector("#rbIsFosterChild input[value=\"true\"]"));
            FosterChildNo = new Radio(Driver, By.CssSelector("#rbIsFosterChild input[value=\"false\"]"));
            OutOfHomeCareYes = new Radio(Driver, By.CssSelector("#rbIsOutOfHome input[value=\"true\"]"));
            OutOfHomeCareNo = new Radio(Driver, By.CssSelector("#rbIsOutOfHome input[value=\"false\"]"));
            Gender = new Dropdown(Driver, By.Id("sctGender"));
            Kindergarten = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"1\"]"));
            FirstGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"2\"]"));
            SecondGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"3\"]"));
            ThirdGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"4\"]"));
            FourthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"5\"]"));
            FifthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"6\"]"));
            SixthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"7\"]"));
            SeventhGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"8\"]"));
            EighthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"9\"]"));
            NinthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"10\"]"));
            TenthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"11\"]"));
            EleventhGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"12\"]"));
            TwelfthGrade = new Radio(Driver, By.CssSelector("#rbGradeLevel input[value=\"13\"]"));
            ScholarshipStatus = new EditField(Driver, By.Id("sctStudentScholarshipStatus"));
            StudentEligibilityStatus = new Dropdown(Driver, By.Id("sctStudentEligibilityStatus"));
            CategoricallyEligibleStatus = new Dropdown(Driver, By.Id("sctStudentCetEligible"));
            SaveWorkflowStatusButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveApplicationWorkflowStatus\"]"));
            HoldReason = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlApplicationHoldReason\"]"));
            HoldHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationonholdreason\"][id$=\"ddlHouseholdMember\"]"));
            HoldNote = new EditField(Driver, By.CssSelector("textarea[id*=\"applicationonholdreason\"][id$=\"tbHoldNote\"]"));
            HoldReasonsTable = new PLSAHoldReasonsTable(Driver, By.CssSelector("div[id$=\"divReasonList\"]"));
            DenialHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationdenialreason\"][id$=\"ddlHouseholdMember\"]"));
            DenialNote = new EditField(Driver, By.CssSelector("textarea[id*=\"applicationdenialreason\"][id$=\"tbHoldNote\"]"));
            DenialReasonsTable = new Table(Driver, By.CssSelector("table[id^=\"tblDenialReasonList\"]"));
            NoteHouseholdMember = new Dropdown(Driver, By.CssSelector("select[id*=\"applicationprocessingnotes\"][id$=\"ddlHouseholdMember\"]"));
            IsSensitiveNote = new Checkbox(Driver, By.CssSelector("input[id$=\"chkIsSensitiveNote\"]"));
            Note = new EditField(Driver, By.CssSelector("textarea[id$=\"tbProcessingNote\"]"));
            NotesTable = new Table(Driver, By.Id("tblNoteList"));
            ScholarshipStatusModal = new FTCSASScholarshipStatusConfirmationModal(Driver, By.XPath("//*[@class='modal-content']"));
            RemoveMatrixReviewRequestButton = new Button(Driver, By.CssSelector("input[id$=\"btnRemoveMatrixRequest\"]"));
            RemoveMatrixReviewRequestMessage = new Text(Driver, By.CssSelector("span[id$=\"lblRemoveMatrixConfirmMessage\"]"));
            ConfirmRemoveMatrixReviewRequest = new Button(Driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestConfirmed\"]"));
            CancelRemoveMatrixReviewRequest = new Button(Driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestCancel\"]"));
            RequiredDocumentsSection = new Table(Driver, By.CssSelector("table[id$=\"rblEvidenceType\"]"));
            MaritalStatusSingle = new Checkbox(Driver, By.CssSelector("input[id$=\"rblMaritalStatus_0\"]"));
            StudentInformationTables = new FTCSASStudentInformationTables(Driver, By.CssSelector("div[id$=\"scrollable\"]"));
            WorksheetPopupYES = new SASPopupButton(Driver, By.XPath("//span[text() = 'Yes']"));
            WorksheetPopupNO = new SASPopupButton(Driver, By.XPath("//span[text() = 'No']"));
            ParentPaycheckAmount_Textbox = new EditField(Driver, By.CssSelector("#tblHouseholdIncomeAnnual > tbody > tr.ng-scope > td:nth-child(2) > input"));
            AppealReasonDropdown = new Dropdown(Driver, By.CssSelector("body > div.modal.fade.ng-isolate-scope.in > div > div > div > div > div.modal-body > form > div > table > tbody > tr:nth-child(1) > td > select"));
            AppealExplanationTextbox = new EditField(Driver, By.Name("taAppealJustification"));
            SaveAppealButton = new Button(Driver, By.CssSelector("body > div.modal.fade.ng-isolate-scope.in > div > div > div > div > div.modal-footer > button.btn.btn-primary"));
            StartAppealButton = new Button(Driver, By.Id("btnStartAppeal"));
            RemoveAppealButton = new Button(Driver, By.Id("btnRemoveAppeal"));
            OnceInAlwaysInText = new Text(Driver, By.Id("spOnceInAlwaysIn"));
            CloseWorksheetButton = new Button(Driver, By.CssSelector("#dvNotes > div.container.save-row > div > div:nth-child(2) > input"));
        }
    }
}
