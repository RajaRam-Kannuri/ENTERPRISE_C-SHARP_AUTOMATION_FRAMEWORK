using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Diagnostics;

namespace AutomationFramework
{
    public static class UIElementManager
    {
        public static void HardWait(IWebDriver driver, int time = 1)
        {
            int waited = 0;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(d =>
            {
                waited++;
                return waited == time;
            });
        }

        public static IWebElement WaitForElement(IWebDriver driver, WebElement elem, int timeout = 30)
        {
            return WaitForElement(driver, elem.LocateBy(), timeout);
        }

        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(d => d.FindElement(by));
        }

        public static void WaitForElementToBeGone(IWebDriver driver, WebElement elem, int timeout = 30)
        {
            WaitForElementToBeGone(driver, elem.LocateBy(), timeout);
        }

        public static void WaitForElementToBeGone(IWebDriver driver, By by, int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public static void WaitForElementToBeUsable(IWebDriver driver, WebElement element, int timeout = 30)
        {
            WaitForElementToBeUsable(driver, element.LocateBy(), timeout);
        }

        public static void WaitForElementToBeUsable(IWebDriver driver, By by, int timeout = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static void WaitForPageLoad(IWebDriver driver, int timeout = 45)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until(d => (bool)((IJavaScriptExecutor)d).ExecuteScript("return document.readyState == 'complete' && (typeof jQuery != 'undefined') ? jQuery.active == 0 : true && (typeof angular != 'undefined') ? angular.element(document.body).injector().get('$http').pendingRequests.length == 0 : true;"));

            if (driver.PageSource.Contains("Server Error"))
                throw new WebDriverException("Server error encountered during test execution:\n\n" + driver.PageSource);

            Thread.Sleep(AutomationUtilities.GetPageWaitTime() * 1000);
        }

        public static void WaitForPageLoadWithSpinners(IWebDriver driver, int timeout = 45)
        {
            UIElementManager.WaitForPageLoad(driver, timeout);

            List<IWebElement> waitSpinners;
            if (driver.TryGetElements(By.CssSelector("img[alt=\"Loading\"]"), out waitSpinners))
            {
                bool loadersShowing = true;
                do
                {
                    waitSpinners = driver.FindElements(By.CssSelector("img[alt=\"Loading\"]")).ToList();
                    try
                    {
                        loadersShowing = waitSpinners.Any(spinner => spinner.Displayed);
                    }
                    catch (StaleElementReferenceException e)
                    {
                        // This exception happens when the page transitions after we've gotten a reference to a UI element.
                        // Since we are waiting for a page to load, we'll just eat the exception and see what the next page
                        // has to offer by way of spinners.
                        Logger.Log("Swallowing StaleElementReferenceException while waiting for ajax spinners: " + e.Message);
                    }
                } while (waitSpinners.Count != 0 && loadersShowing);
            }
        }
    }
}
