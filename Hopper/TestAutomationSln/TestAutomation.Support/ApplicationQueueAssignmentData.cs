using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class ApplicationQueueAssignmentData
    {
        public string Processor { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string ImmediateAssignment { get; set; }

        public string Priority { get; set; }

        public List<PriorityAssignmentData> PriorityData { get; set; }

        public ApplicationQueueAssignmentData()
        {
            PriorityData = new List<PriorityAssignmentData>();
        }
    }
}
