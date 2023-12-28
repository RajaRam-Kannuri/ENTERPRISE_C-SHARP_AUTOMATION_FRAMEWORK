using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentFosterOrOutOfHomeCarePage : ApplicationWizardPage
    {
        public Radio No { get; private set; }
        public Radio FosterCare { get; private set; }
        public Radio OutOfHomeCare { get; private set; }
        public Text YouMustSelectAnOptionMessage { get; private set; }

        public StudentFosterOrOutOfHomeCarePage(IWebDriver driver)
            : base(driver)
        {
            No = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(1) > div:nth-child(1) > label"));
            FosterCare = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(1) > div:nth-child(2) > label"));
            OutOfHomeCare = new Radio(Driver, By.CssSelector("#question-form > div:nth-child(1) > div:nth-child(3) > label"));
            YouMustSelectAnOptionMessage = new Text(Driver, By.CssSelector("#question-form > div:nth-child(2) > div > div"));
        }
    }
}
