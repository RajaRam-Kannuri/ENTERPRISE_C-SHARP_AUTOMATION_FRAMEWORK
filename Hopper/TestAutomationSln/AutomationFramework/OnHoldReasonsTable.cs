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
    public class OnHoldReasonsTable : WebElement
    {
        public OnHoldReasonsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
		[KeywordTestingOnHoldReasonsTable]
		public bool VerifyFirstRowOnHoldReasonByText(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

			IWebElement reason = rows[1].FindElement(By.CssSelector("span[id$=\"lblOHReason\"]"));
            reason.Click();
            if (reason.Text.Equals(data))
                return true;

			return false;
		}

        [KeywordTestingOnHoldReasonsTable]
        public bool VerifySecondRowOnHoldReasonByText(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            IWebElement reason = rows[2].FindElement(By.CssSelector("span[id$=\"lblOHReason\"]"));
            reason.Click();
            if (reason.Text.Equals(data))
                return true;

            return false;
        }
    }
}
