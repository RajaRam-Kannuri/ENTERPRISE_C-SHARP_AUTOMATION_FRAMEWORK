using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class LoginPage : BaseLoggedOutPage
    {
        public EditField Username { get; private set; }

        public FundedStudentUsername FundedStudentUsername { get; private set; }

        public EditField Password { get; private set; }

        public Button LogInButton { get; private set; }

        public HiddenButton OnlineChatButton { get; private set; }

		public Text ErrorMessage { get; private set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            FundedStudentUsername = new FundedStudentUsername(Driver, By.CssSelector("input[id$=\"UserName\"]"));
            Password = new EditField(Driver, By.CssSelector("input[id$=\"Password\"]"));
            LogInButton = new Button(Driver, By.CssSelector("input[id$=\"LoginButton\"]"));
            OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
			ErrorMessage = new Text(Driver, By.CssSelector("#RPMainPanel_controls_authentication_login_ascx6_LoginControlOnPage_pnlLogin > table > tbody > tr > td > table > tbody > tr:nth-child(6) > td"));
		}
	}
}
