using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public abstract class PowerBIBasePage : BasePage
    {
        public Button PowerBIHomeButton { get; private set; }
        public Button MenuOptionHome { get; private set; }
        public Button MenuOptionFavorites { get; private set; }
        public Button MenuOptionRecent { get; private set; }
        public Button MenuOptionApps { get; private set; }
        public Button MenuOptionSharedWithMe { get; private set; }
        public Link Resources { get; private set; }
        public Link SignOut { get; private set; }
		public HiddenButton OnlineChatButton { get; private set; }
		public Text SchoolYear { get; private set; }

        public PowerBIBasePage(IWebDriver driver)
            : base(driver)
        {
            PowerBIHomeButton = new Button(Driver, By.CssSelector("#navBar > nav > div.topNavLeft > pbi-logo > button"));
            //MenuOptionHome = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.home.ng-star-inserted.selected > button"));
            //MenuOptionFavorites = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-expander:nth-child(2) > div > nav-pane-button > button"));
            //MenuOptionRecent = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-expander:nth-child(3) > div > nav-pane-button > button"));
            //MenuOptionApps = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.myApps > button"));
            //MenuOptionSharedWithMe = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.sharedWithMe > button"));
        }
    }
}
