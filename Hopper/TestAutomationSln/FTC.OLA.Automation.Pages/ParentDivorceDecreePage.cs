using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentDivorceDecreePage : ApplicationWizardPage
    {
        public OLAWorkflowDropdown DivorceDecreeDropdown { get; private set; }
        public OLADocUploadButton UploadDocumentsButton { get; private set; }

        public ParentDivorceDecreePage(IWebDriver driver)
            : base(driver)
        {
            DivorceDecreeDropdown = new OLAWorkflowDropdown(Driver, By.ClassName("select-dropdown"));
            UploadDocumentsButton = new OLADocUploadButton(Driver, By.XPath("//span[text() = 'Upload Documents']"));
        }
    }
}