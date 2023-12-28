using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
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
            ViewStudentStatementLink = new Link(driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(1)"));
            MyScholarShopLink = new Link(driver, By.CssSelector("#PanelForScrollBar > table > tbody > tr > td > span > a:nth-child(2)"));
            GoToMyScholarShopButton = new Button(driver, By.CssSelector("span[id$=\"lblGoToMyScholarShop\"]")); ;
            PurchaseOrdersTab = new Tab(driver, By.CssSelector("td[id$=\"myScholarShopTabPage_T0T\"]")); ;
            InvoicesTab = new Tab(driver, By.CssSelector("td[id$=\"myScholarShopTabPage_T1T\"]")); ;
        }
    }
}