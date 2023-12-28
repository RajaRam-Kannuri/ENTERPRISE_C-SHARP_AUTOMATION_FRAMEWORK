using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class GuardianStudentInformationPage : StudentInformationPage
    {
        public GuardianStudentInformationPage(IWebDriver driver)
            : base(driver)
        {
            PersonalLearningPlanButton = new Button(Driver, By.CssSelector("a[href*=\"/LearningPlanList\"]"));
        }
    }
}
