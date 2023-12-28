using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class ApplicationReviewPage :
        SurveyBasePage
    {
        public Button SubmitButton { get; private set; }
        public Text StudentNameText { get; private set; }
        public Text StudentDateOfBirthText { get; private set; }
        public Text StudentFLEIDText { get; private set; }
        public Text StudentEthnicityHispanicText { get; private set; }
        public Text StudentGenderText { get; private set; }
        public Text StudentGradeLevelText { get; private set; }
        public Text PlannedSchoolText { get; private set; }
        public Text DistrictText { get; private set; }
        public Text GradeText { get; private set; }
        public Text PrimaryGuardianNameText { get; private set; }
        public Text PrimaryGuardianAddressText { get; private set; }
        public Text PrimaryGuardianEmailText { get; private set; }
        public Text PrimaryGuardianPhoneText { get; private set; }
        public Text PrimaryGuardianLanguageText { get; private set; }
        public Text SecondaryGuardianNameText { get; private set; }
        public Text SecondaryGuardianEmailText { get; private set; }
        public Text SecondaryGuardianPhoneText { get; private set; }
        public Text StudentInformationText { get; private set; }
        public Text SchoolInformationText { get; private set; }
        public Text GuardianInformationText { get; private set; }
        public Text SecondaryGuardianInformationText { get; private set; }

        public ApplicationReviewPage(IWebDriver driver)
            : base(driver)
        {
            SubmitButton = new Button(Driver, By.Id("sg_SubmitButton"));
            //StudentNameText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[1]"));
            //StudentDateOfBirthText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[2]"));
            //StudentFLEIDText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[3]"));
            //StudentEthnicityHispanicText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[4]"));
            //StudentGenderText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[5]"));
            //StudentGradeLevelText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[6]"));
            //PlannedSchoolText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[2]/span/text()[1]"));
            //DistrictText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[2]/span/text()[2]"));
            //GradeText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[2]/span/text()[3]"));
            //PrimaryGuardianNameText = new Text(Driver, By.XPath("//*@id='sgE-5397639-17-174-box']/div/div[1]/span/text()[1]"));
            //PrimaryGuardianAddressText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[5]/span/text()[1]"));
            //PrimaryGuardianEmailText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[5]/span/text()[1]"));
            //PrimaryGuardianPhoneText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[5]/span/text()[3]"));
            //PrimaryGuardianLanguageText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[5]/span/text()[4]"));
            //SecondaryGuardianNameText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[7]/span/text()[1]"));
            //SecondaryGuardianEmailText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[7]/span/text()[2]"));
            //SecondaryGuardianPhoneText = new Text(Driver, By.XPath("//*[@id='sgE-5397639-17-174-box']/div/div[7]/span/text()[3]"));
            StudentInformationText = new Text(Driver, By.CssSelector("#sgE-5397639-17-174-box > div > div:nth-child(2) > span"));
            SchoolInformationText = new Text(Driver, By.CssSelector("#sgE-5397639-17-174-box > div > div:nth-child(4) > span"));
            GuardianInformationText = new Text(Driver, By.CssSelector("#sgE-5397639-17-174-box > div > div:nth-child(7) > span"));
            SecondaryGuardianInformationText = new Text(Driver, By.CssSelector("#sgE-5397639-17-174-box > div > div:nth-child(9) > span"));
        }
    }
}
