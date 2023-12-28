using ForgotPassword_Dashboard;
using ForgotUsername_Dashboard;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using SignUp;

namespace Login_Dashboard
{
    public class LoginDashboard : Dashboard
    {

        public LoginDashboard(IWebDriver driver) : base(driver)
        {
        }

        public LoginDashboard ClearUsername()
        {
            FindTextField(By.Id("logonIdentifier")).Clear();
            return this;
        }

        public LoginDashboard TypeUsername(string username)
        {
            FindTextField(By.Id("logonIdentifier")).Type(username);
            return this;
        }

        public LoginDashboard ClearPassword()
        {
            FindTextField(By.Id("password")).Clear();
            return this;
        }

        public LoginDashboard TypePassword(string password)
        {
            FindTextField(By.Id("password")).Type(password);
            return this;
        }

        public LoginDashboard ClickLogin()
        {
            FindButton(By.Id("next")).Click();
            return this;
        }

        public Signup_Dashboard ClickSignup()
        {
            FindText(By.Id("createAccount")).Click();
            return new(driver);
        }

        public string GetEMAWelcomeImage()
        {
            return FindImage(By.XPath("//div[@class='logo']")).GetSource();
        }

        public string GetLeftHandImageWelcomeImage()
        {
            return FindImage(By.XPath("//div[@class='child-Pic']")).GetSource();
        }

        public string GetWelcomeText()
        {
            return FindText(By.XPath("(//h1)[2]")).GetText();
        }

        public string GetUsernameText()
        {
            return FindText(By.XPath("//label[@for='logonIdentifier']")).GetText();
        }

        public string GetForgotUsernameText()
        {
            return FindText(By.Id("ForgotUsernameExchange")).GetText();
        }

        public string GetForgotUsernameLink()
        {
            return FindText(By.Id("ForgotUsernameExchange")).GetFromHTMLAttribute("href");
        }

        public ForgotUsernameDashboard ClickForgotUsername()
        {
            FindText(By.Id("ForgotUsernameExchange")).Click();
            return new(driver);
        }

        public string GetPasswordText()
        {
            return FindText(By.XPath("//label[@for='password']")).GetText();
        }

        public string GetForgotPasswordText()
        {
            return FindText(By.Id("forgotPassword")).GetText();
        }

        public string GetForgotPasswordLink()
        {
            return FindText(By.Id("forgotPassword")).GetFromHTMLAttribute("href");
        }

        public ForgotPasswordDashboard ClickForgotPassword()
        {
            FindText(By.Id("forgotPassword")).Click();
            return new(driver);
        }

        public string GetKeepMeSignedInText()
        {
            return FindText(By.XPath("//label[@for='rememberMe']")).GetText();
        }

        public string GetLoginButtonText()
        {
            return FindText(By.Id("next")).GetText();
        }

        public string GetLoginButtonForegroundColor()
        {
            return FindButton(By.Id("next")).GetFromCSSAttribute("color");
        }

        public string GetLoginButtonBackgroundColor()
        {
            return FindButton(By.Id("next")).GetFromCSSAttribute("background-color");
        }

        public string GetDontHaveAccountText()
        {
            return FindText(By.XPath("(//p)[6]")).GetText();
        }

        public string GetDontHaveAccountSignUpLink()
        {
            return FindText(By.Id("createAccount")).GetFromHTMLAttribute("href");
        }

        public string GetSUFSTeamMemberText()
        {
            return FindText(By.XPath("//*[@role='form']")).GetText();
        }

        public string GetSUFSTeamMemberSignInLink()
        {
            return FindText(By.XPath("AADScholarFLExchange")).GetFromHTMLAttribute("href");
        }

        public string GetErrorMessage()
        {
            return FindText(By.XPath("//div[@role='alert'][@aria-hidden='false']")).GetText();
        }

    }
}
