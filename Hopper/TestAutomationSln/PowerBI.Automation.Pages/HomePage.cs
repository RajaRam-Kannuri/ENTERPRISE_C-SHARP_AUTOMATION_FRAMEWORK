using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class HomePage : PowerBIBasePage
    {
        public Link MenuOptionWorkspaces { get; private set; }
        public Link QATeamLink { get; private set; }
        public Link DataTeamLink { get; private set; }
        //      public Button MenuOptionRecent { get; private set; }
        //      public Button MenuOptionApps { get; private set; }
        //      public Button MenuOptionSharedWithMe { get; private set; }
        //      public Link Resources { get; private set; }
        //      public Link SignOut { get; private set; }
        //public HiddenButton OnlineChatButton { get; private set; }
        //public Text SchoolYear { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            MenuOptionWorkspaces = new Link(Driver, By.CssSelector("#leftNavPane > section > nav > button > span"));
            QATeamLink = new Link(Driver, By.CssSelector("#cdk-overlay-0 > nav > nav-pane-workspaces > div.workspaces > virtual-scroll > div.scrollable-content > ul > li > workspace-button > button:nth-child(1) > span"));
            DataTeamLink = new Link(Driver, By.CssSelector("#cdk-overlay-0 > nav > nav-pane-workspaces > div.workspaces > virtual-scroll > div.scrollable-content > ul > li > workspace-button > button:nth-child(1) > span"));
            //MenuOptionHome = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.home.ng-star-inserted.selected > button"));
            //MenuOptionFavorites = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-expander:nth-child(2) > div > nav-pane-button > button"));
            //MenuOptionRecent = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-expander:nth-child(3) > div > nav-pane-button > button"));
            //MenuOptionApps = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.myApps > button"));
            //MenuOptionSharedWithMe = new Button(Driver, By.CssSelector("#leftNavPane > section > nav > nav-pane-button.sharedWithMe > button"));
        }
    }
}
