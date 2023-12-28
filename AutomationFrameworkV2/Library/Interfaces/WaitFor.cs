using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Interfaces
{
    public class WaitFor
    {
        public static void WaitForElementToBeVisiable(IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public static void WaitForElementToExist(IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
        }

        public static void WaitForElementToBeClickable(IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }

        public static void InvisiabilityOfElement(IWebDriver driver, By by)
        {
            try
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch(WebDriverTimeoutException)
            {

            }
        }

    }
}
