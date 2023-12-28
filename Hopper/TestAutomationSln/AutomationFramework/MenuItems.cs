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
    public class MenuItems : WebElement
    {

        protected readonly IWebDriver _driver;

        public MenuItems(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            _driver = driver;
        }

        [KeywordTestingMenuItems]
        public void SelectMenuItemByPartialText(string text)
        {
            bool matchFound = false;

            var rows = this.FindElements(By.TagName("li"));

            ReadOnlyCollection<IWebElement> subRows = null;

            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    row.Click();

                    try
                    {
                        if (row.Text.Contains("Go to MyScholarShop"))
                            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
                    }
                    catch { }

                    break;
                }

                //else if (!row.Text.Equals("") && row.Text.Contains("\r\n"))
                //{
                //    try
                //    {
                //        row.Click();
                //        subRows = row.FindElement(By.TagName("ul")).FindElements(By.TagName("li"));
                //    }
                //    catch { }

                //    if (subRows != null)
                //        foreach (var subRow in subRows)
                //        {
                //            if (subRow.Text.Contains(text))
                //            {
                //                subRow.Click();
                //                matchFound = true;
                //                break;
                //            }
                //        }
                //}

                else if (!row.Text.Equals(""))
                {
                    var subCount = 0;
                    
                    try
                    {
                        int index = rows.IndexOf(row);
                        if (rows[index + 1].Text.Equals(""))
                        {
                            subRows = row.FindElement(By.TagName("ul")).FindElements(By.TagName("li"));
                            subCount = subRows.Count();
                        }
                    }
                    catch { }

                    if (subCount > 0)
                    {
                        row.Click();

                        foreach (var subRow in subRows)
                        {
                            if (subRow.Text.Contains(text))
                            {
                                subRow.Click();
                                matchFound = true;
                                break;
                            }
                        }
                    }
                }
                if (matchFound)
                    break;
            }
        }
    }
}
