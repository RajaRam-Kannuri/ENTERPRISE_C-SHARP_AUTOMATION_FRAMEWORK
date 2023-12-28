using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Portal.Automation.Pages
{
    public class ChangePasswordPage : PortalBasePage
    {
        public EditField CurrentPasswordField { get; private set; }
        public EditField NewPasswordField { get; private set; }
        public EditField ConfirmPasswordField { get; private set; }
        public Button SubmitButton { get; private set; }

        public ChangePasswordPage(IWebDriver driver)
            : base(driver)
        {
            CurrentPasswordField = new EditField(Driver, By.Id("OldPassword"));
            NewPasswordField = new EditField(Driver, By.Id("NewPassword"));
            ConfirmPasswordField = new EditField(Driver, By.Id("ConfirmPassword"));
            SubmitButton = new Button(Driver, By.CssSelector("#nextButton > div > button"));
        }
    }
}
