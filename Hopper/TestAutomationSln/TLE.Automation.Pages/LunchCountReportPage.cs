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
    public class LunchCountReportPage : CommonPage
    {
        public Dropdown SchoolYear { get; private set; }

        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public Dropdown DayOfTheWeek { get; private set; }

        public EditField StudentLastName { get; private set; }

        public Button ViewReportButton { get; private set; }

        public Table LunchCountTable { get; private set; }

        public LunchCountReportPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.selectedSchoolYear\"]"));
            StartDate = new EditField(Driver, By.CssSelector("input[data-ng-model$=\"startDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[data-ng-model$=\"endDate\"]"));
            DayOfTheWeek = new Dropdown(Driver, By.CssSelector("select[ng-model='vm.selectedDayOfWeek']"));
            StudentLastName = new EditField(Driver, By.Id("txtStudentLastName"));
            ViewReportButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.report()\"]"));
            LunchCountTable = new Table(Driver, By.Id("divLunchCountReport"));
        }
    }
}
