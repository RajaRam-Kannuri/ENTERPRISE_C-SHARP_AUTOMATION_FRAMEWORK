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
    public class GARReimbursementQueueTable : WebElement
    {
        public GARReimbursementQueueTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingGARReimbursementQueueTable]
        public bool VerifyReimbursementReviewCompleteByReimbursementID(string id)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(id))
                {
                    IList<IWebElement> cells = row.FindElements(By.TagName("td"));
                    if (cells[1].Text.Equals("Review Complete"))
                        return true;
                }
            }

            return false;
        }
    }
}
