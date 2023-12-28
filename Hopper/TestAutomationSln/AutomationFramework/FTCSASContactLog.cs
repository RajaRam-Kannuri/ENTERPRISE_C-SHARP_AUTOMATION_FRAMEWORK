using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    [KeywordTesting]
    public class FTCSASContactLog : WebElement
    {
        public FTCSASContactLog(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASContactLog]
        public bool VerifyContactLogContainsText(string text)
        {
            var lineItem = Locate();

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {
                if(row.Text.Contains(text))
                    return true;
            }

            return false;
        }
    }
}
