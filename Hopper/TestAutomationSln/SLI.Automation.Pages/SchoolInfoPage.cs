using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class SchoolInfoPage : HomePage
    {
        public Link SchoolProfile { get; private set; }

        public Link SchoolContacts { get; private set; }

        public Link TuitionFees { get; private set; }

        public Table SUFSContacts { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public SchoolInfoPage(IWebDriver driver)
            : base(driver)
        {
            SchoolProfile = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=33\"]"));
            SchoolContacts = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=99\"]"));
            TuitionFees = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=34\"]"));
            SUFSContacts = new Table(Driver, By.CssSelector("table[id$=\"_DTextReadOnly\"] > table"));
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlSchoolYear\"]"));
        }
    }
}
