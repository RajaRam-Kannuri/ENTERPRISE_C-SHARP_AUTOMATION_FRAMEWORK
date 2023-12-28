using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public abstract class WizardPage : BaseLoggedOutPage
    {
        public Button NextButton { get; private set; }

        public Button PreviousButton { get; private set; }

        public WizardPage(IWebDriver driver)
            : base(driver)
        {
            NextButton = new Button(Driver, By.Id("RPMainPanel_BtnNext"));
            PreviousButton = new Button(Driver, By.Id("RPMainPanel_BtnPrevious"));
        }
    }
}
