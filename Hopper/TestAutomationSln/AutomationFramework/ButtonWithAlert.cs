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
    public class ButtonWithAlert : CustomWebElement
    {
        public ButtonWithAlert(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingButtonWithAlert]
        public void ClickButton()
        {
            this.Click();

            try
            {
                _driver.SwitchTo().Alert().Accept();
            }
            catch { }
        }

        [KeywordTestingButtonWithAlert]
        public bool ClickButtonAndValidateTextPartiallyEquals(string text)
        {
            this.Click();

            var message = _driver.SwitchTo().Alert().GetText();
            _driver.SwitchTo().Alert().Accept();

            if (message.Contains(text))
                return true;

            return false;
        }
    }
}
