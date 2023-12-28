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
    public class ApplicationSecondaryGuardianPage : ApplicationOtherAdultsPage
    {
        public EditField SSN { get; private set; }

        public EditField VerifySSN { get; private set; }

        public EditField HomePhone { get; private set; }

        public EditField WorkPhone { get; private set; }

        public EditField MobilePhone { get; private set; }

        public ApplicationSecondaryGuardianPage(IWebDriver driver)
            : base(driver)
        {
            SSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSocial1\"]"));
            VerifySSN = new EditField(Driver, By.CssSelector("input[id$=\"txtSocial2\"]"));
            HomePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtHomePhone\"]"));
            WorkPhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtWorkPhone\"]"));
            MobilePhone = new EditField(Driver, By.CssSelector("input[id$=\"_txtMobilePhone\"]"));
        }
    }
}
