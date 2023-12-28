using AutomationFramework.Core.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace AutomationFramework.Core
{
    public abstract class BaseUITest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        /// <summary>
        /// Initializes a new instance of the BaseUITest class.
        /// </summary>
        public BaseUITest()
        {
            var executionMode = ConfigurationManager.AppSettings["ExecutionMode"];
            var browser = ConfigurationManager.AppSettings["Browser"];

            driver = WebDriverFactory.CreateWebDriver(executionMode, browser);

            var waitTimeoutSeconds = int.Parse(ConfigurationManager.AppSettings["WebDriverWaitTimeoutSeconds"]);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTimeoutSeconds));
        }

        /// <summary>
        /// Initializes the test environment.
        /// </summary>
        public void Initialize()
        {
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Cleans up the test environment.
        /// </summary>
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
        }

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Finds the web element with the specified locator.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <returns>The found web element.</returns>
        public IWebElement FindElement(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        /// <summary>
        /// Clicks on the web element with the specified locator.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        public void ClickElement(By locator)
        {
            FindElement(locator).Click();
        }

        /// <summary>
        /// Enters text into the web element with the specified locator.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <param name="text">The text to enter.</param>
        public void EnterText(By locator, string text)
        {
            var element = FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        /// <summary>
        /// Checks if the web element with the specified locator is displayed.
        /// </summary>
        /// <param name="locator">The locator used to find the element.</param>
        /// <returns>True if the element is displayed, false otherwise.</returns>
        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}