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
    public class SASPopupButton : CustomWebElement
    {
        public SASPopupButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingSASPopupButton]
        public bool ClickButton()
        {
            List<IWebElement> items = LocateAll();

            foreach (var item in items)
            {
                if (item.Displayed)
                {
                    try
                    {
                        item.Click();
                    }
                    catch
                    {
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
