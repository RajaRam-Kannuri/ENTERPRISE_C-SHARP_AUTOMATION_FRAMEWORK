using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class PrintIDCardPage : AccountActivityPage
    {
        public Dropdown StudentList { get; private set; }

        public PrintIDCardPage(IWebDriver driver)
            : base(driver)
        {
            StudentList = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudentList\"]"));
        }
    }
}
