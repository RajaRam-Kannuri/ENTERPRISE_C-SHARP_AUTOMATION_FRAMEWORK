using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class TLEGradingPeriod
    {
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Number { get; set; }
    }
}
