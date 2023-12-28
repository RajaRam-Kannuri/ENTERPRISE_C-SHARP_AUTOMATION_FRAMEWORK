using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Tab : BaseElement
    {
        public Tab(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
