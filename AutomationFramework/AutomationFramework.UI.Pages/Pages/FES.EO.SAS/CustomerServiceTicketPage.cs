using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class CustomerServiceTicketPage : BasePage
    {
        public Text ApplicationID { get; private set; }

        public Text Type { get; private set; }

        public Checkbox FollowUp { get; private set; }

        public EditField Comments { get; private set; }

        public Button SaveButton { get; private set; }

        public Text Status { get; private set; }

        public Table HistoryTable { get; private set; }

        public CustomerServiceTicketPage(IWebDriver driver)
            : base(driver)
        {
            ApplicationID = new Text(driver, By.CssSelector("span[id$=\"lblApplicationID\"]"));
            Type = new Text(driver, By.CssSelector("span[id$=\"lblTicketType\"]"));
            FollowUp = new Checkbox(driver, By.CssSelector("input[id$=\"_chkFollowUp\"]"));
            Comments = new EditField(driver, By.CssSelector("textarea[id$=\"txtComments\"]"));
            SaveButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveNote\"]"));
            Status = new Text(driver, By.CssSelector("[id$=\"\"]"));
            HistoryTable = new Table(driver, By.CssSelector("div[id=\"PanelForScrollBar\"] > table + table"));
        }
    }
}
