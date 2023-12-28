using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace OLA.Automation.Pages
{
    public class LoginPage : BaseLoggedOutPage
    {
        public EditField Username { get; private set; }

        public EditField Password { get; private set; }

        public Button LogInButton { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            Password = new EditField(Driver, By.CssSelector("input[id$=\"Password\"]"));
            LogInButton = new Button(Driver, By.CssSelector("input[id$=\"LoginButton\"]"));
        }

        public void LogInAs(string username, string password = "Hello123")
        {
            Username.SetText(username);
            Password.SetText(password);
            LogInButton.Click();
            UIElementManager.WaitForPageLoad(Driver);

            string pageSource = Driver.PageSource;
            if (pageSource.Contains("Your account is locked"))
                throw new WebDriverException("Login issue: Locked account - " + username);

            if (pageSource.Contains("Your password is incorrect."))
                throw new WebDriverException("Login issue: Incorrect password - " + username);
        }

        public bool IsLoginPresent()
        {
            return Username.IsAvailable();
        }
    }
}
