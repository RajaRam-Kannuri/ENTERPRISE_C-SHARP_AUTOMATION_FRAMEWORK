using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class GuardianGradeBookPage : CommonPage
    {
        public TypeAheadList GradingPeriod { get; }

        public GuardianGradeBookPage(IWebDriver driver)
            : base(driver)
        {
            GradingPeriod = new TypeAheadList(Driver, By.CssSelector("div[ng-model='vm.selectedAcademicPeriodId']"));
        }
    }
}
