using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class PreScreenVerifyStudentsPage : WizardPage
    {
        public Table StudentList { get; private set; }

        public PreScreenVerifyStudentsPage(IWebDriver driver)
            : base(driver)
        {
            StudentList = new Table(Driver, By.Id("gvStudentValidation"));
        }
    }
}
