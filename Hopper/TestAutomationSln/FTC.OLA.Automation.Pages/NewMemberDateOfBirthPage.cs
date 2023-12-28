using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class NewMemberDateOfBirthPage : ApplicationWizardPage
    {
        public EditField DateOfBirth { get; private set; }
        public Text DateOfBirthIsRequiredMessage { get; private set; }

        public NewMemberDateOfBirthPage(IWebDriver driver)
            : base(driver)
        {
            DateOfBirth = new EditField(Driver, By.Id("dateOfBirth"));
            DateOfBirthIsRequiredMessage = new Text(Driver, By.CssSelector("#question-form > div > div > div"));
        }
    }
}
