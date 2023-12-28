using OpenQA.Selenium;

namespace Interfaces
{
    public class IsElement
    {

        public static bool Present(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }

        }

    }
}
