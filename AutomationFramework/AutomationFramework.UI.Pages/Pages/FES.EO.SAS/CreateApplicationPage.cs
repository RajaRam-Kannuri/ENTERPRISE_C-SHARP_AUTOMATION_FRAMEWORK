using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
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
            PrimaryGuardianEmail = new EditField(driver, By.CssSelector("input[id$=\"tbxEmail\"]"));
            SchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolYears\"]"));
            CloseApplicationDate = new EditField(driver, By.CssSelector("input[id$=\"tbxDate\"]"));
            CreateApplicationButton = new Button(driver, By.CssSelector("input[id$=\"btnSubmit\"]"));
            ApplicationCreationMessage = new Text(driver, By.CssSelector("span[id$=\"lblFeedback\"]"));
        }
    }
}
