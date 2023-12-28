using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class RegisterRenewalStudentPage : StudentInfoPage
    {
        public Text RenewalStudentsFound { get; private set; }

        public Table StudentList { get; private set; }

        public RegisterRenewalStudentPage(IWebDriver driver)
            : base(driver)
        {
            RenewalStudentsFound = new Text(Driver, By.CssSelector("span[id$=\"_lblCount\"]"));
            StudentList = new Table(Driver, By.CssSelector("table[id$=\"_GVStudents\"]"));
        }
    }
}
