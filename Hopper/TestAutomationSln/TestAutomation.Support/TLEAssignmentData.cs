using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEAssignmentData
    {
        public string Type { get; set; }

        public string Title { get; set; }

        public string Assignment { get; set; }

        public List<string> AttachedFiles { get; set; }

        public DateTime DueDate { get; set; }

        public int Points { get; set; }

        public string UnitPlan { get; set; }

        public TLEAssignmentData()
        {
            AttachedFiles = new List<string>();
        }
    }
}
