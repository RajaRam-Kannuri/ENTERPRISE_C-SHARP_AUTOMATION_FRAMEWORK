using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.SLI.Automation.Pages
{
    public class SchoolProfilePage : SchoolInfoPage
    {
        public Text SchoolCode { get; private set; }

        public Text SchoolDistrictId { get; private set; }

        public Text SUFSRegion { get; private set; }

        public Text SchoolComplianceDate { get; private set; }

        public Text SchoolName { get; private set; }

        public Text DOERegionalManager { get; private set; }

        public Text SchoolDistrictName { get; private set; }

        public Text MailingAddress { get; private set; }

        public Text PermanentAddress { get; private set; }

        public Text SchoolWebSite { get; private set; }

        public Text SchoolPhone { get; private set; }

        public Text SchoolFax { get; private set; }

        public Text Owner_ChiefAdministrativeOffice { get; private set; }

        public Text SchoolDirector_Principal { get; private set; }

        public Text SchoolDirector_Principal_Email { get; private set; }

        public Text SchoolContact { get; private set; }

        public Text SchoolContactEmail { get; private set; }

        public Text SUFSParticipant { get; private set; }

        public Text McKayParticipant { get; private set; }

        public Text NumberOfDaysInSession { get; private set; }

        public Text Denomination { get; private set; }

        public Text FTCParticipant { get; private set; }

        public Text Military { get; private set; }

        public Text Religious { get; private set; }

        public Text GradesServed { get; private set; }

        public Text AccreditingAgency { get; private set; }

        public SchoolProfilePage(IWebDriver driver)
            : base(driver)
        {
            SchoolCode = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl00_lblValue\"]"));
            SchoolDistrictId = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl04_lblValue\"]"));
            SUFSRegion = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl08_lblValue\"]"));
            SchoolComplianceDate = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl12_lblValue\"]"));
            SchoolName = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl02_lblValue\"]"));
            DOERegionalManager = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl06_lblValue\"]"));
            SchoolDistrictName = new Text(Driver, By.CssSelector("span[id$=\"_rpGeneralInfo_ctl10_lblValue\"]"));
            MailingAddress = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolAddress_ctl00_lblValue\"]"));
            PermanentAddress = new Text(Driver, By.CssSelector("span[id$=\"_rpSchoolAddress_ctl02_lblValue\"]"));
            SchoolWebSite = new Text(Driver, By.CssSelector("span[id$=\"_rpPhoneInformation_ctl00_lblValue\"]"));
            SchoolPhone = new Text(Driver, By.CssSelector("span[id$=\"_rpPhoneInformation_ctl04_lblValue\"]"));
            SchoolFax = new Text(Driver, By.CssSelector("span[id$=\"_rpPhoneInformation_ctl02_lblValue\"]"));
            Owner_ChiefAdministrativeOffice = new Text(Driver, By.CssSelector("span[id$=\"_rpAdministrator_ctl00_lblValue\"]"));
            SchoolDirector_Principal = new Text(Driver, By.CssSelector("span[id$=\"_rpAdministrator_ctl04_lblValue\"]"));
            SchoolDirector_Principal_Email = new Text(Driver, By.CssSelector("span[id$=\"_rpAdministrator_ctl06_lblValue\"]"));
            SchoolContact = new Text(Driver, By.CssSelector("span[id$=\"_rpAdministrator_ctl10_lblValue\"]"));
            SchoolContactEmail = new Text(Driver, By.CssSelector("span[id$=\"_rpAdministrator_ctl12_lblValue\"]"));
            SUFSParticipant = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl00_lblValue\"]"));
            McKayParticipant = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl04_lblValue\"]"));
            NumberOfDaysInSession = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl08_lblValue\"]"));
            Denomination = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl12_lblValue\"]"));
            FTCParticipant = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl02_lblValue\"]"));
            Military = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl06_lblValue\"]"));
            Religious = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl10_lblValue\"]"));
            GradesServed = new Text(Driver, By.CssSelector("span[id$=\"_rpParticipation_ctl14_lblValue\"]"));
            AccreditingAgency = new Text(Driver, By.CssSelector("span[id$=\"_rpAccreditingAgency_ctl00_lblValue\"]"));
        }
    }
}
