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
    public class DropdownWithAlert : WebElement
    {
        public DropdownWithAlert(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

        [KeywordTestingDropdownWithAlert]
        public void SelectByPartialText(string item)
        {
            IWebElement list = LocateAndEnsureUsable();

            if (item == null) return;
            list.Click();
            Thread.Sleep(3000);

            IList<IWebElement> options = list.FindElements(By.TagName("option"));
            IWebElement desiredOption = options.Where(op => op.Text.Contains(item.ToString())).ToList().FirstOrDefault();
            if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));

            Thread.Sleep(1000);

            try
            {
                _driver.SwitchTo().Alert().Accept();
            }
            catch { }
        }

        [KeywordTestingDropdownWithAlert]
        public void SelectByPartialTextIfDisplayed(string item)
        {
            try
            {
                IWebElement list = LocateAndEnsureUsable();

                if (item == null) return;
                list.Click();
                Thread.Sleep(3000);

                IList<IWebElement> options = list.FindElements(By.TagName("option"));
                IWebElement desiredOption = options.Where(op => op.Text.Contains(item.ToString())).ToList().FirstOrDefault();
                if (desiredOption != null) new SelectElement(list).SelectByValue(desiredOption.GetAttribute("value"));

                Thread.Sleep(1000);

                try
                {
                    _driver.SwitchTo().Alert().Accept();
                }
                catch { }
            }
            catch { }
        }
    }
}
