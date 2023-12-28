using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
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
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            VRType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRType\"]"));
            VRPeriodId = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRPeriod\"]"));
            StudentAwardId = new EditField(Driver, By.CssSelector("input[id$=\"tbStudentAwardID\"]"));
            VRReportId = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRReport\"]"));
            DisplayVRButton = new Button(Driver, By.CssSelector("input[$=\"btnSearch\"]"));
            ResetSearchButton = new Button(Driver, By.CssSelector("input[$=\"btnReset\"]"));
            CurrentlyEnrolledStudentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvEnrolled\"]"));
            ExitedStudentsTable = new Table(Driver, By.CssSelector("table[id$=\"gvExited\"]"));
            UncertifyButton = new Button(Driver, By.CssSelector("input[id$=\"btnUnCertify\"]"));
        }
    }
}
