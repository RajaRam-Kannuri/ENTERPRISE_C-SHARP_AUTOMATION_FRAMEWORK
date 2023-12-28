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
    public class AttendanceReportPage : CommonPage
    {
        public Dropdown SchoolYear { get; private set; }

        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public Dropdown DayOfTheWeek { get; private set; }

        public Dropdown Teacher { get; private set; }

        public EditField StudentLastName { get; private set; }

        public Dropdown GradeLevel { get; private set; }

        public Dropdown Period { get; private set; }

        public Button ViewReportButton { get; private set; }

        public Table AttendanceTable { get; private set; }

        public AttendanceReportPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.selectedSchoolYear\"]"));
            StartDate = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.reportForm.startDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.reportForm.endDate\"]"));
            DayOfTheWeek = new Dropdown(Driver, By.Id("DayOfWeek"));
            Teacher = new Dropdown(Driver, By.Id("Teachers"));
            StudentLastName = new EditField(Driver, By.Id("txtStudentLastName"));
            GradeLevel = new Dropdown(Driver, By.Id("GradeLevel"));
            Period = new Dropdown(Driver, By.Id("Period"));
            ViewReportButton = new Button(Driver, By.Id("btnViewReport"));
            AttendanceTable = new Table(Driver, By.CssSelector(".reportData"));
        }
    }
}
