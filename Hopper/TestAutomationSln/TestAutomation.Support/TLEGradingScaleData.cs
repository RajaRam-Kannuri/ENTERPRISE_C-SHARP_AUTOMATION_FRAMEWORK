using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEGradingScaleData
    {
        public string Type { get; set; }

        public SchoolYear SchoolYear { get; set; }

        public string Description { get; set; }

        public bool AutomaticallyRoundUp { get; set; }

        public List<TLELetterGradeData> LetterGrades { get; set; }

        public TLEGradingScaleData()
        {
            LetterGrades = new List<TLELetterGradeData>();
        }
    }
}
