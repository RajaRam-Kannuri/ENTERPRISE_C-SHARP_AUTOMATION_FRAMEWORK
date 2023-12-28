using System;
using System.Threading;
using Interfaces;
using NLPLogix.Core.Abstract;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SidePanelDashboard
{
    public class UA_Application : Widget
    {
        public UA_Application(IWebDriver driver) : base(driver)
        {
        }

        public string getHeader()
        {
            return FindText(By.XPath("(//h2)[1]")).GetText();
        }

        public UA_Application ClickStudentApplyingFor()
        {
            FindButton(By.XPath("//div[@class='student-list-grid']//..//*[@type='checkbox']")).Click();
            return this;
        }

        public UA_Application ClickContinue()
        {
            try
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("//button[contains(text(),'Continue')]")));
                FindButton(By.XPath("//button[contains(text(),'Continue')]")).Click();
            }
            catch(NoSuchElementException)
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("//button[contains(text(),'CONTINUE')]")));
                FindButton(By.XPath("//button[contains(text(),'CONTINUE')]")).Click();
            }
            return this;
        }

        public UA_Application ClickStudent(string student)
        {
            FindText(By.XPath("//*[contains(.,'" + student + "')][@aria-expanded='false']")).Click();
            return this;
        }

        public UA_Application SelectRelationshipToGuardian(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'relationshipToGuardian')]")).SelectOption(option);
            return this;
        }

        public UA_Application ClearSSNITIN()
        {
            FindTextField(By.XPath("//label[contains(.,'SSN / ITIN')]//..//input")).Clear();
            return this;
        }

        public UA_Application TypeSSNITIN(string SSNITIN)
        {
            FindTextField(By.XPath("//label[contains(.,'SSN / ITIN')]//..//input")).Type(SSNITIN);
            return this;
        }

        public UA_Application SelectExpectedTypeOfSchool(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'Expected__SchoolType')]")).SelectOption(option);
            return this;
        }

        public UA_Application SelectExpectedGradeLevel(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'Expected__GradeLevel')]")).SelectOption(option);
            return this;
        }

        public UA_Application SelectCurrentTypeOfSchool(string option)
        {
            try
            {
                FindDropdown(By.XPath("//select[contains(@id,'Current__SchoolType')]")).SelectOption(option);
            }
            catch (InvalidElementStateException)
            {
                FindDropdown(By.XPath("//select[contains(@id,'Current__SchoolType')]")).SelectOption(option);
            }
            return this;
        }

        public UA_Application ClearCurrentSchoolName()
        {
            Thread.Sleep(1000);
            try
            {
                FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Clear();
            }
            catch(InvalidElementStateException)
            {
                FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Clear();
            }
            return this;
        }

        public UA_Application TypeCurrentSchoolName(string schoolName)
        {
            FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Type(schoolName);
            return this;
        }

        public UA_Application SelectCurrentSchoolCounty(string option)
        {
            FindTextField(By.XPath("//div[contains(@id,'Current__SchoolCounty')]")).Click();
            FindTextField(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//input[contains(@id,'search')]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisASpecificLearningDisability()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__0')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisAnaphylaxis()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__1')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisAutismSpectrumDisorder()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__2')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisCerebalPalsy()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__3')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisDownSyndrome()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__4')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisDualSensoryImpaired()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__5')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisEmotionalOrBehavioualDisability()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__6')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisHearingImpaired()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__7')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisHighRiskChild()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__8')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisHospitalOrHomebound()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__9')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisIntellectualDisability()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__10')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisLanguageImpairment()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__11')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisMusularDystrophy()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__12')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisOrthopedicImpairement()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__13')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisOtherHealthImpairment()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__14')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisPhelanMcDemidSyndrome()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__15')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisPraderWilliSyndrome()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__16')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisRareDiseases()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__17')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisSpeechImpairment()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__18')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisSpinaBifta()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__19')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisTraumaticBrainInjury()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__20')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisVisuallyImpaired()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__21')]")).Click();
            return this;
        }

        public UA_Application ClickDiagnosisWilliamsSyndrome()
        {
            FindCheckBox(By.XPath("//input[contains(@id,'Diagnosis__Check__22')]")).Click();
            return this;
        }

        public UA_Application ClearDiagnosisDocumentationName()
        {
            FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[1]")).Clear();
            return this;
        }

        public UA_Application TypeDiagnosisDocumentationName(string documentname)
        {
            FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[1]")).Type(documentname);
            Thread.Sleep(500);
            FindText(By.XPath("(//div[contains(@class,'alert')])[2]")).Click();
            return this;
        }

        public UA_Application TypeDiagnosisUpload(string pathtofile)
        {
            Thread.Sleep(1000);
            try
            {
                FindImport(By.XPath("(//label[contains(.,'UPLOAD')])[1]//..//*[@type='file']"), pathtofile);
            } catch (NoSuchElementException)
            {
                FindImport(By.XPath("(//button[contains(.,'UPLOAD')])[1]"), pathtofile);
            }
            Thread.Sleep(1000);
            return this;
        }

        public UA_Application SelectStudentAdopted(string adopted)
        {
            if(adopted.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__0")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__0")).Click();
            }
            return this;
        }

        public UA_Application SelectFosterCare(string fosterCare)
        {
            if(fosterCare.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__1")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__1")).Click();
            }
            return this;
        }

        public UA_Application SelectUSArmedForces(string usarmedforces)
        {
            if(usarmedforces.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__2")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__2")).Click();
            }
            return this;
        }

        public UA_Application SelectLawEnforcement(string lawenforcement)
        {
            if(lawenforcement.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__3")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__3")).Click();
            }
            return this;
        }

        public UA_Application ClearAdditionalInformationDocumentationName()
        {
            try
            {
                FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[1]")).Clear();
            } catch (NoSuchElementException)
            {
                FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[2]")).Clear();
            }
            return this;
        }

        public UA_Application TypeAdditionalInformationDocumentationName(string documentname)
        {
            try
            {
                FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[1]")).Type(documentname);
            }
            catch(NoSuchElementException)
            {
                FindTextField(By.XPath("(//div[@class='inline-file-upload']//input)[2]")).Type(documentname);
            }
            Thread.Sleep(500);
            FindText(By.XPath("(//div[contains(@class,'alert')])[2]")).Click();
            return this;
        }

        public UA_Application TypeAdditionalInformationUpload(string pathtofile)
        {
            Thread.Sleep(1000);
            try
            {
                FindImport(By.XPath("(//button[contains(.,'UPLOAD')])[1]"), pathtofile);
            }
            catch(NoSuchElementException)
            {
                FindImport(By.XPath("(//label[contains(.,'UPLOAD')])[1]//..//*[@type='file']"), pathtofile);
            }
            Thread.Sleep(1000);
            return this;
        }

        public UA_Application ClickGuardian(string Open)
        {
            if(Open.Equals("Open"))
            {
                FindText(By.XPath("//*[contains(.,'Primary Guardian')][@aria-expanded='false']")).Click();
            }
            else if(Open.Equals("Close"))
            {
                FindText(By.XPath("//*[contains(.,'Primary Guardian')][@aria-expanded='true']")).Click();
            }
            return this;
        }

        public UA_Application ClickSpousePartner(string Open)
        {
            if(Open.Equals("Open"))
            {
                FindText(By.XPath("//*[contains(.,'Spouse')][@aria-expanded='false']")).Click();
            }
            else if(Open.Equals("Close"))
            {
                FindText(By.XPath("//*[contains(.,'Spouse')][@aria-expanded='true']")).Click();
            }
            return this;
        }

        public Boolean DoesSpouseExist()
        {
            return IsElement.Present(driver, By.XPath("//*[@class='card-header '][contains(.,'Spouse')]"));
        }

        public UA_Application SelectProofDocumentationType(string option)
        {
            FindDropdown(By.Id("typeOfDocument")).SelectOption(option);
            return this;
        }

        public UA_Application TypeProofOfDocument(string ProofOfDocument)
        {
            Thread.Sleep(1000);
            try
            {
                FindImport(By.XPath("(//button[contains(.,'UPLOAD')])[1]"), ProofOfDocument);
            } catch (NoSuchElementException)
            {
                FindImport(By.XPath("(//label[contains(.,'UPLOAD')])[1]//..//*[@type='file']"), ProofOfDocument);
            }
            Thread.Sleep(1000);
            return this;
        }

        public UA_Application ClearFirstName()
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[1]")).Clear();
            return this;
        }

        public UA_Application TypeFirstName(string firstname)
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[1]")).Type(firstname);
            return this;
        }

        public UA_Application ClearMiddleName()
        {
            FindTextField(By.Id("partnermiddleName")).Clear();
            return this;
        }

        public UA_Application TypeMiddleName(string middlename)
        {
            FindTextField(By.Id("partnermiddleName")).Type(middlename);
            return this;
        }

        public UA_Application ClearLastName()
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[2]")).Clear();
            return this;
        }

        public UA_Application TypeLastName(string lastname)
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[2]")).Type(lastname);
            return this;
        }

        public UA_Application SelectPartnerSuffix(string option)
        {
            FindDropdown(By.Id("partnersuffix")).SelectOption(option);
            return this;
        }

        public UA_Application ClickAttestation0()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__0")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation1()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__1")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation2()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__2")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation3()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__3")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation4()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__4")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation5()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__5")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation6()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__6")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation7()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__7")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }

        public UA_Application ClickAttestation8()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__8")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }


        public UA_Application ClickComplianceStatement()
        {
            FindCheckBox(By.Id("ComplianceStatementAccepted")).Click();
            return this;
        }

        public UA_Application ClearName()
        {
            FindTextField(By.Id("SignatureName")).Clear();
            return this;
        }

        public UA_Application TypeName(string name)
        {
            FindTextField(By.Id("SignatureName")).Type(name);
            return this;
        }

        public UA_Application Signature()
        {
            MoveTo.Signature(driver, driver.FindElement(By.Id("signature-pad--canvas")));
            return this;
        }

        public UA_Application ClickKeep()
        {
            FindButton(By.XPath("//button[contains(text(),'Keep')]")).Click();
            return this;
        }

        public Dashboard_Dashboard ClickSubmit()
        {
            MoveTo.BottomOfPage(driver);
            FindButton(By.XPath("//button[contains(text(),'SUBMIT')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, By.XPath("//button[contains(text(),'SUBMIT')]"));
            return new(driver);
        }



    }
}
