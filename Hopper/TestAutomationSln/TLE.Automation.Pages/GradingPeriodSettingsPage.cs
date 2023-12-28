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
    public class GradingPeriodSettingsPage : CommonPage
    {
        public Dropdown SchoolYear { get; private set; }

        public Button SaveButton { get; private set; }

        public GradingPeriodSettingsPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.Id("SelectedSchoolYearId"));
            SaveButton = new Button(Driver, By.Id("btnSaveAll"));
        }
    }
}
