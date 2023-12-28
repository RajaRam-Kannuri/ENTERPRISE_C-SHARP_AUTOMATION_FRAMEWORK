using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ChangePasswordPage : BasePage
    {
        public EditField CurrentPassword { get; private set; }

        public EditField NewPassword { get; private set; }

        public EditField ConfirmNewPassword { get; private set; }

        public Button SaveButton { get; private set; }

        public Button CancelButton { get; private set; }

        public ChangePasswordPage(IWebDriver driver)
            : base(driver)
        {
            CurrentPassword = new EditField(Driver, By.Id("OldPassword"));
            NewPassword = new EditField(Driver, By.Id("NewPassword"));
            ConfirmNewPassword = new EditField(Driver, By.Id("ConfirmNewPassword"));
            SaveButton = new Button(Driver, By.Name("save"));
            CancelButton = new Button(Driver, By.LinkText("Cancel"));
        }
    }
}
