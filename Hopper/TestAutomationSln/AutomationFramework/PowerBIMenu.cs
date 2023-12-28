using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace AutomationFramework
{
    [KeywordTesting]
    public class PowerBIMenu : WebElement
    {

        protected readonly IWebDriver _driver;

        public PowerBIMenu(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _driver = driver;
        }

        //[KeywordTestingPowerBIMenu]
        //public void SelectMenuItemByPartialText(string text)
        //{
        //    var rows = this.FindElements(By.TagName("button"));

        //    foreach (var row in rows)
        //    {
        //        var expanded = row.GetAttribute("aria-expanded");

        //        if (expanded.Contains("false"))
        //        {
        //            row.Click();
        //        }
        //    }

        //    var subRows = this.FindElements(By.TagName("button"));

        //    foreach (var subRow in subRows)
        //    {
        //        try
        //        {
        //            var expanded = subRow.GetAttribute("aria-expanded");

        //            if (expanded.Contains("false"))
        //            {
        //                subRow.Click();
        //            }
        //        }
        //        catch { }
        //    }

        //    var rowTitles = this.FindElements(By.TagName("span"));

        //    foreach (var rowTitle in rowTitles)
        //    {
        //        var title = rowTitle.GetAttribute("title");

        //        if (title.Contains(text))
        //        {
        //            rowTitle.Click();
        //            break;
        //        }
        //    }
        //}

        [KeywordTestingPowerBIMenu]
        public void SelectMenuItemByPartialText(string text)
        {
            var rowTitles = this.FindElements(By.TagName("span"));

            foreach (var rowTitle in rowTitles)
            {
                var title = rowTitle.GetAttribute("title");

                if (title.Contains(text))
                {
                    rowTitle.Click();
                    break;
                }
            }
        }

        [KeywordTestingPowerBIMenu]
        public void SelectMenuItem(string text)
        {
            var rowTitles = this.FindElements(By.TagName("span"));

            foreach (var rowTitle in rowTitles)
            {
                var title = rowTitle.GetAttribute("title");

                if (title.Equals(text))
                {
                    rowTitle.Click();
                    break;
                }
            }
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderCorporateCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Corporate"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderOperationsCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Operations"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderPAPACategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("PAPA"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderFinanceCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Finance"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderCommunicationsCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Communications"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderScholarshipDataCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Scholarship Data"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [KeywordTestingPowerBIMenu]
        public bool SelectReportUnderGlossaryCategory(string report)
        {
            var rows = this.FindElements(By.TagName("button"));

            foreach (var row in rows)
            {
                try
                {
                    var expanded = row.GetAttribute("aria-expanded");

                    if (expanded.Contains("true"))
                    {
                        row.Click();
                    }
                }
                catch { }
            }

            var subRows = this.FindElements(By.TagName("span"));

            foreach (var subRow in subRows)
            {
                if (subRow.Text.Contains("Glossary"))
                {
                    subRow.Click();

                    var reports = this.FindElements(By.TagName("span"));

                    foreach (var report2 in reports)
                    {
                        if (report2.Text.Contains(report))
                        {
                            report2.Click();
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
