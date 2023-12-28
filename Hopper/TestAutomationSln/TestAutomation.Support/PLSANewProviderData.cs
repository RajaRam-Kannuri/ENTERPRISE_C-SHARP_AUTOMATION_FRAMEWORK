using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class PLSANewProviderData
    {
        public int Id { get; set; }

        public int? GroupId { get; set; }

        public string Name { get; set; }

        public string TaxId { get; set; }

        public string LicenseNumber { get; set; }

        public string LicenseType { get; set; }

        public DateTime? LicenseExpirationDate { get; set; }

        public string ApprovalStatus { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public ContactInformationData ContactInformation { get; set; }

        public AddressData PhysicalAddress { get; set; }

        public AddressData MailingAddress { get; set; }

        public FinancialInstitutionData Bank { get; set; }

        public bool IsGroup { get; set; }

        public PLSANewProviderData()
        {
            ContactInformation = new ContactInformationData();
            PhysicalAddress = new AddressData();
            MailingAddress = new AddressData();
        }
    }
}
