using System;
using System.Reflection;
using System.Threading;
using EthnicityGen;
using Interfaces;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using RandomNameGen;
using RandomRaceGen;
using RandomRelationshipToYouGen;
using RandomYesNoAns;
using ServiceStack;
using SuffixGen;
using TestSuite;

namespace SidePanelDashboard
{
    public class MyStudent_Dashboard : Widget
    {
        public MyStudent_Dashboard(IWebDriver driver) : base(driver)
        {
        }

        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Suffix;
        public string Gender;
        public string Ethnicity;
        public string RelationshipToYou;
        public string FleidNumber;
        public string WVEISNumber;
        public string DOB;
        public static string LANGUAGE;
        public string Race;
        public string YesNo1;
        public string YesNo2;

        private void GenerateName(Sex MaleOrFemale)
        {
            Gender = MaleOrFemale.ToString();
            if (LANGUAGE.Equals("Spanish") && Gender.Equals("Male"))
            {
                Gender = "MASCULINO";
            } else if (LANGUAGE.Equals("Spanish") && Gender.Equals("Female"))
            {
                Gender = "FEMENINO";
            }

            Random rand = new Random(DateTime.Now.Second);
            RandomName nameGen = new RandomName("No", rand);
            string name = nameGen.Generate(MaleOrFemale);

            string name2 = "";

            if(YesNo1.Equals("Yes"))
            {
                Random rand2 = new Random(DateTime.Now.Second);
                RandomName nameGen2 = new RandomName("Yes", rand2);
                name2 = nameGen2.Generate(MaleOrFemale);
            }
            else
            {
                Random rand2 = new Random(DateTime.Now.Second);
                RandomName nameGen2 = new RandomName("No", rand2);
                name2 = nameGen2.Generate(MaleOrFemale);
            }

            LastName = name.Substring(name.IndexOf(" ") + 1).TrimStart().TrimEnd();
            MiddleName = name2.Substring(0, name2.IndexOf(" ") - 0).TrimStart().TrimEnd();
            FirstName = name.Substring(0, name.IndexOf(" ") - 0).TrimStart().TrimEnd();
        }

        private void GenerateSuffix()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomSuffix suffixGen = new RandomSuffix(rand);
            string suffix = suffixGen.Generate();

