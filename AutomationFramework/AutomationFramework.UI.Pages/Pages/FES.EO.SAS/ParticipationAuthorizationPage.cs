using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
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
            AuthorizationSchoolYear = new Dropdown(driver, By.CssSelector("select[id*=\"participationauthorization\"][id$=\"ddlSchoolYear\"]"));
            SUFSParticipant = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolParticipant\"]"));
            EffectiveDate = new EditField(driver, By.CssSelector("input[id$=\"tbxEffectiveDate\"]"));
            SaveAuthorizationButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveSchoolParticipation\"]"));
            Reason = new Dropdown(driver, By.CssSelector("select[id$=\"ddlReason\"]"));
            ValidationErrors = new Text(driver, By.Id("VSControlValidationSummary"));
        }
    }
}
