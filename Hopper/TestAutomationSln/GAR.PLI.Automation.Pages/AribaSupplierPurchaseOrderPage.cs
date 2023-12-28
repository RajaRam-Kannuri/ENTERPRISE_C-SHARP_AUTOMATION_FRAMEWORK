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
    public class AribaSupplierPurchaseOrderPage : BasePage
    {
        public Text PurchaseOrderNumber { get; private set; }
        public Text PurchaseOrderAmount { get; private set; }
        public Button CreateOrderConfirmationDropdown { get; private set; }
        public Button CreateInvoiceDropdown { get; private set; }
        public Text ConfirmEntireOrder { get; private set; }
        public Text UpdateLineItems { get; private set; }
        public Text RejectEntireOrder { get; private set; }
        public Text StandardInvoice { get; private set; }

        public AribaSupplierPurchaseOrderPage(IWebDriver driver)
            : base(driver)
        {
            PurchaseOrderNumber = new Text(Driver, By.CssSelector("#_rhlznd > table > tbody > tr:nth-child(2) > td.poHeaderSectionTitleStyle > table > tbody > tr:nth-child(2) > td > span"));
            PurchaseOrderAmount = new Text(Driver, By.CssSelector("#_rhlznd > table > tbody > tr:nth-child(2) > td.poHeaderSectionTitleStyle > table > tbody > tr:nth-child(2) > td > div.po-INSPON-std-money > table > tbody > tr > td:nth-child(3) > div"));
            CreateOrderConfirmationDropdown = new Button (Driver, By.Id("_p88s_c"));
            ConfirmEntireOrder = new Text(Driver, By.Id("_95uf3d"));
            UpdateLineItems = new Text(Driver, By.Id("_omeduc"));
            RejectEntireOrder = new Text(Driver, By.Id("_qkhh4b"));
            CreateInvoiceDropdown = new Button(Driver, By.Id("_1fsqfb"));
            StandardInvoice = new Text(Driver, By.Id("_iusucc"));
        }
    }
}
