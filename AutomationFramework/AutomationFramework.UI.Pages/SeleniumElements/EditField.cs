using OpenQA.Selenium;

namespace AutomationFramework
{
    public class EditField : BaseElement
    {
        public EditField(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }
    }
}
