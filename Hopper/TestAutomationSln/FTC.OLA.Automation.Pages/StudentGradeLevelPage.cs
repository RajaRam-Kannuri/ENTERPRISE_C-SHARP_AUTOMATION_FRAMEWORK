using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentGradeLevelPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown GradeLevelDropdown { get; private set; }
        public Text GradeLevelIsRequiredMessage { get; private set; }

        public StudentGradeLevelPage(IWebDriver driver)
            : base(driver)
        {
            GradeLevelDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            GradeLevelIsRequiredMessage = new Text(Driver, By.XPath("//p[text() = 'Grade Level is required!']"));
        }
    }
}
