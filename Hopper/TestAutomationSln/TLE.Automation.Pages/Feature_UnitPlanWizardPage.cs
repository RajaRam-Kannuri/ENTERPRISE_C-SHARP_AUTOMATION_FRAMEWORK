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
    public abstract class Feature_UnitPlanWizardPage : CommonPage
    {
        public Link EditUnitPlanStep { get; private set; }

        public Link AddLessonPlansStep { get; private set; }

        public Link AddAssignmentsStep { get; private set; }

        public Link EnterGradesStep { get; private set; }

        public Feature_UnitPlanWizardPage(IWebDriver driver)
            : base(driver)
        {
            EditUnitPlanStep = new Link(Driver, By.CssSelector("a[href*=\"/UnitPlans/Edit\"]"));
            AddLessonPlansStep = new Link(Driver, By.CssSelector("a[href$=\"/LessonPlans\"]"));
            AddAssignmentsStep = new Link(Driver, By.CssSelector("a[href$=\"/Assignments\"]"));
            EnterGradesStep = new Link(Driver, By.CssSelector("a[href$=\"/Gradebook\"]"));
        }
    }
}
