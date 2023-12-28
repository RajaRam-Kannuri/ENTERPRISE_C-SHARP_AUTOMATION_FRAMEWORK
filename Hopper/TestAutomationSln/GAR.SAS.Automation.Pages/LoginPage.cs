using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class LoginPage : BasePage
    {
        public EditField Username { get; private set; }

        public EditField Password { get; private set; }

        public Button LoginButton { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("LoginUser_UserName"));
            Password = new EditField(Driver, By.Id("LoginUser_Password"));
            LoginButton = new Button(Driver, By.Id("LoginUser_LoginButton"));
        }
    }
}
