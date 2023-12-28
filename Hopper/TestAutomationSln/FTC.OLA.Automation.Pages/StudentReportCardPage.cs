using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentReportCardPage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown ReportCardDropdown { get; private set; }

        public StudentReportCardPage(IWebDriver driver)
            : base(driver)
        {
            ReportCardDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
        }
    }
}
