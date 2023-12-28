using DocumentFormat.OpenXml.Spreadsheet;
using Interfaces;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SecurityQuestions;

namespace SignUp
{
    public class Signup_Dashboard : Dashboard
    {
        public Signup_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public Signup_Dashboard SelectAccountType(string option)
        {
            FindDropdown(By.Id("extension_accountType")).SelectOption(option);
            return this;
        }

        public Signup_Dashboard ClearEmailAddress()
        {
            FindTextField(By.Id("email")).Clear();
            return this;
        }

        public Signup_Dashboard TypeEmailAddress(string emailAddress)
        {
            FindTextField(By.Id("email")).Type(emailAddress);
            return this;
        }

        public Signup_Dashboard ClickSendCode()
        {
            FindButton(By.Id("emailVerificationControl_but_send_code")).Click();
            return this;
        }

        public Signup_Dashboard ClearVerificationCode()
        {
            FindTextField(By.Id("VerificationCode")).Clear();
            return this;
        }

        public Signup_Dashboard TypeVerificationCode(string verificationCode)
        {
            FindTextField(By.Id("VerificationCode")).Type(verificationCode);
            return this;
        }

        public Signup_Dashboard ClickConfirm()
        {
            FindButton(By.Id("emailVerificationControl_but_verify_code")).Click();
            return this;
        }

        public Signup_Dashboard ClickContinue()
        {
            FindButton(By.Id("continue")).Click();
            return this;
        }

        public Signup_Dashboard ClearUsername()
        {
            FindTextField(By.Id("UserId")).Clear();
            return this;
        }

        public Signup_Dashboard TypeUsername(string Username)
        {
            FindTextField(By.Id("UserId")).Type(Username);
            return this;
        }

        public Signup_Dashboard ClearFirstName()
        {
            FindTextField(By.Id("givenName")).Clear();
            return this;
        }

        public Signup_Dashboard TypeFirstName(string firstName)
        {
            FindTextField(By.Id("givenName")).Type(firstName);
            return this;
        }

        public Signup_Dashboard ClearLastName()
        {
            FindTextField(By.Id("surname")).Clear();
            return this;
        }

        public Signup_Dashboard TypeLastName(string lastName)
        {
            FindTextField(By.Id("surname")).Type(lastName);
            return this;
        }

        public Signup_Dashboard ClearCreatePassword()
        {
            FindTextField(By.Id("newPassword")).Clear();
            return this;
        }

        public Signup_Dashboard TypeCreatePassword(string createPassword)
        {
            FindTextField(By.Id("newPassword")).Type(createPassword);
            return this;
        }

        public Signup_Dashboard ClearConfirmPassword()
        {
            FindTextField(By.Id("reenterPassword")).Clear();
            return this;
        }

        public Signup_Dashboard TypeConfirmPassword(string confirmPassword)
        {
            FindTextField(By.Id("reenterPassword")).Type(confirmPassword);
            return this;
        }

        public SecurityQuestions_Dashboard ClickContinueToProfile()
        {
            MoveTo.BottomOfPage(driver);
            FindButton(By.Id("continue")).Click();
            return new(driver);
        }

    }
}
