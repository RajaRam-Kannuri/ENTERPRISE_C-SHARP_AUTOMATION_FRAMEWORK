using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class ChangePasswordPage : HomePage
    {
        public EditField CurrentPassword { get; private set; }

        public EditField NewPassword { get; private set; }

        public EditField ConfirmNewPassword { get; private set; }

        public Button ChangePasswordButton { get; private set; }

        public Button CancelButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public ChangePasswordPage(IWebDriver driver)
            : base(driver)
        {
            CurrentPassword = new EditField(Driver, By.CssSelector("input[id$=\"CurrentPassword\"]"));
            NewPassword = new EditField(Driver, By.CssSelector("input[id$=\"NewPassword\"]"));
            ConfirmNewPassword = new EditField(Driver, By.CssSelector("input[id$=\"ConfirmNewPassword\"]"));
            ChangePasswordButton = new Button(Driver, By.CssSelector("input[id$=\"ChangePasswordPushButton\"]"));
            CancelButton = new Button(Driver, By.CssSelector("input[id$=\"CancelPushButton\"]"));
            StatusMessage = new Text(Driver, By.CssSelector("td[id$=\"tablecellSuccessTemplate\"]"));
        }
    }
}
