using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ChoosePerformanceMeasuresPage : UnitPlanWizardPage
    {
        public Radio PointsBasedSystemRadio { get; private set; }

        public Radio WeightedSystemRadio { get; private set; }

        public Button SaveAndNext { get; private set; }

        public ChoosePerformanceMeasuresPage(IWebDriver driver)
            : base(driver)
        {
            PointsBasedSystemRadio = new Radio(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.usesWeightedSystem\"][value=\"false\"]"));
            WeightedSystemRadio = new Radio(Driver, By.CssSelector("input[data-ng-model=\"vm.createForm.usesWeightedSystem\"][value=\"false\"]"));
            SaveAndNext = new Button(Driver, By.CssSelector("button[data-ng-click=\"vm.save(true)\"]"));
        }
    }
}
