using java.awt.datatransfer;
using java.awt;
using OpenQA.Selenium;

namespace Interfaces
{
    public class Import
    {
        protected IWebDriver driver;
        protected IWebElement element;

        public Import(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }

        public void SelectFile(string File) => element.SendKeys(File);
    }

    //public void SelectFile(string File)
    //{
    //    new TextField(driver, element).Click(); ;
    //
    //    Thread.Sleep(3000);
    //    System.Environment.SetEnvironmentVariable("java.awt.Headless", "false");
    //
    //    var rb = new Robot();
    //
    //    stringSelection str = new stringSelection(File);
    //    Toolkit.getDefaultToolkit().getSystemClipboard().setContents(str, null);

    //    rb.keyPress(KeyEvent.VK_CONTROL);
    //    Thread.Sleep(500);
    //    rb.keyPress(KeyEvent.VK_V);
    //    Thread.Sleep(500);
    //    rb.keyRelease(KeyEvent.VK_CONTROL);
    //    Thread.Sleep(500);
    //    rb.keyRelease(KeyEvent.VK_V);
    //    Thread.Sleep(500);
    //    rb.keyPress(KeyEvent.VK_ENTER);
    //    Thread.Sleep(500);
    //    rb.keyRelease(KeyEvent.VK_ENTER);
    //    Thread.Sleep(500);
    //}
}
