using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class SchoolPasswordResetPage : HomePage
    {
        public EditField NewPassword { get; private set; }

        public Button ResetPasswordButton { get; private set; }

        public Text StatusMessage { get; private set; }

        public SchoolPasswordResetPage(IWebDriver driver)
            : base(driver)
        {
            NewPassword = new EditField(driver, By.CssSelector("input[id$=\"txtPassword\"]"));
            ResetPasswordButton = new Button(driver, By.CssSelector("input[id$=\"btnSave\"]"));
            StatusMessage = new Text(driver, By.CssSelector("span[id$=\"lblResult\"]"));
        }
    }
}
