using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJESignInPage : BasePage
    {
        public EditField Username { get; private set; }
        public EditField Password { get; private set; }
        public Button SignInLink { get; private set; }
        public Button SignInButton { get; private set; }

        public MJESignInPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("user_login"));
            Password = new EditField(Driver, By.Id("user_pass"));
            SignInLink = new Button(Driver, By.CssSelector("#myAccount > div > ul > li:nth-child(1) > a"));
            SignInButton = new Button(Driver, By.CssSelector("#signInForm > form > div.inner-form.signin-form > div:nth-child(3) > div.sign-in-button.float-left > button"));
        }
    }
}
