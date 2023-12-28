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
    public class CreateLessonPlanPage : UnitPlanWizardPage
    {
        public EditField Topic { get; private set; }

        public EditField Date { get; private set; }

        public EditField Activities { get; private set; }

        public WebElement SelectedStandards { get; private set; }

        public EditField ResourcesAndMaterials { get; private set; }

        public Button EditInstructionalStrategiesButton { get; private set; }

        public Modal InstructionalStrategiesModal { get; private set; }

        public Button SaveInstructionalStrategies { get; private set; }

        public Button DifferentiatedInstructionButton { get; private set; }

        public WebElement DifferentiatedStudents { get; private set; }

        public Button DeleteLessonPlanButton { get; private set; }

        public Button SaveAndClose { get; private set; }

        public Button SaveAndNext { get; private set; }

        public CreateLessonPlanPage(IWebDriver driver)
            : base(driver)
        {
            Topic = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.topic\"]"));
            Date = new EditField(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.date\"]"));
            Activities = new EditField(Driver, By.CssSelector("textarea[data-ng-model=\"vm.createForm.activities\"]"));
            SelectedStandards = new WebElement(Driver, By.CssSelector(""));
            ResourcesAndMaterials = new EditField(Driver, By.CssSelector("textarea[data-ng-model=\"vm.createForm.resources\"]"));
            EditInstructionalStrategiesButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.openStrategies()\"]"));
            InstructionalStrategiesModal = new Modal(Driver, By.CssSelector(".modal-dialog #supportingStrategyContainer"));
            SaveInstructionalStrategies = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save();\"]"));
            DifferentiatedInstructionButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.differentiatedInstruction()\"]"));
            DifferentiatedStudents = new WebElement(Driver, By.CssSelector("div[ng-model=\"vm.selectedStudents\"]"));
            DeleteLessonPlanButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.deleteLessonPlan()\"]"));
            SaveAndClose = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(false)\"]"));
            SaveAndNext = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(true)\"]"));
        }
    }
}
