using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEMyPurchasesPage : MJEBasePage
    {
        public Link BackToDashboardLink { get; private set; }
        //public Table MyPurchasesList { get; private set; }

        public MJEMyPurchasesPage(IWebDriver driver)
            : base(driver)
        {
            BackToDashboardLink = new Link(Driver, By.Id("post_content"));
            //MyPurchasesList = new Table(Driver, By.CssSelector(""));
        }
    }
}
