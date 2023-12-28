using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class ApplicationProcessingWorksheetPage : BasePage
    {
        public BaseElement MainInformationPanel { get; private set; }

        public BaseElement TabPanel { get; private set; }

        public BaseElement ApplicationDetails { get; private set; }

        public Text ApplicationId { get; private set; }

        public Text SchoolYear { get; private set; }

        public Text SubmissionDate { get; private set; }

        public RadioButton New { get; private set; }

        public RadioButton Renewal { get; private set; }

        public Button SaveApplicationTypeButton { get; private set; }

        public Text DirectCertificationHousehold { get; private set; }

        public RadioButton AssistanceProgramYes { get; private set; }

        public RadioButton AssistanceProgramNo { get; private set; }

        public RadioButton AuthorizationToCheckAgencies { get; private set; }

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

        public Link ProcessorNotesTab { get; private set; }

        public Dropdown NoteType { get; private set; }

        public Dropdown NoteForHouseholdMember { get; private set; }

        public Checkbox SensitiveNote { get; private set; }

        public EditField NoteBody { get; private set; }

        public Button AddNoteButton { get; private set; }

        public Link OnHoldTab { get; private set; }

        public Button AddHoldReasonButton { get; private set; }

        public Modal AddHoldReasonModal { get; private set; }

        public Dropdown OnHoldReason { get; private set; }

        public Dropdown OnHoldRelatedHouseholdMember { get; private set; }

        public EditField OnHoldNotes { get; private set; }

        public Link DenialTab { get; private set; }

        public Button AddDenialReasonButton { get; private set; }

        public Dropdown DenialReason { get; private set; }

        public Dropdown DenialRelatedHouseholdMember { get; private set; }

        public EditField DenialNotes { get; private set; }

        public Link StudentTab { get; private set; }

        public Link HouseholdCompTab { get; private set; }

        public Table HouseholdCompositionTable { get; private set; }

        public BaseElement NumberOfGuardians { get; private set; }

        public BaseElement NumberOfStudents { get; private set; }

        public BaseElement NumberOfChildren { get; private set; }

        public BaseElement NumberOfAdults { get; private set; }

        public Text TotalInHousehold { get; private set; }

        public Text PrimaryParentHasRoommate { get; private set; }

        public Text NumberOfRoommates { get; private set; }

        public Text HousingPaymentType { get; private set; }

        public BaseElement MaritalStatus { get; private set; }

        public Link IncomeTab { get; private set; }

        public Table EmploymentStatusTable { get; private set; }

        public Text TotalHouseholdIncome { get; private set; }

        public Text AnnualIncomeCap { get; private set; }

        public Text FTCAnnualIncomeCap { get; private set; }

        public Text FESAnnualIncomeCap { get; private set; }

        public Text ScholarshipLevel { get; private set; }

        public Text ScholarshipLevelZeroPercent { get; private set; }
        
        public Dropdown IncomeEligibilityStatus { get; private set; }

        public Dropdown FTCIncomeEligibilityStatus { get; private set; }

        public Dropdown FESIncomeEligibilityStatus { get; private set; }

        public Link RequiredDocumentsTab { get; private set; }

        public Link ContactLogTab { get; private set; }

        public Link TransactionsTab { get; private set; }

        public Table PaymentHistoryTable { get; private set; }

        public EditField MoneyOrderNumber { get; private set; }

        public EditField MoneyOrderAmount { get; private set; }

        public EditField MoneyOrderDate { get; private set; }

        public Button SavePaymentButton { get; private set; }

        public Link HistoricalDocumentsTab { get; private set; }

        public Link AppealTab { get; private set; }

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

        public RadioButton StudentTypeNew { get; private set; }

        public RadioButton StudentTypeRenewal { get; private set; }

        public RadioButton FosterChildYes { get; private set; }

        public RadioButton FosterChildNo { get; private set; }

        public RadioButton OutOfHomeCareYes { get; private set; }

        public RadioButton OutOfHomeCareNo { get; private set; }

        public Dropdown Gender { get; private set; }

        public RadioButton Kindergarten { get; private set; }

        public RadioButton FirstGrade { get; private set; }

        public RadioButton SecondGrade { get; private set; }

        public RadioButton ThirdGrade { get; private set; }

        public RadioButton FourthGrade { get; private set; }

        public RadioButton FifthGrade { get; private set; }

        public RadioButton SixthGrade { get; private set; }

        public RadioButton SeventhGrade { get; private set; }

        public RadioButton EighthGrade { get; private set; }

        public RadioButton NinthGrade { get; private set; }

        public RadioButton TenthGrade { get; private set; }

        public RadioButton EleventhGrade { get; private set; }

        public RadioButton TwelfthGrade { get; private set; }

        public EditField ScholarshipStatus { get; private set; }

        public Dropdown StudentEligibilityStatus { get; private set; }

        public Dropdown CategoricallyEligibleStatus { get; private set; }

        public Text HouseholdIncomeLevel { get; private set; }

        public Button SaveWorkflowStatusButton { get; private set; }

        public Dropdown HoldReason { get; private set; }

        public Dropdown HoldHouseholdMember { get; private set; }

        public EditField HoldNote { get; private set; }

        public Dropdown DenialHouseholdMember { get; private set; }

        public EditField DenialNote { get; private set; }

        public Table DenialReasonsTable { get; private set; }

        public Dropdown NoteHouseholdMember { get; private set; }

        public Checkbox IsSensitiveNote { get; private set; }

        public EditField Note { get; private set; }

        public Table NotesTable { get; private set; }

        public Modal DeniedConfirmationModal { get; private set; }

        public Button RemoveMatrixReviewRequestButton { get; private set; }

        public Text RemoveMatrixReviewRequestMessage { get; private set; }

        public Button ConfirmRemoveMatrixReviewRequest { get; private set; }

        public Button CancelRemoveMatrixReviewRequest { get; private set; }

        public Table RequiredDocumentsSection { get; private set; }

        public Checkbox MaritalStatusSingle { get; private set; }

        public EditField ParentPaycheckAmount_Textbox { get; private set; }

        public Text OnceInAlwaysInText { get; private set; }

        public Button CloseWorksheetButton { get; private set; }

        public ApplicationProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            MainInformationPanel = new BaseElement(driver, By.Id("dvContents"));
            TabPanel = new BaseElement(driver, By.ClassName("tab-content"));
            ApplicationDetails = new BaseElement(driver, By.Id("dvApplicationDetails"));
            ApplicationId = new Text(driver, By.CssSelector("span[id*=\"pplicationId\"]"));
            SchoolYear = new Text(driver, By.Id("spOrganizationYearId"));
            SubmissionDate = new Text(driver, By.Id("spAppSubmissionDate"));
            New = new RadioButton(driver, By.Id("rbApplicationType1"));
            Renewal = new RadioButton(driver, By.Id("rbApplicationType2"));
            SaveApplicationTypeButton = new Button(driver, By.Id("btnSaveAppType"));
            DirectCertificationHousehold = new Text(driver, By.Id("spDirectCertHousehold"));
            AssistanceProgramYes = new RadioButton(driver, By.XPath("//*[@id='tblAssistanceProgramHousehold']/tbody/tr/td/span[2]/label/input"));
            AssistanceProgramNo = new RadioButton(driver, By.XPath("//*[@id='tblAssistanceProgramHousehold']/tbody/tr/td/span[3]/label/input"));
            AuthorizationToCheckAgencies = new RadioButton(driver, By.Id("rbAuthorization"));
            HouseholdLanguage = new Text(driver, By.Id("spHouseholdLanguage"));
            HomePhone = new Text(driver, By.Id("spHomePhone"));
            WorkPhone = new Text(driver, By.Id("spWorkPhone"));
            MobilePhone = new Text(driver, By.Id("spMobilePhone"));
            Email = new Text(driver, By.Id("spEmailAddress"));
            PhysicalAddress = new Text(driver, By.Id("spPhysicalAddress"));
            PhysicalCity = new Text(driver, By.Id("spPhysicalAddressCity"));
            PhysicalState = new Text(driver, By.Id("spPhysicalAddressState"));
            PhysicalZip = new Text(driver, By.Id("spPhysicalAddressZip"));
            EditPhysicalAddress = new Button(driver, By.Id("btnEditPhysicalAddress"));
            EditMailingAddress = new Button(driver, By.Id("btnMailingAddress"));
            EditAddressModal = new Modal(driver, By.CssSelector("div[ng-form=\"addressForm\"]"));
            EditAddress1 = new EditField(driver, By.CssSelector("input[ng-model=\"addressModel.AddressFirstLine\"]"));
            EditAddress2 = new EditField(driver, By.CssSelector("input[ng-model=\"addressModel.AddressSecondLine\"]"));
            EditCity = new Dropdown(driver, By.CssSelector("select[ng-model=\"addressModel.CityId\"]"));
            EditState = new Dropdown(driver, By.CssSelector("select[ng-model=\"addressModel.StateId\"]"));
            EditZip = new EditField(driver, By.CssSelector("input[ng-model=\"addressModel.ZipCode\"]"));
            EditCounty = new Dropdown(driver, By.CssSelector("select[ng-model=\"addressModel.CountyId\"]"));
            CloseModal = new Button(driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveModalChangesButton = new Button(driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            CurrentWorkflowStatus = new Text(driver, By.Id("spApplicationStatus"));
            WorkflowStatusList = new Dropdown(driver, By.Id("sctAppWorkflowStatus"));
            SaveStatusOnlyButton = new Button(driver, By.Id("btnSaveStatus"));
            ProcessorNotesTab = new Link(driver, By.CssSelector("a[href=\"#processorNotes\"]"));
            NoteType = new Dropdown(driver, By.Id("sctNoteTypes"));
            NoteForHouseholdMember = new Dropdown(driver, By.Id("sctHouseholdMembers"));
            SensitiveNote = new Checkbox(driver, By.Id("chkIsSensitiveNote"));
            NoteBody = new EditField(driver, By.Id("taNotes"));
            AddNoteButton = new Button(driver, By.Id("btnAddNotes"));
            OnHoldTab = new Link(driver, By.CssSelector("a[href=\"#onHold\"]"));
            AddHoldReasonButton = new Button(driver, By.Id("btnAddHoldReason"));
            AddHoldReasonModal = new Modal(driver, By.CssSelector("div[ng-form=\"holdReasonForm\"]"));
            OnHoldReason = new Dropdown(driver, By.CssSelector("select[ng-model=\"holdReasonModel.holdReasonId\"]"));
            OnHoldRelatedHouseholdMember = new Dropdown(driver, By.CssSelector("select[ng-model=\"holdReasonModel.householdMemberId\"]"));
            OnHoldNotes = new EditField(driver, By.Name("taOHNotes"));
            DenialTab = new Link(driver, By.CssSelector("a[href=\"#denial\"]"));
            AddDenialReasonButton = new Button(driver, By.CssSelector("button[data-ng-click=\"vm.addDenialReason();\"]"));
            DenialReason = new Dropdown(driver, By.CssSelector("select[ng-model=\"denialReasonModel.denialReasonId\"]"));
            DenialRelatedHouseholdMember = new Dropdown(driver, By.CssSelector("select[ng-model=\"denialReasonModel.householdMemberId\"]"));
            DenialNotes = new EditField(driver, By.Name("taDenialNotes"));
            StudentTab = new Link(driver, By.CssSelector("a[href=\"#student\"]"));
            HouseholdCompTab = new Link(driver, By.CssSelector("a[href=\"#application\"]"));
            HouseholdCompositionTable = new Table(driver, By.Id("tblHHComposition"));
            NumberOfGuardians = new BaseElement(driver, By.Id("rbGuardianCount"));
            NumberOfStudents = new BaseElement(driver, By.Id("rbStudentCount"));
            NumberOfChildren = new BaseElement(driver, By.Id("rbChildrenCount"));
            NumberOfAdults = new BaseElement(driver, By.Id("rbAdultcount"));
            TotalInHousehold = new Text(driver, By.Id(""));
            PrimaryParentHasRoommate = new Text(driver, By.Id("spHasRoommate1"));
            NumberOfRoommates = new Text(driver, By.Id("spRoommateCount1"));
            HousingPaymentType = new Text(driver, By.Id("spHouseholdPayemntType1"));
            MaritalStatus = new BaseElement(driver, By.Id("rbMaritalStatus"));
            IncomeTab = new Link(driver, By.CssSelector("a[href=\"#income\"]"));
            EmploymentStatusTable = new Table(driver, By.Id("dvEmploymentStatus"));
            TotalHouseholdIncome = new Text(driver, By.Id("spFormattedTotal"));
            AnnualIncomeCap = new Text(driver, By.Id("spFtcIncomeCap"));
            FTCAnnualIncomeCap = new Text(driver, By.Id("spFtcIncomeCap"));
            FESAnnualIncomeCap = new Text(driver, By.Id("spFesIncomeCap"));
            ScholarshipLevel = new Text(driver, By.Id("spScholarshipLevel2"));
            ScholarshipLevelZeroPercent = new Text(driver, By.Id("spScholarshipLevel1"));
            HouseholdIncomeLevel = new Text(driver, By.Id("spHouseholdIncomeLevel"));
            IncomeEligibilityStatus = new Dropdown(driver, By.Id("sctFTCHouseholdEligibilityStatus"));
            FTCIncomeEligibilityStatus = new Dropdown(driver, By.Id("sctFTCHouseholdEligibilityStatus"));
            FESIncomeEligibilityStatus = new Dropdown(driver, By.Id("sctFESHouseholdEligibilityStatus"));
            RequiredDocumentsTab = new Link(driver, By.CssSelector("a[href=\"#householdDoc\"]"));
            ContactLogTab = new Link(driver, By.CssSelector("a[href=\"#contactLogs\"]"));
            TransactionsTab = new Link(driver, By.CssSelector("a[href=\"#transactions\"]"));
            PaymentHistoryTable = new Table(driver, By.Id("tblTransactions"));
            MoneyOrderNumber = new EditField(driver, By.Id("txtMONumber"));
            MoneyOrderAmount = new EditField(driver, By.Id("txtMOAmount"));
            MoneyOrderDate = new EditField(driver, By.Id("txtMODate"));
            SavePaymentButton = new Button(driver, By.CssSelector("button[data-ng-click=\"vm.savePayment();\"]"));
            HistoricalDocumentsTab = new Link(driver, By.CssSelector("a[href=\"#historicalDoc\"]"));
            AppealTab = new Link(driver, By.CssSelector("a[href=\"#appeal\"]"));
            SaveEntireWorksheetButton = new Button(driver, By.Id("btnSaveWorksheet"));
            NotificationModal = new Modal(driver, By.ClassName("modal-dialog"));
            NotificationMessage = new Text(driver, By.CssSelector("div[ng-bind-html=\"confirmationMessage\"]"));
            NotificationOKButton = new Button(driver, By.Id("divOK"));
            NotificationYesButton = new Button(driver, By.Id("btnYes"));
            NotificationNoButton = new Button(driver, By.Id("btnNo"));
            ValidationErrors = new Text(driver, By.Id("validationDiv"));
            FullName = new Text(driver, By.Id("spFullName"));
            PersonId = new Text(driver, By.Id("spPersonId"));
            DirectCertification = new Text(driver, By.Id("spReceivesFreeOrReducedLunch"));
            SSN = new EditField(driver, By.Id("txtSocialSecurityNumber"));
            DOB = new EditField(driver, By.Id("spDateOfBirth"));
            RelationshipToPrimaryGuardian = new Text(driver, By.Id("spRelationshipToPP"));
            StudentTypeNew = new RadioButton(driver, By.CssSelector("#rbStudentType input[value=\"1\"]"));
            StudentTypeRenewal = new RadioButton(driver, By.CssSelector("#rbStudentType input[value=\"2\"]"));
            FosterChildYes = new RadioButton(driver, By.CssSelector("#rbIsFosterChild input[value=\"true\"]"));
            FosterChildNo = new RadioButton(driver, By.CssSelector("#rbIsFosterChild input[value=\"false\"]"));
            OutOfHomeCareYes = new RadioButton(driver, By.CssSelector("#rbIsOutOfHome input[value=\"true\"]"));
            OutOfHomeCareNo = new RadioButton(driver, By.CssSelector("#rbIsOutOfHome input[value=\"false\"]"));
            Gender = new Dropdown(driver, By.Id("sctGender"));
            Kindergarten = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"1\"]"));
            FirstGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"2\"]"));
            SecondGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"3\"]"));
            ThirdGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"4\"]"));
            FourthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"5\"]"));
            FifthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"6\"]"));
            SixthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"7\"]"));
            SeventhGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"8\"]"));
            EighthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"9\"]"));
            NinthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"10\"]"));
            TenthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"11\"]"));
            EleventhGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"12\"]"));
            TwelfthGrade = new RadioButton(driver, By.CssSelector("#rbGradeLevel input[value=\"13\"]"));
            ScholarshipStatus = new EditField(driver, By.Id("sctStudentScholarshipStatus"));
            StudentEligibilityStatus = new Dropdown(driver, By.Id("sctStudentEligibilityStatus"));
            CategoricallyEligibleStatus = new Dropdown(driver, By.Id("sctStudentCetEligible"));
            SaveWorkflowStatusButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveApplicationWorkflowStatus\"]"));
            HoldReason = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationHoldReason\"]"));
            HoldHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationonholdreason\"][id$=\"ddlHouseholdMember\"]"));
            HoldNote = new EditField(driver, By.CssSelector("textarea[id*=\"applicationonholdreason\"][id$=\"tbHoldNote\"]"));
            DenialHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationdenialreason\"][id$=\"ddlHouseholdMember\"]"));
            DenialNote = new EditField(driver, By.CssSelector("textarea[id*=\"applicationdenialreason\"][id$=\"tbHoldNote\"]"));
            DenialReasonsTable = new Table(driver, By.CssSelector("table[id^=\"tblDenialReasonList\"]"));
            NoteHouseholdMember = new Dropdown(driver, By.CssSelector("select[id*=\"applicationprocessingnotes\"][id$=\"ddlHouseholdMember\"]"));
            IsSensitiveNote = new Checkbox(driver, By.CssSelector("input[id$=\"chkIsSensitiveNote\"]"));
            Note = new EditField(driver, By.CssSelector("textarea[id$=\"tbProcessingNote\"]"));
            NotesTable = new Table(driver, By.Id("tblNoteList"));
            RemoveMatrixReviewRequestButton = new Button(driver, By.CssSelector("input[id$=\"btnRemoveMatrixRequest\"]"));
            RemoveMatrixReviewRequestMessage = new Text(driver, By.CssSelector("span[id$=\"lblRemoveMatrixConfirmMessage\"]"));
            ConfirmRemoveMatrixReviewRequest = new Button(driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestConfirmed\"]"));
            CancelRemoveMatrixReviewRequest = new Button(driver, By.CssSelector("a[id$=\"btnRemoveMatrixRequestCancel\"]"));
            RequiredDocumentsSection = new Table(driver, By.CssSelector("table[id$=\"rblEvidenceType\"]"));
            MaritalStatusSingle = new Checkbox(driver, By.CssSelector("input[id$=\"rblMaritalStatus_0\"]"));
            ParentPaycheckAmount_Textbox = new EditField(driver, By.CssSelector("#tblHouseholdIncomeAnnual > tbody > tr.ng-scope > td:nth-child(2) > input"));
            AppealReasonDropdown = new Dropdown(driver, By.CssSelector("body > div.modal.fade.ng-isolate-scope.in > div > div > div > div > div.modal-body > form > div > table > tbody > tr:nth-child(1) > td > select"));
            AppealExplanationTextbox = new EditField(driver, By.Name("taAppealJustification"));
            SaveAppealButton = new Button(driver, By.CssSelector("body > div.modal.fade.ng-isolate-scope.in > div > div > div > div > div.modal-footer > button.btn.btn-primary"));
            StartAppealButton = new Button(driver, By.Id("btnStartAppeal"));
            RemoveAppealButton = new Button(driver, By.Id("btnRemoveAppeal"));
            OnceInAlwaysInText = new Text(driver, By.Id("spOnceInAlwaysIn"));
            CloseWorksheetButton = new Button(driver, By.CssSelector("#dvNotes > div.container.save-row > div > div:nth-child(2) > input"));
        }
    }
}
