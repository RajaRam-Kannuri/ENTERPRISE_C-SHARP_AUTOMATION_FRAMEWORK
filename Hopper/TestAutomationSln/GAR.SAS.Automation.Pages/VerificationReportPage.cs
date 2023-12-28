using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class VerificationReportPage : HomePage
    {
        public Table CurrentlyEnrolledStudentsTable { get; private set; }

        public Table ExitedStudentsTable { get; private set; }

        public VerificationReportPage(IWebDriver driver)
            : base(driver)
        {
            CurrentlyEnrolledStudentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvEnrolled\"]"));
            ExitedStudentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvExited\"]"));
        }
    }
}
