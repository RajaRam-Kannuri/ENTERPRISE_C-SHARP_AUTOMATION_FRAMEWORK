using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace PowerBI.Automation.Pages
{
    public class PAPAProgramSelectionPage : PowerBIBasePage
    {
        public Button FTCScholarshipProgramTile { get; private set; }
        public Button GardinerScholarshipProgramTile { get; private set; }

        public PAPAProgramSelectionPage(IWebDriver driver)
            : base(driver)
        {
            FTCScholarshipProgramTile = new Button(Driver, By.CssSelector("#dashboard3760794 > li:nth-child(3) > div.tileWrapper > div > a > div > section > div > div > div"));
            GardinerScholarshipProgramTile = new Button(Driver, By.CssSelector("#dashboard3760794 > li:nth-child(4) > div.tileWrapper > div > a > div > section > div > div > div"));
        }
    }
}
