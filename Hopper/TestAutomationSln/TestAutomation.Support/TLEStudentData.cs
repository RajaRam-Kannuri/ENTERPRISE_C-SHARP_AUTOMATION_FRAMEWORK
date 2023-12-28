using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEStudentData
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string GradeLevel { get; set; }

        public string FirstLast
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FullName
        {
            get
            {
                return string.IsNullOrWhiteSpace(MiddleName)
                    ? FirstName + " " + MiddleName + " " + LastName
                    : FirstName + " " + LastName;
            }
        }

        public string StudentIdentifier { get; set; }

        public bool HasIEP { get; set; }

        public string StudentEmail { get; set; }

        public string RelationshipToPrimaryGuardian { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string SSN { get; set; }

        public string AlienRegistrationNumber { get; set; }

        public TLEGuardianData PrimaryGuardian { get; set; }

        public TLEGuardianData SecondaryGuardian { get; set; }

        public TLEStudentData()
        {
            PrimaryGuardian = new TLEGuardianData();
            SecondaryGuardian = new TLEGuardianData();
        }
    }
}
