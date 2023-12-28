using API;
using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using NUnit.Framework;

namespace TestSuite
{
    public class FindMyStudents : Selenium
    {

        //======================================================================================================
        // Variable
        //======================================================================================================
        public string ENGLISH = "English";
        public string SPANISH = "Spanish";
        public string FLORIDA = "Florida";
        public string WESTVIRGINA = "West Virgina";

        //======================================================================================================
        // Test Methods - Florida
        //======================================================================================================

        [TestCase]
        public void Florida_FindStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickDashboard().ClickFindMyStudent();
            dashboard.ClickFindStudents().ClickProgram("UA")
                .ClearEmail().TypeEmail(APIEmailGenerator.EMAIL)
                .ClearPassword().TypeEmail(Credentials.PASSWORD)
                .ClickVerify();

            Assert.That(dashboard.GetAlert().Equals("Error Not Visable"));
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_FindStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickDashboard().ClickFindMyStudent();
            dashboard.ClickFindStudents().ClickProgram("HOPE")
                .ClearEmail().TypeEmail(APIEmailGenerator.EMAIL)
                .ClearPassword().TypeEmail(Credentials.PASSWORD)
                .ClickVerify();

            Assert.That(dashboard.GetAlert().Equals("Error Not Visable"));
        }

    }
}