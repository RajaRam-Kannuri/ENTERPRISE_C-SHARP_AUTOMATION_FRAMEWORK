using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class StudentReviewPage : ApplicationWizardPage
    {
        public Text NameLabel { get; private set; }
        public Text GenderLabel { get; private set; }
        public Text SocialSecurityNumberLabel { get; private set; }
        public Text DateOfBirthLabel { get; private set; }
        public Text RaceAndEthnicityLabel { get; private set; }

        public StudentReviewPage(IWebDriver driver)
            : base(driver)
        {
            NameLabel = new Text(Driver, By.XPath("//p[text() = 'Name']"));
            GenderLabel = new Text(Driver, By.XPath("//p[text() = 'Gender']"));
            SocialSecurityNumberLabel = new Text(Driver, By.XPath("//p[text() = 'Social Security Number']"));
            DateOfBirthLabel = new Text(Driver, By.XPath("//p[text() = 'Date of Birth']"));
            RaceAndEthnicityLabel = new Text(Driver, By.XPath("//p[text() = 'Race and Ethnicity']"));
        }
    }
}
