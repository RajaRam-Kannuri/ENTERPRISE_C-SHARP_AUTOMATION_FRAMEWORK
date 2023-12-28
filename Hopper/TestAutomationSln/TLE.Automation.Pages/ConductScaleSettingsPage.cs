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
    public class ConductScaleSettingsPage : CommonPage
    {
        public Dropdown ScaleSchoolYear { get; private set; }

        public Button SaveConductGradesButton { get; private set; }

        public ConductScaleSettingsPage(IWebDriver driver)
            : base(driver)
        {
            ScaleSchoolYear = new Dropdown(Driver, By.CssSelector("select[ng-model='vm.selectedSchoolYear']"));
            SaveConductGradesButton = new Button(Driver, By.CssSelector("input[ng-show$='isConductGradeEditable'][type='submit']"));
        }
    }
}
