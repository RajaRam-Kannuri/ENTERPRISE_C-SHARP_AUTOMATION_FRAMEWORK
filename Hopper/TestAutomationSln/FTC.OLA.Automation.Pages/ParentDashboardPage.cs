using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentDashboardPage :
        BasePage
    {
        public Text ParentNameText { get; private set; }
        public Text ParentPhoneNumberText { get; private set; }
        public Text ParentEmailAddressText { get; private set; }
        public Text FundedStudentsText { get; private set; }
        public Text MarketingMessageText { get; private set; }
        public Button ParentProfileButton { get; private set; }
        public Button ResumeApplicationButton { get; private set; }
        public Button ReadingApplyNowButton { get; private set; }
        public Button MicroJobEngineButton { get; private set; }
        public Button PurchasesAndReimbursementsButton { get; private set; }
        public Dropdown MicroJobEngineDropdown { get; private set; }

        public ParentDashboardPage(IWebDriver driver)
            : base(driver)
        {
            ParentNameText = new Text(Driver, By.Id(""));
            ParentPhoneNumberText = new Text(Driver, By.Id(""));
            ParentEmailAddressText = new Text(Driver, By.Id(""));
            FundedStudentsText = new Text(Driver, By.Id(""));
            MarketingMessageText = new Text(Driver, By.Id(""));
            ParentProfileButton = new Button(Driver, By.Id(""));
            ResumeApplicationButton = new Button(Driver, By.Id(""));
            ReadingApplyNowButton = new Button(Driver, By.Id(""));
            MicroJobEngineButton = new Button(Driver, By.Id(""));
            PurchasesAndReimbursementsButton = new Button(Driver, By.Id(""));
            MicroJobEngineDropdown = new Dropdown(Driver, By.Id(""));
        }
    }
}
