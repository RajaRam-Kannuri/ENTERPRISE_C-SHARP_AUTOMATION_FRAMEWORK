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
    public class GARSASApplicationTable : WebElement
    {
        public By _locateBy;
        public GARSASApplicationTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _locateBy = locateBy;
        }

        [KeywordTestingGARSASApplicationTable]
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

                    while (_driver.WindowHandles.Count < 2)
                    {
                        Thread.Sleep(1000);
                        counter++;
                        if (counter > 15)
                            break;
                    }

                    _driver.SwitchTo().Window(_driver.WindowHandles[1]);

                    if (!_driver.ElementExists(By.Id("tblApplicationDetails")))
                        _driver.SwitchTo().Window(_driver.WindowHandles[0]);

                    return true;
                }
            }

            return false;
        }

        [KeywordTestingGARSASApplicationTable]
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

        [KeywordTestingGARSASApplicationTable]
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
    }
}
