using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class StudentInformationSection : ControlSection
    {
        public EditField FirstName { get; private set; }

        public EditField SSN { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField VerifySSN { get; private set; }

        public EditField LastName { get; private set; }

        public EditField EmailAddress { get; private set; }

        public Dropdown RelationshipToPrimaryGuardian { get; private set; }

        public EditField DateofBirth { get; private set; }

        public Dropdown Gender { get; private set; }

        public Radio HispanicOrLatinoYes { get; private set; }

        public Radio HispanicOrLatinoNo { get; private set; }

        public Radio NativeAmericanYes { get; private set; }

        public Radio NativeAmericanNo { get; private set; }

        public Radio AsianYes { get; private set; }

        public Radio AsianNo { get; private set; }

        public Radio AfricanAmericanYes { get; private set; }

        public Radio AfricanAmericanNo { get; private set; }

        public Radio PacificIslanderYes { get; private set; }

        public Radio PacificIslanderNo { get; private set; }

        public Radio WhiteYes { get; private set; }

        public Radio WhiteNo { get; private set; }

        public Radio AdoptedYes { get; private set; }

        public Radio AdoptedNo { get; private set; }

        public Radio FosterCareYes { get; private set; }

        public Radio FosterCareNo { get; private set; }

        public Radio MilitaryYes { get; private set; }

        public Radio MilitaryNo { get; private set; }

        public Radio LawEnforcementYes { get; private set; }

        public Radio LawEnforcementNo { get; private set; }

        public Dropdown GradeLevel { get; private set; }

        public EditField SchoolAttended { get; private set; }

        public Dropdown PriorYearFunding { get; private set; }

        public Dropdown SchoolType { get; private set; }

        public Dropdown SchoolCounty { get; private set; }

        public Dropdown PlannedSchoolType { get; private set; }

        public Dropdown HasStudentGraduated { get; private set; }

        public Dropdown GEDOrSimilar { get; set; }

        public Checkbox AnaphylaxisCheckbox { get; set; }

        public Checkbox AutismSpectrumDisorderCheckbox { get; set; }

        public Checkbox CerebralPalsyCheckbox { get; set; }

        public Checkbox DeafCheckbox { get; set; }

        public Checkbox DownSyndromeCheckbox { get; set; }

        public Checkbox DualSensoryImpairedCheckbox { get; set; }

        public Checkbox HospitalorHomeboundCheckbox { get; set; }

        public Checkbox IntellectualDisabilityCheckbox { get; set; }

        public Checkbox MuscularDystrophyCheckbox { get; set; }

        public Checkbox PhelanMcDermidSyndromeCheckbox { get; set; }

        public Checkbox PraderWilliSyndromeCheckbox { get; set; }

        public Checkbox RareDiseasesCheckbox { get; set; }

        public Checkbox SpinaBifidaCheckbox { get; set; }

        public Checkbox TraumaticBrainInjuredCheckbox { get; set; }

        public Checkbox VisuallyImpairedCheckbox { get; set; }

        public Checkbox WilliamsSyndromeCheckbox { get; set; }

        public StudentInformationSection(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"txtFirstName\"]"));
            SSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSocial1\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"txtMiddleName\"]"));
            VerifySSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSocial2\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"txtLastName\"]"));
            EmailAddress = new EditField(Driver, By.CssSelector("input[id$=\"txtEmail\"]"));
            RelationshipToPrimaryGuardian = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlRelationshipToPrimaryGuardian\"]"));
            DateofBirth = new EditField(Driver, By.CssSelector("input[id$=\"txtDateOfBirth\"]"));
            Gender = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGender\"]"));
            HispanicOrLatinoYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsHispanic_0\"]"));
            HispanicOrLatinoNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsHispanic_1\"]"));
            NativeAmericanYes = new Radio(Driver, By.CssSelector("input[id$=\"rbAmericanIndian_0\"]"));
            NativeAmericanNo = new Radio(Driver, By.CssSelector("input[id$=\"rbAmericanIndian_1\"]"));
            AsianYes = new Radio(Driver, By.CssSelector("input[id$=\"rbAsian_0\"]"));
            AsianNo = new Radio(Driver, By.CssSelector("input[id$=\"rbAsian_1\"]"));
            AfricanAmericanYes = new Radio(Driver, By.CssSelector("input[id$=\"rbAfrican_0\"]"));
            AfricanAmericanNo = new Radio(Driver, By.CssSelector("input[id$=\"rbAfrican_1\"]"));
            PacificIslanderYes = new Radio(Driver, By.CssSelector("input[id$=\"rbHawaiian_0\"]"));
            PacificIslanderNo = new Radio(Driver, By.CssSelector("input[id$=\"rbHawaiian_1\"]"));
            WhiteYes = new Radio(Driver, By.CssSelector("input[id$=\"rbWhite_0\"]"));
            WhiteNo = new Radio(Driver, By.CssSelector("input[id$=\"rbWhite_1\"]"));
            AdoptedYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsAdopted_0\"]"));
            AdoptedNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsAdopted_1\"]"));
            FosterCareYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsFosterCare_0\"]"));
            FosterCareNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsFosterCare_1\"]"));
            MilitaryYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsMilitary_0\"]"));
            MilitaryNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsMilitary_1\"]"));
            LawEnforcementYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsLEO_0\"]"));
            LawEnforcementNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsLEO_1\"]"));
            GradeLevel = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGradeLevel\"]"));
            SchoolAttended = new EditField(Driver, By.CssSelector("input[id$=\"tbSchoolAttendend\"]"));
            SchoolType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolType\"]"));
            PriorYearFunding = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolFundingType\"]"));
            SchoolCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolCounty\"]"));
            PlannedSchoolType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPlannedSchoolYearType\"]"));
            HasStudentGraduated = new Dropdown(Driver, By.CssSelector("select[id$='ddlGraduated']"));
            GEDOrSimilar = new Dropdown(Driver, By.CssSelector("select[id$='ddlGED']"));
            AnaphylaxisCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_0']"));
            AutismSpectrumDisorderCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_1']"));
            CerebralPalsyCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_2']"));
            DeafCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_3']"));
            DownSyndromeCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_4']"));
            DualSensoryImpairedCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_5']"));
            HospitalorHomeboundCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_6']"));
            IntellectualDisabilityCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_7']"));
            MuscularDystrophyCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_8']"));
            PhelanMcDermidSyndromeCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_9']"));
            PraderWilliSyndromeCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_10']"));
            RareDiseasesCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_11']"));
            SpinaBifidaCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_12']"));
            TraumaticBrainInjuredCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_13']"));
            VisuallyImpairedCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_14']"));
            WilliamsSyndromeCheckbox = new Checkbox(Driver, By.XPath("//*[@id='RPMainPanel_controls_student_diagnosis_ascx385_cblDiagnosisType_15']"));
        }
    }
}
