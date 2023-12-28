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
    public class AccountSetupPage : BaseLoggedOutPage
    {
        public EditField FirstName { get; private set; }

        public EditField LastName { get; private set; }

        public EditField Email { get; private set; }

        public EditField ConfirmEmail { get; private set; }

        public EditField Password { get; private set; }

        public EditField ConfirmPassword { get; private set; }

        public Dropdown Question { get; private set; }

        public EditField Answer { get; private set; }

        public Dropdown ScholarshipYearApplyingFor { get; private set; }

        public Radio ContinuePLSAApplication_Yes { get; private set; }

        public Radio ContinuePLSAApplication_No { get; private set; }

        public Button CreateNewUserButton { get; private set; }

        public AccountSetupPage(IWebDriver driver)
            : base(driver)
        {
            FirstName = new EditField(Driver, By.CssSelector("input[id$=\"_TBFirstName\"]"));
            LastName = new EditField(Driver, By.CssSelector("input[id$=\"_TBLastName\"]"));
            Email = new EditField(Driver, By.CssSelector("input[id$=\"_UserName\"]"));
            ConfirmEmail = new EditField(Driver, By.CssSelector("input[id$=\"_Email\"]"));
            Password = new EditField(Driver, By.CssSelector("input[id$=\"_Password\"]"));
            ConfirmPassword = new EditField(Driver, By.CssSelector("input[id$=\"_ConfirmPassword\"]"));
            Question = new Dropdown(Driver, By.CssSelector("select[id$=\"_Question\"]"));
            Answer = new EditField(Driver, By.CssSelector("input[id$=\"_Answer\"]"));
            ScholarshipYearApplyingFor = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlYearSelector\"]"));
            ContinuePLSAApplication_Yes = new Radio(Driver, By.CssSelector("input[id$=\"rblUserConsent_0\"]"));
            ContinuePLSAApplication_No = new Radio(Driver, By.CssSelector("input[id$=\"rblUserConsent_1\"]"));
            CreateNewUserButton = new Button(Driver, By.CssSelector("input[id$=\"_StepNextButtonButton\"]"));
        }
    }
}
