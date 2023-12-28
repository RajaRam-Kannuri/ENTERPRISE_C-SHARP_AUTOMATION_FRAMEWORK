using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class EditEnrollmentPage : CommonPage
    {
        public Text Name { get; private set; }

        public Dropdown GradeLevel { get; private set; }

        public Dropdown StandardsLevel { get; private set; }

        public Button RemoveFromClass { get; private set; }

        public Button SaveButton { get; private set; }

        public EditEnrollmentPage(IWebDriver driver)
            : base(driver)
        {
            Name = new Text(Driver, By.CssSelector(""));
            GradeLevel = new Dropdown(Driver, By.CssSelector(""));
            StandardsLevel = new Dropdown(Driver, By.Id("Enrollment_StudentGradeLevelId"));
            RemoveFromClass = new Button(Driver, By.Id("Enrollment_Active"));
            SaveButton = new Button(Driver, By.Name("save"));
        }
    }
}
