using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using NUnit.Framework;
using RandomNameGen;

namespace TestSuite
{
    public class Login : Selenium
    {
        //======================================================================================================
        // Variable
        //======================================================================================================
        public string ENGLISH = "English";
        public string SPANISH = "Spanish";
        public string FLORIDA = "Florida";
        public string WESTVIRGINA = "West Virgina";
        SoftAssertion.SoftAssert SoftAssert = new SoftAssertion.SoftAssert();
        //======================================================================================================
        // Test Methods
        //======================================================================================================

        [TestCase]
        public void Florida_LoginPageText()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetLogin();
            SoftAssert.That(dashboard.GetUsernameText().Equals("Username"));
            SoftAssert.That(dashboard.GetForgotUsernameText().Equals("Forgot Username?"));
            SoftAssert.That(dashboard.GetPasswordText().Equals("Password"));
            SoftAssert.That(dashboard.GetForgotPasswordText().Equals("Forgot Password?"));
            SoftAssert.That(dashboard.GetKeepMeSignedInText().Equals("Keep me signed in"));
            SoftAssert.That(dashboard.GetDontHaveAccountText().Equals("Don't have an account?Sign Up"));
            SoftAssert.That(dashboard.GetSUFSTeamMemberText().Equals("Sign In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_LoginPageButton()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetLogin();
            SoftAssert.That(dashboard.GetLoginButtonText().Equals("LOG IN"));
            SoftAssert.That(dashboard.GetLoginButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetLoginButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_LoginPageFailedLoginAttempts()
        {
            var LoginDashboard = GetNLPLogix(FLORIDA).GetDashboard();
            LoginDashboard.CreateGuardianAccount("English")
                .ClickLogOut();

            var ldashboard = LoginDashboard.GetLogin();
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), LoginDashboard.GetUsername());
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), Credentials.PASSWORD);
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your account is temporarily locked to prevent unauthorized use. Try again later"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_LoginPageNoUserAttempt()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetDashboard();
            var ldashboard = dashboard.GetLogin();
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            SoftAssert.VerifyAll();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_LoginPageText()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetLogin();
            SoftAssert.That(dashboard.GetUsernameText().Equals("Username"));
            SoftAssert.That(dashboard.GetForgotUsernameText().Equals("Forgot Username?"));
            SoftAssert.That(dashboard.GetPasswordText().Equals("Password"));
            SoftAssert.That(dashboard.GetForgotPasswordText().Equals("Forgot Password?"));
            SoftAssert.That(dashboard.GetKeepMeSignedInText().Equals("Keep me signed in"));
            SoftAssert.That(dashboard.GetDontHaveAccountText().Equals("Don't have an account?Sign Up"));
            SoftAssert.That(dashboard.GetSUFSTeamMemberText().Equals("Sign In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_LoginPageButton()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetLogin();
            SoftAssert.That(dashboard.GetLoginButtonText().Equals("LOG IN"));
            SoftAssert.That(dashboard.GetLoginButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetLoginButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_LoginPageFailedLoginAttempts()
        {
            var LoginDashboard = GetNLPLogix(WESTVIRGINA).GetDashboard();
            LoginDashboard.CreateGuardianAccount("English")
                .ClickLogOut();

            var ldashboard = LoginDashboard.GetLogin();
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), LoginDashboard.GetUsername());
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "!@#$%^&*()");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your password is incorrect"));
            LoginDashboard.LoginWith(LoginDashboard.GetUsername(), Credentials.PASSWORD);
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("Your account is temporarily locked to prevent unauthorized use. Try again later"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_LoginPageNoUserAttempt()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetDashboard();
            var ldashboard = dashboard.GetLogin();
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            dashboard.LoginWith("Test", "Test");
            SoftAssert.That(ldashboard.GetErrorMessage().Equals("We can't seem to find your account"));
            SoftAssert.VerifyAll();
        }

    }
}
