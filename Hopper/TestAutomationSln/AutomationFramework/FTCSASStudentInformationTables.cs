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
    public class FTCSASStudentInformationTables : WebElement
    {
        public FTCSASStudentInformationTables(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToTypeNew()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"cblStudentType_0\"]")).Click();
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToTypeRenewal()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"cblStudentType_1\"]")).Click();
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToStatusPending()
        {
            IList<IWebElement> lists = this.FindElements(By.CssSelector("select[id$=\"sctStudentEligibilityStatus\"]"));

            foreach (var list in lists)
            {
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Pending")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToStatusEligible()
        {
            IList<IWebElement> lists = this.FindElements(By.CssSelector("select[id$=\"sctStudentEligibilityStatus\"]"));

            foreach (var list in lists)
            {
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Eligible")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToStatusIneligible()
        {
            IList<IWebElement> lists = this.FindElements(By.CssSelector("select[id$=\"sctStudentEligibilityStatus\"]"));

            foreach (var list in lists)
            {
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Ineligible")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsToStatusWaitList()
        {
            IList<IWebElement> lists = this.FindElements(By.CssSelector("select[id$=\"sctStudentEligibilityStatus\"]"));

            foreach (var list in lists)
            {
                list.Click();
                Thread.Sleep(3000);
                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains("Wait List")).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetRequiredDocumentsForAllStudentsByText(String text)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"rblEvidenceType\"]"));

            foreach (var row in rows)
            {
                try
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
                catch { }
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SelectOptionForAllStudentsIEPSchoolDistrict(String text)
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

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

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsIEPDateToday()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));
            DateTime thisDay = DateTime.Today;

            foreach (var row in rows)
            {
                IWebElement edit = row.FindElement(By.CssSelector("input[id$=\"tbIEPDate\"]"));
                edit.SetText(thisDay.ToString("d"));
                row.FindElement(By.CssSelector("span[id$=\"lblIEPDate\"]")).Click();
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsIEPtoYES()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"rblIEP_0\"]")).Click();
            }
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public void SetAllStudentsIEPtoNO()
        {
            IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

            foreach (var row in rows)
            {
                row.FindElement(By.CssSelector("input[id$=\"rblIEP_1\"]")).Click();
            }
        }

		[KeywordTestingFTCSASStudentInformationTables]
		public bool VerifyStudentStatusIsSuspendedByStudentID(String data)
		{
			IList<IWebElement> rows = this.FindElements(By.CssSelector("table[id$=\"tblStudentStatus\"]"));

			foreach (var row in rows)
			{
				if (row.Text.Contains("Gardiner Student ID: " + data))
				{
					IWebElement list = row.FindElement(By.CssSelector("input[id$=\"tbScholarshipStatus\"]"));
					list.Click();
					if (list.Value().Equals("Suspended"))
						return true;
				}
			}

			return false;
		}

		[KeywordTestingFTCSASStudentInformationTables]
		public bool VerifyStudentStatusIsAwardedByStudentID(String data)
		{
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
			{
                if (row.Text.Contains(data))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (list.Value().Equals("Awarded"))
                            return true;
                    }
                    catch { }
                }
            }

            return false;
		}

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyStudentStatusIsDeniedByStudentID(String data)
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (list.Value().Equals("Denied"))
                            return true;
                    }
                    catch { }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyStudentStatusIsPendingByStudentID(String data)
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (list.Value().Equals("Pending"))
                            return true;
                    }
                    catch { }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyStudentStatusIsWaitlistByStudentID(String data)
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains(data))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (list.Value().Equals("Wait List"))
                            return true;
                    }
                    catch { }
                }
            }

            return false;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllStudentStatusesAreAwarded()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Awarded"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFTCStudentStatusesAreAwarded()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Awarded"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFESStudentStatusesAreAwarded()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"fesStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Awarded"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllStudentStatusesAreDenied()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Denied"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFTCStudentStatusesAreDenied()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Denied"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFESStudentStatusesAreDenied()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"fesStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Denied"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllStudentStatusesArePending()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Pending"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFTCStudentStatusesArePending()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Pending"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFESStudentStatusesArePending()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"fesStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Pending"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllStudentStatusesAreWaitlist()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Wait List"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFTCStudentStatusesAreWaitlist()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Wait List"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFESStudentStatusesAreWaitlist()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"fesStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Wait List"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFTCStudentStatusesAreDeclined()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"sctStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Declined"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }

        [KeywordTestingFTCSASStudentInformationTables]
        public bool VerifyAllFESStudentStatusesAreDeclined()
        {
            IWebElement container = FindElement(By.Id("student"));
            IList<IWebElement> rows = container.FindElements(By.TagName("div"));

            foreach (var row in rows)
            {
                if (row.Text.Contains("Student Information"))
                {
                    try
                    {
                        IWebElement list = row.FindElement(By.CssSelector("input[id$=\"fesStudentScholarshipStatus\"]"));
                        list.Click();
                        if (!list.Value().Equals("Declined"))
                            return false;
                    }
                    catch { }
                }
            }

            return true;
        }
    }
}
