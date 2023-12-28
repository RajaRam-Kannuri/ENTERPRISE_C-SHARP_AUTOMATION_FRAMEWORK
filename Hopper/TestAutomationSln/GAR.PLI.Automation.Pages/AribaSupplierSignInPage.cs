using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class AribaSupplierSignInPage : BasePage
    {
        public EditField UsernameTextBox { get; private set; }
        public EditField PasswordTextBox { get; private set; }
        public Button LoginButton { get; private set; }

        public AribaSupplierSignInPage(IWebDriver driver)
            : base(driver)
        {
            UsernameTextBox = new EditField(Driver, By.Name("UserName"));
            PasswordTextBox = new EditField(Driver, By.Name("Password"));
            LoginButton = new Button(Driver, By.CssSelector("body > div.w-main-wrapper > table > tbody > tr.a-login-form-bg > td:nth-child(1) > div > table > tbody > tr > td.a-login-form-page.a-login-panel > form > div.loginFormBox > table > tbody > tr:nth-child(4) > td > input"));
        }
    }
}
