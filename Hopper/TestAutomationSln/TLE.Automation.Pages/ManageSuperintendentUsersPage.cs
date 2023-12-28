using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ManageSuperintendentUsersPage : CommonPage
    {
        public Dropdown FilterUserList { get; private set; }

        public Link CreateNewSuperintendentLink { get; private set; }

        public Table SuperintendentList { get; private set; }

        public ManageSuperintendentUsersPage(IWebDriver driver)
            : base(driver)
        {
            FilterUserList = new Dropdown(Driver, By.Id("ActiveFilter"));
            CreateNewSuperintendentLink = new Link(Driver, By.Id("btnEditClass"));
            SuperintendentList = new Table(Driver, By.Id("userTable"));
        }
    }
}
