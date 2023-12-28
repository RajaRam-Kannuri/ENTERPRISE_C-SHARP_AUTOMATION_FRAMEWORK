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
    public class HiddenButton : WebElement
    {
        public HiddenButton(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

        [KeywordTestingHiddenButton]
        public void HideButton()
        {
            try
            {
                IWebElement elem = LocateAndEnsureUsable();
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].style.visibility='hidden'", elem);
            }
            catch { }
        }
    }
}
