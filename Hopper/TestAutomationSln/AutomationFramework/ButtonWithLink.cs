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
    public class ButtonWithLink : CustomWebElement
    {
        public ButtonWithLink(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingButtonWithLink]
        public void ClickButton()
        {
            this.Click();
            Thread.Sleep(3000);
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
        }
    }
}
