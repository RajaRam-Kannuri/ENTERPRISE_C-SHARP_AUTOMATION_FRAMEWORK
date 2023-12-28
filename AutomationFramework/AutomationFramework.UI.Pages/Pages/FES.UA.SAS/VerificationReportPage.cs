using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class VerificationReportPage : HomePage
    {
        public Table CurrentlyEnrolledStudentsTable { get; private set; }

        public Table ExitedStudentsTable { get; private set; }

        public VerificationReportPage(IWebDriver driver)
            : base(driver)
        {
            CurrentlyEnrolledStudentsTable = new Table(driver, By.CssSelector("table[id$=\"gvEnrolled\"]"));
            ExitedStudentsTable = new Table(driver, By.CssSelector("table[id$=\"gvExited\"]"));
        }
    }
}