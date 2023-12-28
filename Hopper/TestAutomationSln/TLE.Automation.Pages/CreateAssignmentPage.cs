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
    public class CreateAssignmentPage : UnitPlanWizardPage
    {
        public Dropdown Type { get; private set; }

        public EditField Assignment { get; private set; }

        public EditField AttachedFiles { get; private set; }

        public EditField DueDate { get; private set; }

        public EditField Points { get; private set; }

        public Button DeleteAssignment { get; private set; }

        public Button SaveAndClose { get; private set; }

        public Button SaveAndNext { get; private set; }

        public CreateAssignmentPage(IWebDriver driver)
            : base(driver)
        {
            Type = new Dropdown(Driver, By.CssSelector("select[data-ng-model=\"vm.createForm.performanceMeasureTypeId\"]"));
            Assignment = new EditField(Driver, By.CssSelector("textarea[data-ng-model=\"vm.createForm.description\"]"));
            AttachedFiles = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.files\"]"));
            DueDate = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.dueDate\"]"));
            Points = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.possiblePoints\"]"));
            DeleteAssignment = new Button(Driver, By.CssSelector("button[ng-click=\"vm.deleteAssignment()\"]"));
            SaveAndClose = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(false)\"]"));
            SaveAndNext = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(true)\"]"));
        }
    }
}
