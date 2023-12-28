using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEAttendanceEntry
    {
        public DateTime Date { get; set; }

        public string StudentLastName { get; set; }

        public string StudentFirstName { get; set; }

        public string AttendanceStatus { get; set; }

        public bool NotifyParents { get; set; }

        public string Note { get; set; }
    }
}
