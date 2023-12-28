using OpenQA.Selenium;

namespace AutomationFramework.Pages.Base
{
    public class GoogleSearchPage
    {
        private readonly IWebDriver driver;

        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchInput => driver.FindElement(By.Name("q"));

        public void EnterSearchText(string searchText)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(searchText);
        }

        public void SubmitSearch()
        {
            SearchInput.Submit();
        }

        public bool ResultsAreDisplayed()
        {
            return driver.FindElement(By.CssSelector("#search .g")).Displayed;
        }
    }
}
