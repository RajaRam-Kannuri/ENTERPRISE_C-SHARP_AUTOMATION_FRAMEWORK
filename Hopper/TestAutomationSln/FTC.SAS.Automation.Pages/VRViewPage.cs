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
    public class VRViewPage : HomePage
    {
        public Dropdown VRSchoolYear { get; private set; }

        public Dropdown VRType { get; private set; }

        public Dropdown VRPeriodId { get; private set; }

        public EditField StudentAwardId { get; private set; }

        public Dropdown VRReportId { get; private set; }

        public Button DisplayVR { get; private set; }

        public Button ResetSearchFields { get; private set; }

        public Text VRSummary { get; private set; }

        public Text VRStatus { get; private set; }

        public WebElement ProgressBar { get; private set; }

        public Link SchoolContacts { get; private set; }

        public Text TotalStudentsForDistributionPeriod { get; private set; }

        public Text SchoolStartDate { get; private set; }

        public Text CurrentlyEnrolledStudents { get; private set; }

        public Table CurrentlyEnrolledStudentsTable { get; private set; }

        public EditField FilterCurrentlyEnrolledStudentsTable { get; private set; }

        public Text ExitedStudentsDue { get; private set; }

        public Table ExitedStudentsDueTable { get; private set; }

        public EditField FilterExitedStudentsTable { get; private set; }

        public Modal SchoolContactsDialog { get; private set; }

        public EditField FilterSchoolContactsTable { get; private set; }

        public Table SchoolContactsTable { get; private set; }

        public Link CloseSchoolContactsDialog { get; private set; }

        public VRViewPage(IWebDriver driver)
            : base(driver)
        {
            VRSchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            VRType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRType\"]"));
            VRPeriodId = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRPeriod\"]"));
            StudentAwardId = new EditField(Driver, By.CssSelector("input[id$=\"tbStudentAwardID\"]"));
            VRReportId = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlVRReport\"]"));
            DisplayVR = new Button(Driver, By.CssSelector("input[id$=\"btnSearch\"]"));
            ResetSearchFields = new Button(Driver, By.CssSelector("input[id$=\"btnReset\"]"));
            VRSummary = new Text(Driver, By.Id(""));
            VRStatus = new Text(Driver, By.Id(""));
            ProgressBar = new WebElement(Driver, By.CssSelector("div[id$=\"_progressbarvalue\"]"));
            SchoolContacts = new Link(Driver, By.ClassName("SchoolContactLink"));
            TotalStudentsForDistributionPeriod = new Text(Driver, By.Id(""));
            SchoolStartDate = new Text(Driver, By.Id(""));
            CurrentlyEnrolledStudents = new Text(Driver, By.Id(""));
            CurrentlyEnrolledStudentsTable = new Table(Driver, By.Id("tblCurrentlyEnrolled"));
            FilterCurrentlyEnrolledStudentsTable = new EditField(Driver, By.CssSelector("#tblCurrentlyEnrolled_filter > label > input"));
            ExitedStudentsDue = new Text(Driver, By.Id(""));
            ExitedStudentsDueTable = new Table(Driver, By.Id("tblUnEnrolled"));
            FilterExitedStudentsTable = new EditField(Driver, By.CssSelector("tblUnEnrolled_filter > label > input"));
            SchoolContactsDialog = new Modal(Driver, By.Id("SchoolPopUp"));
            FilterSchoolContactsTable = new EditField(Driver, By.CssSelector("#tbSchoolContacts_filter > label > input"));
            SchoolContactsTable = new Table(Driver, By.Id("tbSchoolContacts"));
            CloseSchoolContactsDialog = new Link(Driver, By.CssSelector(".ui-icon.ui-icon-closethick"));
        }
    }
}
