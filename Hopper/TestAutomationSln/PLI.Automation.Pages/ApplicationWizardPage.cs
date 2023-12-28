using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public abstract class ApplicationWizardPage : WizardPage
    {
        public Button SaveAndLogoutButton { get; private set; }

        public Modal ApplicationWizardErrorModal { get; private set; }

        public Button ApplicationWizardErrorModalOK { get; private set; }

        public Radio ApplicationWizardErrorRadioYes { get; private set; }

        public Radio ApplicationWizardErrorRadioNo { get; private set; }

        public ApplicationWizardPage(IWebDriver driver)
            : base(driver)
        {
            SaveAndLogoutButton = new Button(Driver, By.Id("RPMainPanel_BtnLogout"));
            PageTitle = new Text(Driver, By.Id("RPMainPanel_LblPageName"));
            ApplicationWizardErrorModal = new Modal(Driver, By.Id("ValidationPopup_PW-1"));
            ApplicationWizardErrorModalOK = new Button(Driver, By.Id("ValidationPopup_btnOk"));
            ApplicationWizardErrorRadioYes = new Radio(Driver, By.CssSelector("#ValidationPopup_PW-1 input[type=\"radio\"][value]:not([value=\"\"])"));
            ApplicationWizardErrorRadioNo = new Radio(Driver, By.CssSelector("input[type=\"radio\"][value=\"\"]"));
        }
    }
}
