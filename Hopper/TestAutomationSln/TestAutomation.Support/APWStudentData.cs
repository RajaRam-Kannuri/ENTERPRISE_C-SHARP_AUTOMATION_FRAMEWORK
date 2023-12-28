using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class APWStudentData : TestData
    {
        public string Name { get; set; }

        public string PersonId { get; set; }

        public string DirectCertification { get; set; }

        public string SSN { get; set; }

        public string DateOfBirth { get; set; }

        public string RelationshipToPrimaryGuardian { get; set; }

        public string Type { get; set; }

        public string Foster { get; set; }

        public string OOHC { get; set; }

        public string Gender { get; set; }

        public List<string> CompareTo(APWStudentData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(Name, expected.Name, "Name")) differences.Add(FormattedLogMessage);
            if (!Compare(PersonId, expected.PersonId, "PersonId")) differences.Add(FormattedLogMessage);
            if (!Compare(DirectCertification, expected.DirectCertification, "DirectCertification")) differences.Add(FormattedLogMessage);
            if (!Compare(SSN, expected.SSN, "SSN")) differences.Add(FormattedLogMessage);
            if (!Compare(DateOfBirth, expected.DateOfBirth, "DateOfBirth")) differences.Add(FormattedLogMessage);
            if (!Compare(RelationshipToPrimaryGuardian, expected.RelationshipToPrimaryGuardian, "RelationshipToPrimaryGuardian")) differences.Add(FormattedLogMessage);
            if (!Compare(Type, expected.Type, "Type")) differences.Add(FormattedLogMessage);
            if (!Compare(Foster, expected.Foster, "Foster")) differences.Add(FormattedLogMessage);
            if (!Compare(OOHC, expected.OOHC, "OOHC")) differences.Add(FormattedLogMessage);
            if (!Compare(Gender, expected.Gender, "Gender")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
