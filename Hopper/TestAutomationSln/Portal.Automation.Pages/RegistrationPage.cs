using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Portal.Automation.Pages
{
    public class RegistrationPage : PortalBasePage
    {
        public EditField FirstNameTextBox { get; private set; }
        public EditField EmailTextBox { get; private set; }
        public EditField UserNameTextBox { get; private set; }
        public EditField PasswordTextBox { get; private set; }
        public EditField ConfirmPasswordTextBox { get; private set; }
        public Text LoginLink { get; private set; }
        public Button CreateMyAccountButton { get; private set; }
        public Text FirstNameIsRequiredMessage { get; private set; }
        public Text EmailIsRequiredMessage { get; private set; }
        public Text UserIDIsRequiredMessage { get; private set; }
        public Text PasswordIsRequiredMessage { get; private set; }
        public Text FirstNameInvalidCharactersMessage { get; private set; }
        public Text EmailFieldIsNotValidEmailAddressMessage { get; private set; }
        public Text UserIDMustContainAtLeast5CharactersMessage { get; private set; }
        public Text UserIDMayContainOnlyNumbersAndLettersMessage { get; private set; }
        public Text PasswordAndConfirmationPasswordDoNotMatchMessage { get; private set; }
        public Text HavingProblemsLink { get; private set; }
        public OLAAccountActivation ActivateAccountUtility { get; private set; }

        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
            FirstNameTextBox = new EditField(Driver, By.Id("FirstName"));
            EmailTextBox = new EditField(Driver, By.Id("Email"));
            UserNameTextBox = new EditField(Driver, By.Id("UserName"));
            PasswordTextBox = new EditField(Driver, By.Id("Password"));
            ConfirmPasswordTextBox = new EditField(Driver, By.Id("ConfirmPassword"));
            LoginLink = new Text(Driver, By.XPath("//a[text() = 'Login']"));
            //CreateMyAccountButton = new Button(Driver, By.XPath("//button[text() = 'Create My Account']"));
            CreateMyAccountButton = new Button(Driver, By.CssSelector("#registration-form > div:nth-child(9) > div > button"));
            FirstNameIsRequiredMessage = new Text(Driver, By.Id("FirstName-error"));
            EmailIsRequiredMessage = new Text(Driver, By.Id("Email-error"));
            UserIDIsRequiredMessage = new Text(Driver, By.Id("UserName-error"));
            PasswordIsRequiredMessage = new Text(Driver, By.Id("Password-error"));
            FirstNameInvalidCharactersMessage = new Text(Driver, By.Id("FirstName-error"));
            EmailFieldIsNotValidEmailAddressMessage = new Text(Driver, By.Id("Email-error"));
            UserIDMustContainAtLeast5CharactersMessage = new Text(Driver, By.Id("UserName-error"));
            UserIDMayContainOnlyNumbersAndLettersMessage = new Text(Driver, By.Id("UserName-error"));
            PasswordAndConfirmationPasswordDoNotMatchMessage = new Text(Driver, By.Id("ConfirmPassword-error"));
            HavingProblemsLink = new Text(Driver, By.CssSelector("body > div.container.card-container.ids-container.sendverify-container > div > div > div > div > p:nth-child(4) > a"));
            ActivateAccountUtility = new OLAAccountActivation(Driver, By.Id(""));
        }
    }
}
