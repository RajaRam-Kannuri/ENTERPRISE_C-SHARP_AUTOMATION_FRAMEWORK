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
    public class AribaPRTable : WebElement
    {
        public AribaPRTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingAribaPRTable]
        public bool SelectItemByPRNumber (string text)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    try
                    {
                        IList<IWebElement> columns = lineItem.FindElements(By.TagName("td"));
                        columns[4].Click();
                        break;
                    }
                    catch { }
                }
            }

            return true;
        }
    }
}
