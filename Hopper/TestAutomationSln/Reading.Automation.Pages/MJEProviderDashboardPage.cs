using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEProviderDashboardPage : MJEBasePage
    {
        public Text JobsInProgressAmount { get; private set; }
        public Text JobsDoneAmount { get; private set; }
        public Text JobsCompleteAmount { get; private set; }
        public Text BioText { get; private set; }
        public Text TotalEarnedAmount { get; private set; }
        public Text AmountPaidToDate { get; private set; }
        public Text FutureAmountToBePaid { get; private set; }
        public Button PostAJobButton { get; private set; }
        public Button MyOrdersTab { get; private set; }
        public Button TasksTab { get; private set; }
        public Button ViewAllOrdersAndTasksLink { get; private set; }
        public Button ViewAllJobsLink { get; private set; }
        public Text EditMyProfileLink { get; private set; }
        public Text ProviderNameText { get; private set; }
        public Text ProviderEmailAddressText { get; private set; }
        public Text ProviderFromText { get; private set; }
        public Text ProviderLanguagesText { get; private set; }
        public Button Avatar { get; private set; }

        public MJEProviderDashboardPage(IWebDriver driver)
            : base(driver)
        {
            JobsInProgressAmount = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-8.col-md-8.col-sm-12.col-xs-12 > div.revenues.box-shadow > ul > li:nth-child(1) > p.currency > span"));
            JobsDoneAmount = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-8.col-md-8.col-sm-12.col-xs-12 > div.revenues.box-shadow > ul > li:nth-child(2) > p.currency.available-text > span"));
            JobsCompleteAmount = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-8.col-md-8.col-sm-12.col-xs-12 > div.revenues.box-shadow > ul > li:nth-child(3) > p.currency.freezable-text > span"));
            BioText = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/ul/li[3]/div/text()"));
            TotalEarnedAmount = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[2]/div[1]/div[3]/p[1]/span[2]/span/text()"));
            AmountPaidToDate = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[2]/div[1]/div[4]/div/div[1]/span[2]/span/text()"));
            FutureAmountToBePaid = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[2]/div[1]/div[4]/div/div[2]/span[2]/span/text()"));
            PostAJobButton = new Button(Driver, By.CssSelector("#content > div > div > div:nth-child(3) > div:nth-child(2) > div > div > div.link-post-job > a > span"));
            MyOrdersTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[1]/div/div/ul/li[1]/a"));
            TasksTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[1]/div/div/ul/li[2]/a"));
            ViewAllOrdersAndTasksLink = new Button(Driver, By.XPath("//*[contains(@href, '/my-list-tasks/')]"));
            ViewAllJobsLink = new Button(Driver, By.XPath("//*[contains(@href, '/my-listing-jobs/')]"));
            EditMyProfileLink = new Text(Driver, By.XPath("//*[contains(@href, '/profile/')]"));
            ProviderNameText = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-4.col-md-4.col-sm-12.col-xs-12.block-items-detail > div > h4"));
            ProviderEmailAddressText = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-4.col-md-4.col-sm-12.col-xs-12.block-items-detail > div > div.user-email > p"));
            ProviderFromText = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-4.col-md-4.col-sm-12.col-xs-12.block-items-detail > div > ul > li.location.clearfix > div.pull-right"));
            ProviderLanguagesText = new Text(Driver, By.CssSelector("#content > div > div > div:nth-child(2) > div.col-lg-4.col-md-4.col-sm-12.col-xs-12.block-items-detail > div > ul > li.language.clearfix > div.pull-right"));
            Avatar = new Button(Driver, By.XPath("/html/body/div[1]/div/div/div/div[2]/div[1]/div/div[1]/img"));
        }
    }
}
