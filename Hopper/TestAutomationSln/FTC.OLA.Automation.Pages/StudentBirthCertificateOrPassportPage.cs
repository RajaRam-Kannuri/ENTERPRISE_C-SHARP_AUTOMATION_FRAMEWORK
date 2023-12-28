using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentBirthCertificateOrPassportPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown Dropdown { get; private set; }

        public StudentBirthCertificateOrPassportPage(IWebDriver driver)
            : base(driver)
        {
            Dropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
        }
    }
}
