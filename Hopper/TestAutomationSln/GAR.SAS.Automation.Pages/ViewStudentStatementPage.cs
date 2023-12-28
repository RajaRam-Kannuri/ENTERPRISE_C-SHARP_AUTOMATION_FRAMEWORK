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
            StudentName = new Text(Driver, By.CssSelector(""));
            StudentId = new Text(Driver, By.CssSelector("span[id*=\"viewstudentstatement\"][id$=\"lblStudentID\"]"));
            TotalFundsAwarded = new Text(Driver, By.CssSelector(""));
            TotalFundsActivity = new Text(Driver, By.CssSelector(""));
            TotalFundsAvailableForReimbursement = new Text(Driver, By.CssSelector(""));
            ActivitySchoolYear = new Dropdown(Driver, By.CssSelector("select[id*='viewstudentstatement'][id$='ddlOrganizationYear']"));
            InProcessTabTitle = new Text(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT0T\"]"));
            PendingPaymentTabTitle = new Text(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT1T\"]"));
            PaidTabTitle = new Text(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT2T\"]"));
            DeniedTabTitle = new Text(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT3T\"]"));
            PreAuthorizationRequestTabTitle = new Text(Driver, By.CssSelector("td[id$=\"claimsTabPage_AT4T\"]"));
            InProcessTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T0\"]"));
            PendingPaymentTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T1\"]"));
            PaidTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T2\"]"));
            DeniedTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            DeclinedTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T3\"]"));
            PreAuthorizationRequestTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T4\"]")); ;
            AdjustmentstTab = new Tab(Driver, By.CssSelector("td[id$=\"claimsTabPage_T5\"]")); ;
            MyScholarShopLink = new Link(Driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(2)"));
        }
    }
}
