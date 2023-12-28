using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class ViewStudentStatementPage : BasePage
    {
        public Text StudentName { get; private set; }

        public Text StudentId { get; private set; }

        public Text TotalFundsAwarded { get; private set; }

        public Text TotalFundsActivity { get; private set; }

        public Text TotalFundsAvailableForReimbursement { get; private set; }

        public Dropdown ActivitySchoolYear { get; private set; }

        public Text InProcessTabTitle { get; private set; }

        public Text PendingPaymentTabTitle { get; private set; }

        public Text PaidTabTitle { get; private set; }

        public Text DeniedTabTitle { get; private set; }

        public Text PreAuthorizationRequestTabTitle { get; private set; }

        public Tab InProcessTab { get; private set; }

        public Tab PendingPaymentTab { get; private set; }

        public Tab PaidTab { get; private set; }

        public Tab DeniedTab { get; private set; }

        public Tab DeclinedTab { get; private set; }

        public Tab PreAuthorizationRequestTab { get; private set; }

        public Tab AdjustmentstTab { get; private set; }
        
        public Link MyScholarShopLink { get; private set; }


        public ViewStudentStatementPage(IWebDriver driver)
            : base(driver)
        {
            StudentName = new Text(driver, By.CssSelector(""));
            StudentId = new Text(driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblStudentID\"]"));
            TotalFundsAwarded = new Text(driver, By.CssSelector(""));
            TotalFundsActivity = new Text(driver, By.CssSelector(""));
            TotalFundsAvailableForReimbursement = new Text(driver, By.CssSelector(""));
            ActivitySchoolYear = new Dropdown(driver, By.CssSelector("select[id*='viewstudentstatement'][id$='ddlOrganizationYear']"));
            InProcessTabTitle = new Text(driver, By.CssSelector("td[id$=\"claimsTabPage_AT0T\"]"));
            PendingPaymentTabTitle = new Text(driver, By.CssSelector("td[id$=\"claimsTabPage_AT1T\"]"));
            PaidTabTitle = new Text(driver, By.CssSelector("td[id$=\"claimsTabPage_AT2T\"]"));
            DeniedTabTitle = new Text(driver, By.CssSelector("td[id$=\"claimsTabPage_AT3T\"]"));
            PreAuthorizationRequestTabTitle = new Text(driver, By.CssSelector("td[id$=\"claimsTabPage_AT4T\"]"));
            InProcessTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T0\"]"));
            PendingPaymentTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T1\"]"));
            PaidTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T2\"]"));
            DeniedTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            DeclinedTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            PreAuthorizationRequestTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T4\"]")); ;
            AdjustmentstTab = new Tab(driver, By.CssSelector("td[id$=\"claimsTabPage_T5\"]")); ;
            MyScholarShopLink = new Link(driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(2)"));
        }
    }
}