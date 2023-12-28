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
    public class ApplicationChildrenInformationPage : ApplicationWizardPage
    {
        public EditField FirstName { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField LastName { get; private set; }

        public Dropdown RelationshipToParent { get; private set; }

        public EditField DateOfBirth { get; private set; }

        public Dropdown Gender { get; private set; }

        public Dropdown Foster { get; private set; }

        public Dropdown OOHC { get; private set; }

        public ApplicationChildrenInformationPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"txtFirstName\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"txtMiddleName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"txtLastName\"]"));
            RelationshipToParent = new Dropdown(Driver, By.CssSelector("input[id$=\"ddlRelationshipToPrimaryGuardian\"]"));
            DateOfBirth = new EditField(Driver, By.CssSelector("input[id$=\"txtDateOfBirth\"]"));
            Gender = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlGender\"]"));
            Foster = new Dropdown(Driver, By.CssSelector("select[id$=\"DdlFoster\"]"));
            OOHC = new Dropdown(Driver, By.CssSelector("select[id$=\"DdlOutOfHome\"]"));
        }
    }
}
