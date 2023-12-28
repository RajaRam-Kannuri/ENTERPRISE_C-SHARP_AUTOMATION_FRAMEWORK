using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentGenderPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown GenderDropdown { get; private set; }
        public Text GenderIsRequiredMessage { get; private set; }

        public StudentGenderPage(IWebDriver driver)
            : base(driver)
        {
            GenderDropdown = new OLAWorkflowDropdown (Driver, By.ClassName("select-dropdown"));
            GenderIsRequiredMessage = new Text(Driver, By.XPath("//p[text() = 'Gender is required!']"));
        }
    }
}
