using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationServiceFeeAcknoledgementPage : ApplicationWizardPage
    {
        public Radio Agree { get; private set; }

        public ApplicationServiceFeeAcknoledgementPage(IWebDriver driver)
            : base(driver)
        {
            Agree = new Radio(Driver, By.CssSelector("input[id$=\"_rbAgree\"]"));
        }
    }
}
