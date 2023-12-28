using System;
using ForgotPassword_Dashboard;
using Login_Dashboard;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;

namespace ForgotUsername_Dashboard
{
    public class ForgotUsernameDashboard : Dashboard
    {

        public ForgotUsernameDashboard(IWebDriver driver) : base(driver)
        {
        }

        public ForgotUsernameDashboard ClearEmailAddress()
        {
            FindTextField(By.Id("email")).Clear();
            return this;
        }

        public ForgotUsernameDashboard TypeEmailAddress(string email)
        {
            FindTextField(By.Id("email")).Type(email);
            return this;
        }

        public ForgotUsernameDashboard ClickContinue()
        {
            FindButton(By.Id("continue")).Click();
            return this;
        }

        public string GetRecoverUsernameText()
        {
            return FindTextField(By.XPath("(//h1)[2]")).GetText();
        }

        public string GetInstructionsText()
        {
            return FindTextField(By.XPath("//h5")).GetText();
        }

        public string GetEmailText()
        {
            return FindTextField(By.Id("email_label")).GetText();
        }

        public string GetContinueButtonText()
        {
            return FindText(By.Id("continue")).GetText();
        }

        public string GetContinueButtonForegroundColor()
        {
            return FindButton(By.Id("continue")).GetFromCSSAttribute("color");
        }

        public string GetContinueButtonBackgroundColor()
        {
            return FindButton(By.Id("continue")).GetFromCSSAttribute("background-color");
        }

        public string GetConfirmationText()
        {
            return FindText(By.Id("userMessage")).GetText();
        }

        public string GetAnyIssueText()
        {
            return FindText(By.XPath("(//h4)[1]")).GetText();
        }

        public string GetReturnToLoginText()
        {
            return FindText(By.XPath("(//h4)[2]")).GetText();
        }

        public LoginDashboard ClickReturnToLogin()
        {
            FindText(By.XPath("(//h4)[2]//a")).Click();
            return new(driver);
        }

        public string GetBackToLoginText()
        {
            return FindText(By.Id("cancel")).GetText();
        }

        public LoginDashboard ClickBackToLogin()
        {
            FindText(By.Id("cancel")).Click();
            return new(driver);
        }

        public string GetErrorMessage1()
        {
            return FindText(By.XPath("(//div[@role='alert'])[1]")).GetText();
        }

        public string GetErrorMessage2()
        {
            return FindText(By.XPath("(//div[@role='alert'])[2]")).GetText();
        }

    }
}
