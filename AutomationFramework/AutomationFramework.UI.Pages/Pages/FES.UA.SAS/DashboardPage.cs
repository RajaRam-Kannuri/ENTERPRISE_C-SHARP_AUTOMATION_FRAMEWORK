using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class DashboardPage : HomePage
    {
        public Table ApplicationTable { get; private set; }
        public Table ReimbursementsTable { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationTable = new Table(driver, By.Id("gvAssignedApplications"));
            ReimbursementsTable = new Table(driver, By.Id("controls_claims_claimassignment_currentclaimassignments_ascx1002_gvAssignedClaims"));
        }
    }
}