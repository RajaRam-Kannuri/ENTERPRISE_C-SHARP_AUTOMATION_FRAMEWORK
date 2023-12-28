using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class StudentInfoPage : HomePage
    {
        public Link ApplicationStatus { get; private set; }

        public Link RegisterARenewalStudentLink { get; private set; }

        public Link RegisterAStudentNewToYourSchoolLink { get; private set; }

        public Link ConfirmEnrollmentLink { get; private set; }

        public Link WithdrawStudentLink { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public FTCSLIStudentTable StudentTable { get; private set; }

        public StudentInfoPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationStatus = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=39\"]"));
            RegisterARenewalStudentLink = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=37\"]"));
            RegisterAStudentNewToYourSchoolLink = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=101\"]"));
            ConfirmEnrollmentLink = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=40\"]"));
            WithdrawStudentLink = new Link(Driver, By.CssSelector("a[href=\"Control.aspx?OSP=38\"]"));
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlScholarshipApplicationYear\"]"));
            StudentTable = new FTCSLIStudentTable(Driver, By.CssSelector("table[id$=\"GVStudents\"]"));
        }
    }
}
