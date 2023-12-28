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
    public class CreateAssignmentControlSection : ControlSection
    {
        public TypeAheadList Type { get; private set; }

        public EditField Title { get; private set; }

        public EditField Assignment { get; private set; }

        public EditField AttachedFiles { get; private set; }

        public EditField DueDate { get; private set; }

        public EditField Points { get; private set; }

        public TypeAheadList AssociatedUnitPlan { get; private set; }

        public Button DeleteButton { get; private set; }

        public CreateAssignmentControlSection(IWebDriver driver)
            : base(driver)
        {
            Type = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.assignment.performanceMeasureTypeId\"]"));
            Title = new EditField(Driver, By.Id("title"));
            Assignment = new EditField(Driver, By.CssSelector("textarea[ng-model=\"vm.assignment.description\"]"));
            AttachedFiles = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.files\"]"));
            DueDate = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.assignment.dueDate\"]"));
            Points = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.assignment.possiblePoints\"]"));
            AssociatedUnitPlan = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.assignment.unitPlanId\"]"));
            DeleteButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.deleteAssignment()\"]"));
        }
    }
}
