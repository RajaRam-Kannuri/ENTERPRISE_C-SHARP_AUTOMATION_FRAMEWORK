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
    public class ScholarshipChildrenStatusTable : WebElement
    {
        public ScholarshipChildrenStatusTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
		[KeywordTestingScholarshipChildrenStatusTable]
		public bool VerifyStudentStatusIsSuspendedByStudentName(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

			foreach (var row in rows)
			{
				if (row.Text.Contains(data))
				{
					IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
					status.Click();
					if (status.Text.Equals("Suspended"))
						return true;
				}
			}

			return false;
		}

		[KeywordTestingScholarshipChildrenStatusTable]
		public bool VerifyStudentStatusIsAwardedByStudentName(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

			foreach (var row in rows)
			{
				if (row.Text.Contains(data))
				{
					IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
					status.Click();
					if (status.Text.Equals("Awarded"))
						return true;
				}
			}

			return false;
		}

		[KeywordTestingScholarshipChildrenStatusTable]
		public bool VerifyStudentStatusIsRevokedByStudentName(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

			foreach (var row in rows)
			{
				if (row.Text.Contains(data))
				{
					IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
					status.Click();
					if (status.Text.Equals("Revoked"))
						return true;
				}
			}

			return false;
		}

        [KeywordTestingScholarshipChildrenStatusTable]
        public bool VerifyStudentStatusIsEligibleForAwardByStudentName(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status.Click();
                    if (status.Text.Equals("Eligible for Award"))
                        return true;
                }
            }

            return false;
        }

        [KeywordTestingScholarshipChildrenStatusTable]
        public bool VerifyStudentStatusIsFundedByStudentName(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status.Click();
                    if (status.Text.Equals("Funded"))
                        return true;
                }
            }

            return false;
        }

        [KeywordTestingScholarshipChildrenStatusTable]
        public bool VerifyStudentStatusIsContinuingByStudentName(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    IWebElement status = row.FindElement(By.CssSelector("span[id$=\"lblStatusDescription\"]"));
                    status.Click();
                    if (status.Text.Equals("Continuing"))
                        return true;
                }
            }

            return false;
        }

        [KeywordTestingScholarshipChildrenStatusTable]
		public bool ClickRevokeCheckboxByStudentName(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.TagName("tr"));

			foreach (var row in rows)
			{
				if (row.Text.Contains(data))
				{
					IWebElement revoke = row.FindElement(By.CssSelector("input[id$=\"chkRevoke\"]"));
					revoke.Click();

					return true;
				}
			}

			return false;
		}
	}
}
