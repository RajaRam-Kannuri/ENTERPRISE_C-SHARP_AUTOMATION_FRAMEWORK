using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class HomePage : BasePage
    {
        public Tab HomeTab { get; private set; }

        public Tab SchoolInfoTab { get; private set; }

        public Tab StudentInfoTab { get; private set; }

        public Tab MarketingToolsTab { get; private set; }

        public Tab VerificationReportTab { get; private set; }

        public Tab GraduationSurveyTab { get; private set; }

        public Tab ChangePasswordTab { get; private set; }

        public Text Username { get; private set; }

        public Link SignOut { get; private set; }

        public Text HeaderSchoolName { get; private set; }

        public Text GraduationSurveyMessage { get; private set; }

        public Button TakeSurveyNowButton { get; private set; }

        public Button TakeSurveyLaterButton { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            HomeTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=100\"]"));
            SchoolInfoTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=33\"]"));
            StudentInfoTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=39\"]"));
            MarketingToolsTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=127\"]"));
            VerificationReportTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=124\"]"));
            GraduationSurveyTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=141\"]"));
            ChangePasswordTab = new Tab(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=36\"]"));
            HeaderSchoolName = new Text(Driver, By.CssSelector("span[id$=\"_lblWelcomeSchool\"]"));
            GraduationSurveyMessage = new Text(Driver, By.Id("lblSurveyText"));
            TakeSurveyNowButton = new Button(Driver, By.Id("btnSurveyNow"));
            TakeSurveyLaterButton = new Button(Driver, By.Id("btnSurveyLater"));
            Username = new Text(Driver, By.Id("LblUsername"));
            SignOut = new Link(Driver, By.Id("LBSignOut"));
        }
    }
}
