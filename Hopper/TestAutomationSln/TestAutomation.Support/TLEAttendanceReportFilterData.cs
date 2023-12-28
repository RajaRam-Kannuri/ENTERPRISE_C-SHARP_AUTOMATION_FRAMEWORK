using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEAttendanceReportFilterData : TLECafeteriaReportFilterData
    {
        public string Teacher { get; set; }

        public string GradeLevel { get; set; }

        public string Period { get; set; }
    }
}
