using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using API;
using ForgotPassword_Dashboard;
using ForgotUsername_Dashboard;
using Interfaces;
using Login_Dashboard;
using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using PhoneType;
using RandomFLAddress;
using RandomMartialStatusGen;
using RandomNameGen;
using RandomYesNoAns;
using SidePanelDashboard;
using SignUp;
using UserProfile;

namespace NLPLogix.Core.Environmental
{
    public class NLPLogix
    {

        private static IWebDriver driver = null;

        public static string Language;
        public static string Headless;
        public static string Client;
        public static string Environment;
        public static string Device;
        public static int WindowSizeX;
        public static int WindowSizeY;
        public static string Browser;
        public static string USERNAME;

        public NLPLogix()
        {
            PreReq pre = new PreReq();
            pre.BrowserStartUpConfig("No");
            Environment = "Test";
            Client = Selenium.SETCLIENT;
            try
            {
                InitaliseWebDriver();
            } catch(NullReferenceException)
            {}
        }

        public static void GoToHomepage()
        {
            if (Client.Equals("Florida"))
            {
                if (Environment.Equals("Test"))
                {
                    driver.Navigate().GoToUrl(ApplicationLink.Test_FL_Base);
                } else if (Environment.Equals("UAT"))
                {
                    driver.Navigate().GoToUrl(ApplicationLink.UAT_FL_Base);
                } else
                {
                    driver.Navigate().GoToUrl(ApplicationLink.Test_FL_Base);
                }
            } else if (Client.Equals("West Virgina"))
            {
                if(Environment.Equals("Test"))
                {
                    driver.Navigate().GoToUrl(ApplicationLink.Test_WV_Base);
                }
                else if(Environment.Equals("UAT"))
                {
                    driver.Navigate().GoToUrl(ApplicationLink.UAT_WV_Base);
                }
                else
                {
                    driver.Navigate().GoToUrl(ApplicationLink.Test_WV_Base);
                }
            } else
            {
                driver.Navigate().GoToUrl(ApplicationLink.Test_FL_Base);
            }

        }

        private void ChromeDriveExtract()
        {
            ChromeOptions options = new();
            options.AddArguments("disable-infobars");
            options.AddArguments("--disable-bundled-ppapi-flash");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--no-sandbox");
            //options.EnableMobileEmulation(Device);
            options.AddArguments("--lang="+Language+"");
            Dashboard_Dashboard.BrowserLanguage = Language;
            if (Headless.Equals("Yes"))
            {
                options.AddArguments("--headless");
                options.AddArguments("--disable-gpu");
            }

            Device = "Desktop";

            if(Device.Equals("Desktop"))
            {
                options.AddArguments("--start-maximized");
            }
            else
            {
                options.AddArguments("window-size="+ WindowSizeX +"," + WindowSizeY + "");
                if (WindowSizeX >= 999)
                {
                    options.AddArguments("deviceOrientation", "landscape");
                }
            }


            int attempt = 0;
            if(driver == null)
            {
                while(attempt < 5)
                {
                    try
                    {                  
                        driver = new ChromeDriver(options);
                        break;
                    }
                    catch(Win32Exception)
                    {
                        attempt++;
                    }
                }
            }
        }

        private void FirefoxExtract()
        {
            FirefoxOptions options = new();
            options.SetPreference("ntl.accept_languages", Language);
            options.SetPreference("dom.webnotifications.enabled", false);
            options.SetPreference("dom.ipc.plugins.enabled.libflashplayer.so", false);
            if(Headless.Equals("Yes"))
            {
                options.SetPreference("--headless", true);
                options.SetPreference("--disable-gpu", true);
            }

            if(Device.Equals("Desktop"))
            {
                options.SetPreference("--start-maximized", true);
            }
            else
            {
                options.SetPreference("window-size=" + WindowSizeX, WindowSizeY + "");
                if(WindowSizeX > 999)
                {
                    options.SetPreference("deviceOrientation", "landscape");
                }
            }


            int attempt = 0;
            if(driver == null)
            {
                while(attempt < 5)
                {
                    try
                    {
                        driver = new FirefoxDriver(options);
                        break;
                    }
                    catch(WebDriverException)
                    {
                        attempt++;
                    }
                }
            }
        }

