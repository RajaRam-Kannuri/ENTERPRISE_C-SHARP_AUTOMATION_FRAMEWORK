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
    public class UnitPlanListPage : UnitPlanWizardPage
    {
        public Link CreateUnitPlanLink { get; private set; }

        public Text School { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Dropdown GradingPeriod { get; private set; }

        public Table UnitPlanTable { get; protected set; }

        public UnitPlanListPage(IWebDriver driver)
            : base(driver)
        {
            CreateUnitPlanLink = new Link(Driver, By.CssSelector("a[href$=\"/UnitPlans/Create\"]"));
            School = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Dropdown(Driver, By.CssSelector(""));
            GradingPeriod = new Dropdown(Driver, By.Id("SelectedAcademicPeriodId"));
            UnitPlanTable = new Table(Driver, By.Id("unitPlans"));
        }
    }
}
