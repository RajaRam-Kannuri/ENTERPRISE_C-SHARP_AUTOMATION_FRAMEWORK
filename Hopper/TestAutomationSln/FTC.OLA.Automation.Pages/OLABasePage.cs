using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public abstract class OLABasePage : BasePage
    {
        public Link SUFSLogo { get; private set; }
        public OLAWorkflowDropdown LanguageDropdown { get; private set; }
        public Link Settings { get; private set; }
        public Link MyAccount { get; private set; }
        public Link FAQ { get; private set; }
        public Link ContactUs { get; private set; }
        public Link Resources { get; private set; }
        public Link SignOut { get; private set; }
		public HiddenButton OnlineChatButton { get; private set; }
		public Text SchoolYear { get; private set; }

		public OLABasePage(IWebDriver driver)
            : base(driver)
        {
            SUFSLogo = new Link(Driver, By.XPath("//*[@id='header']/nav/div/a[2]/img"));
            LanguageDropdown = new OLAWorkflowDropdown(Driver, By.Id("language-dropdown-activator"));
            Settings = new Link(Driver, By.Id("account-menu-icon"));
            MyAccount = new Link(Driver, By.Id("account-menu-header"));
            FAQ = new Link(Driver, By.Id("account-menu-faq-link"));
            ContactUs = new Link(Driver, By.Id("account-menu-contact-us-link"));
            Resources = new Link(Driver, By.Id("account-menu-contact-us-link"));
            SignOut = new Link(Driver, By.Id("account-menu-signout-link"));
			OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
		}
	}
}
