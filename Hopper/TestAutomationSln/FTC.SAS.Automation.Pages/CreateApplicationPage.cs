using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class CreateApplicationPage : HomePage
    {
        public EditField PrimaryGuardianEmail { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public EditField CloseApplicationDate { get; private set; }

        public Button CreateApplicationButton { get; private set; }

        public Text ApplicationCreationMessage { get; private set; }

        public CreateApplicationPage(IWebDriver driver)
            : base(driver)
        {
            PrimaryGuardianEmail = new EditField(Driver, By.CssSelector("input[id$=\"tbxEmail\"]"));
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYears\"]"));
            CloseApplicationDate = new EditField(Driver, By.CssSelector("input[id$=\"tbxDate\"]"));
            CreateApplicationButton = new Button(Driver, By.CssSelector("input[id$=\"btnSubmit\"]"));
            ApplicationCreationMessage = new Text(Driver, By.CssSelector("span[id$=\"lblFeedback\"]"));
        }
    }
}
