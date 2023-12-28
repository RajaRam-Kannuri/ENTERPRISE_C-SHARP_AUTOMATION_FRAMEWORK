using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.PLI.Automation.Pages
{
    public class HomePage : BasePage
    {
        public Link SignOut { get; private set; }

        public PLIEmailAddress UserEmailAddress { get; private set; }

        public Tab HomeTab { get; private set; }

        public Tab MyInformationTab { get; private set; }

        public Tab ScholarshipStatusTab { get; private set; }

        public Tab ApplicationStatusTab { get; private set; }

        public Tab PrintAndSendDocumentsTab { get; private set; }

        public Tab AccountActivityTab { get; private set; }

        public Tab MyScholarShopTab { get; private set; }

        public Tab AccountTab { get; private set; }

        public Tab FAQTab { get; private set; }

        public Tab ContactUsTab { get; private set; }

        public HiddenButton OnlineChatButton { get; private set; }

        public HomePage(IWebDriver driver)
            : base(driver)
        {
            SignOut = new Link(Driver, By.Id("LBSignOut"));
            UserEmailAddress = new PLIEmailAddress(Driver, By.Id("LblUsername"));
            HomeTab = new Tab(Driver, By.LinkText("Home"));
            MyInformationTab = new Tab(Driver, By.LinkText("My Information"));
            ScholarshipStatusTab = new Tab(Driver, By.LinkText("Scholarship Status"));
            ApplicationStatusTab = new Tab(Driver, By.LinkText("Application Status"));
            PrintAndSendDocumentsTab = new Tab(Driver, By.LinkText("Print and Send Documents"));
            AccountActivityTab = new Tab(Driver, By.LinkText("Account Activity"));
            MyScholarShopTab = new Tab(Driver, By.LinkText("MyScholarShop"));
            AccountTab = new Tab(Driver, By.LinkText("Account"));
            FAQTab = new Tab(Driver, By.LinkText("FAQ"));
            ContactUsTab = new Tab(Driver, By.LinkText("Contact Us"));
            OnlineChatButton = new HiddenButton(Driver, By.CssSelector("div[id$=\"designstudio-button\"]"));
        }
    }
}
