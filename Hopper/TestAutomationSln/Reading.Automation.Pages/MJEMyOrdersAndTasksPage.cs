using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEMyOrdersAndTasksPage : MJEBasePage
    {
        public EditField Username { get; private set; }

        public MJEMyOrdersAndTasksPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("UserId"));
        }
    }
}
