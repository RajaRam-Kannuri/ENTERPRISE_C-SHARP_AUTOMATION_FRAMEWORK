using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class HouseholdMembersPage : ApplicationWizardPage
    {
        public Button AddNonScholarshipMembers { get; private set; }
        public OLAOtherMembersTable NonScholarshipMembersTable { get; private set; }

        public HouseholdMembersPage(IWebDriver driver)
            : base(driver)
        {
            AddNonScholarshipMembers = new Button(Driver, By.CssSelector("body > app-root > div:nth-child(2) > standard-navigation-screen > div > div > div > div > div.card-content > scholarship-household-data-provider-container > scholarship-household > div > div.center-align > p > a"));
            NonScholarshipMembersTable = new OLAOtherMembersTable(Driver, By.XPath("//*[contains(@class, 'other-member-section')]"));
        }
    }
}
