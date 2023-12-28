using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class LoggedOutHomePage : BaseLoggedOutPage
    {
        public Text PageTitle { get; private set; }

        public LoggedOutHomePage(IWebDriver driver)
            : base(driver)
        {
            PageTitle = new Text(Driver, By.Id("RPMainPanel_LblPageName"));
        }
    }
}
