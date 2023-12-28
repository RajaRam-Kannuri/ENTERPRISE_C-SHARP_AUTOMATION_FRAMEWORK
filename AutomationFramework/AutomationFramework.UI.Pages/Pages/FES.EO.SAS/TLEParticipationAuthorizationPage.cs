using OpenQA.Selenium;

namespace AutomationFramework.Pages.FES.EO.SAS
{
    public class TLEParticipationAuthorizationPage : HomePage
    {
        public Dropdown TLEParticipation { get; private set; }

        public Button SaveButton { get; private set; }

        public TLEParticipationAuthorizationPage(IWebDriver driver)
            : base(driver)
        {
            TLEParticipation = new Dropdown(driver, By.CssSelector("select[id$=\"ddlSchoolParticipant\"]"));
            SaveButton = new Button(driver, By.CssSelector("input[id$=\"btnSaveSchoolParticipation\"]"));
        }
    }
}
