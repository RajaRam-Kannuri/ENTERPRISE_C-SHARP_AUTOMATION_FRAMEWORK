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
    public class MyScholarShopPage : HomePage
    {
        public Button UpdateAddressButton { get; private set; }

        public Button SaveAndConfirmButton { get; private set; }

        public Button CancelButton { get; private set; }

        public EditField MailingAddressTextBox1 { get; private set; }

        public EditField MailingAddressTextBox2 { get; private set; }

        public Dropdown MailingCityDropdown { get; private set; }

        public Dropdown MailingStateDropdown { get; private set; }

        public Dropdown MailingCountyDropdown { get; private set; }

        public EditField MailingZipCodeTextBox { get; private set; }

        public Dropdown SelectAStudentDropdown { get; private set; }

        public Text StudentEligibilityStatusText { get; private set; }

        public EnterMyScholarShopButton EnterMyScholarShopButton { get; private set; }

        public Text AvailableBalanceAmount { get; private set; }

        public Link SkipMyScholarShopVideo { get; private set; }

        public Button ModalYESButton { get; private set; }

        public Button ModalNOButton { get; private set; }


        public MyScholarShopPage(IWebDriver driver)
            : base(driver)
        {
            UpdateAddressButton = new Button(Driver, By.CssSelector("input[id$=\"btnUpdateAddress\"]"));
            SaveAndConfirmButton = new Button(Driver, By.CssSelector("input[id$=\"btnConfirmAddress\"]"));
            CancelButton = new Button(Driver, By.CssSelector("input[id$=\"btnCancelUpdateAddress\"]"));
            MailingAddressTextBox1 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress1Value\"]"));
            MailingAddressTextBox2 = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingAddress2Value\"]"));
            MailingCityDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCity\"]"));
            MailingStateDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingState\"]"));
            MailingCountyDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlMailingCounty\"]"));
            MailingZipCodeTextBox = new EditField(Driver, By.CssSelector("input[id$=\"tbMailingZip\"]"));
            SelectAStudentDropdown = new Dropdown(Driver, By.CssSelector("select[id$=\"ddlStudent\"]"));
            StudentEligibilityStatusText = new Text(Driver, By.CssSelector("span[id$=\"lblStudentClaimEligibilityStatus\"]"));
            EnterMyScholarShopButton = new EnterMyScholarShopButton(Driver, By.CssSelector("input[id$=\"btnGoToMyScholarShop\"]"));
            AvailableBalanceAmount = new Text(Driver, By.CssSelector("span[id$=\"lblTotalAvailableBalance\"]"));
            SkipMyScholarShopVideo = new Link(Driver, By.CssSelector("#mssTutorialDialog > a"));
            ModalYESButton = new Button(Driver, By.XPath("//button[text() = 'Yes']"));
            ModalNOButton = new Button(Driver, By.XPath("//button[text() = 'No']"));
        }
    }
}
