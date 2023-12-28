using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    [KeywordTestingUsesChildWindow]
    [KeywordTestingOpensPDFViewer]
    public class ReimbursementProcessingWorksheetPage : BasePage
    {
        public WebElement RequestDetails { get; private set; }

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

        public WebElement AvailableFunds { get; private set; }

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

        public WebElement ReimbursementDetailItems { get; private set; }

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

        public ReimbursementDetailsTable ReimbursementItemStatus { get; private set; }

        public ReimbursementDetailsTable ReimbursementItemID { get; private set; }

        public Button ReimbursementRequestWorkflowStatusOK { get; private set; }

        public ButtonWithAlert ReimbursementRequestWorkflowStatusYES { get; private set; }

        public Button ReimbursementRequestWorkflowStatusNO { get; private set; }

        public Button AddDenialReasonButton { get; private set; }

        public ReimbursementProcessingWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            RequestDetails = new WebElement(Driver, By.Id("dvClaimDetails"));
            ReimbursementId = new Text(Driver, By.Id("spClaimId"));
            CancelReimbursementButton = new Button(Driver, By.Id("btnCancelClaim"));
            CancellationStatus = new Text(Driver, By.Id("spCancelled"));
            CancellationDate = new Text(Driver, By.Id("spCancelledDate"));
            SubmissionDate = new Text(Driver, By.Id("spClaimDate"));
            Type = new Text(Driver, By.Id("spClaimType"));
            Year = new Text(Driver, By.Id("spClaimYear"));
            PayTo = new Dropdown(Driver, By.Id("sctClaimPayTo"));
            EnteredBy = new Text(Driver, By.Id("spPayTo"));
            StudentName = new Text(Driver, By.Id("spName"));
            StudentDOB = new Text(Driver, By.Id("spDOB"));
            StudentPersonId = new Text(Driver, By.Id("spPersonID"));
            StudentSSN = new Text(Driver, By.Id("spSSN"));
            StudentGrade = new Text(Driver, By.Id("spGrade"));
            StudentIsFunded = new Text(Driver, By.Id("spFunded"));
            Tuition = new EditField(Driver, By.Id("txtAnuualTuition"));
            SaveStatusOnlyButton = new Button(Driver, By.Id("btnSaveStatus"));
            HouseholdLanguage = new Text(Driver, By.Id("spHouseholdLanguage"));
            HomePhone = new Text(Driver, By.Id("spHomePhone"));
            WorkPhone = new Text(Driver, By.Id("spWorkPhone"));
            MobilePhone = new Text(Driver, By.Id("spMobilePhone"));
            EmailAddress = new Text(Driver, By.Id("spEmailAddress"));
            PhysicalAddress = new Text(Driver, By.Id("spPhysicalAddress"));
            City = new Text(Driver, By.Id("spPhysicalAddressCity"));
            State = new Text(Driver, By.Id("spPhysicalAddressState"));
            Zip = new Text(Driver, By.Id("spPhysicalAddressZip"));
            AvailableFunds = new WebElement(Driver, By.Id("dvFunds"));
            CurrentWorkflowStatus = new Text(Driver, By.Id("spClaimStatus"));
            WorkflowStatusList = new Dropdown(Driver, By.Id("sctClaimWorkflowStatus"));
            ProcessorNotesTab = new Tab(Driver, By.CssSelector("a[href=\"#processorNotes\"]"));
            NoteType = new Dropdown(Driver, By.Id("sctNoteTypes"));
            NoteReimbursementItemId = new Dropdown(Driver, By.Id("sctClaimType"));
            SensitiveNote = new Checkbox(Driver, By.Id("chkIsSensitiveNote"));
            NoteText = new EditField(Driver, By.Id("taNotes"));
            AddNoteButton = new Button(Driver, By.Id("btnAddNotes"));
            OnHoldTab = new Tab(Driver, By.CssSelector("a[href=\"#onHold\"]"));
            AddHoldReasonButton = new Button(Driver, By.Id("btnAddHoldReason"));
            AddHoldReasonModal = new Modal(Driver, By.CssSelector("div[ng-form=\"holdReasonForm\"]"));
            OnHoldReason = new Dropdown(Driver, By.CssSelector("select[ng-model=\"holdReasonModel.holdReasonId\"]"));
            OnHoldReimbursementItem = new Dropdown(Driver, By.CssSelector("select[ng-model=\"holdReasonModel.claimItemId\"]"));
            OnHoldNote = new EditField(Driver, By.CssSelector("textarea[name=\"taOHNotes\"]"));
            CloseOnHoldModalButton = new Button(Driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveOnHoldReasonButton = new Button(Driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            AddDenialReasonModal = new Modal(Driver, By.CssSelector("div[ng-form=\"denialReasonForm\"]"));
            DenialReason = new Dropdown(Driver, By.CssSelector("select[ng-model=\"denialReasonModel.denialReasonId\"]"));
            DenialNote = new EditField(Driver, By.CssSelector("textarea[ng-model=\"denialReasonModel.notes\"]"));
            CloseDenialModalButton = new Button(Driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveDenialReasonButton = new Button(Driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            ProviderTab = new Tab(Driver, By.CssSelector("a[href=\"#provider\"]"));
            ReimbursementDetailsTab = new Tab(Driver, By.CssSelector("a[href=\"#claimDetails\"]"));
            InvoiceTab = new Tab(Driver, By.CssSelector("a[href=\"#invoice\"]"));
            ContactLogTab = new Tab(Driver, By.CssSelector("a[href=\"#contactLogs\"]"));
            ProviderList = new Dropdown(Driver, By.Id("sctProviders"));
            UnlistedProvider_HasBankInformation = new Text(Driver, By.Id("tdProverHasBankInfo"));
            UnlistedProvider_Name = new EditField(Driver, By.CssSelector("input[ng-model=\"$root.ProviderDetails.UnlistedProviderName\"]"));
            UnlistedProvider_License = new EditField(Driver, By.CssSelector("input[ng-model=\"$root.ProviderDetails.UnlistedProviderLicense\"]"));
            UnlistedProvider_IsRetail = new Checkbox(Driver, By.Id("chkIsRetailer"));
            UnlistedProvider_EligibilityStatus = new Dropdown(Driver, By.Id(""));
            AddProviderButton = new Button(Driver, By.Id("btnAddProvider"));
            AddProviderModal = new Modal(Driver, By.CssSelector("div[ng-form=\"providerForm\"]"));
            AddProvider_Name = new EditField(Driver, By.CssSelector("input[data-ng-model=\"providerModel.providerName\"]"));
            AddProvider_LicenseNumber = new EditField(Driver, By.CssSelector("input[data-ng-model=\"providerModel.providerLicense\"]"));
            AddProvider_Type = new Dropdown(Driver, By.Id("sctProviderType"));
            AddProvider_TaxId = new EditField(Driver, By.Id("txtTaxId"));
            AddProvider_Address = new EditField(Driver, By.Id("txtAddress"));
            AddProvider_State = new Dropdown(Driver, By.CssSelector("select[ng-model=\"providerModel.stateId\"]"));
            AddProvider_City = new Dropdown(Driver, By.CssSelector("select[ng-model=\"providerModel.cityId\"]"));
            AddProvider_Zip = new EditField(Driver, By.CssSelector("txtZipCode"));
            AddProvider_County = new Dropdown(Driver, By.CssSelector("select[ng-model=\"providerModel.countyId\"]"));
            CloseAddProviderModalButton = new Button(Driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            SaveAddedProviderButton = new Button(Driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            ProviderHasBankInformation = new Text(Driver, By.Id("tdProverHasBankInfo"));
            ProviderEligibilityStatus = new Text(Driver, By.Id("tdProviderEligibilityStatus"));
            ProviderContactName = new Text(Driver, By.Id("tdProviderPrimaryContact"));
            ProviderContactEmail = new Text(Driver, By.Id("tdProviderEmailAddress"));
            ProviderContactPhone = new Text(Driver, By.Id("tdProviderPhoneNumber"));
            ProviderContactAddress = new Text(Driver, By.Id("spanProviderAddressFirstLine"));
            ProviderContactCity = new Text(Driver, By.Id("spanProviderCity"));
            ProviderContactState = new Text(Driver, By.Id("spanProviderState"));
            ProviderContactZip = new Text(Driver, By.Id("spanProviderZipCode"));
            ProviderLicenseType = new Text(Driver, By.Id("tdProviderLicenseType"));
            ProviderLicenseNumber = new Text(Driver, By.Id("tdProviderLicenseNumber"));
            ProviderLicenseExpirationDate = new Text(Driver, By.Id("tdProviderExpirationDate"));
            TotalApprovedAmount = new Text(Driver, By.Id("spClaimAmount"));
            AddNewReimbursementDetailButton = new Button(Driver, By.Id("btnAddClaimItem"));
            AddReimbursementItemModal = new Modal(Driver, By.CssSelector("div[ng-form=\"claimItemForm\"]"));
            SaveNewReimbursementItem = new Button(Driver, By.CssSelector("button[ng-click=\"okClick()\"]"));
            CloseNewReimbursementItemModal = new Button(Driver, By.CssSelector("button[ng-click=\"cancelClick()\"]"));
            ReimbursementDetailItems = new WebElement(Driver, By.CssSelector("div[ng-form=\"claimForm\"]"));
            DateOfService = new EditField(Driver, By.Id("spServiceDate"));
            InvoiceDate = new EditField(Driver, By.Id("spInvoiceDate"));
            InvoiceNumber = new EditField(Driver, By.Id("txtInvoiceNumber"));
            TotalInvoiceAmount = new Text(Driver, By.Id("spanTotalInvoiceAmount"));
            InvoiceReceipt = new Checkbox(Driver, By.Id("chkDocument1"));
            SaveEntireWorksheetButton = new Button(Driver, By.Id("btnSaveWorksheet"));
            SaveConfirmationModal = new Modal(Driver, By.CssSelector(".modal-content"));
            AcceptSaveConfirationModalButton = new Button(Driver, By.CssSelector("button[ng-click=\"yesClick()\"]"));
            ReimbursementRequestWorkflowStatusOK = new Button(Driver, By.Id("btnOK"));
            ReimbursementRequestWorkflowStatusYES = new ButtonWithAlert(Driver, By.Id("btnYes"));
            ReimbursementRequestWorkflowStatusNO = new Button(Driver, By.Id("btnNo"));
            ReimbursementItemStatus = new ReimbursementDetailsTable(Driver, By.CssSelector("div[ng-form=\"claimForm\"]"));
            ReimbursementItemID = new ReimbursementDetailsTable(Driver, By.CssSelector("div[ng-form=\"claimForm\"]"));
            AddDenialReasonButton = new Button(Driver, By.CssSelector("button[data-ng-click=\"vm.addDenialReason(s.ClaimItemId);\"]"));
        }
    }
}
