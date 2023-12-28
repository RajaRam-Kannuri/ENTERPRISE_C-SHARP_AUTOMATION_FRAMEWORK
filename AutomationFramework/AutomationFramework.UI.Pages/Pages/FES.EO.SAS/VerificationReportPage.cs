using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class VerificationReportPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Dropdown VRType { get; private set; }

        public Dropdown VRPeriodId { get; private set; }

        public EditField StudentAwardId { get; private set; }

        public Dropdown VRReportId { get; private set; }

        public Button DisplayVRButton { get; private set; }

        public Button ResetSearchButton { get; private set; }

        public Table CurrentlyEnrolledStudentsTable { get; private set; }

        public Table ExitedStudentsTable { get; private set; }

        public Button UncertifyButton { get; private set; }

        public Button RefreshVRButton { get; private set; }

        public VerificationReportPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            VRType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlVRType\"]"));
            VRPeriodId = new Dropdown(driver, By.CssSelector("select[id$=\"ddlVRPeriod\"]"));
            StudentAwardId = new EditField(driver, By.CssSelector("input[id$=\"tbStudentAwardID\"]"));
            VRReportId = new Dropdown(driver, By.CssSelector("select[id$=\"ddlVRReport\"]"));
            DisplayVRButton = new Button(driver, By.CssSelector("input[$=\"btnSearch\"]"));
            ResetSearchButton = new Button(driver, By.CssSelector("input[$=\"btnReset\"]"));
            CurrentlyEnrolledStudentsTable = new Table(driver, By.CssSelector("table[id$=\"gvEnrolled\"]"));
            ExitedStudentsTable = new Table(driver, By.CssSelector("table[id$=\"gvExited\"]"));
            UncertifyButton = new Button(driver, By.CssSelector("input[id$=\"btnUnCertify\"]"));
        }
    }
}
