using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class UserAdministrationPage : CommonPage
    {
        public Button ManageSchoolGroupsButton { get; private set; }

        public Button ManageSuperintendentUsersButton { get; private set; }

        public Button ManageSchoolAdminTeacherUsersButton { get; private set; }

        public UserAdministrationPage(IWebDriver driver)
            : base(driver)
        {
            ManageSchoolGroupsButton = new Button(Driver, By.CssSelector("a[ui-sref='manageschoolgroups']"));
            ManageSuperintendentUsersButton = new Button(Driver, By.CssSelector("a[ui-sref='managesuperintendents']"));
            ManageSchoolAdminTeacherUsersButton = new Button(Driver, By.CssSelector("a[href='/Admin/FacultyUserAdministration']"));
        }
    }
}
