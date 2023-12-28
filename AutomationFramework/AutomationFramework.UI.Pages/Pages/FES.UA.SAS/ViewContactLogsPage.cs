using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ViewContactLogsPage : HomePage
    {
        public Table ContactLogTable { get; private set; }

        public ViewContactLogsPage(IWebDriver driver)
            : base(driver)
        {
            ContactLogTable = new Table(driver, By.Id("tblNotes"));
        }
    }
}