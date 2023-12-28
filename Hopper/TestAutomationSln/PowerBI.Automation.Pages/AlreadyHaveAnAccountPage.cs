using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class AlreadyHaveAnAccountPage : BasePage
    {
        public Button SignInButton { get; private set; }

        public AlreadyHaveAnAccountPage(IWebDriver driver)
            : base(driver)
        {
            SignInButton = new Button(Driver, By.Id("power-bi-portal-link-desktop"));
        }
    }
}
