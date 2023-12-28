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
    public class LessonPlanListPage : UnitPlanWizardPage
    {
        public Link CreateLessonPlanLink { get; private set; }

        public Text Class { get; private set; }

        public Text GradingPeriod { get; private set; }

        public Text UnitPlan { get; private set; }

        public Table UnitPlanTable { get; private set; }

        public LessonPlanListPage(IWebDriver driver)
            : base(driver)
        {
            CreateLessonPlanLink = new Link(Driver, By.Id("btnAddLessonPlan"));
            Class = new Text(Driver, By.CssSelector(""));
            GradingPeriod = new Text(Driver, By.CssSelector(""));
            UnitPlan = new Text(Driver, By.CssSelector(""));
            UnitPlanTable = new Table(Driver, By.CssSelector(""));
        }
    }
}
