using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework;
using OpenQA.Selenium;

namespace FTC.OLA.Automation.Pages
{
    public class SummaryOfApplicationPage : ApplicationWizardPage
    {
        public Text TotalHouseholdMembers { get; private set; }
        public Text TotalHouseholdIncome { get; private set; }
        public Text PrintTheFaxCoverSheetLink { get; private set; }
        public Button ScholarshipButton { get; private set; }
        public Button ConfirmIncomeButton { get; private set; }
		public Button FaxConfirmationYES { get; private set; }
		public Button FaxConfirmationNO { get; private set; }
        public Button ClickHereNoDocumentsRequiredLink { get; private set; }
        public Button NoDocumentConfirmationYES { get; private set; }
        public Button NoDocumentConfirmationNO { get; private set; }
        public Text HouseholdFoodStampsLink { get; private set; }
        public Text PrimaryParentProofOfResidencyLink { get; private set; }
        public Text PrimaryParentAssistanceCashLink { get; private set; }
        public Text PrimaryParentAssistanceChurchFamilyFriendsLink { get; private set; }
        public Text PrimaryParentFamilyIncomeAdoptionLink { get; private set; }
        public Text PrimaryParentFamilyIncomeAlimonyLink { get; private set; }
        public Text PrimaryParentFamiyIncomeChildSupportLink { get; private set; }
        public Text PrimaryParentFamilyIncomeFosterOOHCLink { get; private set; }
        public Text PrimaryParentOtherIncomeAnnuitiesAndRoyaltiesLink { get; private set; }
        public Text PrimaryParentOtherIncomeCashWithdrawalLink { get; private set; }
        public Text PrimaryParentOtherIncomeInterestDividendLink { get; private set; }
        public Text PrimaryParentOtherIncomeNetRentalLink { get; private set; }
        public Text PrimaryParentOtherIncomePensionLink { get; private set; }
        public Text PrimaryParentOtherIncomeRoommateRentLink { get; private set; }
        public Text PrimaryParentSocialSecurityIncomeYouLink { get; private set; }
        public Text PrimaryParentSocialSecurityIncomeYourChildrenLink { get; private set; }
        public Text PrimaryParentSocialSecurityIncomeSupplementalSecurityIncomeLink { get; private set; }
        public Text PrimaryParentUnemploymentIncomeStrikeBenefitsLink { get; private set; }
        public Text PrimaryParentUnemploymentIncomeUnemploymentCompensationLink { get; private set; }
        public Text PrimaryParentUnemploymentIncomeWorkersCompensationLink { get; private set; }
        public Text PrimaryParentJobEmploymentChecksLink { get; private set; }
        public Text PrimaryParentJobEmploymentCashLink { get; private set; }
        public Text PrimaryParentJobEmploymentSelfOwnedLink { get; private set; }
        public Text SecondaryParentProofOfResidencyLink { get; private set; }
        public Text SecondaryParentAssistanceCashLink { get; private set; }
        public Text SecondaryParentAssistanceChurchFamilyFriendsLink { get; private set; }
        public Text SecondaryParentFamilyIncomeAdoptionLink { get; private set; }
        public Text SecondaryParentFamilyIncomeAlimonyLink { get; private set; }
        public Text SecondaryParentFamiyIncomeChildSupportLink { get; private set; }
        public Text SecondaryParentFamilyIncomeFosterOOHCLink { get; private set; }
        public Text SecondaryParentOtherIncomeAnnuitiesAndRoyaltiesLink { get; private set; }
        public Text SecondaryParentOtherIncomeCashWithdrawalLink { get; private set; }
        public Text SecondaryParentOtherIncomeInterestDividendLink { get; private set; }
        public Text SecondaryParentOtherIncomeNetRentalLink { get; private set; }
        public Text SecondaryParentOtherIncomePensionLink { get; private set; }
        public Text SecondaryParentOtherIncomeRoommateRentLink { get; private set; }
        public Text SecondaryParentSocialSecurityIncomeYouLink { get; private set; }
        public Text SecondaryParentSocialSecurityIncomeYourChildrenLink { get; private set; }
        public Text SecondaryParentSocialSecurityIncomeSupplementalSecurityIncomeLink { get; private set; }
        public Text SecondaryParentUnemploymentIncomeStrikeBenefitsLink { get; private set; }
        public Text SecondaryParentUnemploymentIncomeUnemploymentCompensationLink { get; private set; }
        public Text SecondaryParentUnemploymentIncomeWorkersCompensationLink { get; private set; }
        public Text SecondaryParentJobEmploymentChecksLink { get; private set; }
        public Text SecondaryParentJobEmploymentCashLink { get; private set; }
        public Text SecondaryParentJobEmploymentSelfOwnedLink { get; private set; }
        public Text OtherAdultProofOfResidencyLink { get; private set; }
        public Text OtherAdultAssistanceCashLink { get; private set; }
        public Text OtherAdultAssistanceChurchFamilyFriendsLink { get; private set; }
        public Text OtherAdultFamilyIncomeAdoptionLink { get; private set; }
        public Text OtherAdultFamilyIncomeAlimonyLink { get; private set; }
        public Text OtherAdultFamiyIncomeChildSupportLink { get; private set; }
        public Text OtherAdultFamilyIncomeFosterOOHCLink { get; private set; }
        public Text OtherAdultOtherIncomeAnnuitiesAndRoyaltiesLink { get; private set; }
        public Text OtherAdultOtherIncomeCashWithdrawalLink { get; private set; }
        public Text OtherAdultOtherIncomeInterestDividendLink { get; private set; }
        public Text OtherAdultOtherIncomeNetRentalLink { get; private set; }
        public Text OtherAdultOtherIncomePensionLink { get; private set; }
        public Text OtherAdultOtherIncomeRoommateRentLink { get; private set; }
        public Text OtherAdultSocialSecurityIncomeYouLink { get; private set; }
        public Text OtherAdultSocialSecurityIncomeYourChildrenLink { get; private set; }
        public Text OtherAdultSocialSecurityIncomeSupplementalSecurityIncomeLink { get; private set; }
        public Text OtherAdultUnemploymentIncomeStrikeBenefitsLink { get; private set; }
        public Text OtherAdultUnemploymentIncomeUnemploymentCompensationLink { get; private set; }
        public Text OtherAdultUnemploymentIncomeWorkersCompensationLink { get; private set; }
        public Text OtherAdultJobEmploymentChecksLink { get; private set; }
        public Text OtherAdultJobEmploymentCashLink { get; private set; }
        public Text OtherAdultJobEmploymentSelfOwnedLink { get; private set; }
        public Text Student1FosterUploadLink { get; private set; }
        public Text Student1BirthCertificateUploadLink { get; private set; }
        public Text Student1ReportCardLink { get; private set; }
        public Text Student1OutOfHomeCareUploadLink { get; private set; }
        public Text Student2FosterUploadLink { get; private set; }
        public Text Student2BirthCertificateUploadLink { get; private set; }
        public Text Student2ReportCardLink { get; private set; }
        public Text Student2OutOfHomeCareUploadLink { get; private set; }
        public Text Student3FosterUploadLink { get; private set; }
        public Text Student3BirthCertificateUploadLink { get; private set; }
        public Text Student3ReportCardLink { get; private set; }
        public Text Student3OutOfHomeCareUploadLink { get; private set; }

