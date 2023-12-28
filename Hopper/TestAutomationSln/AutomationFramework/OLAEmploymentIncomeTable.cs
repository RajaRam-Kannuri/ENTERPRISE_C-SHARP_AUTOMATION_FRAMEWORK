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
    public class OLAEmploymentIncomeTable : WebElement
    {
        public OLAEmploymentIncomeTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingOLAEmploymentIncomeTable]
        public bool ClickEditByJobName(string text)
        {
            IList<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                    buttons[0].Click();
                    return true;
                }
            }

            return false;
        }

        [KeywordTestingOLAEmploymentIncomeTable]
        public bool DeleteAllJobs(string text)
        {
            IList<IWebElement> lineItems = LocateAll(10);

            while (lineItems != null)
            {
                foreach (var lineItem in lineItems)
                {
                    try
                    {
                        IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                        buttons[1].Click();
                        _driver.FindElement(By.XPath("//a[text() = 'Delete']")).Click();
                    }
                    catch { }
                }

                lineItems = LocateAll(5);
            }

            return true;
        }

        [KeywordTestingOLAEmploymentIncomeTable]
        public bool ClickDeleteByJobName(string text)
        {
            IList<IWebElement> lineItems = LocateAll();

            foreach (var lineItem in lineItems)
            {
                if (lineItem.Text.Contains(text))
                {
                    IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                    buttons[1].Click();
                    return true;
                }
            }

            return false;
        }
	}
}
