using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentProofOfResidencyPage : ApplicationWizardPage
    {
        public OLAResidencyDropdown ResidencyDropdown { get; private set; }
        public OLADocUploadButton UploadDocumentsButton { get; private set; }

        public ParentProofOfResidencyPage(IWebDriver driver)
            : base(driver)
        {
            ResidencyDropdown = new OLAResidencyDropdown(Driver, By.ClassName("select-dropdown"));
            UploadDocumentsButton = new OLADocUploadButton(Driver, By.XPath("//span[text() = 'Upload Documents']"));
        }
    }
}