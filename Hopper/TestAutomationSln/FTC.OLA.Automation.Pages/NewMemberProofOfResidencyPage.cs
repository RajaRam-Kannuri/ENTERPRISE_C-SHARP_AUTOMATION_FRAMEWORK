using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberProofOfResidencyPage : ApplicationWizardPage
    {
        public OLAResidencyDropdown ResidencyDropdown { get; private set; }
        public Button CloseTourPopup { get; private set; }

        public NewMemberProofOfResidencyPage(IWebDriver driver)
            : base(driver)
        {
            ResidencyDropdown = new OLAResidencyDropdown(Driver, By.ClassName("select-dropdown"));
            CloseTourPopup = new Button(Driver, By.XPath("//button[text() = 'Close']"));
        }
    }
}
