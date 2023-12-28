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
    public class HouseholdMemberTable : WebElement
    {
        public HouseholdMemberTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingHouseholdMemberTable]
        public bool ClickEditByMemberType(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("input[ID$='bnEditMember']")).Click();
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

        [KeywordTestingHouseholdMemberTable]
        public bool ClickRemoveByMemberType(string text)
        {
            List<IWebElement> rows = this.Body().Rows();
            foreach (var row in rows)
            {
                if (row.Text.Contains(text))
                {
                    try
                    {
                        row.FindElement(By.CssSelector("input[ID$='bnRemoveMember']")).Click();
                        _driver.SwitchTo().Alert().Accept();
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
    }
}
