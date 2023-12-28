using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class AribaSAPToDoPage : BasePage
    {
        public Table ToDoTable { get; private set; }

        public AribaSAPToDoPage(IWebDriver driver)
            : base(driver)
        {
            ToDoTable = new Table(driver, By.Id("_mjp8tb"));
        }
    }
}
