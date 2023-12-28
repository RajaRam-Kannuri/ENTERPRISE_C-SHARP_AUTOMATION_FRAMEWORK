using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationStatusPage : FTCPLIBasePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Text ApplicationId { get; private set; }

        public Table ScholarshipChildrenTable { get; private set; }

        public Button RequestMatrixReview { get; private set; }

        public ApplicationStatusPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationIDValue\"]"));
            ScholarshipChildrenTable = new Table(Driver, By.CssSelector("table[id$=\"ScholarshipChildrenStatus_DLStudents\"]"));
            RequestMatrixReview = new Button(Driver, By.CssSelector("input[id$=\"requestMatrixReview\"]"));
        }
    }
}
