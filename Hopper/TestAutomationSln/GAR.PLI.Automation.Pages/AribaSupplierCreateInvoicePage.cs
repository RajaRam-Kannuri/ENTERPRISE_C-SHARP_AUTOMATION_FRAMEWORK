using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace GAR.PLI.Automation.Pages
{
    public class AribaSupplierCreateInvoicePage : BasePage
    {
        public EditField InvoiceNumberTextbox { get; private set; }
        public Button NextButton { get; private set; }
        public Button SubmitButton { get; private set; }

        public AribaSupplierCreateInvoicePage(IWebDriver driver)
            : base(driver)
        {
            InvoiceNumberTextbox = new EditField(Driver, By.Id("_kipfyb"));
            NextButton = new Button(Driver, By.Id("_t1zf"));
            SubmitButton = new Button(Driver, By.Id("_uz6b3"));
        }
    }
}
