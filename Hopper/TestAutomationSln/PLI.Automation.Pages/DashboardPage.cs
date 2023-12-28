using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.PLI.Automation.Pages
{
    public class DashboardPage :
        BasePage
    {
        public Button ApplyForApplication { get; private set; }
        public Button Documents { get; private set; }
        public Button CheckStatusOfApplication { get; private set; }
        public Button TryAgainButton { get; private set; }
        public Text ModalMessage { get; private set; }
        public Button ModalOkayButton { get; private set; }
        public Button StartApplicationButton { get; private set; }

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            //ApplyForApplication = new Button(Driver, By.Id("ftc-apply-link"));
            //CheckStatusOfApplication = new Button(Driver, By.Id("dashboard-app-status-link"));
            //Documents = new Button(Driver, By.Id("dashboard-documents-link"));
            ApplyForApplication = new Button(Driver, By.Id("dashboard-apply-link"));
            CheckStatusOfApplication = new Button(Driver, By.Id("dashboard-app-status-link"));
            Documents = new Button(Driver, By.Id("dashboard-documents-link"));
            TryAgainButton = new Button(Driver, By.XPath("//*[@class='waves-effect waves-light btn-large']"));
            ModalMessage = new Text(Driver, By.CssSelector("#warningModal > div.modal-content > div > p"));
            ModalOkayButton = new Button(Driver, By.CssSelector("#warningModal > div.modal-footer > a"));
            StartApplicationButton = new Button(Driver, By.Id("ftc-apply-link"));
        }
    }
}
