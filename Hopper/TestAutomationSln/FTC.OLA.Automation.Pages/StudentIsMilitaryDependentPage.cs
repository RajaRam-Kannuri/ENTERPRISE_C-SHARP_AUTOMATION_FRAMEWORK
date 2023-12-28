using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentIsMilitaryDependentPage : ApplicationWizardPage
    {
        public Radio No { get; private set; }
        public Radio Yes { get; private set; }
        public Radio DependentOfArmedForcesNo { get; private set; }
        public Radio DependentOfArmedForcesYes { get; private set; }
        public Radio DependentOfLEONo { get; private set; }
        public Radio DependentOfLEOYes { get; private set; }
        public Text YouMustSelectYesOrNoMessage { get; private set; }

        public StudentIsMilitaryDependentPage(IWebDriver driver)
            : base(driver)
        {
            No = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div.col.s6.right-align.no-radio-container > div > label"));
            DependentOfArmedForcesNo = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div.col.s6.right-align.no-radio-container > div > label"));
            DependentOfLEONo = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(5) > div.col.s6.right-align.no-radio-container > div > label"));
            Yes = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div.col.s1 > label"));
            DependentOfArmedForcesYes = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(2) > div.col.s1 > label"));
            DependentOfLEOYes = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(5) > div.col.s1 > label"));
            YouMustSelectYesOrNoMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div > div"));
        }
    }
}
