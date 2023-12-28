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
    public class OLAHouseholdIncomeTable : WebElement
    {
        public OLAHouseholdIncomeTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        //[KeywordTestingOLAHouseholdIncomeTable]
        //public bool ClickStartByHouseholdMemberName(string text)
        //{
        //    var lineItems = this.FindElements(By.TagName("tr"));

        //    foreach (var lineItem in lineItems)
        //    {
        //        if (lineItem.Text.Contains(text))
        //        {
        //            lineItem.FindElement(By.XPath("//span[text() = 'Start ']")).Click();
        //            //return true;
        //        }
        //    }
        //    return false;
        //}

        [KeywordTestingOLAHouseholdIncomeTable]
        public bool ClickStartByHouseholdMemberName(string text)
        {
            try
            {
                _driver.FindElement(By.XPath("//*[contains(@href, 'member')]")).Click();
            }
            catch
            {
                return false;
            }

            return true;
        }

        //[KeywordTestingOLAHouseholdIncomeTable]
        //public bool ClickStartForPrimaryParent()
        //{
        //    var lineItems = this.FindElements(By.TagName("tr"));

        //    try
        //    {
        //        lineItems[1].FindElement(By.XPath("//span[text() = 'Start ']")).Click();
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //[KeywordTestingOLAHouseholdIncomeTable]
        //public bool ClickStartForSecondaryParent()
        //{
        //    var lineItems = this.FindElements(By.TagName("tr"));

        //    try
        //    {
        //        lineItems[2].FindElement(By.XPath("//span[text() = 'Start ']")).Click();
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        [KeywordTestingOLAHouseholdIncomeTable]
        public bool ClickStartForPrimaryParent()
        {
            try
            {
                _driver.FindElement(By.XPath("//*[contains(@href, 'primary/income-category-picker')]")).Click();
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        [KeywordTestingOLAHouseholdIncomeTable]
        public bool ClickStartForSecondaryParent()
        {
            try
            {
                _driver.FindElement(By.XPath("//*[contains(@href, 'secondary/income-category-picker')]")).Click();
            }
            catch
            {
                return false;
            }

            return true;
        }

        //[KeywordTestingOLAHouseholdIncomeTable]
        //public bool ClickStartForOtherAdult()
        //{
        //    var lineItems = this.FindElements(By.TagName("tr"));

        //    try
        //    {
        //        lineItems[3].FindElement(By.XPath("//span[text() = 'Start ']")).Click();
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        [KeywordTestingOLAHouseholdIncomeTable]
        public bool ClickStartForOtherAdult()
        {
            try
            {
                _driver.FindElement(By.XPath("//*[contains(@href, 'member')]")).Click();
            }
            catch
            {
                return false;
            }

            return true;
        }

        [KeywordTestingOLAHouseholdIncomeTable]
        public bool ClickEditByHouseholdMemberName(string text)
        {
            var lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    lineItem.FindElement(By.XPath("//span[text() = 'Edit ']")).Click();
                    return true;
                }
            }

            return false;
        }
    }
}
