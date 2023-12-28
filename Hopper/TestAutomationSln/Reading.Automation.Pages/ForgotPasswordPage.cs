using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class ForgotPasswordPage :
        BasePage
    {
        public Link ForgotUserId { get; private set; }
        public Link ForgotPassword { get; private set; }
        public Link BackToLogin { get; private set; }
        public EditField Email { get; private set; }
        public Text EmailIsRequiredMessage { get; private set; }
        public Text EmailIsNotValidMessage { get; private set; }
        public Text EmailHasBeenSentMessage { get; private set; }
        public Button NextButton { get; private set; }

        public ForgotPasswordPage(IWebDriver driver)
            : base(driver)
        {
            ForgotUserId = new Link(Driver, By.Id("userId-icon"));
            ForgotPassword = new Link(Driver, By.Id("password-icon"));
            BackToLogin = new Link(Driver, By.Id("back-to-login"));
            Email = new EditField(Driver, By.Id("email"));
            EmailIsRequiredMessage = new Text(Driver, By.Id("email-error"));
            EmailIsNotValidMessage = new Text(Driver, By.Id("email-error"));
            EmailHasBeenSentMessage = new Text(Driver, By.CssSelector("body > div.container.card-container.ids-container > div > div > div > div > p"));
            NextButton = new Button(Driver, By.CssSelector("#nextButton > div > button"));
        }
    }
}
