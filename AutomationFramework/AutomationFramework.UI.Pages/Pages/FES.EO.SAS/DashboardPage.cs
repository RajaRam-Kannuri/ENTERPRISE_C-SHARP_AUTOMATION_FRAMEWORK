using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class DashboardPage : HomePage
    {
        public Table DashboardApplicationTable { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            DashboardApplicationTable = new Table(driver, By.Id("gvAssignedApplications"));
        }
    }
}
