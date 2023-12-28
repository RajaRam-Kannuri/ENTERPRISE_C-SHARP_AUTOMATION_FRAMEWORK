using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class GuardianUnitPlanListPage : UnitPlanListPage
    {
        public GuardianUnitPlanListPage(IWebDriver driver) : base(driver)
        {
            UnitPlanTable = new Table(Driver, By.CssSelector(".table.fluid"));
        }
    }
}
