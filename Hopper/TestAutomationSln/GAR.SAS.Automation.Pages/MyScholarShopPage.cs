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
    public class MyScholarShopPage : BasePage
    {
        public Link ViewStudentStatementLink { get; private set; }

        public Link MyScholarShopLink { get; private set; }

        public Button GoToMyScholarShopButton { get; private set; }

        public Tab PurchaseOrdersTab { get; private set; }

        public Tab InvoicesTab { get; private set; }

        public MyScholarShopPage(IWebDriver driver)
            : base(driver)
        {
            ViewStudentStatementLink = new Link(Driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(1)"));
            MyScholarShopLink = new Link(Driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(2)"));
            GoToMyScholarShopButton = new Button(Driver, By.CssSelector("span[id$=\"lblGoToMyScholarShop\"]")); ;
            PurchaseOrdersTab = new Tab(Driver, By.CssSelector("td[id$=\"myScholarShopTabPage_T0T\"]")); ;
            InvoicesTab = new Tab(Driver, By.CssSelector("td[id$=\"myScholarShopTabPage_T1T\"]")); ;
        }
    }
}
