using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class AddressData : TestData
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Column("PhysicalCity")]
        public string City { get; set; }

        public string State { get; set; }

        public string StateAbbreviation { get; set; }

        public string Zip { get; set; }

        public string County { get; set; }

        public List<string> CompareTo(AddressData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(Address1, expected.Address1, "Address1")) differences.Add(FormattedLogMessage);
            if (!Compare(Address2, expected.Address2, "Address2")) differences.Add(FormattedLogMessage);
            if (!Compare(City, expected.City, "City")) differences.Add(FormattedLogMessage);
            if (!(Compare(State, expected.State, "State") || Compare(State, expected.StateAbbreviation, "State"))) differences.Add(FormattedLogMessage);
            if (!Compare(Zip, expected.Zip, "Zip")) differences.Add(FormattedLogMessage);
            if (!Compare(County, expected.County, "County")) differences.Add(FormattedLogMessage);
            return differences;
        }

        public AddressData()
        { }

        public AddressData(AddressData address)
        {
            Address1 = address.Address1;
            Address2 = address.Address2;
            City = address.City;
            State = address.State;
            StateAbbreviation = address.StateAbbreviation;
            Zip = address.Zip;
            County = address.County;
        }
    }
}
