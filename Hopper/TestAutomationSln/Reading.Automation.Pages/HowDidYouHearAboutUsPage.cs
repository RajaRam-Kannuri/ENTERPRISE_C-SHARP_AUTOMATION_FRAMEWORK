using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace Reading.Automation.Pages
{
    public class HowDidYouHearAboutUsPage :
        SurveyBasePage
    {

        public Radio StudentFloridaStandardsAssessmentScoreReportRadioButton { get; private set; }
        public Radio SchoolOrSchoolDistrictRadioButton { get; private set; }
        public Radio FriendOrFamilyRadioButton { get; private set; }
        public Radio SocialMediaRadioButton { get; private set; }
        public Radio RadioOrTvRadioButton { get; private set; }
        public Radio BillboardRadioButton { get; private set; }
        public Radio OtherRadioButton { get; private set; }


        public HowDidYouHearAboutUsPage(IWebDriver driver)
            : base(driver)
        {
            StudentFloridaStandardsAssessmentScoreReportRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10826\"]"));
            SchoolOrSchoolDistrictRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10827\"]"));
            FriendOrFamilyRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10828\"]"));
            SocialMediaRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10829\"]"));
            RadioOrTvRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10830\"]"));
            BillboardRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10831\"]"));
            OtherRadioButton = new Radio(Driver, By.CssSelector("label[for$=\"sgE-5397639-26-242-10832\"]"));
        }
    }
}
