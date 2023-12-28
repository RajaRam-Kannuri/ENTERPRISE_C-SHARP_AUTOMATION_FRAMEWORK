using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class EnrollmentSurveyPage : BasePage
    {
        public Button SaveButton { get; private set; }

        public Text SurveyQuestion { get; private set; }

        public EnrollmentSurveyPage(IWebDriver driver)
            : base(driver)
        {
            SaveButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveResponse\"]"));
            SurveyQuestion = new Text(Driver, By.CssSelector("span[id$=\"survey\"][id$=\"lblQuestion\"]"));
        }
    }
}
