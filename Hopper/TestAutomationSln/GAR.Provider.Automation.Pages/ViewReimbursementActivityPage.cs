using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.Provider.Automation.Pages
{
    public class ViewReimbursementActivityPage : ReimbursementRequestPage
    {
        //public Dropdown ReimbursementActivityYear { get; private set; }

        public WebElement InProcessTab { get; private set; }

        public WebElement PendingPaymentTab { get; private set; }

        public WebElement PaidTab { get; private set; }

        public WebElement DeclinedTab { get; private set; }

        public EditField InProcessSearchWithinResults { get; private set; }

        public EditField PendingPaymentSearchWithinResults { get; private set; }

        public EditField DeclinedSearchWithinResults { get; private set; }

        public ReimbursementTable InProcessTable { get; private set; }

        public ReimbursementTable PendingPaymentTable { get; private set; }

        public ReimbursementTable DeclinedTable { get; private set; }

        public ReimbursementDetailsModalProvider ReimbursementDetailsItemStatus { get; private set; }

        public ViewReimbursementActivityPage(IWebDriver driver)
            : base(driver)
        {
            //ReimbursementActivityYear = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlOrganizationYear\"]"));
            InProcessTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T0T\"]"));
            PendingPaymentTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T1T\"]"));
            PaidTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T2T\"]"));
            DeclinedTab = new WebElement(Driver, By.CssSelector("td[id$=\"claimsTabPage_T3T\"]"));
            InProcessSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C0']/div/div[1]/div[2]/label/input"));
            PendingPaymentSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C1']/div/div[1]/div[2]/label/input"));
            DeclinedSearchWithinResults = new EditField(Driver, By.XPath("//*[@id='RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C3']/div/div[1]/div[2]/label/input"));
            InProcessTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C0 > div > table"));
            PendingPaymentTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C1 > div > table"));
            DeclinedTable = new ReimbursementTable(Driver, By.CssSelector("#RPMainPanel_controls_providerlogin_claimactivity_ascx446_claimsTabPage_C3 > div > table"));
            ReimbursementDetailsItemStatus = new ReimbursementDetailsModalProvider(Driver, By.XPath("//*[@id='divDetailInfoReimbursementItems']/fieldset"));
        }
    }
}
