using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class DashboardPage : HomePage
    {
        public DashboardApplicationTable ApplicationTable { get; private set; }
        public DashboardApplicationTable ReimbursementsTable { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationTable = new DashboardApplicationTable(Driver, By.Id("gvAssignedApplications"));
            ReimbursementsTable = new DashboardApplicationTable(Driver, By.Id("controls_claims_claimassignment_currentclaimassignments_ascx1002_gvAssignedClaims"));
        }
    }
}
