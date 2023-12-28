using OpenQA.Selenium;

namespace AutomationFramework
{
    public class Image : BaseElement
    {
        public Image(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
