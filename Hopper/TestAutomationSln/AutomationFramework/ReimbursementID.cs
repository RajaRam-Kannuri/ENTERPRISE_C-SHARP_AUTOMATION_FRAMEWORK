using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class ReimbursementID : WebElement
    {
        public ReimbursementID(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementID]
        public string CollectValue()
        {
            return this.Text.Split(' ')[7].Replace("#", "");
        }

        [KeywordTestingReimbursementID]
        public bool VerifyTextEquals(string expectedValue)
        {
            return CollectValue() == expectedValue;
        }
    }
}
