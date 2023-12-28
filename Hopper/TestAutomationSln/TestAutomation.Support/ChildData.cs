using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class ChildData
    {
        public int HouseholdMemberId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Foster { get; set; }

        public string OOHC { get; set; }

        public string RelationshipToPrimaryGuardian { get; set; }

        public string FullName { get { return FirstName + " " + (String.IsNullOrEmpty(MiddleName) ? String.Empty : MiddleName + " ") + LastName; } }

        public string FirstAndLast { get { return FirstName + " " + LastName; } }

        public ChildData()
        { }

        public ChildData(ChildData child)
        {
            HouseholdMemberId = child.HouseholdMemberId;
            FirstName = child.FirstName;
            MiddleName = child.MiddleName;
            LastName = child.LastName;
            DateOfBirth = child.DateOfBirth;
            Gender = child.Gender;
            Foster = child.Foster;
            OOHC = child.OOHC;
            RelationshipToPrimaryGuardian = child.RelationshipToPrimaryGuardian;
        }
    }
}
