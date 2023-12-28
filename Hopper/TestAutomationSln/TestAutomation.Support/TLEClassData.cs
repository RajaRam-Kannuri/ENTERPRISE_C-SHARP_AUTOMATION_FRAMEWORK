using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEClassData
    {
        public string Teacher { get; set; }

        public string TeacherLogin { get; set; }

        public SchoolYear SchoolYear { get; set; }

        public string Description { get; set; }

        public string Period { get; set; }

        public string Standards { get; set; }

        public string GradingScale { get; set; }

        public List<string> GradeLevels { get; set; }

        public string Credits { get; set; }

        public bool UseWeightedGPA { get; set; }

        public TLEGradingPeriod GradingPeriod { get; set; }

        public List<TLEPerformanceMeasure> PerformanceMeasures { get; set; }

        public TLEClassData()
        {
            SchoolYear = new SchoolYear();
            GradeLevels = new List<string>();
            GradingPeriod = new TLEGradingPeriod();
            PerformanceMeasures = new List<TLEPerformanceMeasure>();
        }
    }
}
