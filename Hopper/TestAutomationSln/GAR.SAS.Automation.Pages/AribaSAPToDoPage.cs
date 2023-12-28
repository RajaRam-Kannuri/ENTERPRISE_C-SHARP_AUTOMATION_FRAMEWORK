using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.SAS.Automation.Pages
{
    public class AribaSAPToDoPage : BasePage
    {
        public AribaPRTable ToDoTable { get; private set; }

        public AribaSAPToDoPage(IWebDriver driver)
            : base(driver)
        {
            ToDoTable = new AribaPRTable(Driver, By.Id("_mjp8tb"));
        }
    }
}
