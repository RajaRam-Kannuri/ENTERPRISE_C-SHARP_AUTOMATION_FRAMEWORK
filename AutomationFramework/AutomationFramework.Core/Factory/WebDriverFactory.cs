using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Core.Factory
{
    public class WebDriverFactory
    {
        /// <summary>
        /// Creates a new instance of the WebDriver based on the execution mode and browser specified.
        /// </summary>
        /// <param name="executionMode">The execution mode ("local" or "remote").</param>
        /// <param name="browser">The browser name.</param>
        /// <returns>The created WebDriver instance.</returns>
        public static IWebDriver CreateWebDriver(string executionMode, string browser)
        {
            if (executionMode.Equals("local", StringComparison.OrdinalIgnoreCase))
            {
                switch (browser)
                {
                    case "Chrome":
                        return new ChromeDriver();
                    case "Firefox":
                        return new FirefoxDriver();
                    default:
                        throw new ConfigurationErrorsException("Invalid browser specified in app.config");
                }
            }
            else if (executionMode.Equals("remote", StringComparison.OrdinalIgnoreCase))
            {
                //TODO: BrowserStack connection
                return null;
            }
            else
            {
                throw new ConfigurationErrorsException("Invalid ExecutionMode specified in app.config");
            }
        }
    }
}
