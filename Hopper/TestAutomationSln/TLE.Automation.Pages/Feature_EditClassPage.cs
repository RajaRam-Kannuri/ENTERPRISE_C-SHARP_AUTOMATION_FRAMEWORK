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
    public class Feature_EditClassPage : CommonPage
    {
        public WebElement ProgressMeter { get; private set; }

        public TypeAheadList Teacher { get; private set; }

        public TypeAheadList ClassSchoolYear { get; private set; }

        public EditField Description { get; private set; }

        public TypeAheadList ClassPeriod { get; private set; }

        public TypeAheadList GradeLevel { get; private set; }

        public TypeAheadList StandardSubject { get; private set; }

        public TypeAheadList GradingScale { get; private set; }

        public EditField Credits { get; private set; }

        public TypeAheadList GradingPeriod { get; private set; }

        public Radio PointsBasedSystem { get; private set; }

        public Radio WeightedSystem { get; private set; }

        public Button CancelButton { get; private set; }

        public Button BackButton { get; private set; }

        public Button NextButton { get; private set; }

        public Button SaveButton { get; private set; }

        public Feature_EditClassPage(IWebDriver driver)
            : base(driver)
        {
            ProgressMeter = new WebElement(Driver, By.CssSelector(".progress-bar"));
            Teacher = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.teacherId\"]"));
            ClassSchoolYear = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.schoolYearId\"]"));
            Description = new EditField(Driver, By.CssSelector("input[name=\"description\"]"));
            ClassPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.period\"]"));
            GradeLevel = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedGradeLevels\"]"));
            StandardSubject = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedSubject\"]"));
            GradingScale = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedGradingScale\"]"));
            Credits = new EditField(Driver, By.CssSelector("input[name=\"credits\"]"));
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[name=\"classEndingPeriod\"]"));
            PointsBasedSystem = new Radio(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.useWeightedSystem\"][ng-value=\"false\"]"));
            WeightedSystem = new Radio(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.useWeightedSystem\"][ng-value=\"true\"]"));
            CancelButton = new Button(Driver, By.CssSelector("input[value=\"Cancel\"]"));
            BackButton = new Button(Driver, By.CssSelector("input[value=\"Back\"]"));
            NextButton = new Button(Driver, By.CssSelector("input[value=\"Next\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[value=\"Save\"]"));
        }
    }
}
