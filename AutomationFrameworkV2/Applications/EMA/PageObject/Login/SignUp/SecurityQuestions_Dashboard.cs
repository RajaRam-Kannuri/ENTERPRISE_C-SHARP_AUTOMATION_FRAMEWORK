using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using SignUp;
using UserProfile;

namespace SecurityQuestions
{
    public class SecurityQuestions_Dashboard : Widget
    {

        public SecurityQuestions_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public SecurityQuestions_Dashboard SelectSecurityQuestionOne(string option)
        {
            FindDropdown(By.Id("extension_securityQuestionOne")).SelectOption(option);
            return this;
        }

        public SecurityQuestions_Dashboard ClearSecurityAnswerOne()
        {
            FindTextField(By.Id("extension_securityQuestionOneAnswer")).Clear();
            return this;
        }

        public SecurityQuestions_Dashboard TypeSecurityAnswerOne(string SecurityAnswerOne)
        {
            FindTextField(By.Id("extension_securityQuestionOneAnswer")).Type(SecurityAnswerOne);
            return this;
        }

        public SecurityQuestions_Dashboard SelectSecurityQuestionTwo(string option)
        {
            FindDropdown(By.Id("extension_securityQuestionTwo")).SelectOption(option);
            return this;
        }

        public SecurityQuestions_Dashboard ClearSecurityAnswerTwo()
        {
            FindTextField(By.Id("extension_securityQuestionTwoAnswer")).Clear();
            return this;
        }

        public SecurityQuestions_Dashboard TypeSecurityAnswerTwo(string SecurityAnswerTwo)
        {
            FindTextField(By.Id("extension_securityQuestionTwoAnswer")).Type(SecurityAnswerTwo);
            return this;
        }


        public SecurityQuestions_Dashboard SelectSecurityQuestionThree(string option)
        {
            FindDropdown(By.Id("extension_securityQuestionThree")).SelectOption(option);
            return this;
        }

        public SecurityQuestions_Dashboard ClearSecurityAnswerThree()
        {
            FindTextField(By.Id("extension_securityQuestionThreeAnswer")).Clear();
            return this;
        }

        public SecurityQuestions_Dashboard TypeSecurityAnswerThree(string SecurityAnswerThree)
        {
            FindTextField(By.Id("extension_securityQuestionThreeAnswer")).Type(SecurityAnswerThree);
            return this;
        }

        public UserProfile_Dashboard ClickContinue()
        {
            FindButton(By.Id("continue")).Click();
            return new(driver);
        }

    }
}
