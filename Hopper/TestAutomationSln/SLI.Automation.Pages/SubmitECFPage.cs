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
    public class SubmitECFPage : StudentInfoPage
    {
        public Text ReturnToStudentList { get; private set; }

        public Text StudentName { get; private set; }

        public Text ApplicationNumber { get; private set; }

        public Text SchoolName { get; private set; }

        public Text StudentSSN { get; private set; }

        public Text ParentName { get; private set; }

        public Text SchoolCode { get; private set; }

        public Text GradeLevel { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text SchoolCounty { get; private set; }

        public Text DateOfBirth { get; private set; }

        public Text CityStateZip { get; private set; }

        public Text PrimaryContact { get; private set; }

        public Text Gender { get; private set; }

        public Text PhysicalCounty { get; private set; }

        public Text PrimaryContactTitle { get; private set; }

        public Text Race { get; private set; }

        public Text PrimaryContactPhone { get; private set; }

        public Text ScholarshipStatus { get; private set; }

        public Text HomePhone { get; private set; }

        public Text PrimaryContactFax { get; private set; }

        public Text PaymentAmount { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text FirstDayOfSchool { get; private set; }

        public Text StudentStartDate { get; private set; }

        public Text CellPhone { get; private set; }

        public Text FundingStartDate { get; private set; }

        public EditField StudentLastDayOfClass { get; private set; }

        public Dropdown ReasonForLeaving { get; private set; }

        public EditField OtherExplanation { get; private set; }

        public Dropdown IsSuspension { get; private set; }

        public EditField SuspensionReason { get; private set; }

        public Dropdown IsExpelled { get; private set; }

        public Dropdown WasViolentBehavior { get; private set; }

        public Dropdown StudentDestination { get; private set; }

        public EditField NameOfNewSchool { get; private set; }

        public Dropdown HasOutstandingBalance { get; private set; }

        public EditField OutstandingBalanceAmount { get; private set; }

        public Dropdown IsPaymentPlanSetUp { get; private set; }

        public Button SubmitECFButton { get; private set; }

        public Text ECFSuccess { get; private set; }

        public Text ValidationSummary { get; private set; }

        public SubmitECFPage(IWebDriver driver)
            : base(driver)
        {
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"_tbStudentName\"]"));
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"_tbApplicationNumber\"]"));
            SchoolName = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolName\"]"));
            StudentSSN = new Text(Driver, By.CssSelector("span[id$=\"_txtStudentSSN\"]"));
            ParentName = new Text(Driver, By.CssSelector("span[id$=\"_txtParentName\"]"));
            SchoolCode = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolCode\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"_txtGradeLevel\"]"));
            PhysicalAddress = new Text(Driver, By.CssSelector("span[id$=\"_txtHouseholdAddress\"]"));
            SchoolCounty = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolCounty\"]"));
            DateOfBirth = new Text(Driver, By.CssSelector("span[id$=\"_txtDOB\"]"));
            CityStateZip = new Text(Driver, By.CssSelector("span[id$=\"_txtCityStateZip\"]"));
            PrimaryContact = new Text(Driver, By.CssSelector("span[id$=\"_txtPrimaryContact\"]"));
            Gender = new Text(Driver, By.CssSelector("span[id$=\"_txtGender\"]"));
            PhysicalCounty = new Text(Driver, By.CssSelector("span[id$=\"_txtCounty\"]"));
            PrimaryContactTitle = new Text(Driver, By.CssSelector("span[id$=\"_txtContactTitle\"]"));
            Race = new Text(Driver, By.CssSelector("span[id$=\"_txtRace\"]"));
            PrimaryContactPhone = new Text(Driver, By.CssSelector("span[id$=\"_txtContactPhone\"]"));
            ScholarshipStatus = new Text(Driver, By.CssSelector("span[id$=\"_txtScholarshipStatus\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"_txtHomePhone\"]"));
            PrimaryContactFax = new Text(Driver, By.CssSelector("span[id$=\"_txtContactFax\"]"));
            PaymentAmount = new Text(Driver, By.CssSelector("span[id$=\"_txtAwardAmount\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"_txtWorkPhone\"]"));
            FirstDayOfSchool = new Text(Driver, By.CssSelector("span[id$=\"_txtFirstDayOfSchool\"]"));
            StudentStartDate = new Text(Driver, By.CssSelector("span[id$=\"_txtStudentStartDate\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"_txtCellPhone\"]"));
            FundingStartDate = new Text(Driver, By.CssSelector("span[id$=\"_txtFundingStartDate\"]"));
            StudentLastDayOfClass = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentLastDay\"]"));
            ReasonForLeaving = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlReasons\"]"));
            OtherExplanation = new EditField(Driver, By.CssSelector("textarea[id$=\"_txtOtherReasonForLeaving\"]"));
            IsSuspension = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlSuspension\"]"));
            SuspensionReason = new EditField(Driver, By.CssSelector("textarea[id$=\"_txtSuspensionReason\"]"));
            IsExpelled = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlExpulsion\"]"));
            WasViolentBehavior = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlViolent\"]"));
            StudentDestination = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlDestinations\"]"));
            NameOfNewSchool = new EditField(Driver, By.CssSelector("input[id$=\"_txtDestinationSchool\"]"));
            HasOutstandingBalance = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlBalance\"]"));
            OutstandingBalanceAmount = new EditField(Driver, By.CssSelector("input[id$=\"_txtBalance\"]"));
            IsPaymentPlanSetUp = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPaymentPlan\"]"));
            SubmitECFButton = new Button(Driver, By.CssSelector("input[id$=\"btnSubmitECF\"]"));
            ECFSuccess = new Text(Driver, By.CssSelector("span[id$=\"_lblSuccess\"]"));
            ValidationSummary = new Text(Driver, By.CssSelector("div[id*=\"submitecf\"][id$=\"ValidationSummary\"]"));
        }
    }
}
