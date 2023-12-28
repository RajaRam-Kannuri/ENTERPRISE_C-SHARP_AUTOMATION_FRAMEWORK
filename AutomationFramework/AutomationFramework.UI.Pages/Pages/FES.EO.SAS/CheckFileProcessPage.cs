using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class CheckFileProcessPage : BasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Dropdown VerificationPeriod { get; private set; }

        public Text CurrentVRPeriod { get; private set; }

        public Button RunCheckFileProcess { get; private set; }

        public CheckFileProcessPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(driver, By.CssSelector("input[id$=\"ddlSchoolYear\"]"));
            VerificationPeriod = new Dropdown(driver, By.CssSelector("input[id$=\"ddlVRPeriod\"]"));
            CurrentVRPeriod = new Text(driver, By.CssSelector("input[id$=\"lblVRPeriodReportID\"]"));
            RunCheckFileProcess = new Button(driver, By.CssSelector("input[id$=\"btnCheckFile\"]"));
        }
    }
}
