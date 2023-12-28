using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class SignInPage : OLABasePage
    {
        public EditField Username { get; private set; }
        public EditField Password { get; private set; }
        public Button SignInButton { get; private set; }
        public Button NextButton { get; private set; }
        public Link ForgotPassword { get; private set; }
        public Link CreateAnAccount { get; private set; }
        public Text UserIDorPasswordIsIncorrectMessage { get; private set; }

        public SignInPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("UserId"));
            Password = new EditField(Driver, By.Id("Password"));
            SignInButton = new Button(Driver, By.XPath("//*[@id='LoginForm']/div[4]/div/button"));
            NextButton = new Button(Driver, By.XPath("//*[@id='LoginForm']/div[3]/div/button"));
            ForgotPassword = new Link(Driver, By.Id("forgot-cred-link"));
            CreateAnAccount = new Link(Driver, By.Id("register-link"));
            UserIDorPasswordIsIncorrectMessage = new Text(Driver, By.XPath("//li[text() = 'The User ID or password is incorrect']"));
        }
    }
}
