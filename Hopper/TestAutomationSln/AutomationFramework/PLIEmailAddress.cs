using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationFramework
{
    [KeywordTesting]
    public class PLIEmailAddress : CustomWebElement
    {
        public PLIEmailAddress(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingPLIEmailAddress]
        public string CollectValue()
        {
            string subString = this.Text.Substring(0, this.Text.Length - 2);

            return subString;
        }

    }
}
