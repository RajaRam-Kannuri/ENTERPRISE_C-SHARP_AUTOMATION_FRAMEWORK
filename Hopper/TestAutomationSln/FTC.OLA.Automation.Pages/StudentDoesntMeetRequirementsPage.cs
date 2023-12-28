using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentDoesntMeetRequirementsPage : ApplicationWizardPage
    {
        public Radio No { get; private set; }
        public Radio Yes { get; private set; }

        public StudentDoesntMeetRequirementsPage(IWebDriver driver)
            : base(driver)
        {
            No = new Radio(Driver, By.CssSelector("#question-form > div > div.col.s6.right-align.no-radio-container > div > label"));
            Yes = new Radio(Driver, By.CssSelector("#question-form > div > div:nth-child(2) > label"));
        }
    }
}
