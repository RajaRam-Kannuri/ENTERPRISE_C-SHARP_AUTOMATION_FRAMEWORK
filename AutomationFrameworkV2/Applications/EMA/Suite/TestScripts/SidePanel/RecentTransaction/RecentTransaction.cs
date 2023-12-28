using NLPLogix.Core.Abstract;
using NUnit.Framework;
using RandomNameGen;

namespace TestSuite
{
    public class RecentTransaction : Selenium
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
        public void Florida_CanNavigateToRecentTransaction()
        {
            GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickRecentTransaction();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_CanNavigateToRecentTransaction()
        {
            GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickRecentTransaction();
        }


    }

}
