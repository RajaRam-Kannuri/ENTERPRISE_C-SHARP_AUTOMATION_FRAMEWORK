using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.Provider.Automation.Pages
{
    public class LoginPage : LoggedOutPage
    {
        public EditField Username { get; private set; }
        public EditField Password { get; private set; }
        public Button LogInButton { get; private set; }
        public Link CreateAnAccountLink { get; private set; }
        public Link ForgotPasswordLink { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            Password = new EditField(Driver, By.CssSelector("input[id$=\"Password\"]"));
            LogInButton = new Button(Driver, By.CssSelector("input[id$=\"LoginButton\"]"));
            CreateAnAccountLink = new Link(Driver, By.CssSelector("input[id$=\"lblProviderCreateAnAccount\"]"));
            ForgotPasswordLink = new Link(Driver, By.CssSelector("input[id$=\"lbForgotPassword\"]"));
        }
    }
}
