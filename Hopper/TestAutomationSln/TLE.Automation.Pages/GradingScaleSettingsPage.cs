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
    public class GradingScaleSettingsPage : CommonPage
    {
        public Radio CalculatedGradingScale { get; private set; }

        public Radio AlternateGradingScale { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public EditField Description { get; private set; }

        public Checkbox AutomaticallyRoundUp { get; private set; }

        public Table DefaultGradingScaleTable { get; private set; }

        public Link AddGradeLink { get; private set; }

        public Button SaveButton { get; private set; }

        public GradingScaleSettingsPage(IWebDriver driver)
            : base(driver)
        {
            CalculatedGradingScale = new Radio(Driver, By.Id("rbCalculated"));
            AlternateGradingScale = new Radio(Driver, By.Id("rbAlternate"));
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[ng-model=\"vm.selectedSchoolYear\"]"));
            Description = new EditField(Driver, By.CssSelector("input[name=\"description\"]"));
            AutomaticallyRoundUp = new Checkbox(Driver, By.CssSelector("input[data-ng-model$=\"roundGrades\"]"));
            DefaultGradingScaleTable = new Table(Driver, By.CssSelector(".table-condensed"));
            AddGradeLink = new Link(Driver, By.CssSelector("button[data-ng-click=\"vm.addDefaultScale()\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[value=\"Save\"]"));
        }
    }
}
