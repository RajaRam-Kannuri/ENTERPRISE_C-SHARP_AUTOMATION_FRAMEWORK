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
    public class BlockedButton : CustomWebElement
    {
        public BlockedButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingBlockedButton]
        public void ClickButton()
        {
            try
            {
                _driver.SwitchTo().Frame("designstudio-button-frame");
                _driver.FindElement(By.CssSelector("span[id$=\"designstudio-button-text\"]")).Click();
            }
            catch { }

            Thread.Sleep(1000);
            _driver.SwitchTo().ParentFrame();

            IWebElement elem = LocateAndEnsureUsable();
            if (elem != null)
            {
                elem.Click();
            }
        }
    }
}
