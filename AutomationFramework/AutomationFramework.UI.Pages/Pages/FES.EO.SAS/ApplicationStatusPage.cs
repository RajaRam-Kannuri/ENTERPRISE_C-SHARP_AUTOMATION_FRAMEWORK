using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class ApplicationStatusPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public EditField SearchWithinResults { get; private set; }

        public Table StudentsTable { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(driver, By.CssSelector("select[id$=\"DdlScholarshipApplicationYear\"]"));
            SearchWithinResults = new EditField(driver, By.Id("tblResults_filter"));
            StudentsTable = new Table(driver, By.Id("tblResults"));
        }
    }
}
