using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
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

        public Dropdown Foster { get; private set; }

        public Dropdown OOHC { get; private set; }

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

        public Dropdown GradeLevel { get; private set; }

        public EditField SchoolAttended { get; private set; }

        public Dropdown SchoolType { get; private set; }

        public Dropdown SchoolCounty { get; private set; }

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
            Foster = new Dropdown(Driver, By.CssSelector("select[id$=\"DdlFoster\"]"));
            OOHC = new Dropdown(Driver, By.CssSelector("select[id$=\"DdlOutOfHome\"]"));
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
            GradeLevel = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGradeLevel\"]"));
            SchoolAttended = new EditField(Driver, By.CssSelector("input[id$=\"tbSchoolAttendend\"]"));
            SchoolType = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolType\"]"));
            SchoolCounty = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolCounty\"]"));
        }
    }
}
