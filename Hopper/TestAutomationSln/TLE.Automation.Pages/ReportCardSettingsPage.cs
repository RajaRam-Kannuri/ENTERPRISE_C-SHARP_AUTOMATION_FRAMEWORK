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
    public class ReportCardSettingsPage : CommonPage
    {
        public TypeAheadList SchoolYear { get; private set; }

        public EditField Description { get; private set; }

        public Dropdown GradeLevels { get; private set; }

        public Button SaveButton { get; private set; }

        public ReportCardSettingsPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.saveModel.schoolYearId\"]"));
            Description = new EditField(Driver, By.CssSelector("input[name=\"description\"]"));
            GradeLevels = new Dropdown(Driver, By.CssSelector("div[name=\"gradelevel\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[value=\"Save\"]"));
        }
    }
}
