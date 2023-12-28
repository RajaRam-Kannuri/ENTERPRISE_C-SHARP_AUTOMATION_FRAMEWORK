using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberChildIsDependentPage : ApplicationWizardPage
    {
        public Button NoButton { get; private set; }
        public Button YesButton { get; private set; }
        public Text YouMustSelectYesOrNoMessage { get; private set; }

        public NewMemberChildIsDependentPage(IWebDriver driver)
            : base(driver)
        {
            NoButton = new Button(Driver, By.CssSelector("#question-form > div:nth-child(1) > div:nth-child(1) > label:nth-child(2)"));
            YesButton = new Button(Driver, By.CssSelector("div.s12:nth-child(2) > label:nth-child(2)"));
            YouMustSelectYesOrNoMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div > div"));
        }
    }
}
