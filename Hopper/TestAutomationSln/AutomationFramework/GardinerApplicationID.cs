using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    [KeywordTesting]
    public class GardinerApplicationID : WebElement
    {
        public GardinerApplicationID(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingGardinerApplicationID]
        public string CollectValue()
        {
            return this.Text.Split(' ')[5].Replace("#", "");
        }

        [KeywordTestingGardinerApplicationID]
        public bool VerifyTextEquals(string expectedValue)
        {
            return CollectValue() == expectedValue;
        }
    }
}
