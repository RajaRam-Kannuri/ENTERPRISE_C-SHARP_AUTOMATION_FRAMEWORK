using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.UA.SAS
{
    public class CommodityManagerPage : HomePage
    {
        public EditField CommodityCode { get; private set; }

        public EditField CommodityDescription { get; private set; }

        public Button Search { get; private set; }

        public Table CommodityCodeTable { get; private set; }

        public Checkbox CommodityCodeEnabled { get; private set; }

        public Dropdown CommodityReimbursementCategory { get; private set; }

        public Dropdown CommodityReimbursementType { get; private set; }

        public Dropdown CommodityReimbursementDetail { get; private set; }
        
        public Button Save { get; private set; }

        public Button Cancel { get; private set; }

        public CommodityManagerPage(IWebDriver driver)
            : base(driver)
        {
            CommodityCode = new EditField(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_tbxCommodityCode']"));
            CommodityDescription = new EditField(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_tbxCommodityDescription']"));
            Search = new Button(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnSubmitSearch']"));
            CommodityCodeTable = new Table(driver, By.XPath("//*[@id='result-table']"));
            CommodityCodeEnabled = new Checkbox(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_chkCommodityEnabled']"));
            CommodityReimbursementCategory = new Dropdown(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemCategory']"));
            CommodityReimbursementType = new Dropdown(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemType']"));
            CommodityReimbursementDetail = new Dropdown(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_ddlItemDetail']"));
            Save = new Button(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnSave']"));
            Cancel = new Button(driver, By.XPath("//*[@id='controls_administration_commoditymanager_ascx1119_btnCancel']"));
        }
    }
}
