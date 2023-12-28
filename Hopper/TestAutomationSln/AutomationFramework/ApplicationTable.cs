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
    public class ApplicationTable : WebElement
    {
        public ApplicationTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingApplicationTable]
        public bool ClickProcessByApplicationID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(text))
                {
                    try
                    {
						rows[i].FindElement(By.CssSelector("a[ID$='lbProcess']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    _driver.SwitchTo().Window(_driver.WindowHandles.First());

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingApplicationTable]
        public bool ClickFirstProcessLinkInTable()
        {
            List<IWebElement> rows = this.Body().Rows();

            try
            {
                rows[0].FindElement(By.CssSelector("a[ID$='lbProcess']")).Click();
            }
            catch
            {
                return false;
            }

            int counter = 0;

            while (_driver.WindowHandles.Count < 3)
            {
                Thread.Sleep(1000);
                counter++;
                if (counter > 15)
                    break;
            }

            _driver.SwitchTo().Window(_driver.WindowHandles[1]);

            if (!_driver.ElementExists(By.Id("tblApplicationDetails")))
                _driver.SwitchTo().Window(_driver.WindowHandles[2]);

            return true;
        }

        [KeywordTestingApplicationTable]
        public bool ClickFirstContactLinkInTable()
        {
            List<IWebElement> rows = this.Body().Rows();

            try
            {
                rows[0].FindElement(By.CssSelector("a[ID$='lbContact']")).Click();
            }
            catch
            {
                return false;
            }

            return true;
        }

        [KeywordTestingApplicationTable]
        public bool ClickFirstAppIdInTable()
        {
            List<IWebElement> rows = this.Body().Rows();

            try
            {
                rows[0].FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();
            }
            catch
            {
                return false;
            }

            return true;
        }

        [KeywordTestingApplicationTable]
        public bool ClickContactByApplicationID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
						row.FindElement(By.CssSelector("a[ID$='lbContact']")).Click();
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

        [KeywordTestingApplicationTable]
        public bool ClickAppIDbyAppStatus(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();
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

		[KeywordTestingApplicationTable]
		public bool ClickAppIDForCurrentYear(string text)
		{
			List<IWebElement> rows = this.Body().Rows();
			rows.Last().FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();

			return true;
		}

		[KeywordTestingApplicationTable]
		public bool ClickStudentIDForCurrentYear(string text)
		{
			List<IWebElement> rows = this.Body().Rows();
			rows.Last().FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();

			return true;
		}

		[KeywordTestingApplicationTable]
        public bool ClickStudentIDbyStudentStatus(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
						row.FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();
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

        [KeywordTestingApplicationTable]
        public bool ClickStudentDetailsLinkByStudentID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("a[ID$='lbStudentDetail']")).Click();
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

        [KeywordTestingApplicationTable]
        public bool ClickStudentSCFLinkByStudentID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("a[ID$='lbStudentSCF']")).Click();
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

        [KeywordTestingApplicationTable]
        public bool ClickProcessReimbursementByRequestStatus(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
						row.FindElement(By.CssSelector("a[ID$='lbClaimID']")).Click();
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

		[KeywordTestingApplicationTable]
		public string CollectStudentFirstName()
		{
			List<IWebElement> rows = this.Body().Rows();

			var rowData = rows[0].FindElements(By.TagName("td"));
			rowData[2].Click();

			return rowData[2].Text;
		}
	}
}
