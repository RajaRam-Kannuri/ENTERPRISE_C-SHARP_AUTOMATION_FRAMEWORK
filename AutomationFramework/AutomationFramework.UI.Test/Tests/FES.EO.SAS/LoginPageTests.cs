using AutomationFramework.Core;
using AutomationFramework.Pages.FES.EO.SAS;
using NUnit.Framework;

namespace AutomationFramework.UI.Test.Tests.FES.EO.SAS
{
    [TestFixture]
    public class LoginPageTests : BaseUITest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            NavigateTo("http://fltestsas.sufs.local/Login.aspx");
        }

        [Test]
        public void VerifyElementsOnCCWorksheetPage()
        {
            var loginPage = new LoginPage(driver);
            var homePage = new HomePage(driver);
            var callCenterWorksheetPage = new CallCenterWorksheetPage(driver);

            loginPage.Username.SetText("SASDirOps@sufs.org");
            loginPage.Password.SetText("LimeSink$123");
            loginPage.LoginButton.Click();

            homePage.ApplicationQuickSearchId.SetText("1450576");
            homePage.ApplicationQuickSearchSearchButton.Click();

            homePage.ContactLink.Click();

            Assert.AreEqual(callCenterWorksheetPage.ApplicationId.Text, "1450576");
            Assert.IsTrue(callCenterWorksheetPage.Email.VerifyElementIsVisible());
            Assert.IsTrue(callCenterWorksheetPage.PhysicalAddress1.VerifyElementIsVisible());
            Assert.IsTrue(callCenterWorksheetPage.MailingAddress1.VerifyElementIsVisible());
            Assert.IsTrue(callCenterWorksheetPage.PrimaryParent.VerifyElementIsVisible());
            Assert.IsTrue(callCenterWorksheetPage.PrimaryParentMaritalStatus.VerifyElementIsVisible());
            Assert.IsTrue(callCenterWorksheetPage.StudentsTable.VerifyElementIsVisible());
        }

        [TearDown]
        public void TearDown()
        {
            Cleanup();
        }
    }
}