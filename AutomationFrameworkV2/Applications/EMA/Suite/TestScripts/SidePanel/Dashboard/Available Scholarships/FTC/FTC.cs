using System;
using System.Threading;
using NLPLogix.Core.Abstract;
using NUnit.Framework;

namespace TestSuite
{
    public class FTC : Selenium
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
        public void CanNavigateToCreateFTCApplication()
        {
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var application = student.ClickDashboard().ClickApplyFTC().ClickContinue();

            Assert.That(application.getHeader().Contains("FTC/FES-EO Application"));
        }

        [TestCase]
        public void CreateFTCApplication()
        {
            var studentdashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            var student = studentdashboard.CreateStudent();
            var applications = student.ClickDashboard();
            applications.CreateFTCApplication();

            Assert.That(applications.DoesApplicationExist().Equals(true));
        }

    }

}
