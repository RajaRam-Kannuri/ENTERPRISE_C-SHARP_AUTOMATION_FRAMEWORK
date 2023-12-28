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
    public class FTCSASApplicationTable : WebElement
    {
        public By _locateBy;
        public FTCSASApplicationTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _locateBy = locateBy;
        }

        [KeywordTestingFTCSASApplicationTable]
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
            }

            return false;
        }

        [KeywordTestingFTCSASApplicationTable]
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

        [KeywordTestingFTCSASApplicationTable]
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

        [KeywordTestingFTCSASApplicationTable]
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

        [KeywordTestingFTCSASApplicationTable]
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

        [KeywordTestingFTCSASApplicationTable]
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

        [KeywordTestingFTCSASApplicationTable]
        public bool ClickAppIDForCurrentYear(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            rows.Last().FindElement(By.CssSelector("a[ID$='lbSetContext']")).Click();

            return true;
        }

        [KeywordTestingFTCSASApplicationTable]
        public string CollectApplicationIdByNumberOfStudents(string text)
        {
            Thread.Sleep(15000);

            List<String> lineString = new List<String>();

            List<IWebElement> rows = this.Body().Rows();

            for (int i = 0; i < rows.Count; i++)
            {
                lineString = rows[i].Text.Split(' ').ToList();

                if (lineString[1].Equals(text))
                {
                    var lineItems = rows[i].FindElements(By.TagName("td"));

                    return lineItems[0].Text;
                }
            }

            return string.Empty;
        }

        [KeywordTestingFTCSASApplicationTable]
        public bool ClickApplicationIdByNumberOfStudents(string text)
        {
            Thread.Sleep(15000);

            List<String> lineString = new List<String>();

            List<IWebElement> rows = this.Body().Rows();

            for (int i = 0; i < rows.Count; i++)
            {
                lineString = rows[i].Text.Split(' ').ToList();

                if (lineString[1].Equals(text))
                {
                    var lineItems = rows[i].FindElements(By.TagName("td"));

                    lineItems[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingFTCSASApplicationTable]
        public bool RemoveAllApplicationsInQueueAssignment(string text)
        {
            Thread.Sleep(15000);

            if (!_driver.ElementExists(_locateBy))
            {
                return true;
            }

            List<IWebElement> rows = this.Body().Rows();

            while (rows.Count > 1)
            {
                foreach(var row in rows)
                {
                    if (rows.IndexOf(row) == 0)
                    {
                        continue;
                    }
                    var lineItems = row.FindElements(By.TagName("td"));

                    var delBtn = lineItems[8].FindElements(By.TagName("input"));
                    delBtn[0].Click();

                    Thread.Sleep(3000);
                    rows = this.Body().Rows();
                    break;
                }
            }

            return true;
        }
    }
}
