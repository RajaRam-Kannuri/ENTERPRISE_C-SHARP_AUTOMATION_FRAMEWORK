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
    public class DashboardApplicationTable : WebElement
    {
        public DashboardApplicationTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingDashboardApplicationTable]
        public bool OpenApplicationByAppStatus(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("a[ID$='lblAppID']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    //_driver.SwitchTo().Window(_driver.WindowHandles.First());

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingDashboardApplicationTable]
        public bool OpenApplicationByAppID(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("a[ID$='lblAppID']")).Click();
                    }
                    catch
                    {
                        break;
                    }

                    //_driver.SwitchTo().Window(_driver.WindowHandles.First());

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingDashboardApplicationTable]
        public bool VerifyFirstRowContainsLink(string text)
        {
            List<IWebElement> rows = this.Body().Rows();

            if (rows[1].ElementExists(By.CssSelector("#controls_claims_claimassignment_currentclaimassignments_ascx1002_gvAssignedClaims_ctl02_lbClaimID")))
                return true;
            
            return false;
        }
    }
}
