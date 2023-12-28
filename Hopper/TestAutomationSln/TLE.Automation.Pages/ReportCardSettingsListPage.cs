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
    public class ReportCardSettingsListPage : CommonPage
    {
        public Link CreateNewLink { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Table ReportCardSettingsList { get; private set; }

        public ReportCardSettingsListPage(IWebDriver driver)
            : base(driver)
        {
            CreateNewLink = new Link(Driver, By.Id("btnCreateNew"));
            SchoolYear = new Dropdown(Driver, By.Id("SelectedSchoolYearId"));
            ReportCardSettingsList = new Table(Driver, By.CssSelector(".table-striped"));
        }
    }
}
