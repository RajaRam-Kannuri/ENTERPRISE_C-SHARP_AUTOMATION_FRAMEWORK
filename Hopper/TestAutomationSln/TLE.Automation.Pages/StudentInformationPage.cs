using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class StudentInformationPage : CommonPage
    {
        public Button EditStudentInfoButton { get; private set; }

        public Button PersonalLearningPlanButton { get; protected set; }

        public Table EnrollmentsTable { get; private set; }

        public StudentInformationPage(IWebDriver driver)
            : base(driver)
        {
            EditStudentInfoButton = new Button(Driver, By.Id("btnEditStudent"));
            PersonalLearningPlanButton = new Button(Driver, By.Id("btnPLP"));
            EnrollmentsTable = new Table(Driver, By.CssSelector(".table.fluid"));
        }
    }
}
