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
    public class OLASuffixDropdown : WebElement
    {
        public OLASuffixDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

        [KeywordTestingOLASuffixDropdown]
        public void SelectByPartialText(String item)
        {
            IWebElement elem = LocateAndEnsureUsable();
            elem.Click();

            if (item == null) return;

            IWebElement list = _driver.FindElement(By.XPath("//*[contains(@id, 'select-options-')]"));

            var options = list.FindElements(By.TagName("li"));

            foreach (var option in options)
            {
                if (option.Text.Contains(item))
                {
                    option.Click();
                    break;
                }
            }
        }
    }
}
