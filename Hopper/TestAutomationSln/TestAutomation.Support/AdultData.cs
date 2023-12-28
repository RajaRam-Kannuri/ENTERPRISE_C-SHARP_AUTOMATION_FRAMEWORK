using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class AdultData
    {
        public int HouseholdMemberId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string ReceivingChildSupport { get; set; }

        public string RelationshipToPrimaryParent { get; set; }

        public string EmploymentStatus { get; set; }

        public string Employer { get; set; }

        public string IncomeChanges { get; set; }

        public decimal CheckWages { get; set; }

        public decimal CashWages { get; set; }

        public decimal NonWorkCompensation { get; set; }

        public decimal ChildSupport { get; set; }

        public decimal Alimony { get; set; }

        public decimal AdoptionBenefits { get; set; }

        public decimal PublicAssistance { get; set; }

        public decimal AdultSocialSecurity { get; set; }

        public decimal ChildSocialSecurity { get; set; }

        public decimal SupplementalSecurity { get; set; }

        public decimal Pension { get; set; }

        public decimal AllowanceBenefits { get; set; }

        public decimal DeployedServiceMember { get; set; }

        public decimal Annuities { get; set; }

        public decimal Interest { get; set; }

        public decimal MonthlyWithdrawals { get; set; }

        public decimal OutsideAssistance { get; set; }

        public decimal SelfEmployment { get; set; }

        public decimal NetRental { get; set; }

        public decimal OtherIncome { get; set; }

        public decimal FosterOOHC { get; set; }

        public AdultData()
        { }

        public AdultData(AdultData adult)
        {
            HouseholdMemberId = adult.HouseholdMemberId;
            FirstName = adult.FirstName;
            MiddleName = adult.MiddleName;
            LastName = adult.LastName;
            EmailAddress = adult.EmailAddress;
            ReceivingChildSupport = adult.ReceivingChildSupport;
            RelationshipToPrimaryParent = adult.RelationshipToPrimaryParent;
            EmploymentStatus = adult.EmploymentStatus;
            Employer = adult.Employer;
            IncomeChanges = adult.IncomeChanges;
            CheckWages = adult.CheckWages;
            CashWages = adult.CashWages;
            NonWorkCompensation = adult.NonWorkCompensation;
            ChildSupport = adult.ChildSupport;
            Alimony = adult.Alimony;
            AdoptionBenefits = adult.AdoptionBenefits;
            PublicAssistance = adult.PublicAssistance;
            AdultSocialSecurity = adult.AdultSocialSecurity;
            ChildSocialSecurity = adult.ChildSocialSecurity;
            SupplementalSecurity = adult.SupplementalSecurity;
            Pension = adult.Pension;
            AllowanceBenefits = adult.AllowanceBenefits;
            DeployedServiceMember = adult.DeployedServiceMember;
            Annuities = adult.Annuities;
            Interest = adult.Interest;
            MonthlyWithdrawals = adult.MonthlyWithdrawals;
            OutsideAssistance = adult.OutsideAssistance;
            SelfEmployment = adult.SelfEmployment;
            NetRental = adult.NetRental;
            OtherIncome = adult.OtherIncome;
            FosterOOHC = adult.FosterOOHC;
        }
    }
}
