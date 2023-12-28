using OpenQA.Selenium;

namespace Interfaces
{
    public class Image
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public Image(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public void Click() => element.Click();

        public void Type(string path)
        {
            element.SendKeys(path);
        }

        public string GetSource()
        {
            return element.GetAttribute("src");
        }
    }
}
