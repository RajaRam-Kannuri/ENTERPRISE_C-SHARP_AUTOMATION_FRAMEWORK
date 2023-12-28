using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ProviderApprovalWorksheetPage : HomePage
    {
        public Text ProviderName { get; private set; }

        public Text ProviderTaxId { get; private set; }

        public Text ProviderLicenseType { get; private set; }

        public Text ProviderLicenseNumber { get; private set; }

        public Text ProviderGeneralStatus { get; private set; }

        public Text ProviderLicenseExpirationDate { get; private set; }

        public Text ProviderApprovedDate { get; private set; }

        public Text GroupName { get; private set; }

        public Text GroupStatus { get; private set; }

        public Text GroupApprovedDate { get; private set; }

        public Text GroupTaxId { get; private set; }

        public Table GroupMemberTable { get; private set; }

        public Button AddProviderButton { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text City { get; private set; }

        public Text State { get; private set; }

        public Text Zip { get; private set; }

        public Text County { get; private set; }

        public Text AccountType { get; private set; }

        public Text AccountUsage { get; private set; }

        public Text Bank { get; private set; }

        public Text BankCity { get; private set; }

        public Text BankState { get; private set; }

        public Text RoutingNumber { get; private set; }

        public Text AccountNumber { get; private set; }

        public Text ConfirmAccountNumber { get; private set; }

        public Text ContactName { get; private set; }

        public Text ContactEmail { get; private set; }

        public Text ContactPhone { get; private set; }

        public Checkbox SensitiveNote { get; private set; }

        public EditField NoteText { get; private set; }

        public Button AddNoteButton { get; private set; }

        public Table NotesTable { get; private set; }

        public Text CurrentStatus { get; private set; }

        public Dropdown StatusList { get; private set; }

        public Button SaveStatusButton { get; private set; }

        public Button UploadDocumentsButton { get; private set; }

        public Button EditAddressButton { get; private set; }

        public EditField NewAddress { get; private set; }

        public Dropdown NewCity { get; private set; }

        public Dropdown NewState { get; private set; }

        public EditField NewZip { get; private set; }

        public Dropdown NewCounty { get; private set; }

        public Button SaveNewAddressButton { get; private set; }

        public Button CancelEditingAddressButton { get; private set; }

        public Button EditBankInformationButton { get; private set; }

        public Text NewAccountType { get; private set; }

        public Text NewAccountUsage { get; private set; }

        public EditField NewBankName { get; private set; }

        public Dropdown NewBankCity { get; private set; }

        public Dropdown NewBankState { get; private set; }

        public EditField NewRoutingNumber { get; private set; }

        public EditField NewAccountNumber { get; private set; }

        public EditField NewConfirmAccountNumber { get; private set; }

        public Button SaveNewBankInformationButton { get; private set; }

        public Button CancelEditingBankInformationButton { get; private set; }

        public Button EditContactInformationButton { get; private set; }

        public EditField NewContactName { get; private set; }

        public EditField NewContactEmail { get; private set; }

        public EditField NewContactPhone { get; private set; }

        public Button SaveNewContactInformationButton { get; private set; }

        public Button CancelEditingContactInformationButton { get; private set; }

        public Button EditGeneralInformationButton { get; private set; }

        public EditField NewProviderName { get; private set; }

        public EditField NewProviderTaxId { get; private set; }

        public Dropdown NewProviderLicenseType { get; private set; }

        public EditField NewProviderLicenseNumber { get; private set; }

        public EditField NewProviderLicenseExpirationDate { get; private set; }

        public Button SaveGeneralInformationButton { get; private set; }

        public Button CancelEditingGeneralInformationButton { get; private set; }

        public Button EditGroupInformationButton { get; private set; }

        public EditField NewGroupName { get; private set; }

        public Dropdown NewGroupStatus { get; private set; }

        public EditField NewGroupTaxId { get; private set; }

        public Button SaveGroupInformationButton { get; private set; }

        public Button CancelEditingGroupInformationButton { get; private set; }

        public Modal GroupMemberDataModal { get; private set; }

        public EditField NewMemberName { get; private set; }

        public EditField NewMemberLicenseNumber { get; private set; }

        public Dropdown NewMemberLicenseType { get; private set; }

        public EditField NewMemberExpirationDate { get; private set; }

        public Dropdown NewMemberStatus { get; private set; }

        public Button SaveNewMemberInformation { get; private set; }

        public Button CancelEditingMemberInformation { get; private set; }

        public ProviderApprovalWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            ProviderName = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderName\"]"));
            ProviderTaxId = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderTaxId\"]"));
            ProviderLicenseType = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderLicenseType\"]"));
            ProviderLicenseNumber = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderLicenseNumber\"]"));
            ProviderGeneralStatus = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderGeneralStatus\"]"));
            ProviderLicenseExpirationDate = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderExpirationDate\"]"));
            ProviderApprovedDate = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderApprovedDate\"]"));
            GroupName = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderGroupName\"]"));
            GroupStatus = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderGroupStatus\"]"));
            GroupApprovedDate = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderGroupApprovedDate\"]"));
            GroupTaxId = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderGroupTaxId\"]"));
            GroupMemberTable = new Table(driver, By.CssSelector("div[id*=\"providerapprovalworksheet\"][id$=\"MainPanel\"] .dataTable"));
            AddProviderButton = new Button(driver, By.CssSelector("input[id$=\"btnAddProvider\"]"));
            PhysicalAddress = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhysicalAddress\"]"));
            City = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhysicalCity\"]"));
            State = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhysicalState\"]"));
            Zip = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhysicalZipCode\"]"));
            County = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhysicalCounty\"]"));
            AccountType = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionAccountType\"]"));
            AccountUsage = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionAccountUsage\"]"));
            Bank = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitution\"]"));
            BankCity = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionCity\"]"));
            BankState = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionState\"]"));
            RoutingNumber = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionAchRoutingNumber\"]"));
            AccountNumber = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionAccountNumber\"]"));
            ConfirmAccountNumber = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderFinancialInstitutionAccountNumberConfirm\"]"));
            ContactName = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderContactName\"]"));
            ContactEmail = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderEmailAddress\"]"));
            ContactPhone = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblProviderPhoneNumber\"]"));
            SensitiveNote = new Checkbox(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"chkSensitiveNote\"]"));
            NoteText = new EditField(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"tbxNote\"]"));
            AddNoteButton = new Button(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"btnAddNote\"]"));
            NotesTable = new Table(driver, By.Id("tblResults"));
            CurrentStatus = new Text(driver, By.CssSelector("span[id*=\"providerapprovalworksheet\"][id$=\"lblCurrentStatus\"]"));
            StatusList = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderStatus\"]"));
            SaveStatusButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveProviderStatus\"]"));
            UploadDocumentsButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnUpload\"]"));
            EditAddressButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnEditAddressInformation\"]"));
            NewAddress = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderPhysicalAddress\"]"));
            NewCity = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderPhysicalCity\"]"));
            NewState = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderPhysicalState\"]"));
            NewZip = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderPhysicalZipCode\"]"));
            NewCounty = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderPhysicalCounty\"]"));
            SaveNewAddressButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveAddressInformation\"]"));
            CancelEditingAddressButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnCancelAddressInformation\"]"));
            EditBankInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnEditFinancialInformation\"]"));
            NewAccountType = new Text(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderFinancialInstitutionAccountType\"]"));
            NewAccountUsage = new Text(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderFinancialInstitutionAccountUsage\"]"));
            NewBankName = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderFinancialInstitution\"]"));
            NewBankCity = new Dropdown(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderFinancialInstitutionCity\"]"));
            NewBankState = new Dropdown(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderFinancialInstitutionState\"]"));
            NewRoutingNumber = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderFinancialInstitutionAchRoutingNumber\"]"));
            NewAccountNumber = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderFinancialInstitutionAccountNumber\"]"));
            NewConfirmAccountNumber = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderFinancialInstitutionAccountNumberConfirm\"]"));
            SaveNewBankInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveFinancialInformation\"]"));
            CancelEditingBankInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnCancelFinancialInformation\"]"));
            EditContactInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnEditContactInformation\"]"));
            NewContactName = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderContactName\"]"));
            NewContactEmail = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderEmailAddress\"]"));
            NewContactPhone = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderPhoneNumber\"]"));
            SaveNewContactInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveContactInformation\"]"));
            CancelEditingContactInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnCancelContactInformation\"]"));
            EditGeneralInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnEditGeneralInformation\"]"));
            NewProviderName = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderName\"]"));
            NewProviderTaxId = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderTaxId\"]"));
            NewProviderLicenseType = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderLicenseType\"]"));
            NewProviderLicenseNumber = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderLicenseNumber\"]"));
            NewProviderLicenseExpirationDate = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"tbxProviderExpirationDate\"]"));
            SaveGeneralInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveGeneralInformation\"]"));
            CancelEditingGeneralInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnCancelGeneralInformation\"]"));
            EditGroupInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnEditProviderGroupInfo\"]"));
            NewGroupName = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"txtProviderGroupName\"]"));
            NewGroupStatus = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"ddlProviderGroupApprovalStatus\"]"));
            NewGroupTaxId = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"txtProviderGroupTaxId\"]"));
            SaveGroupInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnSaveProviderGroupInfo\"]"));
            CancelEditingGroupInformationButton = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"btnCancelProviderGroupInfo\"]"));
            GroupMemberDataModal = new Modal(driver, By.CssSelector("div[id*=\"providerapprovalworksheet\"][id*=\"modalEidtAddProvider\"]"));
            NewMemberName = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_txtProviderName\"]"));
            NewMemberLicenseNumber = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_txtLicenseNumber\"]"));
            NewMemberLicenseType = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_ddlProviderType\"]"));
            NewMemberExpirationDate = new EditField(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_txtExpirationDate\"]"));
            NewMemberStatus = new Dropdown(driver, By.CssSelector("select[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_ddlApprovalStatus\"]"));
            SaveNewMemberInformation = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_btnSaveProvider\"]"));
            CancelEditingMemberInformation = new Button(driver, By.CssSelector("input[id*=\"providerapprovalworksheet\"][id$=\"modalEidtAddProvider_btnCancel\"]"));
        }
    }
}
