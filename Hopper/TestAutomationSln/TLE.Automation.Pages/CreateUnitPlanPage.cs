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
    public class CreateUnitPlanPage : UnitPlanWizardPage
    {
        public TypeAheadList TemplateName { get; private set; }

        public EditField Title { get; private set; }

        public TypeAheadList GradingPeriod { get; private set; }

        public EditField StartDate { get; private set; }

        public EditField EndDate { get; private set; }

        public Button EditStandardsButton { get; private set; }

        public Button DeleteUnitPlanButton { get; private set; }

        public Button SaveAndClose { get; private set; }

        public Button SaveAndNext { get; private set; }

        public Modal StandardsModal { get; private set; }

        public Button SaveStandards { get; private set; }

        public Text CoveredStandards { get; private set; }

        public CreateUnitPlanPage(IWebDriver driver)
            : base(driver)
        {
            //TemplateName = new WebElement(Driver, By.Id("UnitPlanTemplate"));
            TemplateName = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.selectedUnitPlanTemplate\"]"));
            Title = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.createForm.title\"]"));
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model=\"vm.createForm.selectedAcademicPeriod\"]"));
            StartDate = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.createForm.startDate\"]"));
            EndDate = new EditField(Driver, By.CssSelector("input[ng-model=\"vm.createForm.endDate\"]"));
            EditStandardsButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.openStandards()\"]"));
            DeleteUnitPlanButton = new Button(Driver, By.CssSelector("button[ng-click=\"vm.deleteUnitPlan()\"]"));
            SaveAndClose = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(false)\"]"));
            SaveAndNext = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(true)\"]"));
            StandardsModal = new Modal(Driver, By.CssSelector(".modal-dialog"));
            SaveStandards = new Button(Driver, By.CssSelector("button[ng-click=\"modalCtrl.save();\"]"));
            CoveredStandards = new Text(Driver, By.CssSelector(".supportStrategyContent"));
        }
    }
}
