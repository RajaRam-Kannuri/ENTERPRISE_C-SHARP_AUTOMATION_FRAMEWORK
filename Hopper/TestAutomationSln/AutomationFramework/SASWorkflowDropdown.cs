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
    public class SASWorkflowDropdown : WebElement
    {
        public SASWorkflowDropdown(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        {
            var _driver = driver;
        }

		[KeywordTestingSASWorkflowDropdown]
        public void SelectByPartialText(String item)
        {
            Thread.Sleep(StringConstants.DropDownWaitTime);

            if (item == null) return;

            List<IWebElement> lineItems = LocateAll();

            IReadOnlyCollection<IWebElement> options = null;

            IWebElement list = lineItems[0];

            list.Click();

            Thread.Sleep(StringConstants.DropDownWaitTime);

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

        [KeywordTestingSASWorkflowDropdown]
        public void SelectByPartialTextIfDisplayed(String item)
        {
            try
            {
                Thread.Sleep(StringConstants.DropDownWaitTime);

                if (item == null) return;

                List<IWebElement> lineItems = LocateAll();

                IReadOnlyCollection<IWebElement> options = null;

                IWebElement list = lineItems[0];

                list.Click();

                Thread.Sleep(StringConstants.DropDownWaitTime);

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
            catch { }
        }
    }
}
