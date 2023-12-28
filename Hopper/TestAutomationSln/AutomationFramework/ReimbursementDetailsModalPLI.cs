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
    public class ReimbursementDetailsModalPLI : WebElement
    {
        public ReimbursementDetailsModalPLI(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementDetailsModalPLI]
        public bool VerifyItemStatusPendingByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    try
                    {
                        string status = lineItem.FindElement(By.CssSelector(".reimbursementItemStatus")).Text;
                        if (status.Equals("Pending"))
                            return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        [KeywordTestingReimbursementDetailsModalPLI]
        public bool VerifyItemStatusApprovedByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    try
                    {
                        string status = lineItem.FindElement(By.CssSelector(".reimbursementItemStatus")).Text;
                        if (status.Equals("Approved"))
                            return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        [KeywordTestingReimbursementDetailsModalPLI]
        public bool VerifyItemStatusDeniedByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    try
                    {
                        string status = lineItem.FindElement(By.CssSelector(".reimbursementItemStatus")).Text;
                        if (status.Equals("Denied"))
                            return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        [KeywordTestingReimbursementDetailsModalPLI]
        public bool VerifyDenialReasonExistsByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    if (lineItem.Text.Contains("Denial Reason:"))
                        return true;
                    break;
                }
            }

            return false;
        }
    }
}
