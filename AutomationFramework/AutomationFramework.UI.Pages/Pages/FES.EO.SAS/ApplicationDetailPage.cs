using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class ApplicationDetailPage : HomePage
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

        public ApplicationDetailPage(IWebDriver driver)
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
        }
    }
}
