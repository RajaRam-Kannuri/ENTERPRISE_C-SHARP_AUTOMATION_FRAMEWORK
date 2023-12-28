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
    public class SASTabInformation : WebElement
    {
        public SASTabInformation(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingSASTabInformation]
        public bool SelectAllYellowHighlightedItems()
        {
            IList<IWebElement> highlightedItems = this.FindElements(By.CssSelector("span[class*=\"yellowBG\"]"));

            foreach (var highlightedItem in highlightedItems)
            {
                highlightedItem.Click();
            }

            return true;
        }
    }
}