            Suffix = suffix.Substring(suffix.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateEthnicity()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomEthnicity ethnicityGen;
            if(FindText(By.XPath("//h1")).GetText().Equals("Scholarship Portal"))
            {
                LANGUAGE = "English";
                ethnicityGen = new RandomEthnicity(rand, "English");
            }
            else
            {
                LANGUAGE = "Spanish";
                ethnicityGen = new RandomEthnicity(rand, "Spanish");
            }
            string ethnicity = ethnicityGen.Generate();

            Ethnicity = ethnicity.Substring(ethnicity.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateRelationshipToYou()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomRelationshipToYou relationGen;
            if(FindText(By.XPath("//h1")).GetText().Equals("Scholarship Portal"))
            {
                LANGUAGE = "English";
                relationGen = new RandomRelationshipToYou(rand, "English");
            } else
            {
                LANGUAGE = "Spanish";
                relationGen = new RandomRelationshipToYou(rand, "Spanish");
            }

            string relationshiptoyou = relationGen.Generate();
            RelationshipToYou = relationshiptoyou.Substring(relationshiptoyou.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private void GenerateRace()
        {
            Random rand = new Random(DateTime.Now.Second);
            RandomRace raceGen;
            if(FindText(By.XPath("//h1")).GetText().Equals("Scholarship Portal"))
            {
                LANGUAGE = "English";
                raceGen = new RandomRace(rand, "English");
            }
            else
            {
                LANGUAGE = "Spanish";
                raceGen = new RandomRace(rand, "Spanish");
            }

            string race = raceGen.Generate();
            Race = race.Substring(race.IndexOf(" ") + 1).TrimStart().TrimEnd();
        }

        private string range1;
        private string range2;
        private string range3;
        private int age;

        private void Fleidnumber()
        {
            Random rnd = new Random();
            for(int j = 0; j < 4; j++)
            {
                range1 = rnd.Next(1000, 9999).ToString();
                range2 = rnd.Next(1000, 9999).ToString();
                range3 = rnd.Next(1000, 9999).ToString();
            }
            FleidNumber = range1 + range2 + range3;
        }

        private void WVEISnumber()
        {
            Random rnd = new Random();
            for(int j = 0; j < 4; j++)
            {
                range1 = rnd.Next(100, 999).ToString();
                range2 = rnd.Next(100, 909).ToString();
                range3 = rnd.Next(1000, 9999).ToString();
            }
            WVEISNumber = range1 + range2 + range3;
        }

        private void StudentAge()
        {
            Random rnd = new Random();

            if(RSA.ApplicationType.IsEmpty())
            {
                for(int j = 0; j < 4; j++)
                {
                    age = rnd.Next(5, 21);
                }
            } else
            {
                for(int j = 0; j < 4; j++)
                {
                    age = rnd.Next(5, 14);
                }
            }
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
            Thread.Sleep(1000);
        }

        public MyStudent_Dashboard CreateStudent()
        {
            GenerateAnswer();
            MyStudent_Dashboard studentDashboard = new(driver);
            if(YesNo2.Equals("Yes"))
            {
                GenerateName(Sex.Male);
            }
            else
            {
                GenerateName(Sex.Female);
            }
            GenerateSuffix();
            GenerateEthnicity();
            GenerateRelationshipToYou();
            StudentAge();
            Fleidnumber();
            WVEISnumber();
            if (Ethnicity.Equals("Non-Hispanic or Latino") || Ethnicity.Equals("No es Hispano o Latino"))
            {
                GenerateRace();
            }
            Dashboard_Dashboard.StudentFirstName = FirstName;
            Dashboard_Dashboard.StudentMiddleName = MiddleName;
            Dashboard_Dashboard.StudentLastName = LastName;
            studentDashboard.ClickAddAStudent()
            .ClearFirstName().TypeFirstName(FirstName)
                .ClearMiddleName().TypeMiddleName(MiddleName)
                .ClearLastName().TypeLastName(LastName)
                .SelectSuffix(Suffix);
            if(FindText(By.XPath("(//label)[5]")).GetText().Contains("WVEIS"))
            {
                studentDashboard.ClearFleidNumber().TypeFleidNumber(WVEISNumber);
            }
            else
            {
                studentDashboard.ClearFleidNumber().TypeFleidNumber("FL" + FleidNumber);
            }
            studentDashboard.ClearDOB().TypeDOB(GetUSRandomDOB(age))
                .SelectGender(Gender)
                .SelectEthnicity(Ethnicity);
            if (Ethnicity.Equals("Non-Hispanic or Latino") || Ethnicity.Equals("No es Hispano o Latino"))
            {
                studentDashboard.SelectRace(Race);
            };
            studentDashboard.SelectRelationshipToYou(RelationshipToYou)
                .ClickSave();
            return new(driver);
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

        public string GetUSRandomDOB(int age)
        {
            int days = DateGenerator(1, 364);
            try
            {
                DOB = DateTime.Today.AddDays(-days).AddYears(-age).ToString("MM/dd/yyyy").ToString();
                return DateTime.Today.AddDays(-days).AddYears(-age).ToString("MMddyyyy").ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                DOB = DateTime.Today.AddDays(-days).AddYears(-age).ToString("MM/dd/yyyy").ToString();
                return DateTime.Today.AddDays(-days).AddYears(-age).ToString("MMddyyyy").ToString();
            }
        }

        public MyStudent_Dashboard ClickApplyForScholarships()
        {
            FindButton(By.Id("applyForScholarshipsButton")).Click();
            return this;
        }

        public MyStudent_Dashboard ClickFindStudent()
        {
            FindButton(By.Id("activateStudentButton")).Click();
            return this;
        }

        public MyStudent_Dashboard ClickFindStudents()
        {
            FindButton(By.XPath("(//div[@class='modal-content']//button)[2]")).Click();
            return this;
        }

        public MyStudent_Dashboard ClickProgram(string program)
        {
            if (program.Equals("UA"))
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[1]")).Click();
            } else if(program.Equals("FTC"))
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[2]")).Click();
            } else
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[2]")).Click();
            }

            return this;
        }


        public MyStudent_Dashboard ClickClose()
        {
            FindButton(By.XPath("(//div[@class='modal-content']//button)[2]")).Click();
            return this;
        }

        public MyStudent_Dashboard ClickAddAStudent()
        {
            try
            {
                FindButton(By.Id("addStudentButton")).Click();
            }
            catch(ElementClickInterceptedException) {
                FindButton(By.Id("addStudentButton")).Click();
            }
            return this;
        }

        public MyStudent_Dashboard ClearFirstName()
        {
            FindTextField(By.Id("firstName")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeFirstName(string firstname)
        {
            FindTextField(By.Id("firstName")).Type(firstname);
            return this;
        }

        public MyStudent_Dashboard ClearMiddleName()
        {
            FindTextField(By.Id("middleName")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeMiddleName(string middlename)
        {
            FindTextField(By.Id("middleName")).Type(middlename);
            return this;
        }

        public MyStudent_Dashboard ClearLastName()
        {
            FindTextField(By.Id("lastName")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeLastName(string lastname)
        {
            FindTextField(By.Id("lastName")).Type(lastname);
            return this;
        }

        public MyStudent_Dashboard SelectSuffix(string option)
        {
            FindDropdown(By.Id("suffix")).SelectOption(option);
            return this;
        }

        public MyStudent_Dashboard ClearFleidNumber()
        {
            FindTextField(By.Id("FleidNo")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeFleidNumber(string fleidnumber)
        {
            FindTextField(By.Id("FleidNo")).Type(fleidnumber);
            return this;
        }

        public MyStudent_Dashboard ClearDOB()
        {
            FindTextField(By.Id("dateOfBirth")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeDOB(string dob)
        {
            FindTextField(By.Id("dateOfBirth")).Type(dob);
            return this;
        }

        public MyStudent_Dashboard SelectGender(string option)
        {
            FindDropdown(By.Id("gender")).SelectOption(option);
            return this;
        }

        public MyStudent_Dashboard SelectEthnicity(string option)
        {
            FindDropdown(By.Id("ethnicity")).SelectOption(option);
            return this;
        }

        public MyStudent_Dashboard SelectRace(string option)
        {
            FindDropdown(By.Id("race")).SelectOption(option);
            return this;
        }

        public MyStudent_Dashboard SelectRelationshipToYou(string option)
        {
            FindDropdown(By.Id("relationshipToGuardian")).SelectOption(option);
            return this;
        }

        public MyStudent_Dashboard ClickSave()
        {
            FindButton(By.Id("save__student")).Click();
            WaitFor.InvisiabilityOfElement(driver, By.Id("save__student"));
            return this;
        }

        public MyStudent_Dashboard ClickCancel()
        {
            FindButton(By.Id("cancel__student")).Click();
            return this;
        }

        public MyStudent_Dashboard ClickApplicationType(string applicationtype)
        {
            FindCheckBox(By.XPath("(//h3[contains(text(),'"+ applicationtype + "')]//..//..//..//div[contains(@class,'btn-contents')]/div)[1]")).Click();
            return this;
        }

        public MyStudent_Dashboard ClearEmail()
        {
            FindTextField(By.Id("username")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypeEmail(string email)
        {
            FindTextField(By.Id("username")).Type(email);
            return this;
        }

        public MyStudent_Dashboard ClearPassword()
        {
            FindTextField(By.Id("password")).Clear();
            return this;
        }

        public MyStudent_Dashboard TypePassword(string password)
        {
            FindTextField(By.Id("password")).Type(password);
            return this;
        }

        public MyStudent_Dashboard ClickVerify()
        {
            FindButton(By.XPath("(//div[@class='modal-content']//button)[3]")).Click();
            return this;
        }

        public string GetAlert()
        {
            try
            {
                return FindText(By.XPath("//p[contains(@class,'danger')]")).GetText();
            } catch (WebDriverTimeoutException)
            {
                return "Error Not Visable";
            }
        }

        public string ApplyForScholarshipsText()
        {
            return FindButton(By.Id("applyForScholarshipsButton")).GetText();
        }

        public string FindStudentText()
        {
            return FindButton(By.Id("activateStudentButton")).GetText();
        }

        public string AddAStudentText()
        {
            try
            {
                return FindButton(By.Id("addStudentButton")).GetText();
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("addStudentButton")).GetText();
            }
        }

        public string ApplyForScholarshipsTextColor()
        {
            return FindButton(By.Id("applyForScholarshipsButton")).GetFromCSSAttribute("color");
        }

        public string FindStudentTextColor()
        {
            return FindButton(By.Id("activateStudentButton")).GetFromCSSAttribute("color");
        }

        public string AddAStudentTextColor()
        {
            try
            {
                return FindButton(By.Id("addStudentButton")).GetFromCSSAttribute("color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("addStudentButton")).GetFromCSSAttribute("color");
            }
        }

        public string ApplyForScholarshipsBackgroundColor()
        {
            return FindButton(By.Id("applyForScholarshipsButton")).GetFromCSSAttribute("background-color");
        }

        public string FindStudentBackgroundColor()
        {
            return FindButton(By.Id("activateStudentButton")).GetFromCSSAttribute("background-color");
        }

        public string AddAStudentBackgroundColor()
        {
            try
            {
                return FindButton(By.Id("addStudentButton")).GetFromCSSAttribute("background-color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("addStudentButton")).GetFromCSSAttribute("background-color");
            }
        }

        public string GetHeaderText()
        {
            return FindText(By.XPath("//h2")).GetText();
        }

        public string GetApplicationID()
        {
            return FindText(By.XPath("//*[@class='bold-nunito']")).GetText();
        }

        public string GetWelcomeMessageText()
        {
            return FindText(By.XPath("//div[contains(@class,'alert-warning')]")).GetText();
        }

        public string GetMyStudentTableTitleText(int table)
        {
            return FindText(By.XPath("(//table//tr[contains(@class,'header')])["+ table + "]")).GetText();
        }

        public string GetMyStudentTableHeaderText(int table, int row, int column)
        {
            return FindTable(By.XPath("(//table//tr[th[" + row + "]]//th[" + column+"])[" + table+"]")).GetText();
        }

        public string GetMyStudentTableContentText(int table, int row, int column)
        {
            return FindTable(By.XPath("(//table//tr["+row+"]//td["+column+"])["+table+"]")).GetText();
        }

        public MyStudent_Dashboard ClickMyStudentView(int table, int row)
        {
            WaitFor.WaitForElementToBeVisiable(driver, By.XPath("(//table//tr[" + row + "]//td[4])[" + table + "]//button"));
            FindTable(By.XPath("(//table//tr[" + row + "]//td[4])[" + table + "]//button")).Click();
            WaitFor.InvisiabilityOfElement(driver, By.XPath("(//table//tr[" + row + "]//td[4])[" + table + "]//button"));
            return this;
        }

        public string GetMyStudentActiveStudentText()
        {
            return FindText(By.XPath("(//div[@b-oaj2yc196p])[6]")).GetText();
        }

        public string GetMyStudentInactiveStudentText()
        {
            return FindText(By.XPath("(//div[@b-oaj2yc196p])[9]")).GetText();
        }

        public MyStudent_Dashboard ClickEditStudentButton()
        {
            try
            {
                FindButton(By.Id("enable__student__edit")).Click();
                WaitFor.InvisiabilityOfElement(driver, By.Id("enable__student__edit"));
                return this;
            }
            catch(ElementClickInterceptedException)
            {
                FindButton(By.Id("enable__student__edit")).Click();
                WaitFor.InvisiabilityOfElement(driver, By.Id("enable__student__edit"));
                return this;
            }
        }

        public string EditStudentButtonText()
        {
            try
            {
                return FindButton(By.Id("enable__student__edit")).GetText();
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("enable__student__edit")).GetText();
            }
        }

        public string EditStudentButtonColour()
        {
            try
            {
                return FindButton(By.Id("enable__student__edit")).GetFromCSSAttribute("color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("enable__student__edit")).GetFromCSSAttribute("color");
            }
        }

        public string EditStudentButtonBackgroundColour()
        {
            try
            {
                return FindButton(By.Id("enable__student__edit")).GetFromCSSAttribute("background-color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("enable__student__edit")).GetFromCSSAttribute("background-color");
            }
        }

        public string GetFirstName()
        {
            return FindTextField(By.Id("firstName")).GetText();
        }

        public string GetMiddleName()
        {
            return FindTextField(By.Id("middleName")).GetText();
        }

        public string GetLastName()
        {
            return FindTextField(By.Id("lastName")).GetText();
        }

        public string GetSuffix()
        {
            By id = By.Id("suffix");
            return FindDropdown(id).OptionSelected(id);
        }

        public string GetFleidNumber()
        {
            return FindTextField(By.Id("FleidNo")).GetText();
        }

        public string GetDOB()
        {
            return FindTextField(By.Id("dateOfBirth")).GetText();
        }

        public string GetGender()
        {
            By id = By.Id("gender");
            return FindDropdown(id).OptionSelected(id);
        }

        public string GetEthnicity()
        {
            By id = By.Id("ethnicity");
            return FindDropdown(id).OptionSelected(id);
        }

        public string GetRelationshipToYou()
        {
            By id = By.Id("relationshipToGuardian");
            return FindDropdown(id).OptionSelected(id);
        }

        public MyStudent_Dashboard ClickCancelStudentButton()
        {
            try
            {
                FindButton(By.Id("cancel__student")).Click();
                return this;
            }
            catch(ElementClickInterceptedException)
            {
                FindButton(By.Id("cancel__student")).Click();
                return this;
            }
        }

        public string CancelEditStudentButtonText()
        {
            try
            {
                return FindButton(By.Id("cancel__student")).GetText();
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("cancel__student")).GetText();
            }
        }

        public string CancelEditStudentButtonColour()
        {
            try
            {
                return FindButton(By.Id("cancel__student")).GetFromCSSAttribute("color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("cancel__student")).GetFromCSSAttribute("color");
            }
        }

        public string CancelEditStudentButtonBackgroundColour()
        {
            try
            {
                return FindButton(By.Id("cancel__student")).GetFromCSSAttribute("background-color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("cancel__student")).GetFromCSSAttribute("background-color");
            }
        }

        public MyStudent_Dashboard ClickSaveStudentButton()
        {
            try
            {
                FindButton(By.Id("save__student")).Click();
                return this;
            }
            catch(ElementClickInterceptedException)
            {
                FindButton(By.Id("save__student")).Click();
                return this;
            }
        }

        public string SaveEditStudentButtonText()
        {
            try
            {
                return FindButton(By.Id("save__student")).GetText();
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("save__student")).GetText();
            }
        }

        public string SaveEditStudentButtonColour()
        {
            try
            {
                return FindButton(By.Id("save__student")).GetFromCSSAttribute("color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("save__student")).GetFromCSSAttribute("color");
            }
        }

        public string SaveEditStudentButtonBackgroundColour()
        {
            try
            {
                return FindButton(By.Id("save__student")).GetFromCSSAttribute("background-color");
            }
            catch(ElementClickInterceptedException)
            {
                return FindButton(By.Id("save__student")).GetFromCSSAttribute("background-color");
            }
        }

        public bool FirstNameDisabled()
        {
            try
            {
                WaitFor.WaitForElementToBeVisiable(driver, By.XPath("//*[@id='firstName'][@disabled='']"));
            } catch(WebDriverTimeoutException) {
                return false;
            }
            return IsElement.Present(driver, By.XPath("//*[@id='firstName'][@disabled='']"));
        }

        public bool GetMiddleNameDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='middleName'][@disabled='']"));
        }

        public bool GetLastNameDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='lastName'][@disabled='']"));
        }

        public bool GetSuffixDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='suffix'][@disabled='']"));
        }

        public bool GetFleidNumberDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='FleidNo'][@disabled='']"));
        }

        public bool GetDOBDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='dateOfBirth'][@disabled='']"));
        }

        public bool GetGenderDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='gender'][@disabled='']"));
        }

        public bool GetEthnicityDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='ethnicity'][@disabled='']"));
        }

        public bool GetRelationshipToYouDisabled()
        {
            return IsElement.Present(driver, By.XPath("//*[@id='relationshipToGuardian'][@disabled='']"));
        }

    }
}
