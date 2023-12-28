using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ApplicationSearchResultsPage : BasePage
    {
        public Table ApplicationTable { get; private set; }

        public Link NumberofEntriesToShow { get; private set; }

        public EditField SearchWithinApplicationResults { get; private set; }

        public ApplicationSearchResultsPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationTable = new Table(driver, By.Id("tblResults"));
            NumberofEntriesToShow = new Link(driver, By.Name("tblResults_length"));
            SearchWithinApplicationResults = new EditField(driver, By.Id("tblResults_filter"));
        }
    }
}
