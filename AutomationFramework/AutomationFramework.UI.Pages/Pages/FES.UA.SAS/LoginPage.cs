using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class LoginPage : BasePage
    {
        public EditField Username { get; private set; }

        public EditField Password { get; private set; }

        public Button LoginButton { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(driver, By.Id("LoginUser_UserName"));
            Password = new EditField(driver, By.Id("LoginUser_Password"));
            LoginButton = new Button(driver, By.Id("LoginUser_LoginButton"));
        }
    }
}