        public SummaryOfApplicationPage(IWebDriver driver)
            : base(driver)
        {
            TotalHouseholdMembers = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > application-summary-container > application-summary > div > div.total-section.hide-on-small-only > div:nth-child(1) > div.col.l8"));
            TotalHouseholdIncome = new Text(Driver, By.CssSelector("body > app-root > div:nth-child(2) > section-summary-screen > div > div > div > div > div.card-content > application-summary-container > application-summary > div > div.total-section.hide-on-small-only > div:nth-child(2) > div.col.s4.l8"));
            PrintTheFaxCoverSheetLink = new Text(Driver, By.XPath("//a[text() = 'print the fax cover sheet']"));
            //PrintTheFaxCoverSheetLink = new Text(Driver, By.XPath("//*[contains(@href, 'javascript:void(0);')]"));
            ScholarshipButton = new Button(Driver, By.XPath("//span[text() = 'Scholarship']"));
            ConfirmIncomeButton = new Button(Driver, By.XPath("//span[text() = 'Confirm Income']"));
			FaxConfirmationYES = new Button(Driver, By.XPath("//a[text() = 'Yes']"));
			FaxConfirmationNO = new Button(Driver, By.XPath("//a[text() = 'No']"));
            ClickHereNoDocumentsRequiredLink = new Button(Driver, By.XPath("//a[text() = 'here']"));
            NoDocumentConfirmationYES = new Button(Driver, By.XPath("//a[text() = 'Yes']"));
            NoDocumentConfirmationNO = new Button(Driver, By.XPath("//a[text() = 'No']"));
            HouseholdFoodStampsLink = new Text(Driver, By.XPath("//*[contains(@href, 'scholarship/food-stamps')]"));
            PrimaryParentProofOfResidencyLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/parent-proof-of-residency')]"));
            PrimaryParentAssistanceCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/assistance-cash')]"));
            PrimaryParentAssistanceChurchFamilyFriendsLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/assistance-church-family-friends')]"));
            PrimaryParentFamilyIncomeAdoptionLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/family-income-adoption')]"));
            PrimaryParentFamilyIncomeAlimonyLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/family-income-alimony')]"));
            PrimaryParentFamiyIncomeChildSupportLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/child-support')]"));
            PrimaryParentFamilyIncomeFosterOOHCLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/family-income-foster-oohc')]"));
            PrimaryParentOtherIncomeAnnuitiesAndRoyaltiesLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-annuities-royalties')]"));
            PrimaryParentOtherIncomeCashWithdrawalLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-cash-withdrawal')]"));
            PrimaryParentOtherIncomeInterestDividendLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-interest-dividend')]"));
            PrimaryParentOtherIncomeNetRentalLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-net-rental')]"));
            PrimaryParentOtherIncomePensionLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-pension')]"));
            PrimaryParentOtherIncomeRoommateRentLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/other-income-roommate-rent')]"));
            PrimaryParentSocialSecurityIncomeYouLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/social-security-income-you')]"));
            PrimaryParentSocialSecurityIncomeYourChildrenLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/social-security-income-your-children')]"));
            PrimaryParentSocialSecurityIncomeSupplementalSecurityIncomeLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/assistance-security')]"));
            PrimaryParentUnemploymentIncomeStrikeBenefitsLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/unemployment-income-strike-benefits')]"));
            PrimaryParentUnemploymentIncomeUnemploymentCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/unemployment-income-unemployment-compensation')]"));
            PrimaryParentUnemploymentIncomeWorkersCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'primary/unemployment-income-workers-compensation')]"));
            PrimaryParentJobEmploymentChecksLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-1/job-employment-income-checks')]"));
            PrimaryParentJobEmploymentCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-1/job-employment-income-cash')]"));
            PrimaryParentJobEmploymentSelfOwnedLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-2/job-employment-income-self-owned')]"));
            SecondaryParentProofOfResidencyLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/parent-proof-of-residency')]"));
            SecondaryParentAssistanceCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/assistance-cash')]"));
            SecondaryParentAssistanceChurchFamilyFriendsLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/assistance-church-family-friends')]"));
            SecondaryParentFamilyIncomeAdoptionLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/family-income-adoption')]"));
            SecondaryParentFamilyIncomeAlimonyLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/family-income-alimony')]"));
            SecondaryParentFamiyIncomeChildSupportLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/child-support')]"));
            SecondaryParentFamilyIncomeFosterOOHCLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/family-income-foster-oohc')]"));
            SecondaryParentOtherIncomeAnnuitiesAndRoyaltiesLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-annuities-royalties')]"));
            SecondaryParentOtherIncomeCashWithdrawalLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-cash-withdrawal')]"));
            SecondaryParentOtherIncomeInterestDividendLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-interest-dividend')]"));
            SecondaryParentOtherIncomeNetRentalLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-net-rental')]"));
            SecondaryParentOtherIncomePensionLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-pension')]"));
            SecondaryParentOtherIncomeRoommateRentLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/other-income-roommate-rent')]"));
            SecondaryParentSocialSecurityIncomeYouLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/social-security-income-you')]"));
            SecondaryParentSocialSecurityIncomeYourChildrenLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/social-security-income-your-children')]"));
            SecondaryParentSocialSecurityIncomeSupplementalSecurityIncomeLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/assistance-security')]"));
            SecondaryParentUnemploymentIncomeStrikeBenefitsLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/unemployment-income-strike-benefits')]"));
            SecondaryParentUnemploymentIncomeUnemploymentCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/unemployment-income-unemployment-compensation')]"));
            SecondaryParentUnemploymentIncomeWorkersCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'secondary/unemployment-income-workers-compensation')]"));
            SecondaryParentJobEmploymentChecksLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-3/job-employment-income-checks')]"));
            SecondaryParentJobEmploymentCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-3/job-employment-income-cash')]"));
            SecondaryParentJobEmploymentSelfOwnedLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-4/job-employment-income-self-owned')]"));
            OtherAdultProofOfResidencyLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/household-proof-of-residency')]"));
            OtherAdultAssistanceCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/assistance-cash')]"));
            OtherAdultAssistanceChurchFamilyFriendsLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/assistance-church-family-friends')]"));
            OtherAdultFamilyIncomeAdoptionLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/family-income-adoption')]"));
            OtherAdultFamilyIncomeAlimonyLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/family-income-alimony')]"));
            OtherAdultFamiyIncomeChildSupportLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/child-support')]"));
            OtherAdultFamilyIncomeFosterOOHCLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/family-income-foster-oohc')]"));
            OtherAdultOtherIncomeAnnuitiesAndRoyaltiesLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-annuities-royalties')]"));
            OtherAdultOtherIncomeCashWithdrawalLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-cash-withdrawal')]"));
            OtherAdultOtherIncomeInterestDividendLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-interest-dividend')]"));
            OtherAdultOtherIncomeNetRentalLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-net-rental')]"));
            OtherAdultOtherIncomePensionLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-pension')]"));
            OtherAdultOtherIncomeRoommateRentLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/other-income-roommate-rent')]"));
            OtherAdultSocialSecurityIncomeYouLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/social-security-income-you')]"));
            OtherAdultSocialSecurityIncomeYourChildrenLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/social-security-income-your-children')]"));
            OtherAdultSocialSecurityIncomeSupplementalSecurityIncomeLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/assistance-security')]"));
            OtherAdultUnemploymentIncomeStrikeBenefitsLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/unemployment-income-strike-benefits')]"));
            OtherAdultUnemploymentIncomeUnemploymentCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/unemployment-income-unemployment-compensation')]"));
            OtherAdultUnemploymentIncomeWorkersCompensationLink = new Text(Driver, By.XPath("//*[contains(@href, 'member-1/unemployment-income-workers-compensation')]"));
            OtherAdultJobEmploymentChecksLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-5/job-employment-income-checks')]"));
            OtherAdultJobEmploymentCashLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-5/job-employment-income-cash')]"));
            OtherAdultJobEmploymentSelfOwnedLink = new Text(Driver, By.XPath("//*[contains(@href, 'job-6/job-employment-income-self-owned')]"));
            Student1FosterUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/student-foster-upload')]"));
            Student1BirthCertificateUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/student-birth-certificate-upload')]"));
            Student1ReportCardLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/student-report-card')]"));
            Student1OutOfHomeCareUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-1/student-out-of-home-care-upload')]"));
            Student2FosterUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-2/student-foster-upload')]"));
            Student2BirthCertificateUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-2/student-birth-certificate-upload')]"));
            Student2ReportCardLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-2/student-report-card')]"));
            Student2OutOfHomeCareUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-2/student-out-of-home-care-upload')]"));
            Student3FosterUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-3/student-foster-upload')]"));
            Student3BirthCertificateUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-3/student-birth-certificate-upload')]"));
            Student3ReportCardLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-3/student-report-card')]"));
            Student3OutOfHomeCareUploadLink = new Text(Driver, By.XPath("//*[contains(@href, 'student-3/student-out-of-home-care-upload')]"));
        }
    }
}
