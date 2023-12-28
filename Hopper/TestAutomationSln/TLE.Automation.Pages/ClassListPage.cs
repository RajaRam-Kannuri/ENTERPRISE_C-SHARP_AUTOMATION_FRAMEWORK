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
    public class ClassListPage : CommonPage
    {
        public Link CreateClassLink { get; private set; }

        public Text SchoolName { get; private set; }

        public Dropdown TeacherName { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Text ClassCount { get; private set; }

        public Table ClassTable { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link ViewOrEditClass { get; private set; }

        public ClassListPage(IWebDriver driver)
            : base(driver)
        {
            CreateClassLink = new Link(Driver, By.Id("btnEditClass"));
            SchoolName = new Text(Driver, By.Id("school"));
            TeacherName = new Dropdown(Driver, By.Id("teacher"));
            SchoolYear = new Dropdown(Driver, By.Id("schoolYear"));
            ClassCount = new Text(Driver, By.Id("classCount"));
            ClassTable = new Table(Driver, By.CssSelector(".table.classes"));
            ViewOrEditClass = new Link(Driver, By.CssSelector(".btnClassDetails"));
        }
    }
}
