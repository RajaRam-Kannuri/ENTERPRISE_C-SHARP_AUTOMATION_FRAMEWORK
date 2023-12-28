using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLELessonPlanData
    {
        public string Topic { get; set; }

        public DateTime Date { get; set; }

        public string Activities { get; set; }

        public string ResourcesAndMaterials { get; set; }

        public List<string> InstructionalStrategies { get; set; }
    }
}
