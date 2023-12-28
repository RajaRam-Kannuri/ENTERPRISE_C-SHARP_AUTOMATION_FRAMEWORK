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
    public class OLAWorkflowDropdown : WebElement
    {
        public OLAWorkflowDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

		[KeywordTestingOLAWorkflowDropdown]

        public void SelectByPartialText(String item)
        {
            Thread.Sleep(StringConstants.DropDownWaitTime);

            if (item == null) return;

            List<IWebElement> lineItems = LocateAll();

            IReadOnlyCollection<IWebElement> options = null;

            lineItems[0].Click();

            Thread.Sleep(StringConstants.DropDownWaitTime);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(StringConstants.WebdriverWaitTime));

            IWebElement list = lineItems[1];

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

        [KeywordTestingOLAWorkflowDropdown]
        public void SelectRandom()
        {
            Thread.Sleep(StringConstants.DropDownWaitTime);

            List<IWebElement> lineItems = LocateAll();

            lineItems[0].Click();

            Thread.Sleep(StringConstants.DropDownWaitTime);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(StringConstants.WebdriverWaitTime));

            IWebElement list = lineItems[1];

            var options = list.FindElements(By.TagName("li"));

            int idx = new Random().Next(1, options.Count - 1);

            options[idx].Click();
        }
    }
}
