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
    public class OLAOtherMembersTable : WebElement
    {
        public OLAOtherMembersTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
                
        [KeywordTestingOLAOtherMembersTable]
        public bool ClickUpdateByMemberName(string text)
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

        [KeywordTestingOLAOtherMembersTable]
        public bool ClickDeleteByMemberName(string text)
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

        [KeywordTestingOLAOtherMembersTable]
        public bool DeleteAllOtherMembers()
        {
            IList<IWebElement> lineItems = LocateAll();
            int counter = 0;

            while (lineItems != null)
            {
                foreach (var lineItem in lineItems)
                {
                    try
                    {
                        IList<IWebElement> buttons = lineItem.FindElements(By.TagName("a"));
                        buttons[1].Click();
                        _driver.FindElement(By.XPath("//a[text() = 'Delete']"), StringConstants.WebdriverWaitTime).Click();
                    }
                    catch { }
                }

                Thread.Sleep(1000);
                counter++;

                if (counter > 5)
                    break;
            }

            return true;
        }
    }
}
