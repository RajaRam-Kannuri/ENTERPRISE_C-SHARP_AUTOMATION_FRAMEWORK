using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class MicrosoftSignInPage : BasePage
    {
        public EditField EmailTextBox { get; private set; }
        public Button SubmitButton { get; private set; }
        public Button NextButton { get; private set; }

        public MicrosoftSignInPage(IWebDriver driver)
            : base(driver)
        {
            EmailTextBox = new EditField(Driver, By.Id("email"));
            SubmitButton = new Button(Driver, By.Id("submitBtn"));
            NextButton = new Button(Driver, By.Id("idSIButton9"));
        }
    }
}
