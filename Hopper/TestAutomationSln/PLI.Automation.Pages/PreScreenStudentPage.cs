using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class PreScreenStudentPage : WizardPage
    {
        public Dropdown SchoolYear { get; private set; }

        public Dropdown NumberOfStudentsApplying { get; private set; }

        public Table StudentsApplying { get; private set; }

        public Modal NotificationModal { get; private set; }

        public Text NotificationMessage { get; private set; }

        public WebElement ModalHeader { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField FirstName { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField MiddleName { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField LastName { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField DateOfBirth { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown GradeLevel { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public EditField SSN { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown AttendedPublicSchoolLastYear { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown Foster { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown Gender { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown ReceivedSUFSFundingLastYear { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Dropdown OutOfHomeCare { get; private set; }

        public PreScreenStudentPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_DdlScholarshipApplicationYear"));
            NumberOfStudentsApplying = new Dropdown(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_DdlStudentCount"));
            StudentsApplying = new Table(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_DLStudentInfo"));
            NotificationModal = new Modal(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_ASPxModalPopupControl_CLW-1"));
            NotificationMessage = new Text(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_ASPxModalPopupControl_ModalContentTemplateLabel"));
            ModalHeader = new WebElement(Driver, By.Id("RPMainPanel_controls_prescreen_studentvalidation_ascx2_ASPxModalPopupControl_PWH-1"));
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"_TBFirstName\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"_TBMiddleName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"_TBLastName\"]"));
            DateOfBirth = new EditField(Driver, By.CssSelector("input[id$=\"_TBDateOfBirth\"]"));
            GradeLevel = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlGradeLevel\"]"));
            SSN = new EditField(Driver, By.CssSelector("input[id$=\"_TBSSN\"]"));
            AttendedPublicSchoolLastYear = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlPublicSchool\"]"));
            Foster = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlFoster\"]"));
            Gender = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlGender\"]"));
            ReceivedSUFSFundingLastYear = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlRenewal\"]"));
            OutOfHomeCare = new Dropdown(Driver, By.CssSelector("select[id$=\"_DdlOutOfHome\"]"));
        }
    }
}
