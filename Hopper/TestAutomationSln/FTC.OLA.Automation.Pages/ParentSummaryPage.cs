using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class ParentSummaryPage : ApplicationWizardPage
    {
        public Button StartPrimaryParent { get; private set; }
        public Link UpdatePrimaryParent { get; private set; }
        public Link UpdateSecondaryParent { get; private set; }
        public Link DeleteSecondaryParent { get; private set; }
        public Button ConfirmDeleteButton { get; private set; }
        public Button CancelDeleteButton { get; private set; }
        public Button AddSecondaryParent { get; private set; }
        public Button StudentButton { get; private set; }
        public Button CloseTourPopup { get; private set; }
        public Link ReviewPrimaryParent { get; private set; }
        public Link ReviewSecondaryParent { get; private set; }
        public Text ProvideASecondaryParentMessage { get; private set; }
        public Text SecondaryParentContactInfoIsMissingMessage { get; private set; }
        public Text SecondaryParentEmploymentInfoIsMissingMessage { get; private set; }
        public Text PrimaryParentAddressInfoIsMissingMessage { get; private set; }
        public Text PrimaryParentEmploymentInfoIsMissingMessage { get; private set; }
        public Text PrimaryParentMaritalStatusInfoIsMissingMessage { get; private set; }

        public ParentSummaryPage(IWebDriver driver)
            : base(driver)
        {
            StartPrimaryParent = new Button(Driver, By.XPath("//*[contains(@href, 'primary/parent-name')]"));
            UpdatePrimaryParent = new Link(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > parent-summary-container > parent-summary > div > div.row.no-margin-bottom > div > div.parent-section.row > div.col.s12.m2.buttons > div > div.col.s2.m10 > div.hide-on-small-only > a:nth-child(1)"));
            UpdateSecondaryParent = new Link(Driver, By.XPath("/html/body/app-root/div[1]/parent-summary/div[1]/div/div/div/div[2]/div/div/div[4]/div[3]/div/div[2]"));
            DeleteSecondaryParent = new Link(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > parent-summary-container > parent-summary > div > div > div > div:nth-child(5) > div.col.s12.m2.buttons > div > div.col.s2.m2 > a"));
            AddSecondaryParent = new Button(Driver, By.XPath("//*[contains(@href, 'secondary/parent-name')]"));
            StudentButton = new Button(Driver, By.XPath("//span[text() = 'Student']"));
            CloseTourPopup = new Button(Driver, By.XPath("//button[text() = 'Close']"));
            ReviewPrimaryParent = new Link(Driver, By.XPath("//*[contains(@href, 'primary/primary-parent-review')]"));
            ReviewSecondaryParent = new Link(Driver, By.XPath("//*[contains(@href, 'secondary/parent-name')]"));
            ConfirmDeleteButton = new Button(Driver, By.XPath("//a[text() = 'Delete']"));
            CancelDeleteButton = new Button(Driver, By.XPath("//a[text() = 'Cancel']"));
            ProvideASecondaryParentMessage = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > parent-summary-data-provider-container > parent-summary > div > div.row.no-margin-bottom.section-error-padding > div > section-validation-errors > div > div > ul > li > a"));
            SecondaryParentContactInfoIsMissingMessage = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/parent-contact-info')]"));
            SecondaryParentEmploymentInfoIsMissingMessage = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/survey-parent-employment-info')]"));
            PrimaryParentAddressInfoIsMissingMessage = new Text(Driver, By.XPath("//*[contains(@href, 'primary/parent-address')]"));
            PrimaryParentEmploymentInfoIsMissingMessage = new Text(Driver, By.XPath("//*[contains(@href, 'primary/survey-parent-employment-info')]"));
            PrimaryParentMaritalStatusInfoIsMissingMessage = new Text(Driver, By.XPath("//*[contains(@href, 'primary/marital-status')]"));
        }
    }
}
