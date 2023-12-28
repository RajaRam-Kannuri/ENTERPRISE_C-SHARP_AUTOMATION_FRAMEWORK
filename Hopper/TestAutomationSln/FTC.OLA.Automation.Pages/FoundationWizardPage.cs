using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public abstract class FoundationWizardPage : BasePage
    {
        public HiddenButton OnlineChatButton { get; private set; }
        public Button HomeTab { get; private set; }
        public Button MyInformationTab { get; private set; }
        public Button ApplicationStatusTab { get; private set; }
        public Button PrintAndSendDocumentsTab { get; private set; }
        public Link SignOut { get; private set; }
        public Text Username { get; private set; }

        public FoundationWizardPage(IWebDriver driver)
            : base(driver)
        {
            OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
            HomeTab = new Button(Driver, By.Id("TCMainTab_T0"));
            MyInformationTab = new Button(Driver, By.Id("TCMainTab_T1"));
            ApplicationStatusTab = new Button(Driver, By.Id("TCMainTab_T2"));
            PrintAndSendDocumentsTab = new Button(Driver, By.Id("TCMainTab_T3"));
            SignOut = new Link(Driver, By.Id("LBSignOut"));
            Username = new Text(Driver, By.Id("LBSignOut"));
        }
    }
}
