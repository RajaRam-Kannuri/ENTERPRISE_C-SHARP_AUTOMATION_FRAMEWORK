using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace TLE.Automation.Pages
{
    public class EditSUFSStudentPage : EditStudentPage
    {
        public EditSUFSStudentPage(IWebDriver driver)
            : base(driver)
        {
        }
    }
}
