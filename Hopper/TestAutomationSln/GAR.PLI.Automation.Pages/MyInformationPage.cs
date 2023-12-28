using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class MyInformationPage : HomePage
    {
        public Text PrimaryParent { get; private set; }

        public Text SecondaryParent { get; private set; }

        public Text HomePhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text CellPhone { get; private set; }

        public Text Email { get; private set; }

        public Button UpdateContactInformationButton { get; private set; }

        public EditField UpdateHomePhone { get; private set; }

        public EditField UpdateWorkPhone { get; private set; }

        public EditField UpdateCellPhone { get; private set; }

        public EditField UpdateEmail { get; private set; }

        public Button CancelUpdateContactInformation { get; private set; }

        public Button SaveNewContactInformation { get; private set; }

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

        public Button UpdateAuthorizedCallerButton { get; private set; }

        public EditField UpdateAuthorizedCallerFirstName { get; private set; }

        public EditField UpdateAuthorizedCallerLastName { get; private set; }

        public EditField UpdateAuthorizedCallerEmail { get; private set; }

        public EditField UpdateAuthorizedCallerPhoneNumber { get; private set; }

        public EditField UpdateAuthorizedCallerLast4SSN { get; private set; }

        public EditField UpdateAuthorizedCallerAddress1 { get; private set; }

        public EditField UpdateAuthorizedCallerAddress2 { get; private set; }

        public EditField UpdateAuthorizedCallerCity { get; private set; }

        public Dropdown UpdateAuthorizedCallerState { get; private set; }

        public EditField UpdateAuthorizedCallerZip { get; private set; }

        public Dropdown UpdateAuthorizedCallerSecurityQuestion { get; private set; }

        public EditField UpdateAuthorizedCallerSecurityAnswer { get; private set; }

        public Button CancelUpdateAuthorizedCaller { get; private set; }

        public Button SaveAuthorizedCaller { get; private set; }

        public Button DeleteAuthorizedCaller { get; private set; }

        public Text PhysicalAddress1 { get; private set; }

        public Text PhysicalAddress2 { get; private set; }

        public Text PhysicalCity { get; private set; }

        public Text PhysicalState { get; private set; }

        public Text PhysicalZip { get; private set; }

        public Text PhysicalCounty { get; private set; }

        public Button UpdatePhysicalAddressButton { get; private set; }

        public EditField UpdatePhysicalAddress1 { get; private set; }

        public EditField UpdatePhysicalAddress2 { get; private set; }

        public Dropdown UpdatePhysicalCity { get; private set; }

        public Dropdown UpdatePhysicalState { get; private set; }

        public EditField UpdatePhysicalZip { get; private set; }

        public Dropdown UpdatePhysicalCounty { get; private set; }

        public Button CancelUpdatePhysicalAddress { get; private set; }

        public Button SavePhysicalAddress { get; private set; }

        public Text MailingAddress1 { get; private set; }

        public Text MailingAddress2 { get; private set; }

        public Text MailingCity { get; private set; }

        public Text MailingState { get; private set; }

        public Text MailingZip { get; private set; }

        public Text MailingCounty { get; private set; }

        public Button UpdateMailingAddressButton { get; private set; }

        public EditField UpdateMailingAddress1 { get; private set; }

        public EditField UpdateMailingAddress2 { get; private set; }

        public Dropdown UpdateMailingCity { get; private set; }

        public Dropdown UpdateMailingState { get; private set; }

        public EditField UpdateMailingZip { get; private set; }

        public Dropdown UpdateMailingCounty { get; private set; }

        public Button CancelUpdateMailingAddress { get; private set; }

        public Button SaveMailingAddress { get; private set; }

        public Text Password { get; private set; }

        public Button UpdatePasswordButton { get; private set; }

        public EditField NewPassword { get; private set; }

        public EditField ConfirmPassword { get; private set; }

        public Button CancelUpdatePassword { get; private set; }

        public Button SaveNewPassword { get; private set; }

        public Text AccountType { get; private set; }

        public Text AccountUsage { get; private set; }

        public Text AccountName { get; private set; }

        public Text InstitutionName { get; private set; }

        public Text State { get; private set; }

        public Text City { get; private set; }

        public Text RoutingNumber { get; private set; }

        public Text AccountNumber { get; private set; }

        public Text ConfirmAccountNumber { get; private set; }

        public Text AuthorizeACH { get; private set; }

        public Button EditACHInformation { get; private set; }

        public Radio EditAccountTypeSavings { get; private set; }

        public Radio EditAccountTypeChecking { get; private set; }

        public Radio EditAccountUsageBusiness { get; private set; }

        public Radio EditAccountUsagePersonal { get; private set; }

        public EditField EditAccountName { get; private set; }

        public EditField EditBank { get; private set; }

        public Dropdown EditACHState { get; private set; }

        public Dropdown EditACHCity { get; private set; }

        public EditField EditRoutingNumber { get; private set; }

        public EditField EditAccountNumber { get; private set; }

        public EditField EditConfirmAccountNumber { get; private set; }

        public Button SaveACHInformationButton { get; private set; }

        public Button CancelEditingACHButton { get; private set; }

        public Button ConfirmAddressYES { get; private set; }

        public EditField NameOfPrimaryAccountHolder { get; private set; }

        public Button SaveBankAccount { get; private set; }

        public MyInformationPage(IWebDriver driver)
            : base(driver)
        {
            PrimaryParent = new Text(Driver, By.CssSelector("span[id$=\"lblPrimaryParentValue\"]"));
            SecondaryParent = new Text(Driver, By.CssSelector("span[id$=\"lblSecondaryParentValue\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"lblHomePhoneValue\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"lblWorkPhoneValue\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"lblCellPhoneValue\"]"));
            Email = new Text(Driver, By.CssSelector("span[id$=\"lblEmailValue\"]"));
            UpdateContactInformationButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditContact\"]"));
            UpdateHomePhone = new EditField(Driver, By.CssSelector("input[id$=\"_tbHomePhone\"]"));
            UpdateWorkPhone = new EditField(Driver, By.CssSelector("input[id$=\"_tbWorkPhone\"]"));
            UpdateCellPhone = new EditField(Driver, By.CssSelector("input[id$=\"_tbCellPhone\"]"));
            UpdateEmail = new EditField(Driver, By.CssSelector("input[id$=\"_tbEmail\"]"));
            CancelUpdateContactInformation = new Button(Driver, By.CssSelector("input[id$=\"_btnCancelContact\"]"));
            SaveNewContactInformation = new Button(Driver, By.CssSelector("input[id$=\"_btnSaveContact\"]"));
            AuthorizedCallerFirstName = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerFirstNameValue\"]"));
            AuthorizedCallerLastName = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerLastNameValue\"]"));
            AuthorizedCallerEmail = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerEmailValue\"]"));
            AuthorizedCallerPhoneNumber = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerPhoneValue\"]"));
            AuthorizedCallerLast4SSN = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerLastFourSSNValue\"]"));
            AuthorizedCallerAddress1 = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerAddressValue\"]"));
            AuthorizedCallerAddress2 = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerAddress2Value\"]"));
            AuthorizedCallerCity = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerCityValue\"]"));
            AuthorizedCallerState = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerStateValue\"]"));
            AuthorizedCallerZip = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerZipCodeValue\"]"));
            AuthorizedCallerSecurityQuestion = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerSecurityQuestionValue\"]"));
            AuthorizedCallerSecurityAnswer = new Text(Driver, By.CssSelector("span[id$=\"lblAuthCallerSecurityAnswerValue\"]"));
            UpdateAuthorizedCallerButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditAuthCaller\"]"));
            UpdateAuthorizedCallerFirstName = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerFirstName\"]"));
            UpdateAuthorizedCallerLastName = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerLastName\"]"));
            UpdateAuthorizedCallerEmail = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerEmail\"]"));
            UpdateAuthorizedCallerPhoneNumber = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerPhone\"]"));
            UpdateAuthorizedCallerLast4SSN = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerLastFourSSN\"]"));
            UpdateAuthorizedCallerAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerAddress\"]"));
            UpdateAuthorizedCallerAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerAddress2\"]"));
            UpdateAuthorizedCallerCity = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerCity\"]"));
            UpdateAuthorizedCallerState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAuthCallerSecurityQuestion\"]"));
            UpdateAuthorizedCallerZip = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerZipCode\"]"));
            UpdateAuthorizedCallerSecurityQuestion = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlAuthCallerState\"]"));
            UpdateAuthorizedCallerSecurityAnswer = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerSecurityAnswer\"]"));
            CancelUpdateAuthorizedCaller = new Button(Driver, By.CssSelector("input[id$=\"btnCancelAuthCaller\"]"));
            SaveAuthorizedCaller = new Button(Driver, By.CssSelector("input[id$=\"btnSaveAuthCaller\"]"));
            DeleteAuthorizedCaller = new Button(Driver, By.CssSelector("input[id$=\"btnDeleteAuthCaller\"]"));
            PhysicalAddress1 = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalAddress1Value\"]"));
            PhysicalAddress2 = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalAddress2Value\"]"));
            PhysicalCity = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalCityValue\"]"));
            PhysicalState = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalStateValue\"]"));
            PhysicalZip = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalZipValue\"]"));
            PhysicalCounty = new Text(Driver, By.CssSelector("span[id$=\"lblPhysicalCountyValue\"]"));
            UpdatePhysicalAddressButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditPhysicalAddress\"]"));
            UpdatePhysicalAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalAddress1Value\"]"));
            UpdatePhysicalAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalAddress2Value\"]"));
            UpdatePhysicalCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalCity\"]"));
            UpdatePhysicalState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalState\"]"));
            UpdatePhysicalZip = new EditField(Driver, By.CssSelector("input[id$=\"tbPhysicalZip\"]"));
            UpdatePhysicalCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPhysicalCounty\"]"));
            CancelUpdatePhysicalAddress = new Button(Driver, By.CssSelector("input[id$=\"btnCancelPhysicalAddress\"]"));
            SavePhysicalAddress = new Button(Driver, By.CssSelector("input[id$=\"btnSavePhysicalAddress\"]"));
            MailingAddress1 = new Text(Driver, By.CssSelector("span[id$=\"lblMailingAddress1Value\"]"));
            MailingAddress2 = new Text(Driver, By.CssSelector("span[id$=\"lblMailingAddress2Value\"]"));
            MailingCity = new Text(Driver, By.CssSelector("span[id$=\"lblMailingCityValue\"]"));
            MailingState = new Text(Driver, By.CssSelector("span[id$=\"lblMailingStateValue\"]"));
            MailingZip = new Text(Driver, By.CssSelector("span[id$=\"lblMailingZipValue\"]"));
            MailingCounty = new Text(Driver, By.CssSelector("span[id$=\"lblMailingCountyValue\"]"));
            UpdateMailingAddressButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditMailingAddress\"]"));
            UpdateMailingAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress1Value\"]"));
            UpdateMailingAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress2Value\"]"));
            UpdateMailingCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCity\"]"));
            UpdateMailingState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingState\"]"));
            UpdateMailingZip = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingZip\"]"));
            UpdateMailingCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCounty\"]"));
            CancelUpdateMailingAddress = new Button(Driver, By.CssSelector("input[id$=\"btnCancelMailingAddress\"]"));
            SaveMailingAddress = new Button(Driver, By.CssSelector("input[id$=\"btnSaveMailingAddress\"]"));
            Password = new Text(Driver, By.Id("span[id$=\"lblPasswordValue\"]"));
            UpdatePasswordButton = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnEditPassword"));
            NewPassword = new EditField(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_tbPassword"));
            ConfirmPassword = new EditField(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_tbPasswordConfirm"));
            CancelUpdatePassword = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnCancelPassword"));
            SaveNewPassword = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnSavePassword"));
            AccountType = new Text(Driver, By.CssSelector("span[id$=\"lblAccountType\"]"));
            AccountUsage = new Text(Driver, By.CssSelector("span[id$=\"lblAccountPurpose\"]"));
            AccountName = new Text(Driver, By.CssSelector("span[id$=\"lblAccountName\"]"));
            InstitutionName = new Text(Driver, By.CssSelector("span[id$=\"lblInstitutionName\"]"));
            State = new Text(Driver, By.CssSelector("span[id$=\"lblState\"]"));
            City = new Text(Driver, By.CssSelector("span[id$=\"lblCity\"]"));
            RoutingNumber = new Text(Driver, By.CssSelector("span[id$=\"lblRoutingNumber\"]"));
            AccountNumber = new Text(Driver, By.CssSelector("span[id$=\"lblAccountNumber\"]"));
            ConfirmAccountNumber = new Text(Driver, By.CssSelector("span[id$=\"lblAccountNumberConfirm\"]"));
            AuthorizeACH = new Text(Driver, By.CssSelector("input[id$=\"chkTerms\"]"));
            EditACHInformation = new Button(Driver, By.CssSelector("input[id$=\"btnEditBankAccount\"]"));
            EditAccountTypeSavings = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_0\"]"));
            EditAccountTypeChecking = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountType_1\"]"));
            EditAccountUsageBusiness = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_0\"]"));
            EditAccountUsagePersonal = new Radio(Driver, By.CssSelector("input[id$=\"rbAccountPurpose_1\"]"));
            EditAccountName = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountName\"]"));
            EditBank = new EditField(Driver, By.CssSelector("input[id$=\"txtInstitutionName\"]"));
            EditACHState = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlState\"]"));
            EditACHCity = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlCity\"]"));
            EditRoutingNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtRoutingNumber\"]"));
            EditAccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumber\"]"));
            EditConfirmAccountNumber = new EditField(Driver, By.CssSelector("input[id$=\"txtAccountNumberConfirm\"]"));
            SaveACHInformationButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveBankAccount\"]"));
            CancelEditingACHButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancelBankAccount\"]"));
            ConfirmAddressYES = new Button(Driver, By.CssSelector("input[id$=\"btnConfirmAddress\"]"));
            NameOfPrimaryAccountHolder = new EditField(Driver, By.CssSelector("input[id$=\"RPMainPanel_controls_guardianlogin_claims_bankinformation_ascx415_txtAccountName\"]"));
            SaveBankAccount = new Button(Driver, By.CssSelector("input[id$=\"RPMainPanel_controls_guardianlogin_claims_bankinformation_ascx415_btnSaveBankAccount\"]"));
        }
    }
}
