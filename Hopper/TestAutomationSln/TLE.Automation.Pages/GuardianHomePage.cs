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
    public class GuardianHomePage : BasePage
    {
        public Text GuardianName { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Table StudentsTable { get; private set; }

        public GuardianHomePage(IWebDriver driver)
            : base(driver)
        {
            GuardianName = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Dropdown(Driver, By.CssSelector(""));
            StudentsTable = new Table(Driver, By.CssSelector(".table.fluid"));
        }
    }
}
