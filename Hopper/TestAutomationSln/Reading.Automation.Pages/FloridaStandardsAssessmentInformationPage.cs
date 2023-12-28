using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class FloridaStandardsAssessmentInformationPage :
        SurveyBasePage
    {

        public EditField FloridaEducationIdentifierTextBox { get; private set; }
        public EditField SchoolDOECodeTextBox { get; private set; }
        public EditField SchoolDistrictIDTextBox { get; private set; }
        public EditField FSAELAScoreTextBox { get; private set; }
        public DocUploadButton BrowseButton { get; private set; }
        public Dropdown FSAELAPerformanceLevelDropdown { get; private set; }
        public Radio GradeLevelThirdRadioButton { get; private set; }
        public Radio GradeLevelFourthRadioButton { get; private set; }

        public FloridaStandardsAssessmentInformationPage(IWebDriver driver)
            : base(driver)
        {
            FloridaEducationIdentifierTextBox = new EditField(Driver, By.Id("sgE-5397639-9-199-element"));
            SchoolDOECodeTextBox = new EditField(Driver, By.Id("sgE-5397639-9-195-element"));
            SchoolDistrictIDTextBox = new EditField(Driver, By.Id("sgE-5397639-9-198-element"));
            FSAELAPerformanceLevelDropdown = new Dropdown(Driver, By.Id("sgE-5397639-9-196-element"));
            FSAELAScoreTextBox = new EditField(Driver, By.Id("sgE-5397639-9-197-element"));
            BrowseButton = new DocUploadButton(Driver, By.CssSelector("#sgE-5397639-9-165-element"));
            GradeLevelFourthRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-9-190-10681\"]"));
            GradeLevelThirdRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-9-190-10680\"]"));
        }
    }
}
