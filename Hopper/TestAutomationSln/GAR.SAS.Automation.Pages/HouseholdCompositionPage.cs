using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class HouseholdCompositionPage : HomePage
    {
        public HouseholdMemberTable HouseholdMemberTable { get; private set; }

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

        public Radio AttendedPublicSchoolYes { get; private set; }

        public Radio AttendedPublicSchoolNo { get; private set; }

        public Dropdown SchoolCounty { get; private set; }

        public Dropdown PlannedSchoolYearType { get; private set; }
        
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

        public Radio MultiRacialYes { get; private set; }

        public Radio MultiRacialNo { get; private set; }

        public Button SaveModalUpdatesButton { get; private set; }

        public Button CloseModalButton { get; private set; }

        public Modal AddEditModal { get; private set; }

        public Radio AdoptedYes { get; private set; }

        public Radio AdoptedNo { get; private set; }

        public Radio FosterCareYes { get; private set; }

        public Radio FosterCareNo { get; private set; }

        public Radio MilitaryYes { get; private set; }

        public Radio MilitaryNo { get; private set; }

        public Radio LEOYes { get; private set; }

        public Radio LEONo { get; private set; }

        public HouseholdCompositionPage(IWebDriver driver)
            : base(driver)
        {
            HouseholdMemberTable = new HouseholdMemberTable(Driver, By.CssSelector("table[id$=\"gvHousehold\"]"));
            HouseholdMemberType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlHouseholdMemberType\"]"));
            AddButton = new Button(Driver, By.CssSelector("input[id$=\"btnAdd\"]"));
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"txtFirstName\"]"));
            SSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSSNITIN1\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"txtMiddleName\"]"));
            VerifySSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSSNITIN2\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"txtLastName\"]"));
            EmailAddress = new EditField(Driver, By.CssSelector("input[id$=\"txtEmail\"]"));
            RelationshipToPrimaryGuardian = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlRelationshipToPrimaryGuardian\"]"));
            DateofBirth = new EditField(Driver, By.CssSelector("input[id$=\"txtDateOfBirth\"]"));
            Gender = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGender\"]"));
            GradeLevel = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGradeLevel\"]"));
            SchoolAttended = new EditField(Driver, By.CssSelector("input[id$=\"tbSchoolAttended\"]"));
            SchoolType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolType\"]"));
            AttendedPublicSchoolYes = new Radio(Driver, By.CssSelector("input[id$=\"rblAttendedPublicSchool_0\"]"));
            AttendedPublicSchoolNo = new Radio(Driver, By.CssSelector("input[id$=\"rblAttendedPublicSchool_1\"]"));
            SchoolCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolCounty\"]"));
            PlannedSchoolYearType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlPlannedSchoolYearType\"]"));
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
            MultiRacialNo = new Radio(Driver, By.CssSelector("input[id$=\"rbMultiRacial_0\"]"));
            MultiRacialYes = new Radio(Driver, By.CssSelector("input[id$=\"rbMultiRacial_1\"]"));
            SaveModalUpdatesButton = new Button(Driver, By.CssSelector("input[id$=\"btnAddMember\"]"));
            CloseModalButton = new Button(Driver, By.CssSelector("input[id$=\"btnClose\"]"));
            AddEditModal = new Modal(Driver, By.CssSelector("td[id$=\"ModalPopupControlAddPeople_PWC-1\"]"));
            AdoptedYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsAdopted_0\"]"));
            AdoptedNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsAdopted_1\"]"));
            FosterCareYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsFosterCare_0\"]"));
            FosterCareNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsFosterCare_1\"]"));
            MilitaryYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsMilitary_0\"]"));
            MilitaryNo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsMilitary_1\"]"));
            LEOYes = new Radio(Driver, By.CssSelector("input[id$=\"rbIsLawEnforcementOfficer_0\"]"));
            LEONo = new Radio(Driver, By.CssSelector("input[id$=\"rbIsLawEnforcementOfficer_1\"]"));
        }
    }
}
