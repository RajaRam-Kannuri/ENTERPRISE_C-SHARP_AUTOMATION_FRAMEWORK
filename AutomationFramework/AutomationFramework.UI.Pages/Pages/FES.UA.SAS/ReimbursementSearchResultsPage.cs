using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ReimbursementSearchResultsPage : HomePage
    {
        public Table ReimbursementTable { get; private set; }

        public ReimbursementSearchResultsPage(IWebDriver driver)
            : base(driver)
        {
            ReimbursementTable = new Table(driver, By.Id("tblResults"));
        }
    }
}