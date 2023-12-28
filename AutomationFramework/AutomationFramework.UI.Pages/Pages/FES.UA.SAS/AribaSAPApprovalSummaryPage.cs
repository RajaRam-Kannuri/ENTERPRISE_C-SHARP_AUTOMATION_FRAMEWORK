using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class AribaSAPApprovalSummaryPage : BasePage
    {
        public Button ApproveButton { get; private set; }
        public Button DenyButton { get; private set; }

        public AribaSAPApprovalSummaryPage(IWebDriver driver)
            : base(driver)
        {
            ApproveButton = new Button(driver, By.Id("_z7oeq"));
            DenyButton = new Button(driver, By.Id("_rof2d"));
        }
    }
}
