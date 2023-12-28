using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class StudentGradesPage : CommonPage
    {
        public Text CurrentGradeLevel { get; private set; }

        public Dropdown NextYearPlacementLevel { get; private set; }

        public Table GradingPeriodsTable { get; private set; }

        public Button SaveButton { get; private set; }

        public StudentGradesPage(IWebDriver driver)
            : base(driver)
        {
            CurrentGradeLevel = new Text(Driver, By.CssSelector(""));
            NextYearPlacementLevel = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.model.nextGradeLevelId\"]"));
            GradingPeriodsTable = new Table(Driver, By.CssSelector(".table-striped"));
            SaveButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(item)\"]"));
        }
    }
}
