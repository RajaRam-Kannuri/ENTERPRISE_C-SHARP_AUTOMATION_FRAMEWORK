using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class AuthorizedCallerData : TestData
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Last4SSN { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public List<string> CompareTo(AuthorizedCallerData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(FirstName, expected.FirstName, "FirstName")) differences.Add(FormattedLogMessage);
            if (!Compare(LastName, expected.LastName, "LastName")) differences.Add(FormattedLogMessage);
            if (!Compare(Email, expected.Email, "Email")) differences.Add(FormattedLogMessage);
            if (!Compare(PhoneNumber, expected.PhoneNumber, "PhoneNumber")) differences.Add(FormattedLogMessage);
            if (!Compare(Last4SSN, expected.Last4SSN, "Last4SSN")) differences.Add(FormattedLogMessage);
            if (!Compare(Address1, expected.Address1, "Address1")) differences.Add(FormattedLogMessage);
            if (!Compare(Address2, expected.Address2, "Address2")) differences.Add(FormattedLogMessage);
            if (!Compare(City, expected.City, "City")) differences.Add(FormattedLogMessage);
            if (!Compare(State, expected.State, "State")) differences.Add(FormattedLogMessage);
            if (!Compare(Zip, expected.Zip, "Zip")) differences.Add(FormattedLogMessage);
            if (!Compare(SecurityQuestion, expected.SecurityQuestion, "SecurityQuestion")) differences.Add(FormattedLogMessage);
            if (!Compare(SecurityAnswer, expected.SecurityAnswer, "SecurityAnswer")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
