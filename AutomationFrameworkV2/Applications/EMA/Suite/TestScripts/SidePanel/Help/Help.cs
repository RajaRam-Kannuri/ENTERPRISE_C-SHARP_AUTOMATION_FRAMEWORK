using NLPLogix.Core.Abstract;
using NUnit.Framework;
using RandomNameGen;

namespace TestSuite
{
    public class NavigatingToHelp : Selenium
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
        public void Florida_CanNavigateToHelp()
        {
            GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickHelp();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_CanNavigateToHelp()
        {
            GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickHelp();
        }


    }

}
