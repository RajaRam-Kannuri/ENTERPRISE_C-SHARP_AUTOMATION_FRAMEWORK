using System.Linq;
using AutomationFramework;
using OpenQA.Selenium;
using TestAutomation.Support;

namespace FTC.PLI.Automation.Pages
{
    public class ApplicationOtherAdultsPage : ApplicationWizardPage
    {
        public Dropdown RelationshipToPrimaryParent { get; private set; }

        public CommonAdultInformationSection CommonAdultInformationSection { get; private set;}

        public ApplicationOtherAdultsPage(IWebDriver driver)
            : base(driver)
        {
            RelationshipToPrimaryParent = new Dropdown(Driver, By.CssSelector("select[id$=\"_ddlRelationshipTypes\"]"));
            CommonAdultInformationSection = new CommonAdultInformationSection(Driver);
        }
    }
}
