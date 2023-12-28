using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class ExitConfirmationFormPage : HomePage
    {
        public Table ECFUpdateHistory { get; private set; }

        public Text StudentName { get; private set; }

        public Text ApplicationNumber { get; private set; }

        public Text ECFSchoolName { get; private set; }

        public Text ECFStudentSSN { get; private set; }

        public Text ParentName { get; private set; }

        public Text ECFSchoolCode { get; private set; }

        public Text GradeLevel { get; private set; }

        public Text HouseholdAddress { get; private set; }

        public Text SchoolCounty { get; private set; }

        public Text DOB { get; private set; }

        public Text CityStateZip { get; private set; }

        public Text PrimaryContact { get; private set; }

        public Text Gender { get; private set; }

        public Text County { get; private set; }

        public Text ContactTitle { get; private set; }

        public Text Race { get; private set; }

        public Text ContactPhone { get; private set; }

        public Text ScholarshipStatus { get; private set; }

        public Text HomePhone { get; private set; }

        public Text ContactFax { get; private set; }

        public Text AwardAmount { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text FirstDayOfSchool { get; private set; }

        public Text FundingStartDate { get; private set; }

        public Text CellPhone { get; private set; }

        public Text StudentLastDay { get; private set; }

        public Text ReasonForLeaving { get; private set; }

        public Text OtherReasonForLeaving { get; private set; }

        public Text IsSuspension { get; private set; }

        public Text SuspensionReason { get; private set; }

        public Text IsExpelled { get; private set; }

        public Text IsViolent { get; private set; }

        public Text Destination { get; private set; }

        public Text School { get; private set; }

        public Text Balance { get; private set; }

        public Text BalanceAmount { get; private set; }

        public Text Paymentplan { get; private set; }

        public Button EditECFButton { get; private set; }

        public EditField EditStudentLastDayOfClass { get; private set; }

        public Dropdown EditReasonForLeaving { get; private set; }

        public EditField EditOtherExplanation { get; private set; }

        public Dropdown EditIsSuspension { get; private set; }

        public EditField EditSuspensionReason { get; private set; }

        public Dropdown EditIsExpelled { get; private set; }

        public Dropdown EditWasViolentBehavior { get; private set; }

        public Dropdown EditStudentDestination { get; private set; }

        public EditField EditNameOfNewSchool { get; private set; }

        public Dropdown EditHasOutstandingBalance { get; private set; }

        public EditField EditOutstandingBalanceAmount { get; private set; }

        public Dropdown EditIsPaymentPlanSetUp { get; private set; }

        public Button SaveUpdateECFButton { get; private set; }

        public Button CancelUpdateECFButton { get; private set; }

        public Button CreateECFButton { get; private set; }

        public Text ECFMessage { get; private set; }

        public ExitConfirmationFormPage(IWebDriver driver)
            : base(driver)
        {
            ECFUpdateHistory = new Table(Driver, By.CssSelector("table[id$=\"GVECFUpdates\"]"));
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"tbStudentName\"]"));
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"tbApplicationNumber\"]"));
            ECFSchoolName = new Text(Driver, By.CssSelector("span[id$=\"txtSchoolName\"]"));
            ECFStudentSSN = new Text(Driver, By.CssSelector("span[id$=\"txtStudentSSN\"]"));
            ParentName = new Text(Driver, By.CssSelector("span[id$=\"txtParentName\"]"));
            ECFSchoolCode = new Text(Driver, By.CssSelector("span[id$=\"txtSchoolCode\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"txtGradeLevel\"]"));
            HouseholdAddress = new Text(Driver, By.CssSelector("span[id$=\"txtHouseholdAddress\"]"));
            SchoolCounty = new Text(Driver, By.CssSelector("span[id$=\"txtSchoolCounty\"]"));
            DOB = new Text(Driver, By.CssSelector("span[id$=\"txtDOB\"]"));
            CityStateZip = new Text(Driver, By.CssSelector("span[id$=\"txtCityStateZip\"]"));
            PrimaryContact = new Text(Driver, By.CssSelector("span[id$=\"txtPrimaryContact\"]"));
            Gender = new Text(Driver, By.CssSelector("span[id$=\"txtGender\"]"));
            County = new Text(Driver, By.CssSelector("span[id$=\"txtCounty\"]"));
            ContactTitle = new Text(Driver, By.CssSelector("span[id$=\"txtContactTitle\"]"));
            Race = new Text(Driver, By.CssSelector("span[id$=\"txtRace\"]"));
            ContactPhone = new Text(Driver, By.CssSelector("span[id$=\"txtContactPhone\"]"));
            ScholarshipStatus = new Text(Driver, By.CssSelector("span[id$=\"txtScholarshipStatus\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"txtHomePhone\"]"));
            ContactFax = new Text(Driver, By.CssSelector("span[id$=\"txtContactFax\"]"));
            AwardAmount = new Text(Driver, By.CssSelector("span[id$=\"txtAwardAmount\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"txtWorkPhone\"]"));
            FirstDayOfSchool = new Text(Driver, By.CssSelector("span[id$=\"txtFirstDayOfSchool\"]"));
            FundingStartDate = new Text(Driver, By.CssSelector("span[id$=\"txtFundingStartDate\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"txtCellPhone\"]"));

            StudentLastDay = new Text(Driver, By.CssSelector("span[id$=\"lblStudentLastDayValue\"]"));
            ReasonForLeaving = new Text(Driver, By.CssSelector("span[id$=\"lblReasonForLeavingValue\"]"));
            OtherReasonForLeaving = new Text(Driver, By.CssSelector("span[id$=\"lblOtherReasonForLeavingValue\"]"));
            IsSuspension = new Text(Driver, By.CssSelector("span[id$=\"lblIsSuspensionValue\"]"));
            SuspensionReason = new Text(Driver, By.CssSelector("span[id$=\"lblSuspensionReasonValue\"]"));
            IsExpelled = new Text(Driver, By.CssSelector("span[id$=\"lblIsExpelledValue\"]"));
            IsViolent = new Text(Driver, By.CssSelector("span[id$=\"lblIsViolentValue\"]"));
            Destination = new Text(Driver, By.CssSelector("span[id$=\"lblDestinationValue\"]"));
            School = new Text(Driver, By.CssSelector("span[id$=\"lblSchoolValue\"]"));
            Balance = new Text(Driver, By.CssSelector("span[id$=\"lblBalanceValue\"]"));
            BalanceAmount = new Text(Driver, By.CssSelector("span[id$=\"lblBalanceAmountValue\"]"));
            Paymentplan = new Text(Driver, By.CssSelector("span[id$=\"lblPaymentplanValue\"]"));

            EditECFButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditECF\"]"));
            EditStudentLastDayOfClass = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentLastDay\"]"));
            EditReasonForLeaving = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlReasons\"]"));
            EditOtherExplanation = new EditField(Driver, By.CssSelector("textarea[id$=\"_txtOtherReasonForLeaving\"]"));
            EditIsSuspension = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlSuspension\"]"));
            EditSuspensionReason = new EditField(Driver, By.CssSelector("textarea[id$=\"_txtSuspensionReason\"]"));
            EditIsExpelled = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlExpulsion\"]"));
            EditWasViolentBehavior = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlViolent\"]"));
            EditStudentDestination = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlDestinations\"]"));
            EditNameOfNewSchool = new EditField(Driver, By.CssSelector("input[id$=\"_txtDestinationSchool\"]"));
            EditHasOutstandingBalance = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlBalance\"]"));
            EditOutstandingBalanceAmount = new EditField(Driver, By.CssSelector("input[id$=\"_txtBalance\"]"));
            EditIsPaymentPlanSetUp = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlPaymentPlan\"]"));
            SaveUpdateECFButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveECF\"]"));
            CancelUpdateECFButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancel\"]"));

            CreateECFButton = new Button(Driver, By.CssSelector("span[id$=\"lblStudentContext\"]"));
            ECFMessage = new Text(Driver, By.CssSelector("input[id$=\"btnCreateECF\"]"));
        }
    }
}
