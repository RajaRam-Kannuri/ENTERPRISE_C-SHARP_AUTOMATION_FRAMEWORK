using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
{
    public class SchoolPasswordResetPage : HomePage
    {
        public EditField NewPassword { get; private set; }

        public Button ResetPasswordButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public SchoolPasswordResetPage(IWebDriver driver)
            : base(driver)
        {
            NewPassword = new EditField(Driver, By.CssSelector("input[id$=\"txtPassword\"]"));
            ResetPasswordButton = new Button(Driver, By.CssSelector("input[id$=\"btnSave\"]"));
            StatusMessage = new Text(Driver, By.CssSelector("span[id$=\"lblResult\"]"));
        }
    }
}
