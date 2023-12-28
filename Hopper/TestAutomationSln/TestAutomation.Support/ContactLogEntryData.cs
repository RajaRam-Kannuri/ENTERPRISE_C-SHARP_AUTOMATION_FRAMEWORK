using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class ContactLogEntryData
    {
        public string Language { get; set; }

        public string ContactType { get; set; }

        public string ContactReason { get; set; }

        public List<string> CallResolution { get; set; }

        public string Contact { get; set; }

        public string Subject { get; set; }

        public string CustomerServiceTicket { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public ContactLogEntryData()
        {
            CallResolution = new List<string>();
        }
    }
}
