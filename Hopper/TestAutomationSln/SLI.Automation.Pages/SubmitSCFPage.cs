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
    public class SubmitSCFPage : SchoolInfoPage
    {
        public Button ReturnToStudentSelectionScreen { get; private set; }

        public Text StudentName { get; private set; }

        public Text ApplicationNumber { get; private set; }

        public Text SchoolName { get; private set; }

        public Text StudentSSN { get; private set; }

        public Text ParentName { get; private set; }

        public Text SchoolCode { get; private set; }

        public Text GradeLevel { get; private set; }

        public Button EditGradeLevel { get; private set; }

        public Dropdown NewGradeLevel { get; private set; }

        public Button CancelEditGradeLevel { get; private set; }

        public Button SaveNewGradeLevel { get; private set; }

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

        public Text StudentStatus { get; private set; }

        public Text HomePhone { get; private set; }

        public Text PrimaryContactFax { get; private set; }

        public Text AwardPercent { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text FirstDayOfSchool { get; private set; }

        public Text AwardDate { get; private set; }

        public Text CellPhone { get; private set; }

        public Text SchoolComplianceDate { get; private set; }

        public EditField StudentAwardID { get; private set; }

        public EditField StudentStartDate { get; private set; }

        public EditField StudentTuition { get; private set; }

        public EditField StudentBooksFee { get; private set; }

        public EditField StudentRegistrationFee { get; private set; }

        public EditField StudentTransportationFee { get; private set; }

        public EditField StudentUniformFee { get; private set; }

        public EditField StudentTestingFee { get; private set; }

        public EditField OtherStudentFees { get; private set; }

        public Text TotalStudentTuitionAndFees { get; private set; }

        public Checkbox CertifyGradeLevel { get; private set; }

        public Checkbox CertifyNonMcKay { get; private set; }

        public Checkbox CertifyAttendingFullTime { get; private set; }

        public Checkbox CertifyStandardizedTest { get; private set; }

        public Checkbox CertifyECF { get; private set; }

        public Checkbox CertifyDoECompliance { get; private set; }

        public Checkbox CertifySUFSPolicies { get; private set; }

        public Checkbox CertifyPaymentConditions { get; private set; }

        public Checkbox CertifyReportDefault { get; private set; }

        public Button Print { get; private set; }

        public Button SubmitSCFButton { get; private set; }

        public Text ValidationSummary { get; private set; }

        public Button OKButton { get; private set; }

        public SubmitSCFPage(IWebDriver driver)
            : base(driver)
        {
            ReturnToStudentSelectionScreen = new Button(Driver, By.CssSelector("input[id$=\"_btnReturn\"]"));
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"_tbStudentName\"]"));
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"_tbApplicationNumber\"]"));
            SchoolName = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolName\"]"));
            StudentSSN = new Text(Driver, By.CssSelector("span[id$=\"_txtStudentSSN\"]"));
            ParentName = new Text(Driver, By.CssSelector("span[id$=\"_txtParentName\"]"));
            SchoolCode = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolCode\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"_txtGradeLevel\"]"));
            EditGradeLevel = new Button(Driver, By.CssSelector("span[id$=\"_btnEditGL\"]"));
            NewGradeLevel = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlGradeLevel\"]"));
            CancelEditGradeLevel = new Button(Driver, By.CssSelector("input[id$=\"_btnCancelGL\"]"));
            SaveNewGradeLevel = new Button(Driver, By.CssSelector("input[id$=\"_btnSaveGL\"]"));
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
            StudentStatus = new Text(Driver, By.CssSelector("span[id$=\"_txtScholarshipStatus\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"_txtHomePhone\"]"));
            PrimaryContactFax = new Text(Driver, By.CssSelector("span[id$=\"_txtContactFax\"]"));
            AwardPercent = new Text(Driver, By.CssSelector("span[id$=\"_txtAwardPercent\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"_txtWorkPhone\"]"));
            FirstDayOfSchool = new Text(Driver, By.CssSelector("span[id$=\"_txtFirstDayOfSchool\"]"));
            AwardDate = new Text(Driver, By.CssSelector("span[id$=\"_txtAwardDate\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"_txtCellPhone\"]"));
            SchoolComplianceDate = new Text(Driver, By.CssSelector("span[id$=\"_txtSchoolComplianceDate\"]"));
            StudentAwardID = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentAwardID\"]"));
            StudentStartDate = new EditField(Driver, By.CssSelector("input[id$=\"_txtStartDate\"]"));
            StudentTuition = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentTuition\"]"));
            StudentBooksFee = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentBooksFee\"]"));
            StudentRegistrationFee = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentRegistrationFee\"]"));
            StudentTransportationFee = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentTransportationFee\"]"));
            StudentUniformFee = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentUniformFee\"]"));
            StudentTestingFee = new EditField(Driver, By.CssSelector("input[id$=\"_txtStudentTestingFee\"]"));
            OtherStudentFees = new EditField(Driver, By.CssSelector("input[id$=\"_txtOtherStudentFee\"]"));
            TotalStudentTuitionAndFees = new Text(Driver, By.CssSelector("span[id$=\"_lblTotalTuitionAndFee\"]"));
            CertifyGradeLevel = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_0\"]"));
            CertifyNonMcKay = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_1\"]"));
            CertifyAttendingFullTime = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_2\"]"));
            CertifyStandardizedTest = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_3\"]"));
            CertifyECF = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_4\"]"));
            CertifyDoECompliance = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_5\"]"));
            CertifySUFSPolicies = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_6\"]"));
            CertifyPaymentConditions = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_7\"]"));
            CertifyReportDefault = new Checkbox(Driver, By.CssSelector("input[id$=\"cblConfirmCertification_8\"]"));
            Print = new Button(Driver, By.CssSelector("input[id$=\"btnPrint\"]"));
            SubmitSCFButton = new Button(Driver, By.CssSelector("input[id$=\"btnSubmitSCF\"]"));
            ValidationSummary = new Text(Driver, By.CssSelector("div[id$=\"ValidationSummary\"]"));
            OKButton = new Button(Driver, By.XPath("//a[text() = 'OK']"));
        }
    }
}
