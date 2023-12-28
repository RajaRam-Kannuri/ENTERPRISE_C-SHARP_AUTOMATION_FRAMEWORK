using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class DashboardPage : HomePage
    {
        public DashboardApplicationTable DashboardApplicationTable { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            DashboardApplicationTable = new DashboardApplicationTable(Driver, By.Id("gvAssignedApplications"));
        }
    }
}
