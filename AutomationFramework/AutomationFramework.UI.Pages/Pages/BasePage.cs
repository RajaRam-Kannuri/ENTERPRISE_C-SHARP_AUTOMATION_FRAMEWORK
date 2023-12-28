using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        private readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}