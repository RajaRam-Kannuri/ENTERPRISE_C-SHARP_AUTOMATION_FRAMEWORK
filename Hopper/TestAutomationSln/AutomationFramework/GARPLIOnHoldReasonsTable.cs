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
    public class GARPLIOnHoldReasonsTable : WebElement
    {
        public GARPLIOnHoldReasonsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
		[KeywordTestingGARPLIOnHoldReasonsTable]
		public bool VerifyFirstRowOnHoldReasonByPartialText(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            if (rows[1].Text.Contains(data))
                return true;

            return false;
        }

        [KeywordTestingGARPLIOnHoldReasonsTable]
        public bool VerifyFirstRowExplanationByPartialText(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            if (rows[1].Text.Contains(data))
                return true;

            return false;
        }

        [KeywordTestingGARPLIOnHoldReasonsTable]
        public bool VerifySecondRowOnHoldReasonByPartialText(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            if (rows[2].Text.Contains(data))
                return true;

            return false;
        }

        [KeywordTestingGARPLIOnHoldReasonsTable]
        public bool VerifySecondRowExplanationByPartialText(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            if (rows[2].Text.Contains(data))
                return true;

            return false;
        }
    }
}
