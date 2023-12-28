using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class PLSAPreAuthorizationData
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public int StudentId { get; set; }

        public string Email { get; set; }

        public int HouseholdMemberId { get; set; }

        public string ProviderGroup { get; set; }

        public string ProviderName { get; set; }

        public string ProviderLicense { get; set; }

        public string Title { get; set; }

        public string BenefitToStudent { get; set; }

        public DateTime SubmittedDate { get; set; }

        public string Status { get; set; }

        public bool IsProviderRetail { get; set; }

        public DateTime RequestDate { get; set; }

        public List<PLSAPreAuthorizationItemData> LineItems { get; set; }

        public PLSAPreAuthorizationData()
        {
            LineItems = new List<PLSAPreAuthorizationItemData>();
        }
    }
}
