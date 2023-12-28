using System.Threading;
using Interfaces;
using Microsoft.VisualStudio.Services.Common.CommandLine;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using SignUp;

namespace UserProfile
{
    public class UserProfile_Dashboard : Widget
    {
        public UserProfile_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public UserProfile_Dashboard ClickCheckBoxToVerify()
        {
            FindCheckBox(By.Id("termsAccepted")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickOk()
        {
            FindCheckBox(By.Id("acceptTerms")).Click();
            return this;
        }

        public UserProfile_Dashboard SelectMartialStatus(string option)
        {
            FindDropdown(By.Id("maritalStatus")).SelectOption(option);
            return this;
        }

        public UserProfile_Dashboard SelectPrimaryLanguage(string option)
        {
            FindTextField(By.Id("language")).Click();
            FindTextField(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//input[contains(@id,'search')]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public UserProfile_Dashboard TypeMailAddressStreetName(string option)
        {
            FindTextField(By.Id("google__api__0")).Type(option);
            return this;
        }

        public UserProfile_Dashboard ClearMailingAddressLine2()
        {
            FindTextField(By.Id("street__two__0")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeMailingAddressLine2(string addressline2)
        {
            FindTextField(By.Id("street__two__0")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard ClearMailingCity()
        {
            FindTextField(By.Id("city__0")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeMailingCity(string addressline2)
        {
            FindTextField(By.Id("city__0")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard ClearMailingCounty()
        {
            FindTextField(By.Id("county__0")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeMailingCounty(string addressline2)
        {
            FindTextField(By.Id("county__0")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard SelectMailingState(string option)
        {
            FindTextField(By.Id("state__0")).Click();
            FindTextField(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//input[contains(@id,'search')]")).Type(option);
            Thread.Sleep(500);
            FindText(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public UserProfile_Dashboard ClearMailingZIP()
        {
            FindTextField(By.Id("zip__code__0")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeMailingZIP(string zip)
        {
            FindTextField(By.Id("zip__code__0")).Type(zip);
            return this;
        }

        public UserProfile_Dashboard ClickUseSameAddressForPhysicalAndMailing()
        {
            FindCheckBox(By.Id("useSameAddress")).Click();
            return this;
        }

        public UserProfile_Dashboard TypePhysicalAddressStreetName(string option)
        {
            FindTextField(By.Id("google__api__1")).Type(option);
            return this;
        }

        public UserProfile_Dashboard ClearPhysicalAddressLine2()
        {
            FindTextField(By.Id("street__two__1")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypePhysicalAddressLine2(string addressline2)
        {
            FindTextField(By.Id("street__two__1")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard ClearPhysicalCity()
        {
            FindTextField(By.Id("city__1")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypePhysicalCity(string addressline2)
        {
            FindTextField(By.Id("city__1")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard ClearPhysicalCounty()
        {
            FindTextField(By.Id("county__1")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypePhysicalCounty(string addressline2)
        {
            FindTextField(By.Id("county__1")).Type(addressline2);
            return this;
        }

        public UserProfile_Dashboard SelectPhysicalState(string option)
        {
            FindTextField(By.Id("state__1")).Click();
            FindTextField(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//input[contains(@id,'search')]")).Type(option);
            Thread.Sleep(500);
            FindText(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public UserProfile_Dashboard ClearPhysicalZIP()
        {
            FindTextField(By.Id("zip__code__1")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypePhysicalZIP(string zip)
        {
            FindTextField(By.Id("zip__code__1")).Type(zip);
            return this;
        }

        public UserProfile_Dashboard ClearPrimaryPhone()
        {
            FindTextField(By.Id("primary__phone")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypePrimaryPhone(string primaryPhone)
        {
            FindTextField(By.Id("primary__phone")).Type(primaryPhone);
            return this;
        }

        public UserProfile_Dashboard SelectPhoneTypePrimary(string option)
        {
            FindDropdown(By.Id("primaryPhoneType")).SelectOption(option);
            return this;
        }

        public UserProfile_Dashboard ClearSecondaryPhone()
        {
            FindTextField(By.Id("secondary__phone")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeSecondaryPhone(string secondaryPhone)
        {
            FindTextField(By.Id("secondary__phone")).Type(secondaryPhone);
            return this;
        }

        public UserProfile_Dashboard SelectPhoneTypeSecondary(string option)
        {
            FindDropdown(By.Id("secondaryPhoneType")).SelectOption(option);
            return this;
        }

        public UserProfile_Dashboard ClearSecondaryEmail()
        {
            FindTextField(By.Id("secondary__email")).Clear();
            return this;
        }

        public UserProfile_Dashboard TypeSecondaryEmail(string secondaryEmail)
        {
            FindTextField(By.Id("secondary__email")).Type(secondaryEmail);
            return this;
        }

        public UserProfile_Dashboard ClickConsentsMessages(string option)
        {
            FindCheckBox(By.XPath("//*[contains(@id,'config-0')][@value='" + option+"']")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickConsentsMarketingPurposes(string option)
        {
            FindCheckBox(By.XPath("//*[contains(@id,'config-1')][@value='" + option + "']")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickConsentsParentalEmpowermentr(string option)
        {
            FindCheckBox(By.XPath("//*[contains(@id,'config-2')][@value='" + option + "']")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickConsentsShareContactInformation(string option)
        {
            FindCheckBox(By.XPath("//*[contains(@id,'config-3')][@value='" + option + "']")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickConsentsTextSMSInformation(string option)
        {
            FindCheckBox(By.XPath("//*[contains(@id,'config-4')][@value='" + option + "']")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickManageContactPreferenceCriticalUpdates(string option)
        {
            FindCheckBox(By.XPath("//*[label[contains(text(),'"+option+"')]]//*[contains(@id,'config-0')]")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickManageContactPreferenceTransaction(string option)
        {
            FindCheckBox(By.XPath("//*[label[contains(text(),'" + option + "')]]//*[contains(@id,'config-1')]")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickManageContactPreferenceNewFeatureAndPromotion(string option)
        {
            FindCheckBox(By.XPath("//*[label[contains(text(),'" + option + "')]]//*[contains(@id,'config-2')]")).Click();
            return this;
        }

        public UserProfile_Dashboard ClickSave()
        {
            FindButton(By.XPath("//button[@type='Submit']")).Click();
            WaitFor.WaitForElementToBeVisiable(driver, By.XPath("//a[contains(@href, 'Dashboard')]"));
            return this;
        }

    }
}
