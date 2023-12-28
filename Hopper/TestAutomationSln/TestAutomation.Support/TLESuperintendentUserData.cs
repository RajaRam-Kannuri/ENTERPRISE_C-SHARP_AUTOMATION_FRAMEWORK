using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLESuperintendentUserData : TLEUserData
    {
        public bool? Active { get; set; }

        public bool? AccountLocked { get; set; }

        public int FailePasswordAttempts { get; set; }

        public List<string> AssignedSchoolGroups { get; set; }

        public TLESuperintendentUserData()
        {
            AssignedSchoolGroups = new List<string>();
        }
    }
}
