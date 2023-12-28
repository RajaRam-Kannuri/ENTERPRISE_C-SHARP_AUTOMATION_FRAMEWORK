using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    [BindChildren(BindChildrenFor.All)]
    public class PLSAProviderData
    {
        public int Id { get; set; }

        public int? GroupId { get; set; }

        public string Name { get; set; }

        public string TaxId { get; set; }

        public string LicenseNumber { get; set; }

        public string LicenseType { get; set; }

        public string LicenseTypeAbbreviation { get; set; }

        public DateTime? LicenseExpirationDate { get; set; }

        public DateTime SubmissionDate { get; set; }

        public string ApprovalStatus { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public string HomePhone { get; set; }

        public string CellPhone { get; set; }

        public string ContactName { get; set; }

        public string WorkPhone { get; set; }

        public string Email { get; set; }

        public AddressData PhysicalAddress { get; set; }

        public AddressData MailingAddress { get; set; }

        public BankData Bank { get; set; }

        public bool IsGroup { get; set; }

        public List<PLSAProviderData> GroupMembers { get; set; }

        public PLSAProviderData()
        {
            PhysicalAddress = new AddressData();
            Bank = new BankData();
            GroupMembers = new List<PLSAProviderData>();
        }
    }
}
