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
    public class CreateUserPage : CommonPage
    {
        public EditField Username { get; private set; }

        public EditField FirstName { get; private set; }

        public EditField LastName { get; private set; }

        public Button SaveAndAddNewButton { get; private set; }

        public Button SaveButton { get; private set; }

        public Link CancelLink { get; private set; }

        public Checkbox TeacherRole { get; private set; }

        public Checkbox SchoolAdminRole { get; private set; }

        public CreateUserPage(IWebDriver driver)
            : base(driver)
        {
            Username = new EditField(Driver, By.Id("UserName"));
            FirstName = new EditField(Driver, By.Id("FirstName"));
            LastName = new EditField(Driver, By.Id("LastName"));
            SaveAndAddNewButton = new Button(Driver, By.Name("savethenNew"));
            SaveButton = new Button(Driver, By.Name("save"));
            CancelLink = new Link(Driver, By.CssSelector(""));
            TeacherRole = new Checkbox(Driver, By.CssSelector("input[value=\"Teacher\"]"));
            SchoolAdminRole = new Checkbox(Driver, By.CssSelector("input[value=\"SchoolAdmin\"]"));
        }
    }
}
