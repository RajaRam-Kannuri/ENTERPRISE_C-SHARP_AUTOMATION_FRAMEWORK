using NLPLogix.Core.Abstract;
using NUnit.Framework;

namespace TestSuite
{
    public class UA : Selenium
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
        public void CanNavigateToCreateUAApplication()
        {
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var application = student.ClickDashboard().ClickApplyUA().ClickContinue();

            Assert.That(application.getHeader().Contains("FES-UA Application"));
        }

        [TestCase]
        public void CreateUAApplication()
        {
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var applications = student.ClickDashboard();
            applications.CreateUAApplication();

            Assert.That(applications.DoesApplicationExist().Equals(true));
        }

    }

}
