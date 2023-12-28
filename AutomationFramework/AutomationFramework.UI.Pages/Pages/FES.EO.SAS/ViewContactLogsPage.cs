using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class ViewContactLogsPage : HomePage
    {
        public Table ContactLogTable { get; private set; }

        public Button ResultsFilter { get; private set; }

        public ViewContactLogsPage(IWebDriver driver)
            : base(driver)
        {
            ContactLogTable = new Table(driver, By.Id("tblNotes"));
            ResultsFilter = new Button(driver, By.Id("tblNotes_filter"));
        }
    }
}
