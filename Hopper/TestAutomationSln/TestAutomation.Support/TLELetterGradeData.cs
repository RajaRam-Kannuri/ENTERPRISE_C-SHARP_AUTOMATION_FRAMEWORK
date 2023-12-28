using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLELetterGradeData
    {
        public string Letter { get; set; }

        public int LowRange { get; set; }

        public bool EarnsCredit { get; set; }

        public decimal? UnweightedGPA { get; set; }

        public decimal? WeightedGPA { get; set; }
    }
}
