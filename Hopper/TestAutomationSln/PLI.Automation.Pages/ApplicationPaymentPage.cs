using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationPaymentPage : HomePage
    {
        public Dropdown SchoolYear { get; private set; }

        public Text ApplicationId { get; private set; }

        public Text ApplicationFee { get; private set; }

        public Text AppealFee { get; private set; }

        public Text YouOwe { get; private set; }

        public Link PaymentLink { get; private set; }

        public ApplicationPaymentPage(IWebDriver driver)
            : base(driver)
        {
            SchoolYear = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlScholarshipApplicationYear\"]"));
            ApplicationId = new Text(Driver, By.CssSelector("span[id$=\"_lblApplicationIDValue\"]"));
            ApplicationFee = new Text(Driver, By.CssSelector("span[id$=\"_lblApplicationFee\"]"));
            AppealFee = new Text(Driver, By.CssSelector("span[id$=\"_lblAppealFee\"]"));
            YouOwe = new Text(Driver, By.CssSelector("span[id$=\"_lblAmountDue\"]"));
            PaymentLink = new Link(Driver, By.CssSelector("a[id$=\"_hlPaymentLink\"]"));
        }
    }
}