        private void EdgeExtract()
        {
            EdgeOptions options = new();
            options.AddArguments("disable-infobars");
            options.AddArguments("--disable-bundled-ppapi-flash");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--no-sandbox");
            //options.EnableMobileEmulation(Device);
            options.AddArguments("--lang=" + Language + "");
            if(Headless.Equals("Yes"))
            {
                options.AddArguments("--headless");
                options.AddArguments("--disable-gpu");
            }

            Device = "Desktop";

            if(Device.Equals("Desktop"))
            {
                options.AddArguments("--start-maximized");
            }
            else
            {
                options.AddArguments("window-size=" + WindowSizeX + "," + WindowSizeY + "");
                if(WindowSizeX > 999)
                {
                    options.AddArguments("deviceOrientation", "landscape");
                }
            }

            int attempt = 0;
            if(driver == null)
            {
                while(attempt < 5)
                {
                    try
                    {
                        driver = new EdgeDriver(options);
                        break;
                    }
                    catch(WebDriverException)
                    {
                        attempt++;
                    }
                }
            }
        }

        private void SafariExtract()
        {
        }

        private void InitaliseWebDriver()
        {
            if(Browser.Equals("Chrome"))
            {
                ChromeDriveExtract();
            }
            else if(Browser.Equals("Firefox"))
            {
                ChromeDriveExtract();
                //FirefoxExtract();
            }
            else if(Browser.Equals("Edge"))
            {
                EdgeExtract();
            }
            else if(Browser.Equals("Safari"))
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    SafariExtract();
                } else
                {
                    ChromeDriveExtract();
                }
            }
            GoToHomepage();
        }

        public void Destroy()
        {
            APIEmailGenerator.ClearAllCodes();

            if(driver != null)
            {

                try
                {
                    driver.Quit();

                    var process = new System.Diagnostics.Process();
                    var startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                        FileName = "cmd.exe",
                        Arguments = "/C taskkill /F /IM chromedriver.exe " +
                        "& taskkill /F /IM chromedriver.exe *32 " +
                        "& taskkill /F /IM chrome.exe " +
                        "& taskkill /F /IM chrome.exe *32 " +
                        "& taskkill /F /IM MicrosoftEdgeCP.exe " +
                        "& taskkill /F /IM MicrosoftEdgeCP.exe *32 " +
                        "& taskkill /F /IM msedge.exe " +
                        "& taskkill /F /IM msedge.exe *32 " +
                        "& taskkill /F /IM msedgedriver.exe " +
                        "& taskkill /F /IM msedgedriver.exe *32 " +
                        "& taskkill /F /IM msedgewebview2.exe " +
                        "& taskkill /F /IM msedgewebview2.exe *32 " +
                        "& taskkill /F /IM geckodriver.exe " +
                        "& taskkill /F /IM geckodriver.exe *32"
                    };
                }
                catch(Exception) { }
            }
            driver = null;
        }

        public LoginDashboard GetLogin()
        {
            WaitFor.WaitForElementToBeVisiable(driver, By.Id("logonIdentifier"));
            return new(driver);
        }

        public NLPLogix GetDashboard()
        {
            WaitFor.WaitForElementToBeVisiable(driver, By.Id("logonIdentifier"));
            return this;
        }

        public ForgotUsernameDashboard GetForgotUsername()
        {
            GetLogin().ClickForgotUsername();
            return new(driver);
        }

        public ForgotPasswordDashboard GetForgotPassword()
        {
            GetLogin().ClickForgotPassword();
            return new(driver);
        }

        public LoginDashboard GetSignUpPassword()
        {
            GetLogin().ClickSignup();
            return new(driver);
        }

        public string GetUsername()
        {
            return USERNAME;
        }

        private string FirstName;
        private string LastName;
        private string MailingZIP;
        private string MailingZIPCodeName;
        private string MailingCity;
        private string MailingState;
        private string MailingCounty;
        private string MailingHouseNumber;
        private string PrimaryZIP;
        private string PrimaryZIPCodeName;
        private string PrimaryCity;
        private string PrimaryState;
        private string PrimaryCounty;
        private string PrimaryHouseNumber;
        private string YesNo;
        private string PhoneType;
        private string MartialStatus;
        public string YesNo1;
        public string YesNo2;

        private void GenerateNameSpecial(Sex MaleOrFemale)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("Yes", rand);
            string name = nameGen.Generate(MaleOrFemale);

            LastName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            FirstName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GenerateName(Sex MaleOrFemale)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("No", rand);
            string name = nameGen.Generate(MaleOrFemale);

            LastName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            FirstName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GenerateMailingAddress()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomFLAddresses address = new RandomFLAddresses(rand);
            MailingZIP = address.GenerateZIP();
            MailingZIPCodeName = address.GenerateZIPCodeName();
            MailingCity = address.GenerateCity();
            MailingState = address.GenerateState();
            MailingCounty = address.GenerateCounty();

            Random rnd = new Random();
            MailingHouseNumber = rnd.Next(10, 9999).ToString();
        }

        private void GeneratePrimaryAddress()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomFLAddresses address = new RandomFLAddresses(rand);
            PrimaryZIP = address.GenerateZIP();
            PrimaryZIPCodeName = address.GenerateZIPCodeName();
            PrimaryCity = address.GenerateCity();
            PrimaryState = address.GenerateState();
            PrimaryCounty = address.GenerateCounty();

            Random rnd = new Random();
            PrimaryHouseNumber = rnd.Next(1, 500).ToString();
        }

        private void GenerateAnswer()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomYesNo yesno = new RandomYesNo(rand, "English");
            string yesnoans = yesno.Generate();

            YesNo = yesnoans.Substring(yesnoans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GeneratePhoneType()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomPhone phonetype = new RandomPhone(rand);
            string phonetypegen = phonetype.Generate();

            PhoneType = phonetypegen.Substring(phonetypegen.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateMartialStatus()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomMartialStatus martialstatus = new RandomMartialStatus(rand, "English");
            string martialstatusgen = martialstatus.Generate();

            MartialStatus = martialstatusgen.Substring(martialstatusgen.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private int GeneratedNumber;
        private string GeneratedPhoneNumber;

        private void RandomNumber()
        {
            Random rnd = new Random();
            for(int j = 0; j < 1; j++)
            {
                GeneratedNumber = rnd.Next();
            }
        }

        private void RandomPhoneNumber()
        {
            Random rnd = new Random();
            string First = rnd.Next(2, 9).ToString();
            string Second = rnd.Next(0, 8).ToString();
            string Third = rnd.Next(0, 9).ToString();
            string Forth = rnd.Next(2, 9).ToString();
            string Fifth = rnd.Next(0, 8).ToString();
            string Sixth = rnd.Next(0, 9).ToString();
            string Seventh = rnd.Next(2, 9).ToString();
            string Eighth = rnd.Next(0, 9).ToString();
            string Ninth = rnd.Next(2, 9).ToString();
            string Tenth = rnd.Next(0, 9).ToString();
            GeneratedPhoneNumber = First + Second + Third + Forth + Fifth + Sixth + Seventh + Eighth + Ninth + Tenth;
        }

        private void GenerateAnswerSex()
        {
            Random rand1 = new Random(DateTime.Now.Second);
            RandomYesNo yesno1 = new RandomYesNo(rand1, "English");
            string yesnoans1 = yesno1.Generate();
            YesNo1 = yesnoans1.Substring(yesnoans1.IndexOf(" ") + 1).TrimStart().TrimEnd();

            Random rand2 = new Random(DateTime.Now.Second);
            RandomYesNo yesno2 = new RandomYesNo(rand2, "English");
            string yesnoans2 = yesno2.Generate();
            YesNo2 = yesnoans2.Substring(yesnoans2.IndexOf(" ") + 1).TrimStart().TrimEnd();

        }

        public UserProfile_Dashboard CreateGuardianAccount(string selectLanguage)
        {
            if(Client.Equals("Florida"))
            {
                Signup_Dashboard signup = GetLogin().ClickSignup();
                APIEmailGenerator.ConfigureClient();
                signup.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickSendCode();
                APIEmailGenerator.GetVerificationCode("Florida");
                RandomNumber();
                RandomPhoneNumber();
                GenerateAnswerSex();
                if(YesNo1.Equals("Yes"))
                {
                    if(YesNo2.Equals("Yes"))
                    {
                        GenerateNameSpecial(Sex.Male);
                    }
                    else
                    {
                        GenerateNameSpecial(Sex.Female);
                    }
                }
                else
                {
                    if(YesNo2.Equals("Yes"))
                    {
                        GenerateName(Sex.Male);
                    }
                    else
                    {
                        GenerateName(Sex.Female);
                    }
                }
                GenerateAnswer();
                GenerateMailingAddress();
                if(YesNo.Equals("Yes"))
                {
                    GeneratePrimaryAddress();
                }
                else
                {
                    PrimaryZIP = MailingZIP;
                    PrimaryZIPCodeName = MailingZIPCodeName;
                    PrimaryCity = MailingCity;
                    PrimaryState = MailingState;
                    PrimaryCounty = MailingCounty;
                    PrimaryHouseNumber = MailingHouseNumber;
                }
                GeneratePhoneType();
                GenerateMartialStatus();
                string username = (FirstName + LastName + GeneratedNumber);
                USERNAME = username.Replace("'", "");
                Dashboard_Dashboard.GuardianFirstName = FirstName;
                Dashboard_Dashboard.GuardianLastName = LastName;
                MyStudent_Dashboard.LANGUAGE = selectLanguage;
                Dashboard_Dashboard.Language = selectLanguage;

                signup.ClearVerificationCode().TypeVerificationCode(APIEmailGenerator.VERIFICATION_CODE).ClickConfirm().ClickContinue()
                    .ClearUsername().TypeUsername(USERNAME)
                    .ClearFirstName().TypeFirstName(FirstName)
                    .ClearLastName().TypeLastName(LastName)
                    .SelectAccountType("Parent / Guardian")
                    .ClearCreatePassword().TypeCreatePassword(Credentials.PASSWORD)
                    .ClearConfirmPassword().TypeConfirmPassword(Credentials.PASSWORD)
                    .ClickContinueToProfile()
                    .SelectSecurityQuestionOne(SecurityQuestion.SecuirtyQuestion1_Question1).ClearSecurityAnswerOne().TypeSecurityAnswerOne("Spouse")
                    .SelectSecurityQuestionTwo(SecurityQuestion.SecuirtyQuestion2_Question1).ClearSecurityAnswerTwo().TypeSecurityAnswerTwo("Mother")
                    .SelectSecurityQuestionThree(SecurityQuestion.SecuirtyQuestion3_Question1).ClearSecurityAnswerThree().TypeSecurityAnswerThree("Father")
                    .ClickContinue()
                    .ClickCheckBoxToVerify().ClickOk()
                    .SelectMartialStatus(MartialStatus)
                    .SelectPrimaryLanguage(selectLanguage)
                    .TypeMailAddressStreetName(MailingHouseNumber)
                    .ClearMailingCity().TypeMailingAddressLine2("Automation")
                    .ClearMailingCity().TypeMailingCity(MailingCity)
                    .ClearMailingCounty().TypeMailingCounty(MailingCounty)
                    .SelectMailingState(MailingState)
                    .ClearMailingZIP().TypeMailingZIP(MailingZIP)
                    .TypePhysicalAddressStreetName(PrimaryHouseNumber)
                    .ClearPhysicalCity().TypePhysicalAddressLine2("Automation")
                    .ClearPhysicalCity().TypePhysicalCity(PrimaryCity)
                    .ClearPhysicalCounty().TypePhysicalCounty(PrimaryCounty)
                    .SelectPhysicalState(PrimaryState)
                    .ClearPhysicalZIP().TypePhysicalZIP(PrimaryZIP)
                    .ClearPrimaryPhone().TypePrimaryPhone(GeneratedPhoneNumber)
                    .SelectPhoneTypePrimary(PhoneType)
                    .ClickConsentsMessages(YesNo).ClickConsentsMarketingPurposes(YesNo).ClickConsentsParentalEmpowermentr(YesNo).ClickConsentsShareContactInformation(YesNo).ClickConsentsTextSMSInformation(YesNo)
                    .ClickManageContactPreferenceNewFeatureAndPromotion("Email")
                    .ClickSave();
                return new UserProfile_Dashboard(driver);
            }
            else
            {
                Signup_Dashboard signup = GetLogin().ClickSignup();
                APIEmailGenerator.ConfigureClient();
                signup.ClearEmailAddress().TypeEmailAddress(APIEmailGenerator.EMAIL).ClickSendCode();
                APIEmailGenerator.GetVerificationCode("West Virgina");
                RandomNumber();
                RandomPhoneNumber();
                GenerateAnswerSex();
                if(YesNo1.Equals("Yes"))
                {
                    if(YesNo2.Equals("Yes"))
                    {
                        GenerateNameSpecial(Sex.Male);
                    }
                    else
                    {
                        GenerateNameSpecial(Sex.Female);
                    }
                }
                else
                {
                    if(YesNo2.Equals("Yes"))
                    {
                        GenerateName(Sex.Male);
                    }
                    else
                    {
                        GenerateName(Sex.Female);
                    }
                }
                GenerateAnswer();
                GenerateMailingAddress();
                if(YesNo.Equals("Yes"))
                {
                    GeneratePrimaryAddress();
                }
                else
                {
                    PrimaryZIP = MailingZIP;
                    PrimaryZIPCodeName = MailingZIPCodeName;
                    PrimaryCity = MailingCity;
                    PrimaryState = MailingState;
                    PrimaryCounty = MailingCounty;
                    PrimaryHouseNumber = MailingHouseNumber;
                }
                GeneratePhoneType();
                GenerateMartialStatus();
                string username = (FirstName + LastName + GeneratedNumber);
                USERNAME = username.Replace("'", "");
                Dashboard_Dashboard.GuardianFirstName = FirstName;
                Dashboard_Dashboard.GuardianLastName = LastName;
                MyStudent_Dashboard.LANGUAGE = selectLanguage;
                Dashboard_Dashboard.Language = selectLanguage;

                signup.ClearVerificationCode().TypeVerificationCode(APIEmailGenerator.VERIFICATION_CODE).ClickConfirm().ClickContinue()
                    .ClearUsername().TypeUsername(USERNAME)
                    .ClearFirstName().TypeFirstName(FirstName)
                    .ClearLastName().TypeLastName(LastName)
                    .SelectAccountType("Parent / Guardian")
                    .ClearCreatePassword().TypeCreatePassword(Credentials.PASSWORD)
                    .ClearConfirmPassword().TypeConfirmPassword(Credentials.PASSWORD)
                    .ClickContinueToProfile()
                    .SelectSecurityQuestionOne(SecurityQuestion.SecuirtyQuestion1_Question1).ClearSecurityAnswerOne().TypeSecurityAnswerOne("Spouse")
                    .SelectSecurityQuestionTwo(SecurityQuestion.SecuirtyQuestion2_Question1).ClearSecurityAnswerTwo().TypeSecurityAnswerTwo("Mother")
                    .SelectSecurityQuestionThree(SecurityQuestion.SecuirtyQuestion3_Question1).ClearSecurityAnswerThree().TypeSecurityAnswerThree("Father")
                    .ClickContinue()
                    .ClickCheckBoxToVerify().ClickOk()
                    .SelectMartialStatus(MartialStatus)
                    .TypeMailAddressStreetName(MailingHouseNumber)
                    .ClearMailingCity().TypeMailingAddressLine2("Automation")
                    .ClearMailingCity().TypeMailingCity(MailingCity)
                    .ClearMailingCounty().TypeMailingCounty(MailingCounty)
                    .SelectMailingState(MailingState)
                    .ClearMailingZIP().TypeMailingZIP(MailingZIP)
                    .TypePhysicalAddressStreetName(PrimaryHouseNumber)
                    .ClearPhysicalCity().TypePhysicalAddressLine2("Automation")
                    .ClearPhysicalCity().TypePhysicalCity(PrimaryCity)
                    .ClearPhysicalCounty().TypePhysicalCounty(PrimaryCounty)
                    .SelectPhysicalState(PrimaryState)
                    .ClearPhysicalZIP().TypePhysicalZIP(PrimaryZIP)
                    .ClearPrimaryPhone().TypePrimaryPhone(GeneratedPhoneNumber)
                    .SelectPhoneTypePrimary(PhoneType)
                    .ClickConsentsMessages(YesNo).ClickConsentsMarketingPurposes(YesNo)
                    .ClickManageContactPreferenceNewFeatureAndPromotion("Email")
                    .ClickSave();
                return new UserProfile_Dashboard(driver);
            }
        }

        public Dashboard_Dashboard LoginWithPrimaryGuardianAccount(string language)
        {
            if(Environment.Equals("Test"))
            {
                if (Client.Equals("Florida"))
                {
                    var dashboard = GetLogin()
                   .ClearUsername().TypeUsername(Credentials.GUARDIAN_FL_TEST_USERNAME)
                   .ClearPassword().TypePassword(Credentials.PASSWORD)
                   .ClickLogin();

                    dashboard.ClickEditProfile().SelectPrimaryLanguage(language).ClickSave();
                    dashboard.ClickDashboard();
                } else
                {
                    var dashboard = GetLogin()
                   .ClearUsername().TypeUsername(Credentials.GUARDIAN_WV_TEST_USERNAME)
                   .ClearPassword().TypePassword(Credentials.PASSWORD)
                   .ClickLogin();

                    dashboard.ClickDashboard();
                }
            }
            else if(Environment.Equals("UAT"))
            {
                if(Client.Equals("Florida"))
                {
                   var dashboard = GetLogin()
                  .ClearUsername().TypeUsername(Credentials.GUARDIAN_FL_UAT_USERNAME)
                  .ClearPassword().TypePassword(Credentials.PASSWORD)
                  .ClickLogin();

                    dashboard.ClickEditProfile().SelectPrimaryLanguage(language).ClickSave();
                    dashboard.ClickDashboard();
                } else
                {
                    var dashboard = GetLogin()
                    .ClearUsername().TypeUsername(Credentials.GUARDIAN_WV_UAT_USERNAME)
                    .ClearPassword().TypePassword(Credentials.PASSWORD)
                    .ClickLogin();

                    dashboard.ClickDashboard();
                }
                   
            } else {}
            return new(driver);
        }

        public Dashboard_Dashboard LoginWith(string username, string password)
        {
                GetLogin()
                    .ClearUsername().TypeUsername(username)
                    .ClearPassword().TypePassword(password)
                    .ClickLogin();
            return new(driver);
        }

        public NLPLogix FailedLoginAttempt(string username, string password)
        {
            GetLogin()
                .ClearUsername().TypeUsername(username)
                .ClearPassword().TypePassword(password)
                .ClickLogin();
            return this;
        }

    }
}
