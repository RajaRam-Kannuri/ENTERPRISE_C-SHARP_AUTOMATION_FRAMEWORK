using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public abstract class BaseLoggedOutPage : BasePage
    {
        public Tab HomeTab { get; private set; }

        public Tab NewUsersTab { get; private set; }

        public Tab UserLoginTab { get; private set; }

        public BaseLoggedOutPage(IWebDriver driver)
            : base(driver)
        {
            HomeTab = new Tab(Driver, By.LinkText("Home"));
            NewUsersTab = new Tab(Driver, By.LinkText("New Users"));
            UserLoginTab = new Tab(Driver, By.LinkText("User Login"));
        }
    }
}
