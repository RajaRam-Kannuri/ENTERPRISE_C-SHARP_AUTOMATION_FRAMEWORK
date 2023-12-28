using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace TLE.Automation.Pages
{
    public class EditSuperintendentUserPage : CreateNewSuperintendentPage
    {
        public Checkbox Active { get; private set; }

        public Checkbox AccountLocked { get; private set; }

        public Text FailedPasswordAttempts { get; private set; }

        public TypeAheadList SchoolGroupField { get; private set; }

        public Dropdown SchoolGroupList { get; private set; }

        public Button AddSchoolGroupButton { get; private set; }

        public Table AssignedSchoolGroupsTable { get; private set; }

        public EditSuperintendentUserPage(IWebDriver driver)
            : base(driver)
        {
            Active = new Checkbox(Driver, By.Id("IsActive"));
            AccountLocked = new Checkbox(Driver, By.Id("IsLockedOut"));
            FailedPasswordAttempts = new Text(Driver, By.ClassName(""));
            SchoolGroupField = new TypeAheadList(Driver, By.CssSelector("div[ng-model='vm.user.newSchools']"));
            SchoolGroupList = new Dropdown(Driver, By.Id("select2-drop"));
            AddSchoolGroupButton = new Button(Driver, By.CssSelector("button[ng-click='vm.addSchools()']"));
            AssignedSchoolGroupsTable = new Table(Driver, By.CssSelector(".table.table-bordered"));
        }
    }
}
