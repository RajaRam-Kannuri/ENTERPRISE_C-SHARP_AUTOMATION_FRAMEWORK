using Microsoft.AspNetCore.Mvc.Diagnostics;
using NLPLogix.Core.Abstract;
using NPOI.HPSF;
using NUnit.Framework;
using SidePanelDashboard;

namespace TestSuite
{
    public class HOPE : Selenium
    {
        //======================================================================================================
        // Variable
        //======================================================================================================
        public string ENGLISH = "English";
        public string SPANISH = "Spanish";
        public string FLORIDA = "Florida";
        public string WESTVIRGINA = "West Virgina";
        SoftAssertion.SoftAssert SoftAssert = new SoftAssertion.SoftAssert();
        public static string ApplicationType;
        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void CanNavigateToCreateHopeApplication()
        {
            var studentdashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var application = student.ClickDashboard().ClickApplyHope();

            Assert.That(application.getHeader().Contains("Hope Scholarship"));
        }

        [TestCase]
        public void CreateHopeApplication()
        {
            var studentdashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var applications = student.ClickDashboard();
            applications.CreateHopeApplication();

            Assert.That(applications.RSASuccessfullySubmitted().Equals(true));
        }

    }

}
