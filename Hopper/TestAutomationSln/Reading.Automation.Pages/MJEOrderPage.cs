using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEOrderPage : MJEBasePage
    {
        public Link BackToDashboardLink { get; private set; }
        public Text OrderTotalText { get; private set; }
        public Text OrderTitleText { get; private set; }

        public MJEOrderPage(IWebDriver driver)
            : base(driver)
        {
            BackToDashboardLink = new Link(Driver, By.Id("post_content"));
            OrderTotalText = new Text(Driver, By.Id("post_content"));
            OrderTitleText = new Text(Driver, By.Id("post_content"));

            //MyPurchasesList = new Table(Driver, By.CssSelector(""));
        }
    }
}
