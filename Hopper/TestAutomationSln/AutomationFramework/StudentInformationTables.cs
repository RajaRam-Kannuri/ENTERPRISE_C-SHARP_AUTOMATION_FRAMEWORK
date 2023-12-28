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
    public class StudentInformationTables : WebElement
    {
        public StudentInformationTables(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsToTypeNew()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"cblStudentType_0\"]")).Click();
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsToTypeRenewal()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"cblStudentType_1\"]")).Click();
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsToStatusPending()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                IWebElement list = row.FindElement(By.CssSelector("select[id$=\"ddlStudentEligibilityStatus\"]"));
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Pending")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsToStatusEligible()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                IWebElement list = row.FindElement(By.CssSelector("select[id$=\"ddlStudentEligibilityStatus\"]"));
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Eligible")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsToStatusIneligible()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                IWebElement list = row.FindElement(By.CssSelector("select[id$=\"ddlStudentEligibilityStatus\"]"));
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Ineligible")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SetRequiredDocumentsForAllStudentsByText(String text)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"rblEvidenceType\"]"));

            foreach (var row in rows)
            {
                switch (text)
                {
                    case "Public school withdrawal":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_0\"]")).Click();
                        break;
                    case "Eligible Private school enrollment":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_1\"]")).Click();
                        break;
                    case "Home education participation":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_2\"]")).Click();
                        break;
                    case "Private school withdrawal from another scholarship":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_3\"]")).Click();
                        break;
                    case "No Document":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_4\"]")).Click();
                        break;
                    case "Incorrect Document":
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_5\"]")).Click();
                        break;
                    default:
                        row.FindElement(By.CssSelector("input[id$=\"rblEvidenceType_4\"]")).Click();
                        break;
                }
            }
        }

        [KeywordTestingStudentInformationTables]
        public void SelectOptionForAllStudentsIEPSchoolDistrict(String text)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            try
            {
                foreach (var row in rows)
                {
                    IWebElement list = row.FindElement(By.CssSelector("select[id$=\"ddlIEPSchoolDistrict\"]"));
                    list.Click();
                    Thread.Sleep(3000);
                    IList<IWebElement> options = list.FindElements(By.TagName("option"));
                    IWebElement desiredOption = options.Where(op => op.Text.Contains(text)).ToList().FirstOrDefault();
                    if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
                }
            }
            catch { }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsIEPDateToday()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));
            DateTime thisDay = DateTime.Today;

            try
            {
                foreach (var row in rows)
                {
                    IWebElement edit = row.FindElement(By.CssSelector("input[id$=\"tbIEPDate\"]"));
                    edit.SetText(thisDay.ToString("d"));
                    row.FindElement(By.CssSelector("span[id$=\"lblIEPDate\"]")).Click();
                }
            }
            catch { }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsIEPtoYES()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            try
            {
                foreach (var row in rows)
                {
                    row.FindElement(By.CssSelector("input[id$=\"rblIEP_0\"]")).Click();
                }
            }
            catch { }
        }

        [KeywordTestingStudentInformationTables]
        public void SetAllStudentsIEPtoNO()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            try
            {
                foreach (var row in rows)
                {
                    row.FindElement(By.CssSelector("input[id$=\"rblIEP_1\"]")).Click();
                }
            }
            catch { }
        }

		[KeywordTestingStudentInformationTables]
		public bool VerifyStudentStatusIsSuspendedByStudentID(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

			foreach (var row in rows)
			{
				if (row.Text.Contains("FES (formerly Gardiner) Student ID: " + data))
				{
					IWebElement list = row.FindElement(By.CssSelector("input[id$=\"tbScholarshipStatus\"]"));
					list.Click();
					if (list.Value().Equals("Suspended"))
						return true;
				}
			}

			return false;
		}

		[KeywordTestingStudentInformationTables]
		public bool VerifyStudentStatusIsAwardedByStudentID(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

			foreach (var row in rows)
			{
				if (row.Text.Contains("FES (formerly Gardiner) Student ID: " + data))
				{
					IWebElement list = row.FindElement(By.CssSelector("input[id$=\"tbScholarshipStatus\"]"));
					list.Click();
					if (list.Value().Equals("Awarded"))
						return true;
				}
			}

			return false;
		}

        [KeywordTestingStudentInformationTables]
        public bool VerifyStudentStatusIsContinuingByStudentID(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("FES (formerly Gardiner) Student ID: " + data))
                {
                    IWebElement list = row.FindElement(By.CssSelector("input[id$=\"tbScholarshipStatus\"]"));
                    list.Click();
                    if (list.Value().Equals("Continuing"))
                        return true;
                    string test = list.Value();
                }
            }

            return false;
        }


        [KeywordTestingStudentInformationTables]
        public bool VerifyStudentIsOver22ByStudentID(String data)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("FES (formerly Gardiner) Student ID: " + data))
                {
                    if (row.Text.Contains("Over 22"))
                        return true;
                }
            }

            return false;
        }
    }
}
