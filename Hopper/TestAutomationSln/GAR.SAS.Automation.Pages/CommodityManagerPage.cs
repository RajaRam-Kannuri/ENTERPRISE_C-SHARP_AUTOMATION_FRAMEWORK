using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace GAR.SAS.Automation.Pages
{
    public class CommodityManagerPage : HomePage
    {
        public EditField CommodityCode { get; private set; }

        public EditField CommodityDescription { get; private set; }

        public Button Search { get; private set; }

        public CommodityCodeTable CommodityCodeTable { get; private set; }

        public Checkbox CommodityCodeEnabled { get; private set; }

        public Dropdown CommodityReimbursementCategory { get; private set; }

        public Dropdown CommodityReimbursementType { get; private set; }

        public Dropdown CommodityReimbursementDetail { get; private set; }
        
        public Button Save { get; private set; }

        public Button Cancel { get; private set; }

        public CommodityManagerPage(IWebDriver driver)
            : base(driver)
        {
            CommodityCode = new EditField(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_tbxCommodityCode']"));
            CommodityDescription = new EditField(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_tbxCommodityDescription']"));
            Search = new Button(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnSubmitSearch']"));
            CommodityCodeTable = new CommodityCodeTable(Driver, By.XPath("//*[@id='result-table']"));
            CommodityCodeEnabled = new Checkbox(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_chkCommodityEnabled']"));
            CommodityReimbursementCategory = new Dropdown(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemCategory']"));
            CommodityReimbursementType = new Dropdown(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemType']"));
            CommodityReimbursementDetail = new Dropdown(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemDetail']"));
            Save = new Button(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnSave']"));
            Cancel = new Button(Driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnCancel']"));
        }
    }
}
