using System;
using System.Threading;
using Interfaces;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;

namespace SidePanelDashboard
{
    public class FTC_Application : Widget
    {
        public FTC_Application(IWebDriver driver) : base(driver)
        {
        }

        public String getHeader()
        {
            return FindText(By.XPath("(//h2)[1]")).GetText();
        }
        public DateTime GetYear(string year)
        {
            System.DateTime moment = new System.DateTime();
            if(year.Equals("Current"))
            {
                return moment.AddYears(0);
            } else if (year.Equals("Next"))
            {
                return moment.AddYears(+1);
            }

            return moment.AddYears(0);
        }

        public FTC_Application SelectAuthorityHouseholdMemeber(string authority)
        {
            try
            {
                if(authority.Equals("Yes"))
                {
                    FindCheckBox(By.XPath("//label[text()='" + authority + "']//..//input[@type='radio']")).Click();
                }
            } catch (ElementClickInterceptedException)
            {
                if(authority.Equals("Yes"))
                {
                    FindCheckBox(By.XPath("//label[text()='" + authority + "']//..//input[@type='radio']")).Click();
                }
            }
            return this;
        }

        public FTC_Application ClickStudentApplyingFor()
        {
            FindButton(By.XPath("//div[@class='student-list-grid']//..//*[@type='checkbox']")).Click();
            return this;
        }

