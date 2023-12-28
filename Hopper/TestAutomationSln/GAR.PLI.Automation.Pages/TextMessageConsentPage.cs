using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class TextMessageConsentPage : ApplicationWizardPage
    {
        public Button AcceptButton { get; private set; }

        public Button DeclineButton { get; private set; }

        public TextMessageConsentPage(IWebDriver driver)
            : base(driver)
        {
            AcceptButton = new Button(Driver, By.Id("RPMainPanel_ctl15_btnAccept"));
            DeclineButton = new Button(Driver, By.Id("RPMainPanel_ctl15_btnDecline"));
        }
    }
}
