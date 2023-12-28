using System;
using Login_Dashboard;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using SidePanelDashboard;

namespace ForgotPassword_Dashboard
{
    public class ForgotPasswordDashboard : Dashboard
    {

        public ForgotPasswordDashboard(IWebDriver driver) : base(driver)
        {
        }

        public ForgotPasswordDashboard ClearEmailAddress()
        {
            FindTextField(By.Id("email")).Clear();
            return this;
        }

        public ForgotPasswordDashboard TypeEmailAddress(string email)
        {
            FindTextField(By.Id("email")).Type(email);
            return this;
        }

        public ForgotPasswordDashboard ClearVerificationCode()
        {
            FindTextField(By.Id("VerificationCode")).Clear();
            return this;
        }

        public ForgotPasswordDashboard TypeVerificationCode(string code)
        {
            FindTextField(By.Id("VerificationCode")).Type(code);
            return this;
        }
        public ForgotPasswordDashboard ClearPassword()
        {
            FindTextField(By.Id("newPassword")).Clear();
            return this;
        }

        public ForgotPasswordDashboard TypePassword(string password)
        {
            FindTextField(By.Id("newPassword")).Type(password);
            return this;
        }

        public ForgotPasswordDashboard ClearConfirmPassword()
        {
            FindTextField(By.Id("reenterPassword")).Clear();
            return this;
        }

        public ForgotPasswordDashboard TypeConfirmPassword(string password)
        {
            FindTextField(By.Id("reenterPassword")).Type(password);
            return this;
        }

        public ForgotPasswordDashboard ClickContinue()
        {
            FindButton(By.Id("continue")).Click();
            return this;
        }

        public Dashboard_Dashboard ClickSubmit()
        {
            FindButton(By.Id("continue")).Click();
            return new(driver);
        }

        public ForgotPasswordDashboard ClickConfirm()
        {
            FindButton(By.Id("emailVerificationControl_but_verify_code")).Click();
            return this;
        }

        public string GetRecoverUsernameText()
        {
            return FindTextField(By.XPath("(//h1)[2]")).GetText();
        }

        public string GetInstructionsText()
        {
            return FindTextField(By.Id("emailVerificationControl_info_message")).GetText();
        }

        public string GetEmailText()
        {
            return FindTextField(By.Id("email_label")).GetText();
        }

        public string GetSendCodeButtonText()
        {
            return FindButton(By.Id("emailVerificationControl_but_send_code")).GetText();
        }

        public string GetSendCodeButtonForegroundColor()
        {
            return FindButton(By.Id("emailVerificationControl_but_send_code")).GetFromCSSAttribute("color");
        }

        public string GetSendCodeButtonBackgroundColor()
        {
            return FindButton(By.Id("emailVerificationControl_but_send_code")).GetFromCSSAttribute("background-color");
        }

        public LoginDashboard ClickBackToLogin()
        {
            FindText(By.Id("cancel")).Click();
            return new(driver);
        }

        public LoginDashboard ClickSendCode()
        {
            FindText(By.Id("emailVerificationControl_but_send_code")).Click();
            return new(driver);
        }

        public string GetError()
        {
            return FindText(By.XPath("//div[@role='alert'][@aria-hidden='false']")).GetText();
        }

    }
}
