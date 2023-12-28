using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public abstract class FTCPLIBasePage : BasePage
    {
        public Dropdown LanguageSelection { get; private set; }

        public Text PageTitle { get; protected set; }

        public FTCPLIBasePage(IWebDriver driver)
            : base(driver)
        {
            LanguageSelection = new Dropdown(Driver, By.Id("DdlLanguage"));
            PageTitle = new Text(Driver, By.Id("RPMainPanel_LblPageName"));
        }
    }
}
