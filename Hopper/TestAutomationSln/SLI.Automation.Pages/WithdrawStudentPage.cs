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
    public class WithdrawStudentPage : StudentInfoPage
    {
        public Text TotalEnrolledStudentsLabel { get; private set; }

        public FTCSLIStudentTable StudentTable { get; private set; }

        public Dropdown WithdrawalSchoolYear { get; private set; }

        public EditField StudentLastDayTextbox { get; private set; }

        public Dropdown ReasonForLeavingDropdown { get; private set; }

        public EditField OtherReasonTextbox { get; private set; }

        public Dropdown StudentSuspensionDropdown { get; private set; }

        public EditField SuspensionReasonTextbox { get; private set; }

        public Dropdown StudentExpelledDropdown { get; private set; }

        public Dropdown StudentViolentBehaviourDropdown { get; private set; }

        public Dropdown WhereIsStudentGoingDropdown { get; private set; }

        public EditField NameOfNewSchoolTextbox { get; private set; }

        public Button SubmitECFButton { get; private set; }

        public WithdrawStudentPage(IWebDriver driver)
            : base(driver)
        {
            TotalEnrolledStudentsLabel = new Text(Driver, By.CssSelector("span[id$=\"_lblCount\"]"));
            StudentTable = new FTCSLIStudentTable(Driver, By.CssSelector("table[id$=\"_GVStudents\"]"));
            WithdrawalSchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"][id*=\"withdrawstudent\"]"));
            ReasonForLeavingDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlReasons\"]"));
            StudentSuspensionDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSuspension\"]"));
            StudentExpelledDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlExpulsion\"]"));
            StudentViolentBehaviourDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlViolent\"]"));
            WhereIsStudentGoingDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlDestinations\"]"));
            StudentLastDayTextbox = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentLastDay\"]"));
            OtherReasonTextbox = new EditField(Driver, By.CssSelector("textarea[id$=\"txtOtherReasonForLeaving\"]"));
            SuspensionReasonTextbox = new EditField(Driver, By.CssSelector("textarea[id$=\"txtSuspensionReason\"]"));
            NameOfNewSchoolTextbox = new EditField(Driver, By.CssSelector("input[id$=\"txtDestinationSchool\"]"));
            SubmitECFButton = new Button(Driver, By.CssSelector("input[id$=\"btnSubmitECF\"]"));
        }
    }
}
