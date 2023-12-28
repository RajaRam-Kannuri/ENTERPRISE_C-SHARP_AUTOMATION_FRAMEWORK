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
    public class AribaOrdersTable : WebElement
    {
        public AribaOrdersTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
        }

        [KeywordTestingAribaOrdersTable]
        public bool ClickOrderLinkByOrderSASNumber(string number)
        {
            Thread.Sleep(3000);

            List<IWebElement> rows = this.Body().Rows();

            foreach (var row in rows)
            {
                if (row.Text.Contains(number))
                {
                    IList<IWebElement> columns = row.FindElements(By.TagName("td"));
                    columns[0].Click();
                    return true;
                }
            }

            return false;
        }
    }
}
