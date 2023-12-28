using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class Feature_UnitPlanGradeBookPage : UnitPlanWizardPage
    {
        public GradeBookControlSection GradeBookControlSection { get; private set; }

        public Feature_UnitPlanGradeBookPage(IWebDriver driver)
            : base(driver)
        {
            GradeBookControlSection = new GradeBookControlSection(Driver);
        }
    }
}
