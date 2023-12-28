using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Support;


namespace GAR.PLI.Automation.Pages
{
    public class SwornComplianceStatementPage : ApplicationWizardPage
    {
        public Text PrimaryParentName { get; private set; }

        public EditField PrimaryParentSignature { get; private set; }

        public Text SecondaryParentName { get; private set; }

        public EditField SecondaryParentSignature { get; private set; }

        public SwornComplianceStatementPage(IWebDriver driver)
            : base(driver)
        {
            PrimaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblPrimaryParentName\"]"));
            PrimaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtPrimaryParentSignature\"]"));
            SecondaryParentName = new Text(Driver, By.CssSelector("span[id$=\"_lblSecondaryParentName\"]"));
            SecondaryParentSignature = new EditField(Driver, By.CssSelector("input[id$=\"_txtSecondaryParentSignature\"]"));
        }
    }
}
