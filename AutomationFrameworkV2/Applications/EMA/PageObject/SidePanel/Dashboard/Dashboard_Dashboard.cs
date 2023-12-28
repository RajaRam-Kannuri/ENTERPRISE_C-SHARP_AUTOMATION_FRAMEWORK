using System;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using RandomNameGen;
using RandomYesNoAns;
using RandomRelationshipToYouGen;
using SuffixGen;
using RandomTypeofSchoolAns;
using RandomSchoolCountyAns;
using RandomGuardianProofOfResidencyAns;
using RandomEmploymentTypeAns;
using RandomPaidHowOftenAns;
using RandomIncomeVerificationDocumentAns;
using RandomIHaveAAns;
using GradeLevelGen;
using AdditionalIncomeGen;
using UnemploymentAndRelatedGen;
using FamilyGen;
using FinancialAssistanceGen;
using SocialSecurityRelatedGen;
using OtherGen;
using Interfaces;
using System.Threading;
using RandomSchoolNameAns;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;

namespace SidePanelDashboard
{
    public class Dashboard_Dashboard : Widget
    {
        public Dashboard_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public static string StudentFirstName;
        public static string StudentMiddleName;
        public static string StudentLastName;
        public static string GuardianFirstName;
        public static string GuardianLastName;

        public string getPortalHeader()
        {
            return FindText(By.XPath("//h1")).GetText();
        }

        public bool DoesApplicationExist()
        {
            return IsElement.Present(driver, By.XPath("//*[contains(@class,'table')]//tr[td]"));
        }

        public bool RSASuccessfullySubmitted()
        {
            return IsElement.Present(driver, By.XPath("(//h2)[2]"));
        }

