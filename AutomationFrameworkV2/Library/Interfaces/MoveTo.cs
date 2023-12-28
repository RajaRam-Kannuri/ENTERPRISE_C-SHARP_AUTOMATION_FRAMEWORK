using System;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ServiceStack;

namespace Interfaces
{
    public static class MoveTo
    {
       
        public static void Element(IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }

        public static void TopOfPage(IWebDriver driver)
        {
            var actions = new Actions(driver);
            actions.SendKeys(Keys.PageUp).Build().Perform();
            actions.Release();
            actions.SendKeys(Keys.PageUp).Build().Perform();
            actions.Release();
            Thread.Sleep(1000);
        }

        public static void BottomOfPage(IWebDriver driver)
        {
            var actions = new Actions(driver);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            actions.Release();
            actions.SendKeys(Keys.PageDown).Build().Perform();
            actions.Release();
            Thread.Sleep(1000);
        }
        public static void Signature(IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            actions.MoveToElement(element)
                .ClickAndHold()
                .MoveByOffset(50, 50)
                .MoveByOffset(80, -50)
                .MoveByOffset(100, 50)
                .Release()
                .Build().Perform();
        }



    }
}
