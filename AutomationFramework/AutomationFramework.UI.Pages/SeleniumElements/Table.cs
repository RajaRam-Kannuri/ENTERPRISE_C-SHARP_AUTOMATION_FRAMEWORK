using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Table : BaseElement
    {
        public Table(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}