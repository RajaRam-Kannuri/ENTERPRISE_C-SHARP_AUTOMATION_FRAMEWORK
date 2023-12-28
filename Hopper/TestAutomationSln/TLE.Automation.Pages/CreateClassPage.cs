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
    public class CreateClassPage : CommonPage
    {
        public TypeAheadList Teacher { get; private set; }

        public TypeAheadList SchoolYear { get; private set; }

        public EditField Description { get; private set; }

        public TypeAheadList ClassPeriod { get; private set; }

        public TypeAheadList GradeLevel { get; private set; }

        public TypeAheadList GradingScale { get; private set; }

        public TypeAheadList Standards { get; private set; }

        public EditField Credits { get; private set; }

        public Checkbox UseWeightedGPA { get; private set; }

        public TypeAheadList GradingPeriod { get; private set; }

        public Button SaveAndAddNewButton { get; private set; }

        public Button SaveButton { get; private set; }

        public CreateClassPage(IWebDriver driver)
            : base(driver)
        {
            Teacher = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.teacherId\"]"));
            SchoolYear = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.schoolYearId\"]"));
            Description = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.description\"]"));
            ClassPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.period\"]"));
            GradeLevel = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedGradeLevels\"]"));
            Standards = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedSubject\"]"));
            GradingScale = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.gradingScaleGroupId\"]"));
            Credits = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.credits\"]"));
            UseWeightedGPA = new Checkbox(Driver, By.CssSelector("input[ng-model=\"vm.classFormModel.useWeightedScale\"]"));
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classFormModel.classEndingPeriodId\"]"));
            SaveAndAddNewButton = new Button(Driver, By.Id("btnSaveNew"));
            SaveButton = new Button(Driver, By.Id("btnSave"));
        }
    }
}
