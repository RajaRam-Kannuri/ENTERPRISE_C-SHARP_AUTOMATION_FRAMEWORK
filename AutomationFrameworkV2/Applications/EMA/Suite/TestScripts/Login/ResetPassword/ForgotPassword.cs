using API;
using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using NUnit.Framework;
using RandomNameGen;

namespace TestSuite
{
    public class ForgotPassword : Selenium
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
        public void Florida_ResetPasswordPageText()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotPassword();
            SoftAssert.That(dashboard.GetRecoverUsernameText().Equals("Update Your Password"));
            SoftAssert.That(dashboard.GetInstructionsText().Equals("For added security, we will send a One-Time Password (OTP) to your email. Please enter a valid email address and verify the code."));
            SoftAssert.That(dashboard.GetEmailText().Equals("Email Address"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ResetPasswordButton()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotPassword();
            SoftAssert.That(dashboard.GetSendCodeButtonText().Equals("SEND CODE"));
            SoftAssert.That(dashboard.GetSendCodeButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetSendCodeButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotPasswordEmail()
        {
            var LoginDashboard = GetNLPLogix(FLORIDA).GetDashboard();

            LoginDashboard.CreateGuardianAccount("English").ClickLogOut();

            var dashboard = LoginDashboard.GetForgotPassword();
            dashboard.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickSendCode();
            APIEmailGenerator.GetVerificationCode("Florida");
            var ddashboard = dashboard.ClearVerificationCode().TypeVerificationCode(APIEmailGenerator.VERIFICATION_CODE).ClickConfirm()
                .ClickContinue()
                .ClearPassword().TypePassword(Credentials.PASSWORD)
                .ClearConfirmPassword().TypeConfirmPassword(Credentials.PASSWORD)
                .ClickSubmit();
            SoftAssert.That(ddashboard.getPortalHeader().Equals("Scholarship Portal"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotPasswordBackToLoginDashboard()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotPassword().ClickBackToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_ForgotPasswordInvalidEmail()
        {
            var dashboard = GetNLPLogix(FLORIDA).GetForgotPassword().ClearEmailAddress().TypeEmailAddress("Testing").ClickSendCode();
            SoftAssert.That(dashboard.GetErrorMessage().Equals("Please enter a valid email address."));
            SoftAssert.VerifyAll();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_ResetPasswordPageText()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotPassword();
            SoftAssert.That(dashboard.GetRecoverUsernameText().Equals("Update Your Password"));
            SoftAssert.That(dashboard.GetInstructionsText().Equals("For added security, we will send a One-Time Password (OTP) to your email. Please enter a valid email address and verify the code."));
            SoftAssert.That(dashboard.GetEmailText().Equals("Email Address"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ResetPasswordButton()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotPassword();
            SoftAssert.That(dashboard.GetSendCodeButtonText().Equals("SEND CODE"));
            SoftAssert.That(dashboard.GetSendCodeButtonBackgroundColor().Equals("rgba(227, 24, 55, 1)"));
            SoftAssert.That(dashboard.GetSendCodeButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotPasswordEmail()
        {
            var LoginDashboard = GetNLPLogix(WESTVIRGINA).GetDashboard();

            LoginDashboard.CreateGuardianAccount("English").ClickLogOut();

            var dashboard = LoginDashboard.GetForgotPassword();
            dashboard.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickSendCode();
            APIEmailGenerator.GetVerificationCode("Florida");
            var ddashboard = dashboard.ClearVerificationCode().TypeVerificationCode(APIEmailGenerator.VERIFICATION_CODE).ClickConfirm()
                .ClickContinue()
                .ClearPassword().TypePassword(Credentials.PASSWORD)
                .ClearConfirmPassword().TypeConfirmPassword(Credentials.PASSWORD)
                .ClickSubmit();
            SoftAssert.That(ddashboard.getPortalHeader().Equals("Scholarship Portal"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotPasswordBackToLoginDashboard()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotPassword().ClickBackToLogin();
            SoftAssert.That(dashboard.GetWelcomeText().Equals("Welcome!"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_ForgotPasswordInvalidEmail()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).GetForgotPassword().ClearEmailAddress().TypeEmailAddress("Testing").ClickSendCode();
            SoftAssert.That(dashboard.GetErrorMessage().Equals("Please enter a valid email address."));
            SoftAssert.VerifyAll();
        }

    }
}
