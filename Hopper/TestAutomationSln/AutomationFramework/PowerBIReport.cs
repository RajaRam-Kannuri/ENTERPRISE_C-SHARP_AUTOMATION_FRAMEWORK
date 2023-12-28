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
    public class PowerBIReport : WebElement
    {

        protected readonly IWebDriver _driver;

        public PowerBIReport(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _driver = driver;
        }

        [KeywordTestingPowerBIReport]
        public bool VerifyReportIsDisplayed()
        {
            var rows = this.FindElements(By.TagName("visual-container-modern"));
            if (rows.Count > 0)
                return true;

            return false;
        }

        [KeywordTestingPowerBIReport]
        public bool VerifyReportContainsText(string text)
        {
            var rows = this.FindElements(By.TagName("div"));
            foreach (var row in rows)
            {
                try
                {
                    if (row.Text.Contains(text))
                        return true;
                }
                catch { }
            }

            return false;
        }
    }
}
