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
    public class ParticipationAuthorizationPage : HomePage
    {
        public Dropdown AuthorizationSchoolYear { get; private set; }

        public Dropdown SUFSParticipant { get; private set; }

        public EditField EffectiveDate { get; private set; }

        public Button SaveAuthorizationButton { get; private set; }

        public Dropdown Reason { get; private set; }

        public Text ValidationErrors { get; private set; }

        public ParticipationAuthorizationPage(IWebDriver driver)
            : base(driver)
        {
            AuthorizationSchoolYear = new Dropdown(Driver, By.CssSelector("select[id*=\"participationauthorization\"][id$=\"ddlSchoolYear\"]"));
            SUFSParticipant = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolParticipant\"]"));
            EffectiveDate = new EditField(Driver, By.CssSelector("input[id$=\"tbxEffectiveDate\"]"));
            SaveAuthorizationButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveSchoolParticipation\"]"));
            Reason = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlReason\"]"));
            ValidationErrors = new Text(Driver, By.Id("VSControlValidationSummary"));
        }
    }
}
