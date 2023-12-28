using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEUnitPlanData
    {
        public string TemplateName { get; set; }

        public string Title { get; set; }

        public TLEGradingPeriod GradingPeriod { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<string> Standards { get; set; }

        public List<string> AdditionalStandards { get; set; }
    }
}
