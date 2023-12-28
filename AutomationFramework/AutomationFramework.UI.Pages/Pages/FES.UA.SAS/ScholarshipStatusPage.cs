using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ScholarshipStatusPage : HomePage
    {
        public Table ScholarshipStatusTable { get; private set; }

        public Dropdown StudentScholarshipStatus { get; private set; }

        public Button UpdateStudentScholarshipStatusButton { get; private set; }

        public ScholarshipStatusPage(IWebDriver driver)
            : base(driver)
        {
            ScholarshipStatusTable = new Table(driver, By.Id("tblHistoricalStatus"));
            StudentScholarshipStatus = new Dropdown(driver, By.CssSelector("select[id$=\"ddlScholarshipStatus\"]"));
            UpdateStudentScholarshipStatusButton = new Button(driver, By.CssSelector("input[id$=\"btnUpdateStatus\"]"));
        }
    }
}