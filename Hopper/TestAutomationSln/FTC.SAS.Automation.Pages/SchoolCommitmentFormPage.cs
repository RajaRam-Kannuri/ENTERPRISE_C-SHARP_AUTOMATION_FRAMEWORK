using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.SAS.Automation.Pages
{
    public class SchoolCommitmentFormPage : HomePage
    {
        public Text NoCurrentSCF { get; private set; }

        public Text ValidationSummary { get; private set; }

        public Text SuccessMessage { get; private set; }

        public Button EditSCFButton { get; private set; }

        public EditField EditStudentAwardID { get; private set; }

        public EditField EditStudentStartDate { get; private set; }

        public Dropdown EditGradeLevel { get; private set; }

        public EditField EditStudentTuition { get; private set; }

        public EditField EditStudentTransportationFee { get; private set; }

        public EditField EditOtherStudentFee { get; private set; }

        public EditField EditStudentBooksFee { get; private set; }

        public EditField EditStudentUniformFee { get; private set; }

        public EditField EditStudentRegistrationFee { get; private set; }

        public EditField EditStudentTestingFee { get; private set; }

        public Button SaveUpdateSCFButton { get; private set; }

        public Button CancelUpdateSCFButton { get; private set; }

        public Text StudentAwardID { get; private set; }

        public Text StudentStartDate { get; private set; }

        public Text GradeLevel { get; private set; }

        public Text StudentTuition { get; private set; }

        public Text StudentTransportationFee { get; private set; }

        public Text OtherStudentFee { get; private set; }

        public Text StudentBooksFee { get; private set; }

        public Text StudentUniformFee { get; private set; }

        public Text StudentRegistrationFee { get; private set; }

        public Text StudentTestingFee { get; private set; }

        public Modal EditConfirmationModal { get; private set; }

        public Button ModalContinueButton { get; private set; }

        public Button ModalEditSCFButton { get; private set; }

        public Text FirstDayOfSchool { get; private set; }

        public Text SchoolComplianceDate { get; private set; }

        public SchoolCommitmentFormPage(IWebDriver driver)
            : base(driver)
        {
            NoCurrentSCF = new Text(Driver, By.CssSelector("span[id$=\"lblStudentContext\"]"));
            ValidationSummary = new Text(Driver, By.CssSelector("div[id$=\"_ValidationSummary\"]"));
            SuccessMessage = new Text(Driver, By.CssSelector("span[id$=\"lblSuccess\"]"));
            EditSCFButton = new Button(Driver, By.CssSelector("input[id$=\"btnEditSCF\"]"));
            EditStudentAwardID = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentAwardID\"]"));
            EditStudentStartDate = new EditField(Driver, By.CssSelector("input[id$=\"txtStartDate\"]"));
            EditGradeLevel = new Dropdown(Driver, By.CssSelector("input[id$=\"ddlGradeLevel\"]"));
            EditStudentTuition = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentTuition\"]"));
            EditStudentTransportationFee = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentTransportationFee\"]"));
            EditOtherStudentFee = new EditField(Driver, By.CssSelector("input[id$=\"txtOtherStudentFee\"]"));
            EditStudentBooksFee = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentBooksFee\"]"));
            EditStudentUniformFee = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentUniformFee\"]"));
            EditStudentRegistrationFee = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentRegistrationFee\"]"));
            EditStudentTestingFee = new EditField(Driver, By.CssSelector("input[id$=\"txtStudentTestingFee\"]"));
            SaveUpdateSCFButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveSCF\"]"));
            CancelUpdateSCFButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancel\"]"));
            StudentAwardID = new Text(Driver, By.CssSelector("span[id$=\"lblStudentAwardIDValue\"]"));
            StudentStartDate = new Text(Driver, By.CssSelector("span[id$=\"StudentStartDateValue\"]"));
            GradeLevel = new Text(Driver, By.CssSelector("span[id$=\"lblGradeLevelValue\"]"));
            StudentTuition = new Text(Driver, By.CssSelector("span[id$=\"StudentTuitionValue\"]"));
            StudentTransportationFee = new Text(Driver, By.CssSelector("span[id$=\"StudentTransportationFeeValue\"]"));
            OtherStudentFee = new Text(Driver, By.CssSelector("span[id$=\"OtherStudentFeeValue\"]"));
            StudentBooksFee = new Text(Driver, By.CssSelector("span[id$=\"StudentBooksFeeValue\"]"));
            StudentUniformFee = new Text(Driver, By.CssSelector("span[id$=\"StudentUniformFeeValue\"]"));
            StudentRegistrationFee = new Text(Driver, By.CssSelector("span[id$=\"StudentRegistrationFeeValue\"]"));
            StudentTestingFee = new Text(Driver, By.CssSelector("span[id$=\"StudentTestingFeeValue\"]"));
            //EditConfirmationModal = new WebElement(Driver, By.CssSelector("div[id$=\"ScholarshipConfirmation_PW-1\"]"));
            EditConfirmationModal = new Modal(Driver, By.CssSelector(".dxpcModalBackground_BlackGlass"));
            ModalContinueButton = new Button(Driver, By.CssSelector("input[id$=\"btnContinue\"]"));
            ModalEditSCFButton = new Button(Driver, By.CssSelector("input[id$=\"btnEdit\"]"));
            FirstDayOfSchool = new Text(Driver, By.CssSelector("span[id$=\"txtFirstDayOfSchool\"]"));
            SchoolComplianceDate = new Text(Driver, By.CssSelector("span[id$=\"txtSchoolComplianceDate\"]"));
        }
    }
}
