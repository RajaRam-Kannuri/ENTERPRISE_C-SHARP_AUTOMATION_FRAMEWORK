using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class GradingScaleSettingsListPage : CommonPage
    {
        public Link CreateNewGradingScaleLink { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Table GradingScaleListTable { get; private set; }

        public GradingScaleSettingsListPage(IWebDriver driver)
            : base(driver)
        {
            CreateNewGradingScaleLink = new Link(Driver, By.Id("btnCreateNew"));
            SchoolYear = new Dropdown(Driver, By.Id("SelectedSchoolYearId"));
            GradingScaleListTable = new Table(Driver, By.CssSelector(".table.table-striped"));
        }
    }
}
