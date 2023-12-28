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
    public class OLASeparatedStateDropdown : WebElement
    {
        public OLASeparatedStateDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

        [KeywordTestingOLASeparatedStateDropdown]
        public void SelectByPartialText(String item)
        {
            IReadOnlyCollection<IWebElement> options = null;
            IWebElement elem = LocateAndEnsureUsable();
            elem.Click();
            //this.Click();
            if (item == null) return;
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(StringConstants.WebdriverWaitTime));
            IWebElement list = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='question - form']/div[6]/div[2]/div[2]/ul")));

            options = list.FindElements(By.TagName("li"));

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
