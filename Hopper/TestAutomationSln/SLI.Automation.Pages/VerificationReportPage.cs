using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SLI.Automation.Pages
{
    public class VerificationReportPage : HomePage
    {
        public Table ExitedStudentsTable { get; private set; }

        public Button GoToCertifyButton { get; private set; }

        public Text TotalStudentsInPeriod { get; private set; }

        public VerificationReportPage(IWebDriver driver)
            : base(driver)
        {
            ExitedStudentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvExited\"]"));
            GoToCertifyButton = new Button(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            TotalStudentsInPeriod = new Text(Driver, By.CssSelector("span[id$=\"lblTotalStudentsValue\"]"));
            // In case we need them, the uniquely identifiable bits of the student data fields are here
            // lblStudentName
            // lblGradeLevel
        }
    }
}
