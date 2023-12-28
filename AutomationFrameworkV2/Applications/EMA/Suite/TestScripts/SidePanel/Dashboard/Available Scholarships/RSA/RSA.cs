using Microsoft.AspNetCore.Mvc.Diagnostics;
using NLPLogix.Core.Abstract;
using NPOI.HPSF;
using NUnit.Framework;
using SidePanelDashboard;

namespace TestSuite
{
    public class RSA : Selenium
    {
        //======================================================================================================
        // Variable
        //======================================================================================================
        public string ENGLISH = "English";
        public string SPANISH = "Spanish";
        public string FLORIDA = "Florida";
        public string WESTVIRGINA = "West Virgina";
        public static string ApplicationType;
        //======================================================================================================
        // Test Methods - Florida
        //======================================================================================================

        [TestCase]
        public void CanNavigateToCreateRSAApplication()
        {
            ApplicationType = "Reading Application";
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var application = student.ClickDashboard().ClickApplyRSA();

            Assert.That(application.getHeader().Contains("New Worlds Reading Scholarship Accounts"));
        }

        [TestCase]
        public void CreateRSAApplication()
        {
            ApplicationType = "Reading Application";
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var applications = student.ClickDashboard();
            applications.CreateRSAApplication();

            Assert.That(applications.RSASuccessfullySubmitted().Equals(true));
        }

    }

}
