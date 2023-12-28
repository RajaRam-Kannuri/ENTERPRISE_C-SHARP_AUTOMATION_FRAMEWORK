using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class AribaSAPHomePage : BasePage
    {
        public Link MyToDoLink { get; private set; }

        public AribaSAPHomePage(IWebDriver driver)
            : base(driver)
        {
            MyToDoLink = new Link(driver, By.Id("_tilmed"));
        }
    }
}
