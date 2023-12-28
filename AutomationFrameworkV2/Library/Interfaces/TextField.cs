using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Interfaces
{
    public class TextField
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public TextField(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public void Clear() => element.Clear();

        public void Click() => element.Click();

        public string GetText()
        {
            return element.Text;
        }

        public object Type(string keys)
        {
            element.SendKeys(keys);
            return this;
        }

        public string GetFromCSSAttribute(string CSSAttribute)
        {
            return element.GetCssValue(CSSAttribute);
        }

        public string GetFromHTMLAttribute(string HTMLAttribute)
        {
            return element.GetAttribute(HTMLAttribute);
        }

    }
}