        public FTC_Dashboard ClickApplyFTC()
        {
            try {
                FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).Click();
            }
            catch (ElementClickInterceptedException)
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")));
                FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).Click();
            }
            return new(driver);
        }
        public UA_Dashboard ClickApplyUA()
        {
            FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[2]")).Click();
            return new(driver);
        }

        public Hope_Dashboard ClickApplyHope()
        {
            FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).Click();
            return new(driver);
        }

        public FindMyStudent ClickFindMyStudent()
        {
            try
            {
                FindButton(By.XPath("//*[@class='container-card-body']//button")).Click();
            }
            catch(ElementClickInterceptedException)
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("//*[@class='container-card-body']//button")));
                FindButton(By.XPath("//*[@class='container-card-body']//button")).Click();
            }
            return new(driver);
        }

        public string getHeader()
        {
            return FindText(By.XPath("(//h2)[1]")).GetText();
        }

        public string getStudentLearningHeader()
        {
            return FindText(By.XPath("(//h2)[2]")).GetText();
        }

        public string getStudentLearningText()
        {
            return FindText(By.XPath("(//p)[3]")).GetText();
        }

        public string getMyApplicationHeader()
        {
            return FindText(By.XPath("(//h2)[3]")).GetText();
        }

        public string getMyStudentHeader()
        {
            return FindText(By.XPath("(//h2)[4]")).GetText();
        }

        public string getAvailableScholarshipsHeader()
        {
            return FindText(By.XPath("(//h2)[5]")).GetText();
        }

        public string getAvailableScholarshipsButtonText()
        {
            return FindText(By.XPath("//*[@class='container-card learning-plan-widget-container']//button")).GetText();
        }

        public string getAvailableScholarshipsButtonForegroundColor()
        {
            return FindButton(By.XPath("//*[@class='container-card learning-plan-widget-container']//button")).GetFromCSSAttribute("color");
        }

        public string getAvailableScholarshipsButtonBackgroundColor()
        {
            return FindButton(By.XPath("//*[@class='container-card learning-plan-widget-container']//button")).GetFromCSSAttribute("background-color");
        }

        public string getAvailableScholarshipsImportantNoticeText()
        {
            return FindText(By.XPath("//*[@role='alert']")).GetText();
        }

        public string getAvailableScholarshipsFTCHeaderText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[3]")).GetText();
        }

        public string getAvailableScholarshipsHOPEHeaderText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[3]")).GetText();
        }

        public string getAvailableScholarshipsUAHeaderText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[5]")).GetText();
        }

        public string getAvailableScholarshipsNewWorldsHeaderText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[7]")).GetText();
        }

        public string getAvailableScholarshipsFTCText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[4]")).GetText();
        }

        public string getAvailableScholarshipsHOPEText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[4]")).GetText();
        }

        public string getAvailableScholarshipsUAText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[6]")).GetText();
        }

        public string getAvailableScholarshipsNewWorldsText()
        {
            return FindText(By.XPath("((//*[@class='container'])[3]//p)[8]")).GetText();
        }


        public bool doesUAApplicationExist()
        {
            return IsElement.Present(driver, By.XPath("((//*[@class='container'])[3]//p)[5]"));
        }

        public bool doesAvailableScholarshipsNewWorldsExist()
        {
            return IsElement.Present(driver, By.XPath("((//*[@class='container'])[3]//p)[7]"));
        }

        public string getFTCButtonText()
        {
            return FindText(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetText();
        }

        public string getFTCButtonForegroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetFromCSSAttribute("color");
        }

        public string getFTCButtonBackgroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetFromCSSAttribute("background-color");
        }

        public string getHOPEButtonText()
        {
            return FindText(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetText();
        }

        public string getHOPEButtonForegroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetFromCSSAttribute("color");
        }

        public string getHOPEButtonBackgroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[1]")).GetFromCSSAttribute("background-color");
        }

        public string getUAButtonText()
        {
            return FindText(By.XPath("(//*[@class='available-scholarships-container']//button)[2]")).GetText();
        }

        public string getUAButtonForegroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[2]")).GetFromCSSAttribute("color");
        }

        public string getUAButtonBackgroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[2]")).GetFromCSSAttribute("background-color");
        }

        public string getNewWorldsButtonText()
        {
            return FindText(By.XPath("(//*[@class='available-scholarships-container']//button)[3]")).GetText();
        }

        public string getNewWorldsButtonForegroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[3]")).GetFromCSSAttribute("color");
        }

        public string getNewWorldsButtonBackgroundColor()
        {
            return FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[3]")).GetFromCSSAttribute("background-color");
        }

        public string getFindYourStudentHeader()
        {
            return FindText(By.XPath("(//h2)[6]")).GetText();
        }
        public string getFindYourStudentText()
        {
            return FindText(By.XPath("//*[@class='container-card-body']//p")).GetText();
        }

        public string getFindStudentButtonText()
        {
            return FindText(By.XPath("//*[@class='container-card-body']//button")).GetText();
        }

        public string getFindStudentButtonForegroundColor()
        {
            return FindButton(By.XPath("//*[@class='container-card-body']//button")).GetFromCSSAttribute("color");
        }

        public string getFindStudentButtonBackgroundColor()
        {
            return FindButton(By.XPath("//*[@class='container-card-body']//button")).GetFromCSSAttribute("background-color");
        }

        //=====================================================================================================================
        // Generic strings
        //=====================================================================================================================
        // FTC strings
        //=====================================================================================================================
        public static string BrowserLanguage;
        public static string Language;
        public string AuthorityHouseMember;
        public string TypeOfSchool;
        public string TypeOfSchoolExpected;
        public string SchoolCounty;
        public string ParcipatingInUA;
        public int UAID;
        public string Adopted;
        public string FosterCare;
        public string CareHomes;
        public string USArmedForces;
        public string LawEnforcement;
        public string ProofOfResidency;
        public string EmploymentType;
        public string PayFrequency;
        public int DDPayment;
        public int CashPayment;
        public string AdditionalIncomeVerificationDocument;
        public string SNAPTANFFDPIR;
        public string IHaveA;
        public string HouseholdFirstName;
        public string HouseholdMiddleName;
        public string HouseholdLastName;
        public string PartnerFirstName;
        public string PartnerMiddleName;
        public string PartnerLastName;
        public string HouseholdSuffix;
        public string HouseholdRelationshipToYou;
        public string HouseholdDOB;
        public string YesNo1;
        public string YesNo2;
        public string YesNo3;
        public string YesNo4;
        public string YesNo5;
        public string StudentSSN;
        public string GuardianSSN;
        public string HouseholdSSN;
        public string PartnerSSN;
        public string AdditionalHouseHoldMembers;
        public string AdditionalIncomes;
        public string GradeLevel;
        public string PaidType;
        public string AdditionalIncome;
        public string AdditionalIncomeSelection;
        public string SchoolName;
        public string GeneratedPhoneNumber;
        //=====================================================================================================================
        // UA strings
        //=====================================================================================================================
        public string ASpecificLearningDisability;
        public string Anphylaxis;
        public string AutismSpectrumDisorder;
        public string CerebralPalsy;
        public string DownSyndrome;
        public string DualSensoryImpaired;
        public string EmotionalOrBehavioralDisability;
        public string HearingImpaired;
        public string HighRiskChild;
        public string HospitalOrHomebound;
        public string IntellectualImpairment;
        public string LanguageImpairment;
        public string MusularDystrophy;
        public string OrthopedicImpairment;
        public string OtherHealthImpairment;
        public string PhelanMcDemidSyndrome;
        public string PraderWilliSyndrome;
        public string RareDiseases;
        public string SpeechImpairment;
        public string SpindaBifida;
        public string TraumaticBrainInjury;
        public string VisuallyImpaired;
        public string WilliamsSyndrome;

        public RSA_Dashboard ClickApplyRSA()
        {
            FindButton(By.XPath("(//*[@class='available-scholarships-container']//button)[3]")).Click();
            return new(driver);
        }

        private void GenerateAnswer()
        {
            Random rand1 = new Random(DateTime.Now.Second);
            RandomYesNo yesno1 = new RandomYesNo(rand1, "English");
            string yesnoans1 = yesno1.Generate();
            YesNo1 = yesnoans1.Substring(yesnoans1.IndexOf(" ") + 1).TrimStart().TrimEnd();

            Random rand2 = new Random(DateTime.Now.Second);
            RandomYesNo yesno2 = new RandomYesNo(rand2, "English");
            string yesnoans2 = yesno2.Generate();
            YesNo2 = yesnoans2.Substring(yesnoans2.IndexOf(" ") + 1).TrimStart().TrimEnd();

            Random rand3 = new Random(DateTime.Now.Second);
            RandomYesNo yesno3 = new RandomYesNo(rand3, "English");
            string yesnoans3 = yesno3.Generate();
            YesNo3 = yesnoans3.Substring(yesnoans3.IndexOf(" ") + 1).TrimStart().TrimEnd();

            Random rand4 = new Random(DateTime.Now.Second);
            RandomYesNo yesno4 = new RandomYesNo(rand4, "English");
            string yesnoans4 = yesno4.Generate();
            YesNo4 = yesnoans4.Substring(yesnoans4.IndexOf(" ") + 1).TrimStart().TrimEnd();

            Random rand5 = new Random(DateTime.Now.Second);
            RandomYesNo yesno5 = new RandomYesNo(rand5, "English");
            string yesnoans5 = yesno5.Generate();
            YesNo5 = yesnoans5.Substring(yesnoans5.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateTypeofSchool()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomTypeofSchool typeofschool = new RandomTypeofSchool(rand);
            string typeofschoolans = typeofschool.Generate();
            TypeOfSchool = typeofschoolans.Substring(typeofschoolans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateTypeofSchoolExpected()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomTypeofSchoolExpected typeofschool = new RandomTypeofSchoolExpected(rand);
            string typeofschoolans = typeofschool.Generate();
            TypeOfSchoolExpected = typeofschoolans.Substring(typeofschoolans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateSchoolCounty()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomSchoolCounty schoolcounty = new RandomSchoolCounty(rand);
            string schoolcountyans = schoolcounty.Generate();
            SchoolCounty = schoolcountyans.Substring(schoolcountyans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateProofOfResidency()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomGuardianProofOfResidency proofofresidency = new RandomGuardianProofOfResidency(rand);
            string proofofresidencyans = proofofresidency.Generate();
            ProofOfResidency = proofofresidencyans.Substring(proofofresidencyans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateEmploymentType()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomEmploymentType employmenttype = new RandomEmploymentType(rand);
            string employmenttypeans = employmenttype.Generate();
            EmploymentType = employmenttypeans.Substring(employmenttypeans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GeneratePayFrequency()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomPaidHowOften paidhowoften = new RandomPaidHowOften(rand);
            string paidhowoftenans = paidhowoften.Generate();
            PayFrequency = paidhowoftenans.Substring(paidhowoftenans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateIncomeVerificationDocument()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomIncomeVerificationDocument incomeverificationdocument = new RandomIncomeVerificationDocument(rand);
            string incomeverificationdocumentans = incomeverificationdocument.Generate();
            AdditionalIncomeVerificationDocument = incomeverificationdocumentans.Substring(incomeverificationdocumentans.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateIHaveA()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomIHaveA ihavea = new RandomIHaveA(rand);
            string ihaveaans = ihavea.Generate();
            IHaveA = ihaveaans.TrimStart().TrimEnd();
        }

        private void GenerateName(Sex MaleOrFemale)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("No", rand);
            string name = nameGen.Generate(MaleOrFemale);

            Random rand2 = new Random(DateTime.Now.Second);
            RandomName nameGen2 = new RandomName("No", rand2);
            string name2 = nameGen2.Generate(MaleOrFemale);

            HouseholdFirstName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            HouseholdMiddleName = name2.Substring(0, name2.IndexOf(" ") - 0).TrimStart().TrimEnd();
            HouseholdLastName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GeneratePartnerName(Sex MaleOrFemale)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("No", rand);
            string name = nameGen.Generate(MaleOrFemale);

            Random rand2 = new Random(DateTime.Now.Second);
            RandomName nameGen2 = new RandomName("No", rand2);
            string name2 = nameGen2.Generate(MaleOrFemale);

            PartnerFirstName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            PartnerMiddleName = name2.Substring(0, name2.IndexOf(" ") - 0).TrimStart().TrimEnd();
            PartnerLastName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GenerateNameSpecial(Sex MaleOrFemale)
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("Yes", rand);
            string name = nameGen.Generate(MaleOrFemale);

            Random rand2 = new Random(DateTime.Now.Second);
            RandomName nameGen2 = new RandomName("Yes", rand2);
            string name2 = nameGen2.Generate(MaleOrFemale);

            HouseholdFirstName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            HouseholdMiddleName = name2.Substring(name2.IndexOf(" ") - 0).TrimStart().TrimEnd();
            HouseholdLastName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GenerateSuffix()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomSuffix suffixGen = new RandomSuffix(rand);
            string suffix = suffixGen.Generate();

            HouseholdSuffix = suffix.Substring(suffix.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateRelationshipToYou()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomRelationshipToYou relationGen;
            relationGen = new RandomRelationshipToYou(rand, "English");
            string relationshiptoyou = relationGen.Generate();
            HouseholdRelationshipToYou = relationshiptoyou.Substring(relationshiptoyou.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        public int DateGenerator(int start, int end)
        {
            Random dayrandom = new Random();
            int days = 0;
            for(int j = 0; j < 4; j++)
            {
                days = dayrandom.Next(start, end);
            }

            return days;
        }

        public void GetUSRandomDOB()
        {
            int age=0;
            Random rnd = new Random();
            for(int j = 0; j < 4; j++)
            {
                age = rnd.Next(21, 60);
            }

            int days = DateGenerator(1, 364);
            try
            {
                HouseholdDOB = DateTime.Today.AddDays(-days).AddYears(-age).ToString("MM/dd/yyyy").ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                HouseholdDOB = DateTime.Today.AddDays(-days).AddYears(-age).ToString("MM/dd/yyyy").ToString();
            }
           
        }

        private void PayGenerator()
        {
            if (PayFrequency.Equals("Every other week"))
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(1000, 5000);
                }
                Random rnd2 = new Random();
                for(int j = 0; j < 4; j++)
                {
                    CashPayment = rnd2.Next(1000, 5000);
                }
            } else if(PayFrequency.Equals("Weekly"))
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(500, 2500);
                }
                Random rnd2 = new Random();
                for(int j = 0; j < 4; j++)
                {
                    CashPayment = rnd2.Next(500, 2500);
                }
            } else if(PayFrequency.Equals("Once a month"))
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(2000, 10000);
                }
                Random rnd2 = new Random();
                for(int j = 0; j < 4; j++)
                {
                    CashPayment = rnd2.Next(2000, 10000);
                }
            } else if(PayFrequency.Equals("Twice a month"))
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(1000, 5000);
                }
                Random rnd2 = new Random();
                for(int j = 0; j < 4; j++)
                {
                    CashPayment = rnd2.Next(1000, 5000);
                }
            } else if(PayFrequency.Equals("Annually"))
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(30000, 150000);
                }
                Random rnd2 = new Random();
                for(int j = 0; j < 4; j++)
                {
                    CashPayment = rnd2.Next(30000, 150000);
                }
            } else
            {
                Random rnd = new Random();
                for(int j = 0; j < 4; j++)
                {
                    DDPayment = rnd.Next(1000, 1001);
                    CashPayment = rnd.Next(1000, 1001);
                }
            }

        }

        private void SSNGenerator()
        {
            int SSNPart1 = 0;
            int SSNPart2 = 0;
            int SSNPart3 = 0;
            int SSNPart4 = 0;
            int SSNPart5 = 0;
            int SSNPart6 = 0;
            int SSNPart7 = 0;
            int SSNPart8 = 0;
            int SSNPart9 = 0;
            int SSNPart10 = 0;
            int SSNPart11 = 0;
            int SSNPart12 = 0;

            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            for(int j = 0; j < 4; j++)
            {
                SSNPart1 = rnd.Next(101, 999);
                SSNPart2 = rnd1.Next(10, 99);
                SSNPart3 = rnd2.Next(1001, 7999);
            }

            StudentSSN = SSNPart1.ToString() + SSNPart2.ToString() + SSNPart3.ToString();

            Random rnd4 = new Random();
            Random rnd5 = new Random();
            Random rnd6 = new Random();
            for(int j = 0; j < 4; j++)
            {
                SSNPart4 = rnd4.Next(101, 999);
                SSNPart5 = rnd5.Next(10, 99);
                SSNPart6 = rnd6.Next(1001, 7999);
            }

            GuardianSSN = SSNPart4.ToString() + SSNPart5.ToString() + SSNPart6.ToString();

            Random rnd7 = new Random();
            Random rnd8 = new Random();
            Random rnd9 = new Random();
            for(int j = 0; j < 4; j++)
            {
                SSNPart7 = rnd7.Next(101, 999);
                SSNPart8 = rnd8.Next(10, 99);
                SSNPart9 = rnd9.Next(1001, 7999);
            }

            HouseholdSSN = SSNPart7.ToString() +  SSNPart8.ToString() + SSNPart9.ToString();

            Random rnd10 = new Random();
            Random rnd11 = new Random();
            Random rnd12 = new Random();
            for(int j = 0; j < 4; j++)
            {
                SSNPart10 = rnd10.Next(101, 999);
                SSNPart11 = rnd11.Next(10, 99);
                SSNPart12 = rnd12.Next(1001, 7999);
            }

            PartnerSSN = SSNPart10.ToString() + SSNPart11.ToString() + SSNPart12.ToString();
        }

        private void UAIDGenerator()
        {
            Random rnd = new Random();
            for(int j = 0; j < 4; j++)
            {
                UAID = rnd.Next(10000000, 99999999);
            }
        }

        private void GenerateGradeLevel()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomGradeLevel gradelevelGen = new RandomGradeLevel(rand);
            string gradelevel = gradelevelGen.Generate();

            GradeLevel = gradelevel.Substring(gradelevel.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GeneratePaidType()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomPaidType paidTypeGen = new RandomPaidType(rand);
            string paidType = paidTypeGen.Generate();

            PaidType = paidType.Substring(paidType.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateAdditionalIncome()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomAdditionalIncome additionalincomeGen = new RandomAdditionalIncome(rand);
            string additionalincome = additionalincomeGen.Generate();

            AdditionalIncome = additionalincome.TrimStart().TrimEnd();
        }

        private void GenerateUnemployment()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomUnemploymentAndRelated unemploymentAndRelatedGen = new RandomUnemploymentAndRelated(rand);
            string unemploymentAndRelated = unemploymentAndRelatedGen.Generate();

            AdditionalIncomeSelection = unemploymentAndRelated.Substring(unemploymentAndRelated.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateFamily()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomFamily familyGen = new RandomFamily(rand);
            string family = familyGen.Generate();

            AdditionalIncomeSelection = family.Substring(family.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateFinancialAssistance()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomFinancialAssistance financialAssistanceGen = new RandomFinancialAssistance(rand);
            string financialAssistance = financialAssistanceGen.Generate();

            AdditionalIncomeSelection = financialAssistance.Substring(financialAssistance.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateSSNRelated()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomSocialSecurityRelated ssRelatedGen = new RandomSocialSecurityRelated(rand);
            string ssRelated = ssRelatedGen.Generate();

            AdditionalIncomeSelection = ssRelated.Substring(ssRelated.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateOther()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomOther otherGen = new RandomOther(rand);
            string other = otherGen.Generate();

            AdditionalIncomeSelection = other.Substring(other.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateSchoolName()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomSchoolName schoolNameGen = new RandomSchoolName(rand);
            string schoolname = schoolNameGen.Generate();

            SchoolName = schoolname.TrimStart().TrimEnd();
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

        public void CreateFTCApplication()
        {
            string StudentName = StudentFirstName + " " + StudentMiddleName + " " + StudentLastName;
            string GuardianName = GuardianFirstName + " " + GuardianLastName;
            string PDFFile = "C:/workspace/automation/NLPLogix/master/Resources/Project/Test Files/Test File.pdf";
            GenerateAnswer();
            GenerateTypeofSchool();
            GenerateSchoolCounty();
            GeneratePaidType();
            GenerateGradeLevel();
            GenerateProofOfResidency();
            GenerateEmploymentType();
            GenerateAdditionalIncome();
            if (AdditionalIncome.Equals("Unemployment & Related"))
            {
                GenerateUnemployment();
            } else if(AdditionalIncome.Equals("Family (Child Support, Alimony, and Related)"))
            {
                GenerateFamily();
            } else if(AdditionalIncome.Equals("Financial Assistance"))
            {
                GenerateFinancialAssistance();
            } else if(AdditionalIncome.Equals("Social Security Related"))
            {
                GenerateSSNRelated();
            } else if(AdditionalIncome.Equals("Other"))
            {
                GenerateOther();
            }
            GeneratePayFrequency();
            GenerateIncomeVerificationDocument();
            GenerateIHaveA();
            if (YesNo1.Equals("Yes"))
            {
                if (YesNo2.Equals("Yes"))
                {
                    GenerateNameSpecial(Sex.Male);
                } else
                {
                    GenerateNameSpecial(Sex.Female);
                }
            } else
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
            if(YesNo1.Equals("Yes"))
            {
                if(YesNo2.Equals("Yes"))
                {
                    GeneratePartnerName(Sex.Male);
                }
                else
                {
                    GeneratePartnerName(Sex.Female);
                }
            }
            else
            {
                if(YesNo2.Equals("Yes"))
                {
                    GeneratePartnerName(Sex.Male);
                }
                else
                {
                    GeneratePartnerName(Sex.Female);
                }
            }
            GenerateSuffix();
            GenerateRelationshipToYou();
            GetUSRandomDOB();
            PayGenerator();
            SSNGenerator();
            UAIDGenerator();
            RandomPhoneNumber();

            AuthorityHouseMember = YesNo1;
            ParcipatingInUA = YesNo3;
            Adopted = YesNo1;
            FosterCare = YesNo2;
            CareHomes = YesNo3;
            USArmedForces = YesNo4;
            LawEnforcement = YesNo5;
            SNAPTANFFDPIR = YesNo3;
            AdditionalHouseHoldMembers = YesNo4;
            AdditionalIncomes = YesNo2;

            var application = ClickApplyFTC().ClickContinue();
            application.SelectAuthorityHouseholdMemeber(AuthorityHouseMember).ClickStudentApplyingFor()
                .ClickContinue()
                .ClickStudent(StudentName);
            if(AuthorityHouseMember.Equals("Yes"))
            {
                application.ClearSSNITIN().TypeSSNITIN(StudentSSN);
            }
            application.SelectRelationshipToGuardian("Son")
                .SelectTypeOfSchool(TypeOfSchool);
            if(!TypeOfSchool.Equals("Out of State")) {
                application.ClearSchoolName().TypeSchoolName("School Name")
                .SelectSchoolCounty(SchoolCounty);
            }
            application.SelectScholarshipForTransportation(YesNo2)
                .SelectGradeLevel(GradeLevel);
            if (ParcipatingInUA.Equals("Yes"))
            {
                application.SelectPartcipatingUA(YesNo3)
                    .ClearUAID().TypeUAID(UAID.ToString());
            } else
            {
                application.SelectPartcipatingUA(YesNo3);
            }
            if(Adopted.Equals("Yes"))
            {
                application.SelectStudentAdopted("Yes");
            }
            if(FosterCare.Equals("Yes"))
            {
                application.SelectFosterCare("Yes");
            }
            if(CareHomes.Equals("Yes"))
            {
                application.SelectOutOfHomeCare("Yes");
            }
            if(USArmedForces.Equals("Yes"))
            {
                application.SelectUSArmedForces("Yes");
            }
            if(LawEnforcement.Equals("Yes"))
            {
                application.SelectLawEnforcement("Yes");
            }
            if(Adopted.Equals("Yes"))
            {
                application.ClearDocumentationName().TypeDocumentationName("Adoption Papers")
                    .TypeUpload(PDFFile);
            }
            if(FosterCare.Equals("Yes"))
            {
                application.ClearDocumentationName().TypeDocumentationName("Foster Care")
                    .TypeUpload(PDFFile);
            }
            if(CareHomes.Equals("Yes"))
            {
                application.ClearDocumentationName().TypeDocumentationName("Care Homes")
                    .TypeUpload(PDFFile);
            }
            if(USArmedForces.Equals("Yes"))
            {
                application.ClearDocumentationName().TypeDocumentationName("US Military Record")
                    .TypeUpload(PDFFile);
            }
            if(LawEnforcement.Equals("Yes"))
            {
                application.ClearDocumentationName().TypeDocumentationName("Law Enforcement")
                    .TypeUpload(PDFFile);
            }
            application.ClickContinue()
                .ClickGuardian("Open");
            if(AuthorityHouseMember.Equals("Yes"))
            {
                application.ClearSSNITIN().TypeSSNITIN(GuardianSSN.ToString());
            }
            application.SelectProofDocumentationType(ProofOfResidency)
                .TypeUpload(PDFFile)
                .SelectEmploymentIncome(EmploymentType);
            if(EmploymentType.Equals("Employed"))
            {
                application.ClearEmployerCompanyName().TypeEmployerCompanyName("Testing Automation Company")
                    .SelectEmploymentRole(YesNo4);
                if (PaidType.Equals("DD"))
                {
                    application.SelectPaidByChequeOrDirectDeposit("Yes")
                        .ClearDDPaymentAmount().TypeDDPaymentAmount(DDPayment.ToString())
                        .SelectDDPaidHowOften(PayFrequency);
                } else if (PaidType.Equals("Cash"))
                {
                    application.SelectPaidInCash("Yes")
                        .ClearCashPaymentAmount().TypeCashPaymentAmount(CashPayment.ToString())
                        .SelectCashPaidHowOften(PayFrequency)
                        .SelectIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                        .TypeIncomeVerificationDocument(PDFFile);
                } else if (PaidType.Equals("Both"))
                {
                    application.SelectPaidByChequeOrDirectDeposit("Yes")
                        .SelectCashPaidHowOften(PayFrequency)
                        .ClearDDPaymentAmount().TypeDDPaymentAmount(DDPayment.ToString())
                        .SelectDDPaidHowOften(PayFrequency)
                        .ClearCashPaymentAmount().TypeCashPaymentAmount(CashPayment.ToString())
                        .SelectIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                        .TypeIncomeVerificationDocument(PDFFile);
                }
            } 
            if (EmploymentType.Equals("Employed") && AdditionalIncomes.Equals("Yes"))
            {
                application.ClickAdditionalIncomeSources()
                    .SelectAdditionalIncome(AdditionalIncome)
                    .SelectAnnualIncomeCategory(AdditionalIncomeSelection)
                    .ClearOtherIncomeAmountMonthly().TypeOtherIncomeAmountMonthly(DDPayment.ToString())
                    .SelectIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                    .TypeIncomeVerificationDocument(PDFFile);
            }
            application.SelectSNAPTANFFDPIR("No");
            application.ClickGuardian("Close");
            if(application.DoesSpouseExist().Equals(true))
            {
                application.ClickSpousePartner("Open")
                    .ClearPartnerFirstName().TypePartnerFirstName(PartnerFirstName)
                    .ClearPartnerMiddleName().TypePartnerMiddleName(PartnerMiddleName)
                    .ClearPartnerLastName().TypePartnerLastName(PartnerLastName)
                    .ClearPartnerPhonePrimary().TypePartnerPhonePrimary(GeneratedPhoneNumber)
                    .SelectPartnerPhoneType("Mobile");
                if(AuthorityHouseMember.Equals("Yes"))
                {
                    application.ClearPartnerSSN().TypePartnerSSN(PartnerSSN.ToString());
                }
                application.SelectPartnerProofDocumentationType(ProofOfResidency)
                    .TypeUpload(PDFFile)
                    .SelectPartnersEmploymentIncome(EmploymentType);
                if(EmploymentType.Equals("Employed"))
                {
                    application.ClearPartnerEmployerCompanyName().TypePartnerEmployerCompanyName("Testing Automation Company")
                        .SelectPartnerEmploymentRole(YesNo4);
                    if(PaidType.Equals("DD"))
                    {
                        application.SelectPartnerPaidByChequeOrDirectDeposit("Yes")
                            .ClearPartnerDDPaymentAmount().TypePartnerDDPaymentAmount(DDPayment.ToString())
                            .SelectPartnerDDPaidHowOften(PayFrequency);
                    }
                    else if(PaidType.Equals("Cash"))
                    {
                        application.SelectPartnerPaidInCash("Yes")
                            .ClearPartnerCashPaymentAmount().TypePartnerCashPaymentAmount(CashPayment.ToString())
                            .SelectPartnerCashPaidHowOften(PayFrequency)
                            .SelectPartnerIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                            .TypePartnerIncomeVerificationDocument(PDFFile);
                    }
                    else if(PaidType.Equals("Both"))
                    {
                        application.SelectPartnerPaidByChequeOrDirectDeposit("Yes")
                            .ClearPartnerDDPaymentAmount().TypePartnerDDPaymentAmount(DDPayment.ToString())
                            .SelectPartnerDDPaidHowOften(PayFrequency)
                            .ClearPartnerCashPaymentAmount().TypePartnerCashPaymentAmount(CashPayment.ToString())
                            .SelectPartnerCashPaidHowOften(PayFrequency)
                            .SelectPartnerIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                            .TypePartnerIncomeVerificationDocument(PDFFile);
                    }
                }
            }
            application.ClickContinue()
                .ClickHouseHoldMember();
            if(AdditionalHouseHoldMembers.Equals("Yes"))
            {
                application.ClickAddMember()
                    .ClickNewHouseHoldmember()
                    .ClearFirstName().TypeFirstName(HouseholdFirstName)
                    .ClearMiddleName().TypeMiddleName(HouseholdMiddleName)
                    .ClearLastName().TypeLastName(HouseholdMiddleName)
                    .SelectSuffix(HouseholdSuffix);
                if(AuthorityHouseMember.Equals("Yes"))
                {
                    application.ClearSSNITIN().TypeSSNITIN(HouseholdSSN.ToString());
                }
                application.ClearDOB().TypeDOB(HouseholdDOB)
                    .SelectHouseHoldRelationshipToYou(HouseholdRelationshipToYou);
                application.SelectProofDocumentationType(ProofOfResidency)
                .TypeUpload(PDFFile)
                .SelectEmploymentIncome(EmploymentType);
                if(EmploymentType.Equals("Employed"))
                {
                    application.ClearEmployerCompanyName().TypeEmployerCompanyName("Testing Automation Company")
                        .SelectEmploymentRole(YesNo4);
                    if(PaidType.Equals("DD"))
                    {
                        application.SelectPaidByChequeOrDirectDeposit("Yes")
                            .ClearDDPaymentAmount().TypeDDPaymentAmount(DDPayment.ToString())
                            .SelectDDPaidHowOften(PayFrequency);
                    }
                    else if(PaidType.Equals("Cash"))
                    {
                        application.SelectPaidInCash("Yes")
                            .ClearCashPaymentAmount().TypeCashPaymentAmount(CashPayment.ToString())
                            .SelectCashPaidHowOften(PayFrequency)
                            .SelectIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                            .TypeIncomeVerificationDocument(PDFFile);
                    }
                    else if(PaidType.Equals("Both"))
                    {
                        application.SelectPaidByChequeOrDirectDeposit("Yes")
                            .SelectCashPaidHowOften(PayFrequency)
                            .ClearDDPaymentAmount().TypeDDPaymentAmount(DDPayment.ToString())
                            .SelectDDPaidHowOften(PayFrequency)
                            .ClearCashPaymentAmount().TypeCashPaymentAmount(CashPayment.ToString())
                            .SelectIncomeVerificationDocument(AdditionalIncomeVerificationDocument)
                            .TypeIncomeVerificationDocument(PDFFile);
                    }
                }
            }
            application.ClickContinue()
                .ClickAttestation0()
                .ClickAttestation1()
                .ClickAttestation2()
                .ClickAttestation3()
                .ClickAttestation4()
                .ClickAttestation5()
                .ClickAttestation6()
                .ClickAttestation7()
                .ClickAttestation8()
                .ClickComplianceStatement()
                .ClearName().TypeName("Testing Automation")
                .Signature()
                .ClickKeep()
                .ClickSubmit();
        }

        public void CreateUAApplication()
        {
            string StudentName = StudentFirstName + " " + StudentMiddleName + " " + StudentLastName;
            string GuardianName = GuardianFirstName + " " + GuardianLastName;
            string PDFFile = "C:/workspace/automation/NLPLogix/master/Resources/Project/Test Files/Test File.pdf";
            GenerateAnswer();
            GenerateTypeofSchool();
            GenerateSchoolCounty();
            GenerateGradeLevel();
            GenerateProofOfResidency();
            GenerateIncomeVerificationDocument();
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
            if(YesNo1.Equals("Yes"))
            {
                if(YesNo2.Equals("Yes"))
                {
                    GeneratePartnerName(Sex.Male);
                }
                else
                {
                    GeneratePartnerName(Sex.Female);
                }
            }
            else
            {
                if(YesNo2.Equals("Yes"))
                {
                    GeneratePartnerName(Sex.Male);
                }
                else
                {
                    GeneratePartnerName(Sex.Female);
                }
            }
            GenerateSuffix();
            GenerateRelationshipToYou();
            SSNGenerator();
            GenerateTypeofSchoolExpected();

            AuthorityHouseMember = YesNo1;
            Adopted = YesNo1;
            FosterCare = YesNo2;
            USArmedForces = YesNo4;
            LawEnforcement = YesNo5;
            ASpecificLearningDisability = YesNo1;
            Anphylaxis = YesNo2;
            AutismSpectrumDisorder = YesNo3;
            CerebralPalsy = YesNo4;
            DownSyndrome = YesNo5;
            DualSensoryImpaired = YesNo1;
            EmotionalOrBehavioralDisability = YesNo2;
            HearingImpaired = YesNo3;
            HighRiskChild = YesNo4;
            HospitalOrHomebound = YesNo5;
            IntellectualImpairment = YesNo1;
            LanguageImpairment = YesNo2;
            MusularDystrophy = YesNo3;
            OrthopedicImpairment = YesNo4;
            OtherHealthImpairment = YesNo5;
            PhelanMcDemidSyndrome = YesNo1;
            PraderWilliSyndrome = YesNo2;
            RareDiseases = YesNo3;
            SpeechImpairment = YesNo4;
            SpindaBifida = YesNo5;
            TraumaticBrainInjury = YesNo1;
            VisuallyImpaired = YesNo2;
            WilliamsSyndrome = YesNo3;

            var application = ClickApplyUA().ClickContinue()
                .ClickStudentApplyingFor()
                .ClickContinue()
                .ClickStudent(StudentName)
                .ClearSSNITIN().TypeSSNITIN(StudentSSN)
                .SelectRelationshipToGuardian("Son")
                .SelectExpectedTypeOfSchool(TypeOfSchoolExpected)
                .SelectExpectedGradeLevel(GradeLevel)
                .SelectCurrentTypeOfSchool(TypeOfSchool);
            if(!TypeOfSchool.Equals("Out of State"))
            {
                application.ClearCurrentSchoolName().TypeCurrentSchoolName("School Name")
                .SelectCurrentSchoolCounty(SchoolCounty);
            }

            int count = 1;

            application.ClickDiagnosisASpecificLearningDisability()
                .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("A Specific Learning Disability")
                .TypeDiagnosisUpload(PDFFile);
            if(Anphylaxis.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisAnaphylaxis()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Anaphylaxis")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(AutismSpectrumDisorder.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisAutismSpectrumDisorder()
                    .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Autism Spectrum Disorder")
                    .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(CerebralPalsy.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisCerebalPalsy()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Cerebral Palsy")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(DownSyndrome.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisDownSyndrome()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Down Syndrome")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(DualSensoryImpaired.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisDualSensoryImpaired()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Dual Sensory Impaired")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(EmotionalOrBehavioralDisability.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisEmotionalOrBehavioualDisability()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Emotional or Behavioral Disability")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(HearingImpaired.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisHearingImpaired()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Hearing Impaired")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(HighRiskChild.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisHighRiskChild()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("High-Risk Child")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(HospitalOrHomebound.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisHospitalOrHomebound()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Hospital or Homebound")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(IntellectualImpairment.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisIntellectualDisability()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Intellectual Disability")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(LanguageImpairment.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisLanguageImpairment()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Language Impairment")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(MusularDystrophy.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisMusularDystrophy()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Muscular Dystrophy")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                } 
            }
            if(OrthopedicImpairment.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisOrthopedicImpairement()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Orthopedic Impairment")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(OtherHealthImpairment.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisOtherHealthImpairment()
                       .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Other Health Impairment")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(PhelanMcDemidSyndrome.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisPhelanMcDemidSyndrome()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Phelan-McDemid Syndrome")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(PraderWilliSyndrome.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisPraderWilliSyndrome()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Prader-Willi Syndrome")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(RareDiseases.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisRareDiseases()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Rare Diseases")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(SpeechImpairment.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisSpeechImpairment()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Speech Impairment")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(SpindaBifida.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisSpinaBifta()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Spina Bifida")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(TraumaticBrainInjury.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisTraumaticBrainInjury()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Traumatic Brain Injured")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(VisuallyImpaired.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisVisuallyImpaired()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Visually Impaired")
                        .TypeDiagnosisUpload(PDFFile);
                    count++;
                }
            }
            if(WilliamsSyndrome.Equals("Yes"))
            {
                if(count < 5)
                {
                    application.ClickDiagnosisWilliamsSyndrome()
                        .ClearDiagnosisDocumentationName().TypeDiagnosisDocumentationName("Williams Syndrome")
                        .TypeDiagnosisUpload(PDFFile);
                }
            }
            if(Adopted.Equals("Yes"))
            {
                application.SelectStudentAdopted("Yes")
                    .ClearAdditionalInformationDocumentationName().TypeAdditionalInformationDocumentationName("Adoption Papers")
                    .TypeAdditionalInformationUpload(PDFFile);
            }
            if(FosterCare.Equals("Yes"))
            {
                application.SelectFosterCare("Yes")
                    .ClearAdditionalInformationDocumentationName().TypeAdditionalInformationDocumentationName("Foster Care")
                    .TypeAdditionalInformationUpload(PDFFile);
            }
            if(USArmedForces.Equals("Yes"))
            {
                application.SelectUSArmedForces("Yes")
                    .ClearAdditionalInformationDocumentationName().TypeAdditionalInformationDocumentationName("US Military Record")
                    .TypeAdditionalInformationUpload(PDFFile);
            }
            if(LawEnforcement.Equals("Yes"))
            {
                application.SelectLawEnforcement("Yes")
                    .ClearAdditionalInformationDocumentationName().TypeAdditionalInformationDocumentationName("Law Enforcement")
                    .TypeAdditionalInformationUpload(PDFFile);
            }
            application.ClickContinue().ClickGuardian("Open");
            if(AuthorityHouseMember.Equals("Yes"))
            {
                application.ClearSSNITIN().TypeSSNITIN(GuardianSSN.ToString());
            }
            application.SelectProofDocumentationType(ProofOfResidency)
                .TypeProofOfDocument(PDFFile)
                .ClickGuardian("Close");
            if(application.DoesSpouseExist().Equals(true))
            {
                application.ClickSpousePartner("Open")
                    .ClearFirstName().TypeFirstName(PartnerFirstName)
                    .ClearMiddleName().TypeMiddleName(PartnerMiddleName)
                    .ClearLastName().TypeLastName(PartnerLastName);
                if (YesNo3.Equals("Yes"))
                {
                    application.SelectPartnerSuffix(HouseholdSuffix);
                }
            }
            application.ClickContinue()
                .ClickAttestation0()
                .ClickAttestation1()
                .ClickAttestation2()
                .ClickAttestation3()
                .ClickAttestation4()
                .ClickAttestation5()
                .ClickAttestation6()
                .ClickAttestation7()
                .ClickAttestation8()
                .ClickComplianceStatement()
                .ClearName().TypeName("Testing Automation")
                .Signature()
                .ClickKeep()
                .ClickSubmit();
        }

        public void CreateRSAApplication()
        {
            string StudentName = StudentFirstName + " " + StudentMiddleName + " " + StudentLastName;
            string GuardianName = GuardianFirstName + " " + GuardianLastName;
            string PDFFile = "C:/workspace/automation/NLPLogix/master/Resources/Project/Test Files/Test File.pdf";
            GenerateAnswer();
            GenerateSchoolName();
            GenerateGradeLevel();

            var application = ClickApplyRSA()
                .SelectStudent(StudentName)
                .SelectSchoolName(SchoolName);
            if (GradeLevel.Equals("06") || GradeLevel.Equals("07") || GradeLevel.Equals("08") || GradeLevel.Equals("09") || GradeLevel.Equals("10") || GradeLevel.Equals("11") || GradeLevel.Equals("12"))
            {
                application.SelectGradeLevel("05");
            } else
            {
                application.SelectGradeLevel(GradeLevel);
            }
            application.ClickCurrentStatus()
            .UploadSupportingDocuments(PDFFile)
            .ClickContinue()
            .ClickContinue()
            .ClickPenalties()
            .ClearName().TypeName(GuardianName)
            .Signature()
            .ClickKeep()
            .ClickSubmit();
        }

        public void CreateHopeApplication()
        {
            string StudentName = StudentFirstName + " " + StudentMiddleName + " " + StudentLastName;
            string GuardianName = GuardianFirstName + " " + GuardianLastName;
            string PDFFile = "C:/workspace/automation/NLPLogix/master/Resources/Project/Test Files/Test File.pdf";
            GenerateAnswer();
            GenerateGradeLevel();

            ClickApplyHope()
            .SelectStudent(StudentName)
            .SelectGradeLevel(GradeLevel)
            .UploadSupportingDocuments(PDFFile)
            .ClickContinue()
            .ClickContinue()
            .ClickPenalties()
            .ClearName().TypeName(GuardianName)
            .Signature()
            .ClickKeep()
            .ClickSubmit();
        }

    }
}
