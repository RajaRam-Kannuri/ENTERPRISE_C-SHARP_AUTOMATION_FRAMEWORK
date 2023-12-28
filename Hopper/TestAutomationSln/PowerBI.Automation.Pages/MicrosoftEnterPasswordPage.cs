using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class MicrosoftEnterPasswordPage : BasePage
    {
        public EditField PasswordTextBox { get; private set; }
        public Button SignInButton { get; private set; }

        public MicrosoftEnterPasswordPage(IWebDriver driver)
            : base(driver)
        {
            PasswordTextBox = new EditField(Driver, By.Id("i0118"));
            SignInButton = new Button(Driver, By.Id("idSIButton9"));
        }
    }
}
