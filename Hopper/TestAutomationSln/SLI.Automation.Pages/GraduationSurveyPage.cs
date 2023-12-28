using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class GraduationSurveyPage : HomePage
    {
        public Table TwelfthGraders { get; private set; }

        public Table EleventhGraders { get; private set; }

        public Button SaveButton { get; private set; }

        public Button SubmitButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public Text SurveyCompleteMessage { get; private set; }

        public GraduationSurveyPage(IWebDriver driver)
            : base(driver)
        {
            TwelfthGraders = new Table(Driver, By.CssSelector("table[id$=\"_gvStudentsSurvey\"]"));
            EleventhGraders = new Table(Driver, By.CssSelector("table[id$=\"_gvStudents11thSurvey\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[id$=\"_btnSave\"]"));
            SubmitButton = new Button(Driver, By.CssSelector("input[id$=\"_btnSubmit\"]"));
            StatusMessage = new Text(Driver, By.CssSelector("span[id$=\"cvSurveyAnswers\"]"));
            SurveyCompleteMessage = new Text(Driver, By.CssSelector("div[id$=\"divMessage\"]"));
        }
    }
}
