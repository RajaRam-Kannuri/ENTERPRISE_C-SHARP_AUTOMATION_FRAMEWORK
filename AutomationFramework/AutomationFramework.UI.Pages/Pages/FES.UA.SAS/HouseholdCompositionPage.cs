using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class HouseholdCompositionPage : HomePage
    {
        public Table HouseholdMemberTable { get; private set; }

        public Dropdown HouseholdMemberType { get; private set; }

        public Button AddButton { get; private set; }

        public EditField FirstName { get; private set; }

        public EditField SSN { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField VerifySSN { get; private set; }

        public EditField LastName { get; private set; }

        public EditField EmailAddress { get; private set; }

        public Dropdown RelationshipToPrimaryGuardian { get; private set; }

        public EditField DateofBirth { get; private set; }

        public Dropdown Gender { get; private set; }

        public Dropdown GradeLevel { get; private set; }

        public EditField SchoolAttended { get; private set; }

        public Dropdown SchoolType { get; private set; }

        public RadioButton AttendedPublicSchoolYes { get; private set; }

        public RadioButton AttendedPublicSchoolNo { get; private set; }

        public Dropdown SchoolCounty { get; private set; }

        public Dropdown PlannedSchoolYearType { get; private set; }
        
        public RadioButton HispanicOrLatinoYes { get; private set; }

        public RadioButton HispanicOrLatinoNo { get; private set; }

        public RadioButton NativeAmericanYes { get; private set; }

        public RadioButton NativeAmericanNo { get; private set; }

        public RadioButton AsianYes { get; private set; }

        public RadioButton AsianNo { get; private set; }

        public RadioButton AfricanAmericanYes { get; private set; }

        public RadioButton AfricanAmericanNo { get; private set; }

        public RadioButton PacificIslanderYes { get; private set; }

        public RadioButton PacificIslanderNo { get; private set; }

        public RadioButton WhiteYes { get; private set; }

        public RadioButton WhiteNo { get; private set; }

        public RadioButton MultiRacialYes { get; private set; }

        public RadioButton MultiRacialNo { get; private set; }

        public Button SaveModalUpdatesButton { get; private set; }

        public Button CloseModalButton { get; private set; }

        public Modal AddEditModal { get; private set; }

        public RadioButton AdoptedYes { get; private set; }

        public RadioButton AdoptedNo { get; private set; }

        public RadioButton FosterCareYes { get; private set; }

        public RadioButton FosterCareNo { get; private set; }

        public RadioButton MilitaryYes { get; private set; }

        public RadioButton MilitaryNo { get; private set; }

        public RadioButton LEOYes { get; private set; }

        public RadioButton LEONo { get; private set; }

        public HouseholdCompositionPage(IWebDriver driver)
            : base(driver)
        {
            HouseholdMemberTable = new Table(driver, By.CssSelector("table[id$=\"gvHousehold\"]"));
            HouseholdMemberType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlHouseholdMemberType\"]"));
            AddButton = new Button(driver, By.CssSelector("input[id$=\"btnAdd\"]"));
            FirstName = new EditField(driver, By.CssSelector("input[id$=\"txtFirstName\"]"));
            SSN = new EditField(driver, By.CssSelector("input[id$=\"txtSSNITIN1\"]"));
            MiddleName = new EditField(driver, By.CssSelector("input[id$=\"txtMiddleName\"]"));
            VerifySSN = new EditField(driver, By.CssSelector("input[id$=\"txtSSNITIN2\"]"));
            LastName = new EditField(driver, By.CssSelector("input[id$=\"txtLastName\"]"));
            EmailAddress = new EditField(driver, By.CssSelector("input[id$=\"txtEmail\"]"));
            RelationshipToPrimaryGuardian = new Dropdown(driver, By.CssSelector("select[id$=\"ddlRelationshipToPrimaryGuardian\"]"));
            DateofBirth = new EditField(driver, By.CssSelector("input[id$=\"txtDateOfBirth\"]"));
            Gender = new Dropdown(driver, By.CssSelector("select[id$=\"ddlGender\"]"));
            GradeLevel = new Dropdown(driver, By.CssSelector("select[id$=\"ddlGradeLevel\"]"));
            SchoolAttended = new EditField(driver, By.CssSelector("input[id$=\"tbSchoolAttended\"]"));
            SchoolType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolType\"]"));
            AttendedPublicSchoolYes = new RadioButton(driver, By.CssSelector("input[id$=\"rblAttendedPublicSchool_0\"]"));
            AttendedPublicSchoolNo = new RadioButton(driver, By.CssSelector("input[id$=\"rblAttendedPublicSchool_1\"]"));
            SchoolCounty = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolCounty\"]"));
            PlannedSchoolYearType = new Dropdown(driver, By.CssSelector("select[id$=\"ddlPlannedSchoolYearType\"]"));
            HispanicOrLatinoYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsHispanic_0\"]"));
            HispanicOrLatinoNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsHispanic_1\"]"));
            NativeAmericanYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbAmericanIndian_0\"]"));
            NativeAmericanNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbAmericanIndian_1\"]"));
            AsianYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbAsian_0\"]"));
            AsianNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbAsian_1\"]"));
            AfricanAmericanYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbAfrican_0\"]"));
            AfricanAmericanNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbAfrican_1\"]"));
            PacificIslanderYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbHawaiian_0\"]"));
            PacificIslanderNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbHawaiian_1\"]"));
            WhiteYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbWhite_0\"]"));
            WhiteNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbWhite_1\"]"));
            MultiRacialNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbMultiRacial_0\"]"));
            MultiRacialYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbMultiRacial_1\"]"));
            SaveModalUpdatesButton = new Button(driver, By.CssSelector("input[id$=\"btnAddMember\"]"));
            CloseModalButton = new Button(driver, By.CssSelector("input[id$=\"btnClose\"]"));
            AddEditModal = new Modal(driver, By.CssSelector("td[id$=\"ModalPopupControlAddPeople_PWC-1\"]"));
            AdoptedYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsAdopted_0\"]"));
            AdoptedNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsAdopted_1\"]"));
            FosterCareYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsFosterCare_0\"]"));
            FosterCareNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsFosterCare_1\"]"));
            MilitaryYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsMilitary_0\"]"));
            MilitaryNo = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsMilitary_1\"]"));
            LEOYes = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsLawEnforcementOfficer_0\"]"));
            LEONo = new RadioButton(driver, By.CssSelector("input[id$=\"rbIsLawEnforcementOfficer_1\"]"));
        }
    }
}