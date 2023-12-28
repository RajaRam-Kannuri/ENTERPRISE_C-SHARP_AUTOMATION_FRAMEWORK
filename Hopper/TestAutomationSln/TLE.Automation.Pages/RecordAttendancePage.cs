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
    public class RecordAttendancePage : CommonPage
    {
        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public EditField StudentLastName { get; private set; }

        public Dropdown Teacher { get; private set; }

        public Dropdown Class { get; private set; }

        public Button SearchButton { get; private set; }

        public Table StudentResultsTable { get; private set; }

        public Table AttendanceByNameResultsTable { get; private set; }

        public Table AttendanceByDateResultsTable { get; private set; }

        public WebElement Flyout { get; private set; }

        public RecordAttendancePage(IWebDriver driver)
            : base(driver)
        {
            StartDate = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.searchForm.startDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.searchForm.endDate\"]"));
            StudentLastName = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.searchForm.studentLastName\"]"));
            Teacher = new Dropdown(Driver, By.Id("Teacher"));
            Class = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.searchForm.classroomId\"]"));
            SearchButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.search()\"]"));
            StudentResultsTable = new Table(Driver, By.CssSelector("div[ng-show=\"vm.isMultiStudent\"] table[ng-show=\"vm.isStudentSearch\"]"));
            AttendanceByNameResultsTable = new Table(Driver, By.CssSelector("div[ng-show=\"vm.hasData\"] table[ng-show=\"vm.isStudentSearch\"]"));
            AttendanceByDateResultsTable = new Table(Driver, By.CssSelector("div[ng-show=\"vm.hasData\"] table[ng-show=\"!vm.isStudentSearch && vm.headerData\"]"));
            Flyout = new WebElement(Driver, By.CssSelector(".popover"));
        }
    }
}
