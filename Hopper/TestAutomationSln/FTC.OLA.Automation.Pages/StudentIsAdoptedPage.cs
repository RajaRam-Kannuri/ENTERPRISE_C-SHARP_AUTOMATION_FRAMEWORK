using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentIsAdoptedPage : ApplicationWizardPage
    {
        public Radio No { get; private set; }
        public Radio Yes { get; private set; }
        public Text YouMustSelectYesOrNoMessage { get; private set; }

        public StudentIsAdoptedPage(IWebDriver driver)
            : base(driver)
        {
            No = new Radio(Driver, By.CssSelector("#question-form > div.row.no-margin-bottom > div.col.s6.right-align.no-radio-container > div > label"));
            Yes = new Radio(Driver, By.CssSelector("#question-form > div.row.no-margin-bottom > div:nth-child(2) > label"));
            YouMustSelectYesOrNoMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div > div"));
        }
    }
}
