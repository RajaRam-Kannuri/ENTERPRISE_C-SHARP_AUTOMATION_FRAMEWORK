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
    public class GradeBookControlSection : ControlSection
    {
        public TypeAheadList Class { get; private set; }

        public TypeAheadList GradingPeriod { get; private set; }

        public TypeAheadList DisplayOrder { get; private set; }

        public Link AddAssignmentButton { get; private set; }

        public Button SaveButton { get; private set; }

        public DivTable GradesTable { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField AssignmentScore { get; private set; }

        public Text ToastSuccess { get; private set; }

        public GradeBookControlSection(IWebDriver driver)
            : base(driver)
        {
            Class = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.classRoomId\"]"));
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedGradingPeriodId\"]"));
            DisplayOrder = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedSortId\"]"));
            AddAssignmentButton = new Link(Driver, By.CssSelector("button[ng-click=\"vm.addAssignment()\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[ng-click=\"vm.save()\"]"));
            GradesTable = new DivTable(Driver, By.CssSelector(".ui-grid-contents-wrapper"));
            AssignmentScore = new EditField(Driver, By.CssSelector("input[ng-model^=\"row.entity['classRoomStudentAssignments']\"][ng-model$=\"['earnedPoints']\"]"));
            ToastSuccess = new Text(Driver, By.CssSelector(".toast-success"));
        }
    }
}
