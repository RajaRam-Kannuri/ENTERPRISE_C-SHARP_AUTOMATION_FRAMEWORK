using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ProviderReimbursementActivityPage : HomePage
    {
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
            InProcessTabTitle = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_AT0T\"]"));
            PendingPaymentTabTitle = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_AT1T\"]"));
            PaidTabTitle = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_AT2T\"]"));
            DeniedTabTitle = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_AT3T\"]"));
            InProcessTab = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_T0\"]"));
            PendingPaymentTab = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_T1\"]"));
            PaidTab = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_T2\"]"));
            DeclinedTab = new Link(driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            InProcessReimbursementsTable = new Table(driver, By.CssSelector("table[id$=\"claimsTabPage_C0\"]"));
            PendingPaymentReimbursementsTable = new Table(driver, By.CssSelector("table[id$=\"claimsTabPage_C1\"]"));
            PaidReimbursementsTable = new Table(driver, By.CssSelector("table[id$=\"claimsTabPage_C2\"]"));
            DeniedReimbursementsTable = new Table(driver, By.CssSelector("table[id$=\"claimsTabPage_C3\"]"));
        }
    }
}
