using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public abstract class ApplicationWizardPage : OLABasePage
    {
        public Button NextButton { get; private set; }
        public Button PreviousButton { get; private set; }
        public Button ParentNavigationButton { get; private set; }
        public Button StudentNavigationButton { get; private set; }
        public Button ScholarshipNavigationButton { get; private set; }
        public Button SummaryNavigationButton { get; private set; }
        public Button CompleteNavigationButton { get; private set; }
		public OLADocUploadButton UploadDocumentsButton { get; private set; }
        public Button CloseTourPopup { get; private set; }

        public ApplicationWizardPage(IWebDriver driver)
            : base(driver)
        {
            NextButton = new Button(Driver, By.XPath("//span[text() = 'Next']"));
            PreviousButton = new Button(Driver, By.XPath("//span[text() = 'Previous']"));
            ParentNavigationButton = new Button(Driver, By.XPath("//*[@class='indicator-wrap five']/div[1]/a"));
            StudentNavigationButton = new Button(Driver, By.XPath("//*[@class='indicator-wrap five']/div[2]/a"));
            ScholarshipNavigationButton = new Button(Driver, By.XPath("//*[@class='indicator-wrap five']/div[3]/a"));
            SummaryNavigationButton = new Button(Driver, By.XPath("//*[@class='indicator-wrap five']/div[4]/a"));
            CompleteNavigationButton = new Button(Driver, By.XPath("//*[@class='indicator-wrap five']/div[5]/a"));
			UploadDocumentsButton = new OLADocUploadButton(Driver, By.XPath("//span[text() = 'Upload Documents']"));
            CloseTourPopup = new Button(Driver, By.XPath("//button[text() = 'Close']"));
        }
    }
}
