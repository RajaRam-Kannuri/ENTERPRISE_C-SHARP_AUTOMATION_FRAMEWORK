using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentSchoolYearPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown SchoolYearDropdown { get; private set; }

        public StudentSchoolYearPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYearDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
        }
    }
}