        public FTC_Application ClickContinue()
        {
            try
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("//button[contains(text(),'Continue')]")));
                FindButton(By.XPath("//button[contains(text(),'Continue')]")).Click();
            } catch (NoSuchElementException)
            {
                MoveTo.Element(driver, driver.FindElement(By.XPath("//button[contains(text(),'CONTINUE')]")));
                FindButton(By.XPath("//button[contains(text(),'CONTINUE')]")).Click();
            }
            return this;
        }

        public FTC_Application ClickStudent(string student)
        {
            FindText(By.XPath("//*[contains(.,'"+student+"')][@aria-expanded='false']")).Click();
            return this;
        }

        public FTC_Application SelectRelationshipToGuardian(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'relationshipToGuardian')]")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearSSNITIN()
        {
            FindTextField(By.XPath("//label[contains(.,'SSN / ITIN')]//..//input")).Clear();
            return this;
        }

        public FTC_Application TypeSSNITIN(string SSNITIN)
        {
            FindTextField(By.XPath("//label[contains(.,'SSN / ITIN')]//..//input")).Type(SSNITIN);
            return this;
        }

        public FTC_Application SelectTypeOfSchool(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'Current__SchoolType')]")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearSchoolName()
        {
            try
            {
                FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Clear();
            }
            catch (InvalidElementStateException)
            {
                FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Clear();
            }
            return this;
        }

        public FTC_Application TypeSchoolName(string schoolName)
        {
            FindTextField(By.XPath("//input[contains(@id,'Current__SchoolName')]")).Type(schoolName);
            return this;
        }

        public FTC_Application SelectSchoolCounty(string option)
        {
                FindTextField(By.XPath("//div[contains(@id,'Current__SchoolCounty')]")).Click();
            FindTextField(By.XPath("//div[contains(@id,'popup')][contains(@style,'display: block')]//input[contains(@id,'search')]")).Type(option);
            Thread.Sleep(1000);
            FindText(By.XPath("//li[contains(@aria-label,'" + option + "')]")).Click();
            return this;
        }

        public FTC_Application SelectScholarshipForTransportation(string transportation)
        {
            if (transportation.Equals("Yes"))
            {
                FindCheckBox(By.XPath("//input[contains(@id,'additional_information')][@value='True']")).Click();
            } else
            {
                FindCheckBox(By.XPath("//input[contains(@id,'additional_information')][@value='False']")).Click();
            }
            return this;
        }

        public FTC_Application SelectGradeLevel(string option)
        {
            FindDropdown(By.XPath("//select[contains(@id,'Expected__GradeLevel')]")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectPartcipatingUA(string partcipatingUA)
        {
            if(partcipatingUA.Equals("Yes"))
            {
                FindCheckBox(By.XPath("//input[contains(@id,'HasSiblingsFES_')][@value='True']")).Click();
            }
            else
            {
                FindCheckBox(By.XPath("//input[contains(@id,'HasSiblingsFES_')][@value='False']")).Click();
            }
            return this;
        }

        public FTC_Application ClearUAID()
        {
            FindTextField(By.Id("SiblingsFES")).Clear();
            return this;
        }

        public FTC_Application TypeUAID(string uaid)
        {
            FindTextField(By.Id("SiblingsFES")).Type(uaid);
            return this;
        }

        public FTC_Application SelectStudentAdopted(string adopted)
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

        public FTC_Application SelectFosterCare(string fosterCare)
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

        public FTC_Application SelectOutOfHomeCare(string OutOfHomeCare)
        {
            if(OutOfHomeCare.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__2")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__2")).Click();
            }
            return this;
        }

        public FTC_Application SelectUSArmedForces(string usarmedforces)
        {
            if(usarmedforces.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__3")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__3")).Click();
            }
            return this;
        }

        public FTC_Application SelectLawEnforcement(string lawenforcement)
        {
            if(lawenforcement.Equals("Yes"))
            {
                FindCheckBox(By.Id("true_0__4")).Click();
            }
            else
            {
                FindCheckBox(By.Id("false_0__4")).Click();
            }
            return this;
        }

        public FTC_Application ClearDocumentationName()
        {
            FindTextField(By.XPath("//div[@class='inline-file-upload']//input")).Clear();
            return this;
        }

        public FTC_Application TypeDocumentationName(string documentname)
        {
            FindTextField(By.XPath("//div[@class='inline-file-upload']//input")).Type(documentname);
            Thread.Sleep(500);
            FindText(By.XPath("(//div[contains(@class,'alert')])[2]")).Click();
            return this;
        }

        public FTC_Application TypeUpload(string pathtofile)
        {
            Thread.Sleep(1000);
            FindImport(By.XPath("(//div[@class='inline-file-upload']//input[@type='file'])[1]"), pathtofile);
            Thread.Sleep(1000);
            return this;
        }

        public FTC_Application ClickSaveAsDraft()
        {
            FindButton(By.XPath("//button[contains(text(),'SAVE AS DRAFT')]")).Click();
            return this;
        }

        public FTC_Application ClickGuardian(string Open)
        {
            if (Open.Equals("Open")) {
                FindText(By.XPath("//*[contains(.,'Primary Guardian')][@aria-expanded='false']")).Click();
            } else if (Open.Equals("Close"))
            {
                FindText(By.XPath("//*[contains(.,'Primary Guardian')][@aria-expanded='true']")).Click();
            }
            return this;
        }

        public FTC_Application ClickSpousePartner(string Open)
        {
            if(Open.Equals("Open")) {
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

        public FTC_Application SelectProofDocumentationType(string option)
        {
            FindDropdown(By.Id("typeOfDocument")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectEmploymentIncome(string option)
        {
            FindDropdown(By.Id("employmentInformation")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectPartnersEmploymentIncome(string option)
        {
            FindDropdown(By.XPath("(//*[@id='employmentInformation'])[2]")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearEmployerCompanyName()
        {
            FindTextField(By.XPath("(//input[@id='middleName'])[2]")).Clear();
            return this;
        }

        public FTC_Application TypeEmployerCompanyName(string employerName)
        {
            FindTextField(By.XPath("(//input[@id='middleName'])[2]")).Type(employerName);
            return this;
        }

        public FTC_Application SelectEmploymentRole(string EmploymentRole)
        {
            if(EmploymentRole.Equals("Employed"))
            {
                FindCheckBox(By.Id("employed_radio")).Click();
            }
            else
            {
                FindCheckBox(By.Id("selfemployed_radio")).Click();
            }
            return this;
        }

        public FTC_Application SelectPaidByChequeOrDirectDeposit(string paidBy)
        {
            if(paidBy.Equals("Yes"))
            {
                FindCheckBox(By.Id("paid_by_check_or_deposit_true")).Click();
            }
            else
            {
                FindCheckBox(By.Id("paid_by_check_or_deposit_false")).Click();
            }
            return this;
        }

        public FTC_Application ClearDDPaymentAmount()
        {
            FindTextField(By.XPath("//*[@id='ddi_incomeAmount']//*[@type='text']")).Clear();
            return this;
        }

        public FTC_Application TypeDDPaymentAmount(string DDPaymentAmount)
        {
            FindTextField(By.XPath("//*[@id='ddi_incomeAmount']//*[@type='text']")).Type(DDPaymentAmount);
            return this;
        }

        public FTC_Application SelectDDPaidHowOften(string option)
        {
            FindDropdown(By.Id("incomeFrequency")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectPaidInCash(string cashPayment)
        {
            if(cashPayment.Equals("Yes"))
            {
                FindCheckBox(By.Id("paid_in_cash_true")).Click();
            }
            else
            {
                FindCheckBox(By.Id("paid_in_cash_false")).Click();
            }
            return this;
        }

        public FTC_Application ClearCashPaymentAmount()
        {
            FindTextField(By.XPath("//*[@id='cdi_incomeAmount']//*[@type='text']")).Clear();
            return this;
        }

        public FTC_Application TypeCashPaymentAmount(string CashPaymentAmount)
        {
            FindTextField(By.XPath("//*[@id='cdi_incomeAmount']//*[@type='text']")).Type(CashPaymentAmount);
            return this;
        }

        public FTC_Application SelectCashPaidHowOften(string option)
        {
            FindDropdown(By.Id("incomeFrequencyCash")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearPartnerEmployerCompanyName()
        {
            FindTextField(By.XPath("(//input[@id='middleName'])[3]")).Clear();
            return this;
        }

        public FTC_Application TypePartnerEmployerCompanyName(string employerName)
        {
            FindTextField(By.XPath("(//input[@id='middleName'])[3]")).Type(employerName);
            return this;
        }

        public FTC_Application SelectPartnerEmploymentRole(string EmploymentRole)
        {
            if(EmploymentRole.Equals("Employed"))
            {
                FindCheckBox(By.XPath("(//input[@id='employed_radio'])[2]")).Click();
            }
            else
            {
                FindCheckBox(By.XPath("(//input[@id='selfemployed_radio'])[2]")).Click();
            }
            return this;
        }

        public FTC_Application SelectPartnerPaidByChequeOrDirectDeposit(string paidBy)
        {
            if(paidBy.Equals("Yes"))
            {
                FindCheckBox(By.XPath("(//input[@id='paid_by_check_or_deposit_true'])[2]")).Click();
            }
            else
            {
                FindCheckBox(By.XPath("(//input[@id='paid_by_check_or_deposit_false'])[2]")).Click();
            }
            return this;
        }

        public FTC_Application ClearPartnerDDPaymentAmount()
        {
            try
            {
                FindTextField(By.XPath("(//*[@id='ddi_incomeAmount']//*[@type='text'])[2]")).Clear();
            } catch (NoSuchElementException)
            {
                FindTextField(By.XPath("//*[@id='ddi_incomeAmount']//*[@type='text']")).Clear();
            }
            return this;
        }

        public FTC_Application TypePartnerDDPaymentAmount(string DDPaymentAmount)
        {
            try
            {
                FindTextField(By.XPath("(//*[@id='ddi_incomeAmount']//*[@type='text'])[2]")).Type(DDPaymentAmount);
            }
            catch(NoSuchElementException)
            {
                FindTextField(By.XPath("//*[@id='ddi_incomeAmount']//*[@type='text']")).Type(DDPaymentAmount);
            }
            return this;
        }

        public FTC_Application SelectPartnerDDPaidHowOften(string option)
        {
            FindDropdown(By.XPath("(//*[@id='incomeFrequency'])[2]")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectPartnerPaidInCash(string cashPayment)
        {
            if(cashPayment.Equals("Yes"))
            {
                FindCheckBox(By.XPath("(//*[@id='paid_in_cash_true'])[2]")).Click();
            }
            else
            {
                FindCheckBox(By.XPath("(//*[@id='paid_in_cash_false'])[2]")).Click();
            }
            return this;
        }

        public FTC_Application ClearPartnerCashPaymentAmount()
        {
            try
            {
                FindTextField(By.XPath("(//*[@id='cdi_incomeAmount']//*[@type='text'])[2]")).Clear();
            }
            catch(NoSuchElementException)
            {
                FindTextField(By.XPath("//*[@id='cdi_incomeAmount']//*[@type='text']")).Clear();
            }
            return this;
        }

        public FTC_Application TypePartnerCashPaymentAmount(string CashPaymentAmount)
        {
            try
            {
                FindTextField(By.XPath("(//*[@id='cdi_incomeAmount']//*[@type='text'])[2]")).Type(CashPaymentAmount);
            }
            catch(NoSuchElementException)
            {
                FindTextField(By.XPath("//*[@id='cdi_incomeAmount']//*[@type='text']")).Type(CashPaymentAmount);
            }
            return this;
        }

        public FTC_Application SelectPartnerCashPaidHowOften(string option)
        {
            FindDropdown(By.XPath("//*[@id='incomeFrequencyCash']")).SelectOption(option);
            return this;
        }

        public FTC_Application ClickAdditionalIncomeSources()
        {
            FindText(By.XPath("//button[contains(text(),'+')]")).Click();
            return this;
        }

        public FTC_Application SelectAdditionalIncome(string option)
        {
            FindDropdown(By.Id("additional_income")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectAnnualIncomeCategory(string option)
        {
            FindDropdown(By.Id("additional_income_category")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearOtherIncomeAmountMonthly()
        {
            FindTextField(By.XPath("(//*[@id='payment_amount']//*[@type='text'])[1]")).Clear();
            return this;
        }

        public FTC_Application TypeOtherIncomeAmountMonthly(string otherIncome)
        {
            FindTextField(By.XPath("(//*[@id='payment_amount']//*[@type='text'])[1]")).Type(otherIncome);
            return this;
        }

        public FTC_Application SelectIncomeVerificationDocument(string option)
        {
            FindDropdown(By.XPath("(//*[@id='typeOfDocument'])[1]")).SelectOption(option);
            return this;
        }

        public FTC_Application TypeIncomeVerificationDocument(string pathtofile)
        {
            FindTextField(By.XPath("(//button[contains(text(),'UPLOAD')])[1]")).Type(pathtofile);
            return this;
        }

        public FTC_Application SelectSNAPTANFFDPIR(string SNAPTANFFDPIR)
        {
            if(SNAPTANFFDPIR.Equals("Yes"))
            {
                FindCheckBox(By.Id("additional_information_true")).Click();
            }
            else
            {
                FindCheckBox(By.Id("additional_information_false")).Click();
            }
            return this;
        }

        public FTC_Application SelectIHaveA(string option)
        {
            FindDropdown(By.XPath("(//*[@id='employmentInformation'])[1]")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearProofOfDocument()
        {
            FindTextField(By.XPath("//div[@class='inline-file-upload']//input")).Clear();
            return this;
        }

        public FTC_Application TypeProofOfDocument(string ProofOfDocument)
        {
            FindTextField(By.XPath("//div[@class='inline-file-upload']//input")).Type(ProofOfDocument);
            return this;
        }

        public FTC_Application TypeUploadAdditionalInformation(string pathtofile)
        {
            FindTextField(By.XPath("(//div[@class='inline-file-upload'])[3]")).Type(pathtofile);
            return this;
        }

        public FTC_Application ClickHouseHoldMember()
        {
            FindCheckBox(By.XPath("//input[@type='checkbox']")).Click();
            return this;
        }

        public FTC_Application ClickAddMember()
        {
            FindCheckBox(By.Id("AddMember__Button")).Click();
            return this;
        }

        public FTC_Application ClickNewHouseHoldmember()
        {
            FindText(By.XPath("(//*[contains(.,'')][@aria-expanded='false'])[3]")).Click();
            return this;
        }

        public FTC_Application ClearFirstName()
        {
            FindTextField(By.Id("firstName")).Clear();
            return this;
        }

        public FTC_Application TypeFirstName(string firstname)
        {
            FindTextField(By.Id("firstName")).Type(firstname);
            return this;
        }

        public FTC_Application ClearMiddleName()
        {
            FindTextField(By.Id("middleName")).Clear();
            return this;
        }

        public FTC_Application TypeMiddleName(string middlename)
        {
            FindTextField(By.Id("middleName")).Type(middlename);
            return this;
        }

        public FTC_Application ClearLastName()
        {
            FindTextField(By.Id("lastName")).Clear();
            return this;
        }

        public FTC_Application TypeLastName(string lastname)
        {
            FindTextField(By.Id("lastName")).Type(lastname);
            return this;
        }

        public FTC_Application ClearPartnerFirstName()
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[1]")).Clear();
            return this;
        }

        public FTC_Application TypePartnerFirstName(string firstname)
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[1]")).Type(firstname);
            return this;
        }

        public FTC_Application ClearPartnerMiddleName()
        {
            FindTextField(By.Id("partnermiddleName")).Clear();
            return this;
        }

        public FTC_Application TypePartnerMiddleName(string middlename)
        {
            FindTextField(By.Id("partnermiddleName")).Type(middlename);
            return this;
        }

        public FTC_Application ClearPartnerLastName()
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[2]")).Clear();
            return this;
        }

        public FTC_Application TypePartnerLastName(string lastname)
        {
            FindTextField(By.XPath("(//input[@id='partnerfirstName'])[2]")).Type(lastname);
            return this;
        }

        public FTC_Application SelectSuffix(string option)
        {
            FindDropdown(By.Id("suffix")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectPartnerSuffix(string option)
        {
            FindDropdown(By.Id("partnersuffix")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearPartnerPhonePrimary()
        {
            FindTextField(By.XPath("(//*[@placeholder='(000) 000-0000'])[3]")).Clear();
            return this;
        }

        public FTC_Application TypePartnerPhonePrimary(string phone)
        {
            FindTextField(By.XPath("(//*[@placeholder='(000) 000-0000'])[3]")).Type(phone);
            return this;
        }

        public FTC_Application SelectPartnerPhoneType(string option)
        {
            FindDropdown(By.XPath("(//*[@id='primaryPhoneType'])[2]")).SelectOption(option);
            return this;
        }

        public FTC_Application ClearPartnerSSN()
        {
            FindTextField(By.XPath("(//*[contains(@placeholder,'XXXX')])[2]")).Clear();
            return this;
        }

        public FTC_Application TypePartnerSSN(string ssn)
        {
            FindTextField(By.XPath("(//*[contains(@placeholder,'XXXX')])[2]")).Type(ssn);
            return this;
        }

        public FTC_Application SelectPartnerProofDocumentationType(string option)
        {
            try
            {
                FindDropdown(By.Id("typeOfDocument")).SelectOption(option);
            } catch (NoSuchElementException)
            {
                FindDropdown(By.XPath("(//*[@id='typeOfDocument'])[2]")).SelectOption(option);
            }
            return this;
        }

        public FTC_Application SelectPartnerIncomeVerificationDocument(string option)
        {
            FindDropdown(By.XPath("(//*[@id='typeOfDocument'])[3]")).SelectOption(option);
            return this;
        }

        public FTC_Application TypePartnerIncomeVerificationDocument(string pathtofile)
        {
            FindTextField(By.XPath("(//button[contains(text(),'UPLOAD')])[3]")).Type(pathtofile);
            return this;
        }

        public FTC_Application ClearDOB()
        {
            FindTextField(By.Id("dateOfBirth")).Clear();
            return this;
        }

        public FTC_Application TypeDOB(string dob)
        {
            FindTextField(By.Id("dateOfBirth")).Type(dob);
            return this;
        }

        public FTC_Application SelectRelationshipToYou(string option)
        {
            FindDropdown(By.Id("relationshipToGuardian")).SelectOption(option);
            return this;
        }

        public FTC_Application SelectHouseHoldRelationshipToYou(string option)
        {
            FindDropdown(By.Id("relationshipToMe")).SelectOption(option);
            return this;
        }


        public FTC_Application ClickAttestation0()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__0")).Click();
            } catch (NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation1()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__1")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation2()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__2")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation3()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__3")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation4()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__4")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation5()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__5")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation6()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__6")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation7()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__7")).Click();
            }
            catch(NoSuchElementException) { }
            return this;
        }

        public FTC_Application ClickAttestation8()
        {
            try
            {
                FindCheckBox(By.Id("Attestation__Check__8")).Click();
            }
            catch(WebDriverTimeoutException) { }
            return this;
        }


        public FTC_Application ClickComplianceStatement()
        {
            FindCheckBox(By.Id("ComplianceStatementAccepted")).Click();
            return this;
        }

        public FTC_Application ClearName()
        {
            FindTextField(By.Id("SignatureName")).Clear();
            return this;
        }

        public FTC_Application TypeName(string name)
        {
            FindTextField(By.Id("SignatureName")).Type(name);
            return this;
        }

        public FTC_Application Signature()
        {
            MoveTo.Signature(driver, driver.FindElement(By.Id("signature-pad--canvas")));
            return this;
        }

        public FTC_Application ClickKeep()
        {
            FindButton(By.XPath("//button[contains(text(),'Keep')]")).Click();
            return this;
        }

        public Dashboard_Dashboard ClickSubmit()
        {
            MoveTo.BottomOfPage(driver);
            FindButton(By.XPath("//button[contains(text(),'SUBMIT')]")).Click();
            WaitFor.InvisiabilityOfElement(driver, By.XPath("//button[contains(text(),'SUBMIT')]"));
            return new (driver);
        }


    }
}
