using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class StudentDetailPage : HomePage
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

        public Table ApplicationTable { get; private set; }

        public StudentDetailPage(IWebDriver driver)
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
            ApplicationTable = new Table(driver, By.CssSelector(@"#\35 xB_gr > table > tbody > tr:nth-child(30) > td:nth-child(3) > table"));
        }
    }
}