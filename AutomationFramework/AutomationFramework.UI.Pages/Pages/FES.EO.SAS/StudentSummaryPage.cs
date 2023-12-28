using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class StudentSummaryPage : HomePage
    {
        public Dropdown ReportSchoolYear { get; private set; }

        public Dropdown ApplicationStatus { get; private set; }

        public Dropdown ApplicationType { get; private set; }

        public Dropdown HouseholdLanguage { get; private set; }

        public Dropdown StudentStatus { get; private set; }

        public Dropdown StudentType { get; private set; }

        public Dropdown PaperApplications { get; private set; }

        public Dropdown AppealApplications { get; private set; }

        public Dropdown Format { get; private set; }

        public Button ViewReportButton { get; private set; }

        public Table ApplicationStudentDetailsTable { get; private set; }

        public Text ReportNumberOfStudentsText { get; private set; }

        public StudentSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ReportSchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            ApplicationStatus = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationStatus\"]"));
            ApplicationType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlApplicationType\"]"));
            HouseholdLanguage = new Dropdown(driver, By.CssSelector("select[id$=\"ddlHouseholdLanguage\"]"));
            StudentStatus = new Dropdown(driver, By.CssSelector("select[id$=\"ddlStudentStatus\"]"));
            StudentType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlStudentType\"]"));
            PaperApplications = new Dropdown(driver, By.CssSelector("select[id$=\"ddlPaper\"]"));
            AppealApplications = new Dropdown(driver, By.CssSelector("select[id$=\"ddlAppeal\"]"));
            Format = new Dropdown(driver, By.CssSelector("select[id$=\"ddlFormat\"]"));
            ViewReportButton = new Button(driver, By.CssSelector("input[id$=\"btnReport\"]"));
            ApplicationStudentDetailsTable = new Table(driver, By.CssSelector(".a191"));
            ReportNumberOfStudentsText = new Text(driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(24) > td:nth-child(3) > table > tbody > tr:nth-child(3) > td.a79c.r6 > div"));
        }
    }
}
