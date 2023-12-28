using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class GraduationSurveyData
    {
        public int GraduationSurveyPeriodId { get; set; }

        public SchoolYear SchoolYear { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime CloseDate { get; set; }

        public GraduationSurveyData()
        {
            SchoolYear = new SchoolYear();
        }
        public bool IsOpen()
        {
            DateTime now = DateTime.Now;
            return OpenDate < now && now < CloseDate;
        }
    }
}
