using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEMyProfilePage : MJEBasePage
    {
        public EditField BioTextBox { get; private set; }
        public Text ProviderNameText { get; private set; }
        public Text ProviderEmailAddressText { get; private set; }
        public Text ProviderFromText { get; private set; }
        public Text ProviderLanguagesText { get; private set; }
        public Button Avatar { get; private set; }
        public Text RevenuesLink { get; private set; }
        public Text OrderStatisticsLink { get; private set; }
        public Text MyTasksLink { get; private set; }
        public Text MyJobsLink { get; private set; }

        public MJEMyProfilePage(IWebDriver driver)
            : base(driver)
        {
            BioTextBox = new EditField(Driver, By.Id("post_content"));
            ProviderNameText = new Text(Driver, By.CssSelector("#display_name > div"));
            ProviderEmailAddressText = new Text(Driver, By.CssSelector("#content > div > div.row.profile > div.col-lg-4.col-md-4.col-sm-12.col-sx-12.block-items-detail.profile > div.personal-profile.box-shadow > div > h4 > div.user-email > p"));
            ProviderFromText = new Text(Driver, By.CssSelector("#content > div > div.row.profile > div.col-lg-4.col-md-4.col-sm-12.col-sx-12.block-items-detail.profile > div.personal-profile.box-shadow > div > ul > li.location.clearfix > div"));
            ProviderLanguagesText = new Text(Driver, By.CssSelector("#content > div > div.row.profile > div.col-lg-4.col-md-4.col-sm-12.col-sx-12.block-items-detail.profile > div.personal-profile.box-shadow > div > ul > li.language.clearfix > div"));
            Avatar = new Button(Driver, By.CssSelector("#content > div > div.row.profile > div.col-lg-4.col-md-4.col-sm-12.col-sx-12.block-items-detail.profile > div.personal-profile.box-shadow > div > div.float-center.profile-avatar > div > a > img"));
            RevenuesLink = new Text(Driver, By.XPath("//*[contains(@href, '/revenues/')]"));
            OrderStatisticsLink = new Text(Driver, By.XPath("//*[contains(@href, '/dashboard/#analytics')]"));
            MyTasksLink = new Text(Driver, By.XPath("//*[contains(@href, '/my-list-tasks/')]"));
            MyJobsLink = new Text(Driver, By.XPath("//*[contains(@href, '/my-listing-jobs/')]"));
        }
    }
}
