using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ClassGradesPage : HomePage
    {
        public Text ClassDescription { get; private set; }

        public TypeAheadList GradingPeriod { get; private set; }

        public Text ClassGradesSchoolYear { get; private set;  }

        public Table StudentsTable { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField Comment { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Checkbox RequestParentConference { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public TypeAheadList ConductGrade { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public TypeAheadList ConductComments { get; private set; }

        public Button SaveButton { get; private set; }

        public ClassGradesPage(IWebDriver driver)
            : base(driver)
        {
            ClassDescription = new Text(Driver, By.CssSelector(""));
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-show=\"vm.model.availableAcademicPeriods != null\"]"));
            ClassGradesSchoolYear = new Text(Driver, By.CssSelector(""));
            StudentsTable = new Table(Driver, By.CssSelector(".table.table-striped"));
            Comment = new EditField(Driver, By.CssSelector("textarea[ng-model=\"gp.notes\"]"));
            RequestParentConference = new Checkbox(Driver, By.CssSelector("input[ng-model=\"gp.isConferenceRequested\"]"));
            ConductGrade = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"gp.conductGradeId\"]"));
            ConductComments = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"gp.conductCommentIds\"]"));
            SaveButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save()\"]"));
        }
    }
}
