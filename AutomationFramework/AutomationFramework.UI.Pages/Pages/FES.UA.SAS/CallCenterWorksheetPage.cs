using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class CallCenterWorksheetPage : HomePage
    {
        public Text ApplicationSchoolYear { get; private set; }

        public Text PrimaryParent { get; private set; }

        public Text PrimaryParentMaritalStatus { get; private set; }

        public Text SecondaryParent { get; private set; }

        public Text SecondaryParentRelationship { get; private set; }

        public Text SecurityQuestion { get; private set; }

        public Text SecurityAnswer { get; private set; }

        public Text AuthorizedCallerFirstName { get; private set; }

        public Text AuthorizedCallerLastName { get; private set; }

        public Text AuthorizedCallerEmail { get; private set; }

        public Text AuthorizedCallerPhoneNumber { get; private set; }

        public Text AuthorizedCallerLast4SSN { get; private set; }

        public Text AuthorizedCallerAddress1 { get; private set; }

        public Text AuthorizedCallerAddress2 { get; private set; }

        public Text AuthorizedCallerCity { get; private set; }

        public Text AuthorizedCallerState { get; private set; }

        public Text AuthorizedCallerZip { get; private set; }

        public Text AuthorizedCallerSecurityQuestion { get; private set; }

        public Text AuthorizedCallerSecurityAnswer { get; private set; }

        public Button EditAuthorizedCaller { get; private set; }

        public EditField EditAuthorizedCallerFirstName { get; private set; }

        public EditField EditAuthorizedCallerLastName { get; private set; }

        public EditField EditAuthorizedCallerEmail { get; private set; }

        public EditField EditAuthorizedCallerPhoneNumber { get; private set; }

        public EditField EditAuthorizedCallerLast4SSN { get; private set; }

        public EditField EditAuthorizedCallerAddress1 { get; private set; }

        public EditField EditAuthorizedCallerAddress2 { get; private set; }

        public EditField EditAuthorizedCallerCity { get; private set; }

        public Dropdown EditAuthorizedCallerState { get; private set; }

        public EditField EditAuthorizedCallerZip { get; private set; }

        public Dropdown EditAuthorizedCallerSecurityQuestion { get; private set; }

        public EditField EditAuthorizedCallerSecurityAnswer { get; private set; }

        public Button CancelEditAuthorizedCallerButton { get; private set; }

        public Button SaveAuthorizedCallerButton { get; private set; }

        public Button DeleteAuthorizedCallerButton { get; private set; }
        
        public Table StudentsTable { get; private set; }

        public Text ApplicationId { get; private set; }

        public Text ApplicationStatus { get; private set; }

        public Text ApplicationSubmissionDate { get; private set; }

        public Text ApplicationType { get; private set; }

        public Text HomePhone { get; private set; }

        public Text CellPhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text Email { get; private set; }

        public Button EditContactInformation { get; private set; }

        public EditField EditHomePhone { get; private set; }

        public EditField EditCellPhone { get; private set; }

        public EditField EditWorkPhone { get; private set; }

        public EditField EditEmail { get; private set; }

        public Button CancelEditContactInformation { get; private set; }

        public Button SaveContactInformation { get; private set; }

        public Text PhysicalAddress1 { get; private set; }

        public Text PhysicalAddress2 { get; private set; }

        public Text PhysicalCity { get; private set; }

        public Text PhysicalState { get; private set; }

        public Text PhysicalZip { get; private set; }

        public Text PhysicalCounty { get; private set; }

        public Button EditPhysicalAddress { get; private set; }

        public EditField EditPhysicalAddress1 { get; private set; }

        public EditField EditPhysicalAddress2 { get; private set; }

        public Dropdown EditPhysicalCity { get; private set; }

        public Dropdown EditPhysicalState { get; private set; }

        public EditField EditPhysicalZip { get; private set; }

        public Dropdown EditPhysicalCounty { get; private set; }

        public Button CancelEditPhysicalAddress { get; private set; }

        public Button SavePhysicalAddress { get; private set; }
        
        public Text MailingAddress1 { get; private set; }

        public Text MailingAddress2 { get; private set; }

        public Text MailingCity { get; private set; }

        public Text MailingState { get; private set; }

        public Text MailingZip { get; private set; }

        public Text MailingCounty { get; private set; }

        public Button EditMailingAddress { get; private set; }

        public EditField EditMailingAddress1 { get; private set; }

        public EditField EditMailingAddress2 { get; private set; }

        public Dropdown EditMailingCity { get; private set; }

        public Dropdown EditMailingState { get; private set; }

        public EditField EditMailingZip { get; private set; }

        public Dropdown EditMailingCounty { get; private set; }

        public Button CancelEditMailingAddress { get; private set; }

        public Button SaveMailingAddress { get; private set; }

        public Button ResetPasswordByEmailButton { get; private set; }

        public Button SendActivationLinkButton { get; private set; }

        public Checkbox EmailConfirmed { get; private set; }

        public Checkbox AccountLocked { get; private set; }

        public Checkbox FailedPasswordAttempts { get; private set; }

        public Table PaymentTransactionsTable { get; private set; }

        public Dropdown ReimbursementRequestYear { get; private set; }

        public Table ReimbursementsTable { get; private set; }

        public Dropdown Language { get; private set; }

        public Dropdown ContactType { get; private set; }

        public Dropdown ContactReason { get; private set; }

        public EditField Subject { get; private set; }

        public Checkbox CustomerServiceTicket { get; private set; }

        public Dropdown Type { get; private set; }

        public EditField Description { get; private set; }

        public Button AddToContactLog { get; private set; }

        public Text ContactLogValidationErrors { get; private set; }

        public Button CancelContactLogButton { get; private set; }

        public Checkbox CallResolved { get; private set; }

        public Checkbox CallTransferred { get; private set; }

        public Checkbox RequestedManager { get; private set; }

        public Checkbox CallDisconnected { get; private set; }

        public Checkbox CustomerFeedback { get; private set; }

        public Checkbox PlacedARWForAppeals { get; private set; }

        public Checkbox PlacedARWForDP { get; private set; }

        public Checkbox PlacedARWForES { get; private set; }

        public Checkbox PlacedARWForPC { get; private set; }

        public Checkbox PrimaryGuardianCheckbox { get; private set; }

        public Checkbox SecondaryGuardianCheckbox { get; private set; }

        public Checkbox ProspectCheckbox { get; private set; }

        public Checkbox SchoolCheckbox { get; private set; }

        public Checkbox AuthorizedUserCheckbox { get; private set; }

        public Checkbox UnauthorizedUserCheckbox { get; private set; }

        public Checkbox DonorCheckbox { get; private set; }

		public Table ScholarshipChildrenStatusTable { get; private set; }

		public Button RevokeStudentsButton { get; private set; }

		public Button ConfirmRevokeButton { get; private set; }

		public Button CancelRevokeButton { get; private set; }

        public Table OnHoldReasonsTable { get; private set; }

        public CallCenterWorksheetPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationSchoolYear = new Text(driver, By.CssSelector("span[id$=\"lblSchoolYearValue\"]"));
            PrimaryParent = new Text(driver, By.CssSelector("span[id$=\"lblPrimaryParentValue\"]"));
            SecondaryParent = new Text(driver, By.CssSelector("span[id$=\"lblSecondaryParentValue\"]"));
            PrimaryParentMaritalStatus = new Text(driver, By.CssSelector("span[id$=\"lblMaritalStatusValue\"]"));
            SecondaryParentRelationship = new Text(driver, By.CssSelector("span[id$=\"lblSPRelationshipValue\"]"));
            SecurityQuestion = new Text(driver, By.CssSelector("span[id$=\"lblSecurityQuestionValue\"]"));
            SecurityAnswer = new Text(driver, By.CssSelector("span[id$=\"lblSecurityAnswerValue\"]"));
            AuthorizedCallerFirstName = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerFirstNameValue\"]"));
            AuthorizedCallerLastName = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerLastNameValue\"]"));
            AuthorizedCallerEmail = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerEmailValue\"]"));
            AuthorizedCallerPhoneNumber = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerPhoneValue\"]"));
            AuthorizedCallerLast4SSN = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerLastFourSSNValue\"]"));
            AuthorizedCallerAddress1 = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerAddressValue\"]"));
            AuthorizedCallerAddress2 = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerAddress2Value\"]"));
            AuthorizedCallerCity = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerCityValue\"]"));
            AuthorizedCallerState = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerStateValue\"]"));
            AuthorizedCallerZip = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerZipCodeValue\"]"));
            AuthorizedCallerSecurityQuestion = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerSecurityQuestionValue\"]"));
            AuthorizedCallerSecurityAnswer = new Text(driver, By.CssSelector("span[id$=\"lblAuthCallerSecurityAnswerValue\"]"));
            EditAuthorizedCaller = new Button(driver, By.CssSelector("input[id$=\"btnEditAuthCaller\"]"));
            EditAuthorizedCallerFirstName = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerFirstName\"]"));
            EditAuthorizedCallerLastName = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerLastName\"]"));
            EditAuthorizedCallerEmail = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerEmail\"]"));
            EditAuthorizedCallerPhoneNumber = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerPhone\"]"));
            EditAuthorizedCallerLast4SSN = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerLastFourSSN\"]"));
            EditAuthorizedCallerAddress1 = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerAddress\"]"));
            EditAuthorizedCallerAddress2 = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerAddress2\"]"));
            EditAuthorizedCallerCity = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerCity\"]"));
            EditAuthorizedCallerState = new Dropdown(driver, By.CssSelector("select[id$=\"ddlAuthCallerState\"]"));
            EditAuthorizedCallerZip = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerZipCode\"]"));
            EditAuthorizedCallerSecurityQuestion = new Dropdown(driver, By.CssSelector("select[id$=\"ddlAuthCallerSecurityQuestion\"]"));
            EditAuthorizedCallerSecurityAnswer = new EditField(driver, By.CssSelector("input[id$=\"tbAuthCallerSecurityAnswer\"]"));
            CancelEditAuthorizedCallerButton = new Button(driver, By.CssSelector("input[id$=\"btnCancelAuthCaller\"]"));
            SaveAuthorizedCallerButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveAuthCaller\"]"));
            DeleteAuthorizedCallerButton = new Button(driver, By.CssSelector("input[id$=\"btnDeleteAuthCaller\"]"));
            StudentsTable = new Table(driver, By.CssSelector("table[id$=\"GVStudents\"]"));
            ApplicationId = new Text(driver, By.CssSelector("span[id$=\"lblApplicationIdValue\"]"));
            ApplicationType = new Text(driver, By.CssSelector("span[id$=\"lblApplicationTypeValue\"]"));
            ApplicationStatus = new Text(driver, By.CssSelector("span[id$=\"lblApplicationStatusValue\"]"));
            ApplicationSubmissionDate = new Text(driver, By.CssSelector("span[id$=\"lblApplicationSubmissionDateValue\"]"));
            HomePhone = new Text(driver, By.CssSelector("span[id$=\"lblHomePhoneValue\"]"));
            WorkPhone = new Text(driver, By.CssSelector("span[id$=\"lblWorkPhoneValue\"]"));
            CellPhone = new Text(driver, By.CssSelector("span[id$=\"lblCellPhoneValue\"]"));
            Email = new Text(driver, By.CssSelector("span[id$=\"lblEmailValue\"]"));
            EditContactInformation = new Button(driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnEditContact"));
            EditHomePhone = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbHomePhone"));
            EditCellPhone = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbCellPhone"));
            EditWorkPhone = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbWorkPhone"));
            EditEmail = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbEmail"));
            CancelEditContactInformation = new Button(driver, By.CssSelector("input[@id$=\"btnCancelContact\"]"));
            SaveContactInformation = new Button(driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnSaveContact"));
            PhysicalAddress1 = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalAddress1Value\"]"));
            PhysicalAddress2 = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalAddress2Value\"]"));
            PhysicalCity = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalCityValue\"]"));
            PhysicalState = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalStateValue\"]"));
            PhysicalZip = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalZipValue\"]"));
            PhysicalCounty = new Text(driver, By.CssSelector("span[id$=\"lblPhysicalCountyValue\"]"));
            EditPhysicalAddress = new Button(driver, By.CssSelector("input[id$=\"btnEditPhysicalAddress\"]"));
            EditPhysicalAddress1 = new EditField(driver, By.CssSelector("input[id$=\"tbPhysicalAddress1Value\"]"));
            EditPhysicalAddress2 = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbPhysicalAddress2Value"));
            EditPhysicalCity = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalCity"));
            EditPhysicalState = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalState"));
            EditPhysicalZip = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbPhysicalZip"));
            EditPhysicalCounty = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalCounty"));
            CancelEditPhysicalAddress = new Button(driver, By.CssSelector("input[id$=\"btnCancelPhysicalAddress\"]"));
            SavePhysicalAddress = new Button(driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnSavePhysicalAddress"));
            MailingAddress1 = new Text(driver, By.CssSelector("span[id$=\"lblMailingAddress1Value\"]"));
            MailingAddress2 = new Text(driver, By.CssSelector("span[id$=\"lblMailingAddress2Value\"]"));
            MailingCity = new Text(driver, By.CssSelector("span[id$=\"lblMailingCityValue\"]"));
            MailingState = new Text(driver, By.CssSelector("span[id$=\"lblMailingStateValue\"]"));
            MailingZip = new Text(driver, By.CssSelector("span[id$=\"lblMailingZipValue\"]"));
            MailingCounty = new Text(driver, By.CssSelector("span[id$=\"lblMailingCountyValue\"]"));
            EditMailingAddress = new Button(driver, By.CssSelector("input[id$=\"btnEditMailingAddress\"]"));
            EditMailingAddress1 = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingAddress1Value"));
            EditMailingAddress2 = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingAddress2Value"));
            EditMailingCity = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingCity"));
            EditMailingState = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingState"));
            EditMailingZip = new EditField(driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingZip"));
            EditMailingCounty = new Dropdown(driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingCounty"));
            CancelEditMailingAddress = new Button(driver, By.CssSelector("input[id$=\"btnCancelMailingAddress\"]"));
            SaveMailingAddress = new Button(driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnSaveMailingAddress"));
            ResetPasswordByEmailButton = new Button(driver, By.CssSelector("a[id$=\"btnResetPassword\"]"));
            SendActivationLinkButton = new Button(driver, By.CssSelector("a[id$=\"btnSendActivationLink\"]"));
            EmailConfirmed = new Checkbox(driver, By.CssSelector("span[id$=\"cbUserApproved\"]"));
            AccountLocked = new Checkbox(driver, By.CssSelector("span[id$=\"cbLockedOut\"]"));
            FailedPasswordAttempts = new Checkbox(driver, By.CssSelector("span[id$=\"lblFailedCount\"]"));
            ReimbursementRequestYear = new Dropdown(driver, By.CssSelector("select[id*=\"claimstablecontrol\"][id$=\"ddlOrgYear\"]"));
            ReimbursementsTable = new Table(driver, By.CssSelector(".dataTable"));
            PaymentTransactionsTable = new Table(driver, By.CssSelector("table[id$=\"DLTransactions\"]"));
            Language = new Dropdown(driver, By.CssSelector("select[id$=\"ddlLanguage\"]"));
            ContactType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlContactType\"]"));
            ContactReason = new Dropdown(driver, By.CssSelector("select[id$=\"ddlContactreason\"]"));
            Subject = new EditField(driver, By.CssSelector("input[id$=\"tbSubject\"]"));
            CustomerServiceTicket = new Checkbox(driver, By.CssSelector("input[id$=\"chkCustomerServiceTicket\"]"));
            Type = new Dropdown(driver, By.CssSelector("select[id$=\"ddlCustomerServiceTicketType\"]"));
            Description = new EditField(driver, By.CssSelector("textarea[id$=\"tbCallLogNotes\"]"));
            AddToContactLog = new Button(driver, By.CssSelector("input[id$=\"btnContactLog\"]"));
            ContactLogValidationErrors = new Text(driver, By.CssSelector("div[id$=\"vsValidationCallLog\"]"));
            CancelContactLogButton = new Button(driver, By.CssSelector("input[id$=\"btnCancel\"]"));
            CallResolved = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_0\"]"));
            CallTransferred = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_1\"]"));
            RequestedManager = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_2\"]"));
            CallDisconnected = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_3\"]"));
            CustomerFeedback = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_4\"]"));
            PlacedARWForAppeals = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_5\"]"));
            PlacedARWForDP = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_6\"]"));
            PlacedARWForES = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_7\"]"));
            PlacedARWForPC = new Checkbox(driver, By.CssSelector("input[id$=\"cblCallResolutions_8\"]"));
            PrimaryGuardianCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_0\"]"));
            ProspectCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_1\"]"));
            SchoolCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_2\"]"));
            AuthorizedUserCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_3\"]"));
            UnauthorizedUserCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_4\"]"));
            DonorCheckbox = new Checkbox(driver, By.CssSelector("input[id$=\"rblContactLogContactType_5\"]"));
			ScholarshipChildrenStatusTable = new Table(driver, By.CssSelector("table[id$=\"DLStudents\"]"));
			RevokeStudentsButton = new Button(driver, By.CssSelector("input[id$=\"btnRevokeStudents\"]"));
			ConfirmRevokeButton = new Button(driver, By.CssSelector("input[id$=\"btnRevokeStudentsConfirmed\"]"));
			CancelRevokeButton = new Button(driver, By.CssSelector("input[id$=\"btnRevokeStudentsCancel\"]"));
            OnHoldReasonsTable = new Table(driver, By.CssSelector("table[id$=\"gvOHReason\"]"));
        }
	}
}
