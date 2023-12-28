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
    public class PersonalLearningPlanListPage : CommonPage
    {
        public Text StudentName { get; private set; }

        public Text School { get; private set; }

        public Text StudentId { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Text Grade { get; private set; }

        public Button StudentDetailsButton { get; private set; }

        public PersonalLearningPlanListPage(IWebDriver driver)
            : base(driver)
        {
            StudentName = new Text(Driver, By.CssSelector(""));
            School = new Text(Driver, By.CssSelector(""));
            StudentId = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Dropdown(Driver, By.CssSelector(""));
            Grade = new Text(Driver, By.CssSelector(""));
            StudentDetailsButton = new Button(Driver, By.CssSelector(""));
        }
    }
}
