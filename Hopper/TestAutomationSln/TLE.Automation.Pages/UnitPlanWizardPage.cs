using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public abstract class UnitPlanWizardPage : CommonPage
    {
        public Link EditUnitPlanStep { get; private set; }

        public Link AddLessonPlansStep { get; private set; }

        public Link ChoosePerformanceMeasuresStep { get; private set; }

        public Link AddAssignmentsStep { get; private set; }

        public Link EnterGradesStep { get; private set; }

        public UnitPlanWizardPage(IWebDriver driver)
            : base(driver)
        {
            EditUnitPlanStep = new Link(Driver, By.CssSelector("a[href*=\"/UnitPlans/Edit\"]"));
            AddLessonPlansStep = new Link(Driver, By.CssSelector("a[href$=\"/LessonPlans\"]"));
            ChoosePerformanceMeasuresStep = new Link(Driver, By.CssSelector("a[href$=\"/PerformanceMeasures\"]"));
            AddAssignmentsStep = new Link(Driver, By.CssSelector("a[href$=\"/Assignments\"]"));
            EnterGradesStep = new Link(Driver, By.CssSelector("a[href$=\"/Gradebook\"]"));
        }
    }
}
