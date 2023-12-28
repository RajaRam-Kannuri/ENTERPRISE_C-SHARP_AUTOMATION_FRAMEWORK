using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class PDFViewerPage : BasePage
    {
        public WebElement PDFViewer { get; private set; }

        public PDFViewerPage(IWebDriver driver)
            : base(driver)
        {
            PDFViewer = new WebElement(Driver, By.CssSelector("embed[id=\"plugin\"]"));
        }
    }
}
