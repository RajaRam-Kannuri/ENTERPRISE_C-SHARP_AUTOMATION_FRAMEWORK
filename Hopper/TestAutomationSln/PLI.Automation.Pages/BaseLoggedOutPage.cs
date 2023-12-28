using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class BaseLoggedOutPage : FTCPLIBasePage
    {
        public Tab HomeTab { get; private set; }

        public Tab StudentPreScreenTab { get; private set; }

        public Tab UserLoginTab { get; private set; }

        public BaseLoggedOutPage(IWebDriver driver)
            : base(driver)
        {
            HomeTab = new Tab(Driver, By.LinkText("Home"));
            StudentPreScreenTab = new Tab(Driver, By.LinkText("Student Pre-Screen"));
            UserLoginTab = new Tab(Driver, By.LinkText("User Login"));
        }
    }
}
