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
    public class CreateStudentPage : StudentDetailsPage
    {
        public Button SaveAndAddNewButton { get; private set; }

        public CreateStudentPage(IWebDriver driver)
            : base(driver)
        {
            SaveAndAddNewButton = new Button(Driver, By.CssSelector("input[value=\"Save And New\"]"));
        }
    }
}
