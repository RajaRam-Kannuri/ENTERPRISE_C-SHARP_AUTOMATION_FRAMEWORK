using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public abstract class PLIBasePage : BasePage
    {
        public Button SUFSLogo { get; private set; }
        public Dropdown LanguageDropdown { get; private set; }
        public Text Username { get; private set; }
        public Tab HomeTab { get; private set; }
        public Tab MyInformationTab { get; private set; }
        public Tab ApplicationStatusTab { get; private set; }
        public Tab PrintAndSendDocumentsTab { get; private set; }
        public Link SignOut { get; private set; }
		public HiddenButton OnlineChatButton { get; private set; }

		public PLIBasePage(IWebDriver driver)
            : base(driver)
        {
            SUFSLogo = new Button(Driver, By.Id("IBHeader"));
            LanguageDropdown = new Dropdown(Driver, By.Id("DdlLanguage"));
            Username = new Text(Driver, By.Id("LblUsername"));
            HomeTab = new Tab(Driver, By.Id("TCMainTab_T0T"));
            MyInformationTab = new Tab(Driver, By.Id("TCMainTab_T1T"));
            ApplicationStatusTab = new Tab(Driver, By.Id("TCMainTab_AT2T"));
            PrintAndSendDocumentsTab = new Tab(Driver, By.Id("TCMainTab_T3"));
            SignOut = new Link(Driver, By.Id("LBSignOut"));
			OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
		}
	}
}
