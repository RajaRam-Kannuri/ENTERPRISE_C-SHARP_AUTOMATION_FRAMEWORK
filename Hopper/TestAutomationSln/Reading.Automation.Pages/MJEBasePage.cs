using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public abstract class MJEBasePage : BasePage
    {
        public Button MenuOptionDropDown { get; private set; }
        public Button MenuOptionDashBoard { get; private set; }
        public Button MenuOptionMyProfile { get; private set; }
        public Button MenuOptionMyTasks { get; private set; }
        public Button MenuOptionMyJobs { get; private set; }
        public Button MenuOptionSignOut { get; private set; }


        public MJEBasePage(IWebDriver driver)
            : base(driver)
        {
            MenuOptionDropDown = new Button(Driver, By.Id("dropdownMenu1"));
            MenuOptionDashBoard = new Button(Driver, By.XPath("//*[contains(@href, '/dashboard/')]"));
            MenuOptionMyProfile = new Button(Driver, By.XPath("//*[contains(@href, '/profile/')]"));
            MenuOptionMyTasks = new Button(Driver, By.XPath("//*[contains(@href, '/my-list-tasks/')]"));
            MenuOptionMyJobs = new Button(Driver, By.XPath("//*[contains(@href, '/my-listing-jobs/')]"));
            MenuOptionSignOut = new Button(Driver, By.XPath("//*[contains(@href, 'sufsesadev.wpengine.com')]"));
        }
    }
}
