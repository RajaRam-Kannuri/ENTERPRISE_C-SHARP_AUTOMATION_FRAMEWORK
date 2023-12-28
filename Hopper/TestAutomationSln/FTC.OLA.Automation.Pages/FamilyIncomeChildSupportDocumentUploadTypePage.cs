using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class FamilyIncomeChildSupportDocumentUploadTypePage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown DocumentDropdown { get; private set; }

        public FamilyIncomeChildSupportDocumentUploadTypePage(IWebDriver driver)
            : base(driver)
        {
            DocumentDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
        }
    }
}