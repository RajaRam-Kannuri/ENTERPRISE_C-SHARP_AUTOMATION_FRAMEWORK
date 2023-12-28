using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class ManageSchoolAdminsTeachersPage : CommonPage
    {
        public Dropdown SchoolLookup { get; private set; }

        public Dropdown FilterUsers { get; private set; }

        public Table UserTable { get; private set; }

        public Link CreateUser { get; private set; }

        public Link UploadUsers { get; private set; }

        public ManageSchoolAdminsTeachersPage(IWebDriver driver)
            : base(driver)
        {
            SchoolLookup = new Dropdown(Driver, By.Id("s2id_SchoolId"));
            FilterUsers = new Dropdown(Driver, By.CssSelector(""));
            UserTable = new Table(Driver, By.CssSelector(""));
            CreateUser = new Link(Driver, By.Id("btnCreateUser"));
            UploadUsers = new Link(Driver, By.Id("btnOpenUpload"));
        }
    }
}
