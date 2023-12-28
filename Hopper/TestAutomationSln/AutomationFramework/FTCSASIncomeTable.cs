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
    public class FTCSASIncomeTable : WebElement
    {
        public FTCSASIncomeTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASIncomeTable]
        public bool ClearAllAnnualIncome()
        {
            var lineItem = Locate();

            var incomeTextfields = lineItem.FindElements(By.TagName("input"));

            foreach (var incomeField in incomeTextfields)
            {
                try
                {
                    incomeField.SetText("0");
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}
