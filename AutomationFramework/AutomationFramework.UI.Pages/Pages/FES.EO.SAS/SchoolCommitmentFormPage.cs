using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
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
            NoCurrentSCF = new Text(driver, By.CssSelector("span[id$=\"lblStudentContext\"]"));
            ValidationSummary = new Text(driver, By.CssSelector("div[id$=\"_ValidationSummary\"]"));
            SuccessMessage = new Text(driver, By.CssSelector("span[id$=\"lblSuccess\"]"));
            EditSCFButton = new Button(driver, By.CssSelector("input[id$=\"btnEditSCF\"]"));
            EditStudentAwardID = new EditField(driver, By.CssSelector("input[id$=\"txtStudentAwardID\"]"));
            EditStudentStartDate = new EditField(driver, By.CssSelector("input[id$=\"txtStartDate\"]"));
            EditGradeLevel = new Dropdown(driver, By.CssSelector("input[id$=\"ddlGradeLevel\"]"));
            EditStudentTuition = new EditField(driver, By.CssSelector("input[id$=\"txtStudentTuition\"]"));
            EditStudentTransportationFee = new EditField(driver, By.CssSelector("input[id$=\"txtStudentTransportationFee\"]"));
            EditOtherStudentFee = new EditField(driver, By.CssSelector("input[id$=\"txtOtherStudentFee\"]"));
            EditStudentBooksFee = new EditField(driver, By.CssSelector("input[id$=\"txtStudentBooksFee\"]"));
            EditStudentUniformFee = new EditField(driver, By.CssSelector("input[id$=\"txtStudentUniformFee\"]"));
            EditStudentRegistrationFee = new EditField(driver, By.CssSelector("input[id$=\"txtStudentRegistrationFee\"]"));
            EditStudentTestingFee = new EditField(driver, By.CssSelector("input[id$=\"txtStudentTestingFee\"]"));
            SaveUpdateSCFButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveSCF\"]"));
            CancelUpdateSCFButton = new Button(driver, By.CssSelector("input[id$=\"btnCancel\"]"));
            StudentAwardID = new Text(driver, By.CssSelector("span[id$=\"lblStudentAwardIDValue\"]"));
            StudentStartDate = new Text(driver, By.CssSelector("span[id$=\"StudentStartDateValue\"]"));
            GradeLevel = new Text(driver, By.CssSelector("span[id$=\"lblGradeLevelValue\"]"));
            StudentTuition = new Text(driver, By.CssSelector("span[id$=\"StudentTuitionValue\"]"));
            StudentTransportationFee = new Text(driver, By.CssSelector("span[id$=\"StudentTransportationFeeValue\"]"));
            OtherStudentFee = new Text(driver, By.CssSelector("span[id$=\"OtherStudentFeeValue\"]"));
            StudentBooksFee = new Text(driver, By.CssSelector("span[id$=\"StudentBooksFeeValue\"]"));
            StudentUniformFee = new Text(driver, By.CssSelector("span[id$=\"StudentUniformFeeValue\"]"));
            StudentRegistrationFee = new Text(driver, By.CssSelector("span[id$=\"StudentRegistrationFeeValue\"]"));
            StudentTestingFee = new Text(driver, By.CssSelector("span[id$=\"StudentTestingFeeValue\"]"));
            //EditConfirmationModal = new WebElement(driver, By.CssSelector("div[id$=\"ScholarshipConfirmation_PW-1\"]"));
            EditConfirmationModal = new Modal(driver, By.CssSelector(".dxpcModalBackground_BlackGlass"));
            ModalContinueButton = new Button(driver, By.CssSelector("input[id$=\"btnContinue\"]"));
            ModalEditSCFButton = new Button(driver, By.CssSelector("input[id$=\"btnEdit\"]"));
            FirstDayOfSchool = new Text(driver, By.CssSelector("span[id$=\"txtFirstDayOfSchool\"]"));
            SchoolComplianceDate = new Text(driver, By.CssSelector("span[id$=\"txtSchoolComplianceDate\"]"));
        }
    }
}
