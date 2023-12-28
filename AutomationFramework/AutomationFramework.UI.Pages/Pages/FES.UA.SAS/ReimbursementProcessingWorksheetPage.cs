using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ReimbursementProcessingWorksheetPage : BasePage
    {
        public Text RequestDetails { get; private set; }

        public Text ReimbursementId { get; private set; }

        public Text CancellationStatus { get; private set; }

        public Text CancellationDate { get; private set; }

        public Button CancelReimbursementButton { get; private set; }

        public Text SubmissionDate { get; private set; }

        public Text Type { get; private set; }

        public Text Year { get; private set; }

        public Dropdown PayTo { get; private set; }

        public Text EnteredBy { get; private set; }

        public Text StudentName { get; private set; }

        public Text StudentDOB { get; private set; }

        public Text StudentPersonId { get; private set; }

        public Text StudentSSN { get; private set; }

        public Text StudentGrade { get; private set; }

        public Text StudentIsFunded { get; private set; }

        public EditField Tuition { get; private set; }

        public Button SaveStatusOnlyButton { get; private set; }

        public Text HouseholdLanguage { get; private set; }

        public Text HomePhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text MobilePhone { get; private set; }

        public Text EmailAddress { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text City { get; private set; }

        public Text State { get; private set; }

        public Text Zip { get; private set; }

        public Text AvailableFunds { get; private set; }

        public Text CurrentWorkflowStatus { get; private set; }

        public Dropdown WorkflowStatusList { get; private set; }

        public Tab ProcessorNotesTab { get; private set; }

        public Dropdown NoteType { get; private set; }

        public Dropdown NoteReimbursementItemId { get; private set; }

        public Checkbox SensitiveNote { get; private set; }

        public EditField NoteText { get; private set; }

        public Button AddNoteButton { get; private set; }

        public Tab OnHoldTab { get; private set; }

        public Button AddHoldReasonButton { get; private set; }

        public Modal AddHoldReasonModal { get; private set; }

        public Dropdown OnHoldReason { get; private set; }

        public Dropdown OnHoldReimbursementItem { get; private set; }

        public EditField OnHoldNote { get; private set; }

        public Button CloseOnHoldModalButton { get; private set; }

        public Button SaveOnHoldReasonButton { get; private set; }

        public Modal AddDenialReasonModal { get; private set; }

        public Dropdown DenialReason { get; private set; }

        public EditField DenialNote { get; private set; }

        public Button CloseDenialModalButton { get; private set; }

        public Button SaveDenialReasonButton { get; private set; }

        public Tab ProviderTab { get; private set; }

        public Tab ReimbursementDetailsTab { get; private set; }

        public Tab InvoiceTab { get; private set; }

        public Tab ContactLogTab { get; private set; }
        
        public Dropdown ProviderList { get; private set; }
        
        public Text UnlistedProvider_HasBankInformation { get; private set; }

        public EditField UnlistedProvider_Name { get; private set; }

        public EditField UnlistedProvider_License { get; private set; }

        public Checkbox UnlistedProvider_IsRetail { get; private set; }

        public Dropdown UnlistedProvider_EligibilityStatus { get; private set; }

        public Button AddProviderButton { get; private set; }

        public Modal AddProviderModal { get; private set; }

        public EditField AddProvider_Name { get; private set; }

        public Dropdown AddProvider_Type { get; private set; }

        public EditField AddProvider_LicenseNumber { get; private set; }

        public EditField AddProvider_TaxId { get; private set; }

        public EditField AddProvider_Address { get; private set; }

        public Dropdown AddProvider_State { get; private set; }

        public Dropdown AddProvider_City { get; private set; }

        public EditField AddProvider_Zip { get; private set; }

        public Dropdown AddProvider_County { get; private set; }

        public Button CloseAddProviderModalButton { get; private set; }

        public Button SaveAddedProviderButton { get; private set; }

        public Text ProviderHasBankInformation { get; private set; }

        public Text ProviderEligibilityStatus { get; private set; }

        public Text ProviderContactName { get; private set; }

        public Text ProviderContactEmail { get; private set; }

        public Text ProviderContactPhone { get; private set; }

        public Text ProviderContactAddress { get; private set; }

        public Text ProviderContactCity { get; private set; }

        public Text ProviderContactState { get; private set; }

        public Text ProviderContactZip { get; private set; }

        public Text ProviderLicenseType { get; private set; }

        public Text ProviderLicenseNumber { get; private set; }

        public Text ProviderLicenseExpirationDate { get; private set; }

        public Button AddNewReimbursementDetailButton { get; private set; }

        public Text TotalApprovedAmount { get; private set; }

        public Modal AddReimbursementItemModal { get; private set; }

        public Button SaveNewReimbursementItem { get; private set; }

        public Button CloseNewReimbursementItemModal { get; private set; }

        public EditField DateOfService { get; private set; }

        public EditField InvoiceDate { get; private set; }

        public EditField InvoiceNumber { get; private set; }

        public Text TotalInvoiceAmount { get; private set; }

        public Checkbox InvoiceReceipt { get; private set; }

        public Button SaveEntireWorksheetButton { get; private set; }

        public Modal SaveConfirmationModal { get; private set; }

        public Button AcceptSaveConfirationModalButton { get; private set; }

        public Table ReimbursementItemStatus { get; private set; }

        public Table ReimbursementItemID { get; private set; }

        public Button ReimbursementRequestWorkflowStatusOK { get; private set; }

        public Button ReimbursementRequestWorkflowStatusYES { get; private set; }

        public Button ReimbursementRequestWorkflowStatusNO { get; private set; }

        public Button AddDenialReasonButton { get; private set; }

        public ReimbursementProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            RequestDetails = new Text(driver, By.Id("dvClaimDetails"));
            ReimbursementId = new Text(driver, By.Id("spClaimId"));
            CancelReimbursementButton = new Button(driver, By.Id("btnCancelClaim"));
            CancellationStatus = new Text(driver, By.Id("spCancelled"));
            CancellationDate = new Text(driver, By.Id("spCancelledDate"));
            SubmissionDate = new Text(driver, By.Id("spClaimDate"));
            Type = new Text(driver, By.Id("spClaimType"));
            Year = new Text(driver, By.Id("spClaimYear"));
            PayTo = new Dropdown(driver, By.Id("sctClaimPayTo"));
            EnteredBy = new Text(driver, By.Id("spPayTo"));
            StudentName = new Text(driver, By.Id("spName"));
            StudentDOB = new Text(driver, By.Id("spDOB"));
            StudentPersonId = new Text(driver, By.Id("spPersonID"));
            StudentSSN = new Text(driver, By.Id("spSSN"));
            StudentGrade = new Text(driver, By.Id("spGrade"));
            StudentIsFunded = new Text(driver, By.Id("spFunded"));
            Tuition = new EditField(driver, By.Id("txtAnuualTuition"));
            SaveStatusOnlyButton = new Button(driver, By.Id("btnSaveStatus"));
            HouseholdLanguage = new Text(driver, By.Id("spHouseholdLanguage"));
            HomePhone = new Text(driver, By.Id("spHomePhone"));
            WorkPhone = new Text(driver, By.Id("spWorkPhone"));
            MobilePhone = new Text(driver, By.Id("spMobilePhone"));
            EmailAddress = new Text(driver, By.Id("spEmailAddress"));
            PhysicalAddress = new Text(driver, By.Id("spPhysicalAddress"));
            City = new Text(driver, By.Id("spPhysicalAddressCity"));
            State = new Text(driver, By.Id("spPhysicalAddressState"));
            Zip = new Text(driver, By.Id("spPhysicalAddressZip"));
            AvailableFunds = new Text(driver, By.Id("dvFunds"));
            CurrentWorkflowStatus = new Text(driver, By.Id("spClaimStatus"));
            WorkflowStatusList = new Dropdown(driver, By.Id("sctClaimWorkflowStatus"));
            ProcessorNotesTab = new Tab(driver, By.CssSelector("a[href=\"#processorNotes\"]"));
            NoteType = new Dropdown(driver, By.Id("sctNoteTypes"));
            NoteReimbursementItemId = new Dropdown(driver, By.Id("sctClaimType"));
            SensitiveNote = new Checkbox(driver, By.Id("chkIsSensitiveNote"));
            NoteText = new EditField(driver, By.Id("taNotes"));
            AddNoteButton = new Button(driver, By.Id("btnAddNotes"));
            OnHoldTab = new Tab(driver, By.CssSelector("a[href=\"#onHold\"]"));
            AddHoldReasonButton = new Button(driver, By.Id("btnAddHoldReason"));
            AddHoldReasonModal = new Modal(driver, By.CssSelector("div[ng-form=\"holdReasonForm\"]"));
            OnHoldReason = new Dropdown(driver, By.CssSelector("select[ng-model=\"holdReasonModel.holdReasonId\"]"));
            OnHoldReimbursementItem = new Dropdown(driver, By.CssSelector("select[ng-model=\"holdReasonModel.claimItemId\"]"));
            OnHoldNote = new EditField(driver, By.CssSelector("textarea[name=\"taOHNotes\"]"));
            CloseOnHoldModalButton = new Button(driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveOnHoldReasonButton = new Button(driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            AddDenialReasonModal = new Modal(driver, By.CssSelector("div[ng-form=\"denialReasonForm\"]"));
            DenialReason = new Dropdown(driver, By.CssSelector("select[ng-model=\"denialReasonModel.denialReasonId\"]"));
            DenialNote = new EditField(driver, By.CssSelector("textarea[ng-model=\"denialReasonModel.notes\"]"));
            CloseDenialModalButton = new Button(driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveDenialReasonButton = new Button(driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            ProviderTab = new Tab(driver, By.CssSelector("a[href=\"#provider\"]"));
            ReimbursementDetailsTab = new Tab(driver, By.CssSelector("a[href=\"#claimDetails\"]"));
            InvoiceTab = new Tab(driver, By.CssSelector("a[href=\"#invoice\"]"));
            ContactLogTab = new Tab(driver, By.CssSelector("a[href=\"#contactLogs\"]"));
            ProviderList = new Dropdown(driver, By.Id("sctProviders"));
            UnlistedProvider_HasBankInformation = new Text(driver, By.Id("tdProverHasBankInfo"));
            UnlistedProvider_Name = new EditField(driver, By.CssSelector("input[ng-model=\"$root.ProviderDetails.UnlistedProviderName\"]"));
            UnlistedProvider_License = new EditField(driver, By.CssSelector("input[ng-model=\"$root.ProviderDetails.UnlistedProviderLicense\"]"));
            UnlistedProvider_IsRetail = new Checkbox(driver, By.Id("chkIsRetailer"));
            UnlistedProvider_EligibilityStatus = new Dropdown(driver, By.Id(""));
            AddProviderButton = new Button(driver, By.Id("btnAddProvider"));
            AddProviderModal = new Modal(driver, By.CssSelector("div[ng-form=\"providerForm\"]"));
            AddProvider_Name = new EditField(driver, By.CssSelector("input[data-ng-model=\"providerModel.providerName\"]"));
            AddProvider_LicenseNumber = new EditField(driver, By.CssSelector("input[data-ng-model=\"providerModel.providerLicense\"]"));
            AddProvider_Type = new Dropdown(driver, By.Id("sctProviderType"));
            AddProvider_TaxId = new EditField(driver, By.Id("txtTaxId"));
            AddProvider_Address = new EditField(driver, By.Id("txtAddress"));
            AddProvider_State = new Dropdown(driver, By.CssSelector("select[ng-model=\"providerModel.stateId\"]"));
            AddProvider_City = new Dropdown(driver, By.CssSelector("select[ng-model=\"providerModel.cityId\"]"));
            AddProvider_Zip = new EditField(driver, By.CssSelector("txtZipCode"));
            AddProvider_County = new Dropdown(driver, By.CssSelector("select[ng-model=\"providerModel.countyId\"]"));
            CloseAddProviderModalButton = new Button(driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveAddedProviderButton = new Button(driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            ProviderHasBankInformation = new Text(driver, By.Id("tdProverHasBankInfo"));
            ProviderEligibilityStatus = new Text(driver, By.Id("tdProviderEligibilityStatus"));
            ProviderContactName = new Text(driver, By.Id("tdProviderPrimaryContact"));
            ProviderContactEmail = new Text(driver, By.Id("tdProviderEmailAddress"));
            ProviderContactPhone = new Text(driver, By.Id("tdProviderPhoneNumber"));
            ProviderContactAddress = new Text(driver, By.Id("spanProviderAddressFirstLine"));
            ProviderContactCity = new Text(driver, By.Id("spanProviderCity"));
            ProviderContactState = new Text(driver, By.Id("spanProviderState"));
            ProviderContactZip = new Text(driver, By.Id("spanProviderZipCode"));
            ProviderLicenseType = new Text(driver, By.Id("tdProviderLicenseType"));
            ProviderLicenseNumber = new Text(driver, By.Id("tdProviderLicenseNumber"));
            ProviderLicenseExpirationDate = new Text(driver, By.Id("tdProviderExpirationDate"));
            TotalApprovedAmount = new Text(driver, By.Id("spClaimAmount"));
            AddNewReimbursementDetailButton = new Button(driver, By.Id("btnAddClaimItem"));
            AddReimbursementItemModal = new Modal(driver, By.CssSelector("div[ng-form=\"claimItemForm\"]"));
            SaveNewReimbursementItem = new Button(driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            CloseNewReimbursementItemModal = new Button(driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            DateOfService = new EditField(driver, By.Id("spServiceDate"));
            InvoiceDate = new EditField(driver, By.Id("spInvoiceDate"));
            InvoiceNumber = new EditField(driver, By.Id("txtInvoiceNumber"));
            TotalInvoiceAmount = new Text(driver, By.Id("spanTotalInvoiceAmount"));
            InvoiceReceipt = new Checkbox(driver, By.Id("chkDocument1"));
            SaveEntireWorksheetButton = new Button(driver, By.Id("btnSaveWorksheet"));
            SaveConfirmationModal = new Modal(driver, By.CssSelector(".modal-content"));
            AcceptSaveConfirationModalButton = new Button(driver, By.CssSelector("button[ng-click=\"yesClick()\"]"));
            ReimbursementRequestWorkflowStatusOK = new Button(driver, By.Id("btnOK"));
            ReimbursementRequestWorkflowStatusYES = new Button(driver, By.Id("btnYes"));
            ReimbursementRequestWorkflowStatusNO = new Button(driver, By.Id("btnNo"));
            ReimbursementItemStatus = new Table(driver, By.CssSelector("div[ng-form=\"claimForm\"]"));
            ReimbursementItemID = new Table(driver, By.CssSelector("div[ng-form=\"claimForm\"]"));
            AddDenialReasonButton = new Button(driver, By.CssSelector("button[data-ng-click=\"vm.addDenialReason(s.ClaimItemId);\"]"));
        }
    }
}
