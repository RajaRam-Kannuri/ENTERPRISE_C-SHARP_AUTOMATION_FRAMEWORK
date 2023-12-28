using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class ContactInformationData : TestData
    {
        public string Name { get; set; }

        public string HomePhone { get; set; }

        public string CellPhone { get; set; }

        public string WorkPhone { get; set; }

        public string Email { get; set; }

        public List<string> CompareTo(ContactInformationData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(Name, expected.Name, "Name")) differences.Add(FormattedLogMessage);
            if (!Compare(HomePhone, expected.HomePhone, "HomePhone")) differences.Add(FormattedLogMessage);
            if (!Compare(CellPhone, expected.CellPhone, "CellPhone")) differences.Add(FormattedLogMessage);
            if (!Compare(WorkPhone, expected.WorkPhone, "WorkPhone")) differences.Add(FormattedLogMessage);
            if (!Compare(Email, expected.Email, "Email")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
