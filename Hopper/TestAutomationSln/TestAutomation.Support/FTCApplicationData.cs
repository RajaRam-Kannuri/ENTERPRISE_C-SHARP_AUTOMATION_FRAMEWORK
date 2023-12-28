using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class FTCApplicationData
    {
        public string ApplicationId { get; set; }

        public SchoolYear SchoolYear { get; set; }

        public GuardianAdultData PrimaryGuardian { get; set; }

        public SecondaryGuardianAdultData SecondaryGuardian { get; set; }

        public List<StudentData> Students { get; set; }

        public List<AdultData> OtherAdults { get; set; }

        public List<ChildData> OtherChildren { get; set; }

        public int ContributingAdultCount
        {
            get
            {
                return 1 + (SecondaryGuardian == null ? 0 : 1) + OtherAdults.Count;
            }
        }

        public int TotalHouseholdMemberCount
        {
            get
            {
                return 1 + (SecondaryGuardian == null ? 0 : 1) + Students.Count + OtherChildren.Count + OtherAdults.Count;
            }
        }

        public FTCApplicationData()
        {
            SchoolYear = new SchoolYear();
            PrimaryGuardian = new GuardianAdultData();
            Students = new List<StudentData>();
            OtherAdults = new List<AdultData>();
            OtherChildren = new List<ChildData>();
        }

    }
}
