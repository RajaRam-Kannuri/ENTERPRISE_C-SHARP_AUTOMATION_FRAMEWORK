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
    public class FTCSASStudentTables : WebElement
    {
        public FTCSASStudentTables(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASStudentTables]
        public bool ConfirmAllStudentsAreAwardedStatus ()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status[0].Click();

                    if (!status[0].Text.Equals("Awarded"))
                        return false;
                }
            }
            return true;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool ConfirmAllStudentsAreDeniedStatus()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status[0].Click();

                    if (!status[0].Text.Equals("Denied"))
                        return false;
                }
            }
            return true;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool ConfirmAllStudentsArePendingStatus()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status[0].Click();

                    if (!status[0].Text.Equals("Pending"))
                        return false;
                }
            }
            return true;
        }
        [KeywordTestingFTCSASStudentTables]
        public bool ConfirmAllStudentsAreWaitListStatus()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> status = lineItem.FindElements(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status[0].Click();

                    if (!status[0].Text.Equals("Wait List"))
                        return false;
                }
            }
            return true;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFESStatusPendingByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[3].Text.Equals("Pending"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFESStatusAwardedByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[3].Text.Equals("Awarded"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFESStatusDeniedByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[3].Text.Equals("Denied"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFESStatusWaitListByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[3].Text.Equals("Wait List"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFTCStatusPendingByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[2].Text.Equals("Pending"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFTCStatusAwardedByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[2].Text.Equals("Awarded"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFTCStatusDeniedByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[2].Text.Equals("Denied"))
                            return true;
                    }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentTables]
        public bool VerifyStudentFTCStatusWaitListByStudentName(String name)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    if (lineItem.Text.Contains(name))
                    {
                        var fields = lineItem.FindElements(By.TagName("td"));

                        if (fields[2].Text.Equals("Wait List"))
                            return true;
                    }
                }
            }

            return false;
        }
    }
}
