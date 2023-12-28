using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class Tab : WebElement
    {
        public Tab(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingTab]
        [KeywordTestingVerificationMethod]
        public bool VerifyTabTextEquals(string tabText)
        {
            return this.Text == tabText;
        }
    }
}
