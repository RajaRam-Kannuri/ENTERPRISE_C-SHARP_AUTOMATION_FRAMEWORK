using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class MyInformationPage : FTCPLIBasePage
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

        public Button UpdateAuthorizedCallerFirstName { get; private set; }

        public EditField UpdateAuthorizedCallerLastName { get; private set; }

        public EditField UpdateAuthorizedCallerEmail { get; private set; }

        public EditField UpdateAuthorizedCallerPhoneNumber { get; private set; }

        public EditField UpdateAuthorizedCallerLast4SSN { get; private set; }

        public EditField UpdateAuthorizedCallerAddress1 { get; private set; }

        public EditField UpdateAuthorizedCallerAddress2 { get; private set; }

        public Dropdown UpdateAuthorizedCallerCity { get; private set; }

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

        public Button UpdateMailingAddress1 { get; private set; }

        public Button UpdateMailingAddress2 { get; private set; }

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
            UpdateAuthorizedCallerFirstName = new Button(Driver, By.CssSelector("input[id$=\"tbAuthCallerFirstName\"]"));
            UpdateAuthorizedCallerLastName = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerLastName\"]"));
            UpdateAuthorizedCallerEmail = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerEmail\"]"));
            UpdateAuthorizedCallerPhoneNumber = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerPhone\"]"));
            UpdateAuthorizedCallerLast4SSN = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerLastFourSSN\"]"));
            UpdateAuthorizedCallerAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerAddress\"]"));
            UpdateAuthorizedCallerAddress2 = new EditField(Driver, By.CssSelector("input[id$=\"tbAuthCallerAddress2\"]"));
            UpdateAuthorizedCallerCity = new Dropdown(Driver, By.CssSelector("input[id$=\"tbAuthCallerCity\"]"));
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
            UpdatePhysicalAddress1 = new EditField(Driver, By.CssSelector("input[id$=\"tbEditAddress1Value\"]"));
            UpdatePhysicalAddress2 = new EditField(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbPhysicalAddress2Value"));
            UpdatePhysicalCity = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalCity"));
            UpdatePhysicalState = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalState"));
            UpdatePhysicalZip = new EditField(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbPhysicalZip"));
            UpdatePhysicalCounty = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlPhysicalCounty"));
            CancelUpdatePhysicalAddress = new Button(Driver, By.CssSelector("input[id$=\"btnCancelPhysicalAddress\"]"));
            SavePhysicalAddress = new Button(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnSavePhysicalAddress"));
            MailingAddress1 = new Text(Driver, By.CssSelector("span[id$=\"lblMailingAddress1Value\"]"));
            MailingAddress2 = new Text(Driver, By.CssSelector("span[id$=\"lblMailingAddress2Value\"]"));
            MailingCity = new Text(Driver, By.CssSelector("span[id$=\"lblMailingCityValue\"]"));
            MailingState = new Text(Driver, By.CssSelector("span[id$=\"lblMailingStateValue\"]"));
            MailingZip = new Text(Driver, By.CssSelector("span[id$=\"lblMailingZipValue\"]"));
            MailingCounty = new Text(Driver, By.CssSelector("span[id$=\"lblMailingCountyValue\"]"));
            UpdateMailingAddressButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditMailingAddress\"]"));
            UpdateMailingAddress1 = new Button(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingAddress1Value"));
            UpdateMailingAddress2 = new Button(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingAddress2Value"));
            UpdateMailingCity = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingCity"));
            UpdateMailingState = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingState"));
            UpdateMailingZip = new EditField(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_tbMailingZip"));
            UpdateMailingCounty = new Dropdown(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_ddlMailingCounty"));
            CancelUpdateMailingAddress = new Button(Driver, By.CssSelector("input[id$=\"btnCancelMailingAddress\"]"));
            SaveMailingAddress = new Button(Driver, By.Id("controls_householdinfo_householdinformation_ascx124_btnSaveMailingAddress"));
            Password = new Text(Driver, By.Id("span[id$=\"lblPasswordValue\"]"));
            UpdatePasswordButton = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnEditPassword"));
            NewPassword = new EditField(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_tbPassword"));
            ConfirmPassword = new EditField(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_tbPasswordConfirm"));
            CancelUpdatePassword = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnCancelPassword"));
            SaveNewPassword = new Button(Driver, By.CssSelector("#RPMainPanel_controls_guardianlogin_guardianprofilehouseholdinformation_ascx54_btnSavePassword"));
        }
    }
}
