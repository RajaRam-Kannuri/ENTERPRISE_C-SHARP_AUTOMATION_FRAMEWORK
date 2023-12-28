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
    public class SASStudentTable : WebElement
    {
        public SASStudentTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingSASStudentTable]
        public bool VerifyAllStudentsHaveEligibilityLetter()
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {

                var fields = lineItem.FindElements(By.TagName("td"));

                if (!fields[3].Text.Equals(""))
                    return true;
            }

            return false;
        }

        [KeywordTestingSASStudentTable]
        public bool VerifyAllStudentsHaveDenialLetter()
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {

                var fields = lineItem.FindElements(By.TagName("td"));

                if (!fields[4].Text.Equals(""))
                    return true;
            }

            return false;
        }

        [KeywordTestingSASStudentTable]
        public bool VerifyAllStudentsHaveWaitListLetter()
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {

                var fields = lineItem.FindElements(By.TagName("td"));

                if (!fields[5].Text.Equals(""))
                    return true;
            }

            return false;
        }

        [KeywordTestingSASStudentTable]
        public bool VerifyAllStudentStatusesByText(String text)
        {
            List<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {

                var fields = lineItem.FindElements(By.TagName("td"));

                if (fields[2].Text.Equals(text))
                    return true;
            }

            return false;
        }

        [KeywordTestingSASStudentTable]
        public bool VerifyStudentStatusPendingByStudentName(String name)
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

        [KeywordTestingSASStudentTable]
        public bool VerifyStudentStatusAwardedByStudentName(String name)
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

        [KeywordTestingSASStudentTable]
        public bool VerifyStudentStatusDeniedByStudentName(String name)
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

        [KeywordTestingSASStudentTable]
        public bool VerifyStudentStatusWaitListByStudentName(String name)
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
