using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SLI.Automation.Pages
{
    public class ConfirmEnrollmentPage : StudentInfoPage
    {
        public Dropdown EnrollmentSchoolYear { get; private set; }

        public Table StudentList { get; private set; }

        public WebElement LoadingPanel { get; private set;}

        public Modal SCFModal { get; private set; }

        public Text StudentName { get; private set; }

        public Text StudentSSN { get; private set; }

        public Text GradeLevel { get; private set; }

        public Text DateofBirth { get; private set; }

        public Text Gender { get; private set; }

        public Text Race { get; private set; }

        public Text StudentStatus { get; private set; }

        public Text PaymentAmount { get; private set; }

        public Text AwardDate { get; private set; }

        public Text ApplicationNumber { get; private set; }

        public Text ParentGuardianName { get; private set; }

        public Text PhysicalAddress { get; private set; }

        public Text PhysicalCounty { get; private set; }

        public Text HomePhone { get; private set; }

        public Text CellPhone { get; private set; }

        public Text WorkPhone { get; private set; }

        public Text SchoolName { get; private set; }

        public Text SchoolCode { get; private set; }

        public Text SchoolCounty { get; private set; }

        public Text PrimaryContact { get; private set; }

        public Text PrimaryContactTitle { get; private set; }

        public Text PrimaryContactPhone { get; private set; }

        public Text PrimaryContactFax { get; private set; }

        public Text FirstDayOfSchool { get; private set; }

        public Text SchoolComplianceDate { get; private set; }

        public Text StudentAwardID { get; private set; }

        public Text StudentStartDate { get; private set; }

        public Text FundingStartDate { get; private set; }

        public Text ScholarshipTuition { get; private set; }

        public Text ScholarshipBooks { get; private set; }

        public Text ScholarshipRegistration { get; private set; }

        public Text ScholarshipTransportation { get; private set; }

        public Text ScholarshipUniforms { get; private set; }

        public Text ScholarshipTesting { get; private set; }

        public Text ScholarshipOther { get; private set; }

        public Text ScholarshipTotal { get; private set; }

        public Text TuitionAndFeesTuition { get; private set; }

        public Text TuitionAndFeesBooks { get; private set; }

        public Text TuitionAndFeesRegistration { get; private set; }

        public Text TuitionAndFeesTransportation { get; private set; }

        public Text TuitionAndFeesUniforms { get; private set; }

        public Text TuitionAndFeesTesting { get; private set; }

        public Text TuitionAndFeesOther { get; private set; }

        public Text TuitionAndFeesTotal { get; private set; }

        public Link CloseModal { get; private set; }

        public ConfirmEnrollmentPage(IWebDriver driver)
            : base(driver)
        {
            EnrollmentSchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
            StudentList = new Table(Driver, By.CssSelector("table[id$=\"_gvConfirmEnrollment\"]"));
            LoadingPanel = new Text(Driver, By.ClassName("Progress"));
            SCFModal = new Modal(Driver, By.ClassName("ModalWindow"));
            StudentName = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl00_lblValue\"]"));
            StudentSSN = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl02_lblValue\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl04_lblValue\"]"));
            DateofBirth = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl06_lblValue\"]"));
            Gender = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl08_lblValue\"]"));
            Race = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl10_lblValue\"]"));
            StudentStatus = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl12_lblValue\"]"));
            PaymentAmount = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl14_lblValue\"]"));
            AwardDate = new Text(Driver, By.CssSelector("span[id$=\"_rpStudentDetail_ctl16_lblValue\"]"));
            ApplicationNumber = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl00_lblValue\"]"));
            ParentGuardianName = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl02_lblValue\"]"));
            PhysicalAddress = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl04_lblValue\"]"));
            PhysicalCounty = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl06_lblValue\"]"));
            HomePhone = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl08_lblValue\"]"));
            CellPhone = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl10_lblValue\"]"));
            WorkPhone = new Text(Driver, By.CssSelector("span[id$=\"_rpApplicationHouseholdDetail_ctl12_lblValue\"]"));
            SchoolName = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl00_lblValue\"]"));
            SchoolCode = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl02_lblValue\"]"));
            SchoolCounty = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl04_lblValue\"]"));
            PrimaryContact = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl06_lblValue\"]"));
            PrimaryContactTitle = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl08_lblValue\"]"));
            PrimaryContactPhone = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl10_lblValue\"]"));
            PrimaryContactFax = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl12_lblValue\"]"));
            FirstDayOfSchool = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl14_lblValue\"]"));
            SchoolComplianceDate = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolDetail_ctl16_lblValue\"]"));
            StudentAwardID = new Text(Driver, By.CssSelector("span[id$=\"_rpAwardDetail_ctl00_lblValue\"]"));
            StudentStartDate = new Text(Driver, By.CssSelector("span[id$=\"_rpAwardDetail_ctl02_lblValue\"]"));
            FundingStartDate = new Text(Driver, By.CssSelector("span[id$=\"_rpAwardDetail_ctl04_lblValue\"]"));
            ScholarshipTuition = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl00_lblValue\"]"));
            ScholarshipBooks = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl01_lblValue\"]"));
            ScholarshipRegistration = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl02_lblValue\"]"));
            ScholarshipTransportation = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl03_lblValue\"]"));
            ScholarshipUniforms = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl04_lblValue\"]"));
            ScholarshipTesting = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl05_lblValue\"]"));
            ScholarshipOther = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl06_lblValue\"]"));
            ScholarshipTotal = new Text(Driver, By.CssSelector("span[id$=\"_rpScholarshipDist_ctl07_lblValue\"]"));
            TuitionAndFeesTuition = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl00_lblValue\"]"));
            TuitionAndFeesBooks = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl01_lblValue\"]"));
            TuitionAndFeesRegistration = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl02_lblValue\"]"));
            TuitionAndFeesTransportation = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl03_lblValue\"]"));
            TuitionAndFeesUniforms = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl04_lblValue\"]"));
            TuitionAndFeesTesting = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl05_lblValue\"]"));
            TuitionAndFeesOther = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl06_lblValue\"]"));
            TuitionAndFeesTotal = new Text(Driver, By.CssSelector("span[id$=\"_rpTuitionAndFee_ctl07_lblValue\"]"));
            CloseModal = new Link(Driver, By.CssSelector("input[id$=\"_imgBtnClose\"]"));
        }
    }
}
