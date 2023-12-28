using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class Feature_UnitPlanCreateAssignmentPage : UnitPlanWizardPage
    {
        public CreateAssignmentControlSection CreateAssignmentControlSection { get; private set; }

        public Button SaveAndClose { get; private set; }

        public Button SaveAndNext { get; private set; }

        public Feature_UnitPlanCreateAssignmentPage(IWebDriver driver)
            : base(driver)
        {
            CreateAssignmentControlSection = new CreateAssignmentControlSection(Driver);
            SaveAndClose = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(false)\"]"));
            SaveAndNext = new Button(Driver, By.CssSelector("button[ng-click=\"vm.save(true)\"]"));
        }
    }
}
