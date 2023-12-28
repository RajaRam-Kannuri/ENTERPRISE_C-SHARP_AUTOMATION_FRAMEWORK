using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class RenewalTestGuideData
    {
        public string PriorYearApplicationId { get; set; }

        public string EmailAddress { get; set; }

        public int HouseholdId { get; set; }

        public string MaritalStatus { get; set; }

        public int NumberOfGuardians { get; set; }

        public int NumberOfStudents { get; set; }

        public int NumberOfChildren { get; set; }

        public int NumberOfAdults { get; set; }

        public int NumberOfFosterStudents { get; set; }

        public int NumberOfFosterChildren { get; set; }

        public int TotalHouseholdMembers
        {
            get
            {
                return NumberOfGuardians + NumberOfStudents + NumberOfChildren + NumberOfAdults;
            }
        }
    }
}
