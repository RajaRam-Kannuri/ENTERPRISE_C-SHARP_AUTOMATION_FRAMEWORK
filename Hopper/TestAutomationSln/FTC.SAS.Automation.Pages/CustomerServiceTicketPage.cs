using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SAS.Automation.Pages
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
            ApplicationID = new Text(Driver, By.CssSelector("span[id$=\"lblApplicationID\"]"));
            Type = new Text(Driver, By.CssSelector("span[id$=\"lblTicketType\"]"));
            FollowUp = new Checkbox(Driver, By.CssSelector("input[id$=\"_chkFollowUp\"]"));
            Comments = new EditField(Driver, By.CssSelector("textarea[id$=\"txtComments\"]"));
            SaveButton = new Button(Driver, By.CssSelector("input[id$=\"btnSaveNote\"]"));
            Status = new Text(Driver, By.CssSelector("[id$=\"\"]"));
            HistoryTable = new Table(Driver, By.CssSelector("div[id=\"PanelForScrollBar\"] > table + table"));
        }
    }
}
