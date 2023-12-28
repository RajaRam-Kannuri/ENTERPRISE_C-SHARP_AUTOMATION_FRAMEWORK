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
    public class SecondaryGuardianPage : ApplicationWizardPage
    {
        public EditField FirstName { get; private set; }

        public EditField MiddleName { get; private set; }

        public EditField LastName { get; private set; }

        public EditField EmailAddress { get; private set; }

        public Dropdown RelationshipToPrimaryParent { get; private set; }

        public EditField HomePhone { get; private set; }

        public EditField WorkPhone { get; private set; }

        public EditField MobilePhone { get; private set; }

        public SecondaryGuardianPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"_txtFirstName\"]"));
            MiddleName = new EditField(Driver, By.CssSelector("input[id$=\"_txtMiddleName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"_txtLastName\"]"));
            EmailAddress = new EditField(Driver, By.CssSelector("input[id$=\"_txtEmail\"]"));
            RelationshipToPrimaryParent = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlRelationshipTypes\"]"));
            HomePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtHomePhone\"]"));
            WorkPhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtWorkPhone\"]"));
            MobilePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtMobilePhone\"]"));
        }
    }
}
