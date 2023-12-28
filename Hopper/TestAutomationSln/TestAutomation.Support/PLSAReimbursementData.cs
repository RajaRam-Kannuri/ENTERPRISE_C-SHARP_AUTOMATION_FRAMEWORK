using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class PLSAReimbursementData
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int HouseholdMemberId { get; set; }

        public DateTime SubmissionDate { get; set; }

        public string Type { get; set; }

        public string Year { get; set; }

        public string PayTo { get; set; }

        public string EnteredBy { get; set; }

        public string StudentName { get; set; }

        public DateTime StudentDateOfBirth { get; set; }

        public string SSN { get; set; }

        public string GradeOrAge { get; set; }

        public string Funded { get; set; }

        public string HouseholdLanguage { get; set; }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public List<string> AvailableFundsByYear { get; set; }

        public string Status { get; set; }

        public string ProviderGroup { get; set; }

        public string ProviderHasBankInformation { get; set; }

        public string ProviderName { get; set; }

        public string ProviderLicense { get; set; }

        public bool IsProviderRetail { get; set; }

        public string ProviderEligibilityStatus { get; set; }

        public DateTime DateOfService { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string InvoiceNumber { get; set; }

        public decimal TotalInvoiceAmount { get; set; }

        public List<string> ValidatedDocuments { get; set; }

        public List<PLSAReimbursementItemData> LineItems { get; set; }

        public int? PreAuthorizationId { get; set; }

        public PLSAReimbursementData()
        {
            AvailableFundsByYear = new List<string>();
            ValidatedDocuments = new List<string>();
            LineItems = new List<PLSAReimbursementItemData>();
        }

        public PLSAReimbursementData(PLSAPreAuthorizationData preAuth)
        {
            PreAuthorizationId = preAuth.Id;
            StudentId = preAuth.StudentId;
            HouseholdMemberId = preAuth.HouseholdMemberId;
            StudentName = preAuth.StudentName;
            ProviderName = preAuth.ProviderName;
            ProviderGroup = preAuth.ProviderGroup;
            ProviderLicense = preAuth.ProviderLicense;
            IsProviderRetail = preAuth.IsProviderRetail;
            LineItems = preAuth.LineItems.Select(preAuthLineItem => new PLSAReimbursementItemData(preAuthLineItem)).ToList();
        }
    }
}
