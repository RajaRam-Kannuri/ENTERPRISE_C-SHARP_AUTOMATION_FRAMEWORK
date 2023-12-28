using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class LoginPage : BasePage
    {
        public EditField Username { get; private set; }

        public EditField Password { get; private set; }

        public Button Submit { get; private set; }

        public Link ForgotPassword { get; private set; }

        public Text ErrorMessage { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("UserName"));
            Password = new EditField(Driver, By.Id("Password"));
            Submit = new Button(Driver, By.CssSelector(".login-action.btn"));
            ForgotPassword = new Link(Driver, By.CssSelector("a[href=\"Account/PasswordRecover\"]"));
            ErrorMessage = new Text(Driver, By.CssSelector(".validation-summary-errors"));
        }
    }
}
