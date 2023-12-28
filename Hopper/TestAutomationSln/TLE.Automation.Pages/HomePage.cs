using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class HomePage : CommonPage
    {
        public Text SchoolName { get; private set; }

        public Text SchoolYear { get; private set; }

        public EditField StudentLastNameField { get; private set; }

        public Button StudentSearchButton { get; private set; }

        public Text ConferenceOutlook { get; private set; }

        public Table MyClassesTable { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link MyClassesRowMenu { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link CreateNewUnitPlanLink { get; private set; }

        [KeywordTestingRequiresStoredElement]
        public Link ViewUnitPlansLink { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            SchoolName = new Text(Driver, By.CssSelector(""));
            SchoolYear = new Text(Driver, By.CssSelector(""));
            StudentLastNameField = new EditField(Driver, By.Id("LastName"));
            StudentSearchButton = new Button(Driver, By.CssSelector("button[type=\"submit\"]"));
            ConferenceOutlook = new Text(Driver, By.CssSelector(""));
            MyClassesTable = new Table(Driver, By.CssSelector(".table.fluid"));
            MyClassesRowMenu = new Link(Driver, By.LinkText(""));
            CreateNewUnitPlanLink = new Link(Driver, By.LinkText("Create New Unit Plan"));
            ViewUnitPlansLink = new Link(Driver, By.LinkText("View Unit Plans"));
        }
    }
}
