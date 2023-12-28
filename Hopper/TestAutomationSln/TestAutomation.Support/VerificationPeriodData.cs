using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class VerificationPeriodData
    {
        public int Id { get; set; }

        public string SchoolYear { get; set; }

        public string PeriodId { get; set; }

        public string Type { get; set; }

        public string SchoolCode { get; set; }

        public string StudentAwardId { get; set; }

        public DateTime OpenDate { get; set; }
        
        public DateTime CloseDate { get; set; }

        public DateTime CheckDate { get; set; }

        public string StartingCheckNumber { get; set; }

        public string ReportId { get; set; }

        public bool IsOpen()
        {
            DateTime now = DateTime.Now;
            return OpenDate < now && now < CloseDate;
        }
    }
}
