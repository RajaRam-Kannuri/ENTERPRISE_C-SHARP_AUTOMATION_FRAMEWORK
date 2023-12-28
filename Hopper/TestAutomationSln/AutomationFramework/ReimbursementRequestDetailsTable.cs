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
    public class ReimbursementRequestDetailsTable : WebElement
    {
        public ReimbursementRequestDetailsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingReimbursementRequestDetailsTable]
        public bool ClickApprovedByTotalAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Total:$" + text))
                {
                    try
                    {
                        IWebElement ddl = lineItem.FindElement(By.Id("sctClaimItemStatus"));
                        ddl.Click();
                        IList<IWebElement> options = ddl.FindElements(By.TagName("option"));
                        IWebElement desiredOption = options.Where(op => op.Text.Contains("App")).ToList().FirstOrDefault();
                        if (desiredOption != null) new SelectElement(ddl).SelectByValue(desiredOption.GetAttribute("value"));
                    }
                    catch
                    {
                        break;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
