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
    public class ReimbursementLineItemsTable : WebElement
    {
        public ReimbursementLineItemsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementLineItemsTable]
        public bool SelectApproveByAmount(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("input[id$='rblProcessLineItem_0']")).Click();
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

        [KeywordTestingReimbursementLineItemsTable]
        public bool SelectDenyByAmount(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("input[id$='rblProcessLineItem_1']")).Click();
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

        [KeywordTestingReimbursementLineItemsTable]
        public bool SetRejectionReasonByAmount(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        var rejectionReason = row.FindElement(By.CssSelector("input[id$='tbTnFItemRejectionReason']"));
                        rejectionReason.Click();
                        rejectionReason.SendKeys(Keys.Control + "a");
                        rejectionReason.SendKeys(Keys.Delete);
                        rejectionReason.SendKeys("Rejection Reason");
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
