using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class LoginPage : BaseLoggedOutPage
    {
        public EditField Username { get; private set; }

        public EditField Password { get; private set; }

        public Button LogInButton { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            // Username = new EditField(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            //Username = new EditField(Driver, By.XPath("//*[@id='UserId']"));
            //Password = new EditField(Driver, By.CssSelector("input[id$=\"Password\"]"));
            //LogInButton = new Button(Driver, By.CssSelector("input[id$=\"LoginButton\"]"));
            Username = new EditField(Driver, By.XPath("//*[@id='UserId']"));
            Password = new EditField(Driver, By.Id("Password"));
            LogInButton = new Button(Driver, By.XPath("//*[contains(text(), 'My Button')]"));

        }
    }
}
