using API;
using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using NUnit.Framework;

namespace TestSuite
{
    public class ForgotUsername : Selenium
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
        // Test Methods - Florida
        //======================================================================================================

        [TestCase]
        public void Florida_ForgotUsernamePageText()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername();
            SoftAssert.That(dashboard.GetRecoverUsernameText().Equals("Recover Your Username"));
            SoftAssert.That(dashboard.GetInstructionsText().Equals("We'll email you instructions to recover your username."));
            SoftAssert.That(dashboard.GetEmailText().Equals("Email Address"));
            SoftAssert.That(dashboard.GetBackToLoginText().Equals("Sign In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameButton()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername();
            SoftAssert.That(dashboard.GetContinueButtonText().Equals("Continue"));
            SoftAssert.That(dashboard.GetContinueButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetContinueButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameEmailSentConfirmation()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername();
            dashboard.ClearEmailAddress().TypeEmailAddress("Testing@NLPQATesting.com").ClickContinue();
            SoftAssert.That(dashboard.GetConfirmationText().Equals("Your username has been sent to your email. To continue open your mailbox, copy the username and login again."));
            SoftAssert.That(dashboard.GetAnyIssueText().Equals("If you have any issues, please contact us at 1-877-735-7837."));
            SoftAssert.That(dashboard.GetReturnToLoginText().Equals("Return to Log In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameReturnToLoginDashboard()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername().ClearEmailAddress().TypeEmailAddress("Testing@NLPQATesting.com").ClickContinue().ClickReturnToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameBackToLoginDashboard()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername().ClickBackToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameConfirmEmailWasSent()
        {
            var LoginDashboard = GetNLPLogix(FLORIDA).GetDashboard();

            LoginDashboard.CreateGuardianAccount("English").ClickLogOut();

            var dashboard = LoginDashboard.GetForgotUsername();
            dashboard.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickContinue();
            SoftAssert.That(dashboard.GetConfirmationText().Equals("Your username has been sent to your email. To continue open your mailbox, copy the username and login again."));
            APIEmailGenerator.GetUsernameCode();
            SoftAssert.That(APIEmailGenerator.USERNAME.Equals(LoginDashboard.GetUsername()));
            dashboard.ClickReturnToLogin();
            var dDashboard = LoginDashboard.LoginWith(APIEmailGenerator.USERNAME, Credentials.PASSWORD);
            SoftAssert.That(dDashboard.getPortalHeader().Equals("Scholarship Portal"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotUsernameInvalidEmail()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotUsername().ClearEmailAddress().TypeEmailAddress("Testing").ClickContinue();
            SoftAssert.That(dashboard.GetErrorMessage1().Equals("One or more fields are filled out incorrectly. Please check your entries and try again."));
            SoftAssert.That(dashboard.GetErrorMessage2().Equals("Please enter a valid email address."));
            SoftAssert.VerifyAll();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_ForgotUsernamePageText()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername();
            SoftAssert.That(dashboard.GetRecoverUsernameText().Equals("Recover Your Username"));
            SoftAssert.That(dashboard.GetInstructionsText().Equals("We'll email you instructions to recover your username."));
            SoftAssert.That(dashboard.GetEmailText().Equals("Email Address"));
            SoftAssert.That(dashboard.GetBackToLoginText().Equals("Sign In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameButton()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername();
            SoftAssert.That(dashboard.GetContinueButtonText().Equals("Continue"));
            SoftAssert.That(dashboard.GetContinueButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetContinueButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameEmailSentConfirmation()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername();
            dashboard.ClearEmailAddress().TypeEmailAddress("Testing@NLPQATesting.com").ClickContinue();
            SoftAssert.That(dashboard.GetConfirmationText().Equals("Your username has been sent to your email. To continue open your mailbox, copy the username and login again."));
            SoftAssert.That(dashboard.GetAnyIssueText().Equals("If you have any issues, please contact us at 1-877-735-7837."));
            SoftAssert.That(dashboard.GetReturnToLoginText().Equals("Return to Log In"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameReturnToLoginDashboard()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername().ClearEmailAddress().TypeEmailAddress("Testing@NLPQATesting.com").ClickContinue().ClickReturnToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameBackToLoginDashboard()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername().ClickBackToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameConfirmEmailWasSent()
        {
            var LoginDashboard = GetNLPLogix(WESTVIRGINA).GetDashboard();

            LoginDashboard.CreateGuardianAccount("English").ClickLogOut();

            var dashboard = LoginDashboard.GetForgotUsername();
            dashboard.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickContinue();
            SoftAssert.That(dashboard.GetConfirmationText().Equals("Your username has been sent to your email. To continue open your mailbox, copy the username and login again."));
            APIEmailGenerator.GetUsernameCode();
            SoftAssert.That(APIEmailGenerator.USERNAME.Equals(LoginDashboard.GetUsername()));
            dashboard.ClickReturnToLogin();
            var dDashboard = LoginDashboard.LoginWith(APIEmailGenerator.USERNAME, Credentials.PASSWORD);
            SoftAssert.That(dDashboard.getPortalHeader().Equals("Scholarship Portal"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotUsernameInvalidEmail()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotUsername().ClearEmailAddress().TypeEmailAddress("Testing").ClickContinue();
            SoftAssert.That(dashboard.GetErrorMessage1().Equals("One or more fields are filled out incorrectly. Please check your entries and try again."));
            SoftAssert.That(dashboard.GetErrorMessage2().Equals("Please enter a valid email address."));
            SoftAssert.VerifyAll();
        }

    }
}
