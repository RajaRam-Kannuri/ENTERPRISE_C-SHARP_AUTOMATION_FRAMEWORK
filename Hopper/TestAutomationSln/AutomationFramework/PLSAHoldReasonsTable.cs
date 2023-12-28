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
    public class PLSAHoldReasonsTable : WebElement
    {
        public PLSAHoldReasonsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingPLSAHoldReasonsTable]
        public bool ClickClearedForEachReason()
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {

                var checkboxes = lineItem.FindElements(By.TagName("input"));

                foreach (var checkbox in checkboxes)
                {
                    try
                    {
                        checkbox.Click();
                    }
                    catch { }
                }

                return true;
            }

            return false;
        }
    }
}
