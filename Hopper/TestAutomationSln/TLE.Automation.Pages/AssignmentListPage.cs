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
    public class AssignmentListPage : UnitPlanWizardPage
    {
        public Text GradingPeriod { get; private set; }

        public Text Class { get; private set; }

        public Text UnitPlan { get; private set; }

        public Button CreateAssignmentButton { get; private set; }

        public Button SaveUnitPlanAsTemplateButton { get; private set; }

        public AssignmentListPage(IWebDriver driver)
            : base(driver)
        {
            GradingPeriod = new Text(Driver, By.CssSelector(""));
            Class = new Text(Driver, By.CssSelector(""));
            UnitPlan = new Text(Driver, By.CssSelector(""));
            CreateAssignmentButton = new Button(Driver, By.CssSelector("a[href$=\"/Assignments/Create\"]"));
            SaveUnitPlanAsTemplateButton = new Button(Driver, By.CssSelector(""));
        }
    }
}
