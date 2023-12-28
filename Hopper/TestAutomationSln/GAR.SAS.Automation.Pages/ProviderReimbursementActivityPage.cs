using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class ProviderReimbursementActivityPage : HomePage
    {
        public Text NoActivityMessage { get; private set; }

        public Text ProviderName { get; private set; }

        public Text ProviderId { get; private set; }

        public Dropdown SchoolYear { get; private set; }

        public Link InProcessTabTitle { get; private set; }

        public Link PendingPaymentTabTitle { get; private set; }

        public Link PaidTabTitle { get; private set; }

        public Link DeniedTabTitle { get; private set; }

        public Link InProcessTab { get; private set; }

        public Link PendingPaymentTab { get; private set; }

        public Link PaidTab { get; private set; }

        public Link DeclinedTab { get; private set; }

        public Table InProcessReimbursementsTable { get; private set; }

        public Table PendingPaymentReimbursementsTable { get; private set; }

        public Table PaidReimbursementsTable { get; private set; }

        public Table DeniedReimbursementsTable { get; private set; }

        public ProviderReimbursementActivityPage(IWebDriver driver)
            : base(driver)
        {
            NoActivityMessage = new Text(Driver, By.CssSelector("span[id$=\"lblMessage\"]"));
            ProviderName = new Text(Driver, By.CssSelector("span[id*=\"providerclaimactivity\"][id$=\"lblProviderName\"]"));
            ProviderId = new Text(Driver, By.CssSelector("span[id*=\"providerclaimactivity\"][id$=\"lblProviderID\"]"));
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id*=\"providerclaimactivity\"][id$=\"ddlOrganizationYear\"]"));
            InProcessTabTitle = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT0T\"]"));
            PendingPaymentTabTitle = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT1T\"]"));
            PaidTabTitle = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT2T\"]"));
            DeniedTabTitle = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT3T\"]"));
            InProcessTab = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_T0\"]"));
            PendingPaymentTab = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_T1\"]"));
            PaidTab = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_T2\"]"));
            DeclinedTab = new Link(Driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            InProcessReimbursementsTable = new Table(Driver, By.CssSelector("table[id$=\"claimsTabPage_C0\"]"));
            PendingPaymentReimbursementsTable = new Table(Driver, By.CssSelector("table[id$=\"claimsTabPage_C1\"]"));
            PaidReimbursementsTable = new Table(Driver, By.CssSelector("table[id$=\"claimsTabPage_C2\"]"));
            DeniedReimbursementsTable = new Table(Driver, By.CssSelector("table[id$=\"claimsTabPage_C3\"]"));
        }
    }
}
