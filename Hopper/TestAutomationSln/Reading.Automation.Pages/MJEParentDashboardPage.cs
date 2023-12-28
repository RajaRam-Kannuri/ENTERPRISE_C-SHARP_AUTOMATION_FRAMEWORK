using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class MJEParentDashboardPage : MJEBasePage
    {
        public Text SUFSPayAvailableAmount { get; private set; }
        public Text SUFSPayPendingAmount { get; private set; }
        public Button ViewAllPurchasesLink { get; private set; }
        public Button AfterSchoolProgramTab { get; private set; }
        public Button PartTimeTutoringTab { get; private set; }
        public Button SummerProgramTab { get; private set; }
        public Button LocationsTab { get; private set; }
        public Text ParentNameText { get; private set; }
        public Text ParentEmailAddressText { get; private set; }
        public Text ParentFromText { get; private set; }
        public Text ParentLanguagesText { get; private set; }
        public Button Avatar { get; private set; }

        public MJEParentDashboardPage(IWebDriver driver)
            : base(driver)
        {
            SUFSPayAvailableAmount = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[2]/div[1]/ul/li[1]/p[2]/span/text()"));
            SUFSPayPendingAmount = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[2]/div[1]/ul/li[2]/p[2]/span/text()"));
            ViewAllPurchasesLink = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[2]/div/div/div[2]/a"));
            ParentNameText = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/h4"));
            ParentEmailAddressText = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/div[2]/p"));
            ParentFromText = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/ul/li[1]/div[1]/span"));
            ParentLanguagesText = new Text(Driver, By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/ul/li[2]/div[1]/span"));
            Avatar = new Button(Driver, By.XPath("/html/body/div[1]/div/div/div/div[2]/div[1]/div/div[1]/img"));
            AfterSchoolProgramTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[2]/div/div/div[2]/a"));
            PartTimeTutoringTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[2]/div/div/div[2]/a"));
            SummerProgramTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[2]/div/div/div[2]/a"));
            LocationsTab = new Button(Driver, By.XPath("//*[@id='content']/div/div/div[3]/div[2]/div/div/div[2]/a"));
        }
    }
}
