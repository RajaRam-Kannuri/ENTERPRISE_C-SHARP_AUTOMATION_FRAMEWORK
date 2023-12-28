using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLECafeteriaReportFilterData
    {
        public SchoolYear SchoolYear { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DayOfTheWeek { get; set; }

        public string StudentLastName { get; set; }
    }
}
