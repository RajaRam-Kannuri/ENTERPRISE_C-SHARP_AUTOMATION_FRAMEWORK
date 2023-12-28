using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEGuardianData
    {
        public string StudentRelationship { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CommunicationPreference { get; set; }

        public List<TLEGuardianPhoneNumberData> PhoneNumbers { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public TLEGuardianData()
        {
            PhoneNumbers = new List<TLEGuardianPhoneNumberData>();
        }
    }
}
