using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class LoginPage : BasePage
    {
        public EditField SchoolCode { get; private set; }

        public EditField Password { get; private set; }

        public Checkbox RememberMe { get; private set; }

        public Button LogIn { get; private set; }

        public Link ForgotPassword { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            SchoolCode = new EditField(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            Password = new EditField(Driver, By.CssSelector("input[id$=\"Password\"]"));
            RememberMe = new Checkbox(Driver, By.CssSelector("input[id$=\"RememberMe\"]"));
            LogIn = new Button(Driver, By.CssSelector("input[id$=\"LoginButton\"]"));
            ForgotPassword = new Link(Driver, By.CssSelector("input[id$=\"PasswordRecoveryLink\"]"));
        }
    }
}
