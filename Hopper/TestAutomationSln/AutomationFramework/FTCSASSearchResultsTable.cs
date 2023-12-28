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
    public class FTCSASSearchResultsTable : WebElement
    {
        public FTCSASSearchResultsTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickProcessLinkByAppID()
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

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickContactsLinkForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement btn = lineItem.FindElement(By.CssSelector("a[id$=\"lbContacts\"]"));
                    btn.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickStudentDetailsLinkForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement btn = lineItem.FindElement(By.CssSelector("a[id$=\"lbStudentDetail\"]"));
                    btn.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickStudentIDLinkForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement btn = lineItem.FindElement(By.CssSelector("a[id$=\"lbSetContext\"]"));
                    btn.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickConfirmEnrollmentLinkForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement btn = lineItem.FindElement(By.CssSelector("a[id$=\"lbConfirmEnrollment\"]"));
                    btn.Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingFTCSASSearchResultsTable]
        public bool ClickSCFLinkForFirstStudent()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IWebElement btn = lineItem.FindElement(By.CssSelector("a[id$=\"lbSCF\"]"));
                    btn.Click();
                    return true;
                }
            }

            return false;
        }
    }
}
