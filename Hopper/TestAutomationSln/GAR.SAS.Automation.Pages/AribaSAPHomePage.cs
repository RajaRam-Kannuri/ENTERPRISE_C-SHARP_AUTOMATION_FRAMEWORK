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
    public class AribaSAPHomePage : BasePage
    {
        public Link MyToDoLink { get; private set; }

        public AribaSAPHomePage(IWebDriver driver)
            : base(driver)
        {
            MyToDoLink = new Link(Driver, By.Id("_tilmed"));
        }
    }
}
