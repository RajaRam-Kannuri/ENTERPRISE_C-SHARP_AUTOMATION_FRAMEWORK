using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentMaritalStatusPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown MaritalStatusDropdown { get; private set; }
        public Text ThisFieldIsRequiredMessage { get; private set; }

        public ParentMaritalStatusPage(IWebDriver driver)
            : base(driver)
        {
			MaritalStatusDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            ThisFieldIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div > div.errors"));
        }
    }
}
