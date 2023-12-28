using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class TuitionData
    {
        [Column("Type")]
        public string Type { get; set; }

        [Column("Amount")]
        public decimal Amount { get; set; }
    }
}
