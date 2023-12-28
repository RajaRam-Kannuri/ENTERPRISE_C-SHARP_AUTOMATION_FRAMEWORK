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
    public class ReimbursementDetailsModalProvider : WebElement
    {
        public ReimbursementDetailsModalProvider(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingReimbursementDetailsModalProvider]
        public bool VerifyItemStatusPendingByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    if (lineItems.Count == 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Pending"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else if (lineItems.Count > 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset[" + (lineItems.IndexOf(lineItem) + 1) + "]/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Pending"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingReimbursementDetailsModalProvider]
        public bool VerifyItemStatusApprovedByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    if (lineItems.Count == 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Approved"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else if (lineItems.Count > 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset[" + (lineItems.IndexOf(lineItem) + 1) + "]/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Approved"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingReimbursementDetailsModalProvider]
        public bool VerifyItemStatusDeniedByItemAmount(string text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains("Item Amount: $" + text))
                {
                    if (lineItems.Count == 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Denied"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else if (lineItems.Count > 1)
                    {
                        try
                        {
                            string status = lineItem.FindElement(By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset[" + (lineItems.IndexOf(lineItem) + 1) + "]/table/tbody/tr[8]/td[2]")).Text;
                            if (status.Equals("Denied"))
                                return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }
    }
}
