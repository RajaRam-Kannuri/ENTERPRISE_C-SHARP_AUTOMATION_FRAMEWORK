using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ViewContactLogsPage : HomePage
    {
        public ContactLogsTable ContactLogTable { get; private set; }

        public ViewContactLogsPage(IWebDriver driver)
            : base(driver)
        {
            ContactLogTable = new ContactLogsTable(Driver, By.Id("tblNotes"));
        }
    }
}
