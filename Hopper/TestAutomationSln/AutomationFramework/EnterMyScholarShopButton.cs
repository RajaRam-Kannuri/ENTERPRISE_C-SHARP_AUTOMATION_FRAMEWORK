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
    public class EnterMyScholarShopButton : CustomWebElement
    {
        public EnterMyScholarShopButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingEnterMyScholarShopButton]
        public void ClickButton()
        {
            Locate(0).Click();

            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
        }
    }
}
