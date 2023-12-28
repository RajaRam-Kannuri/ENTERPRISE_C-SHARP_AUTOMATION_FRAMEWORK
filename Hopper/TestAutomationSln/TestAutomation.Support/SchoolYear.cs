using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class SchoolYear
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public SchoolYear()
        { }

        public SchoolYear(SchoolYear schoolYear)
        {
            Id = schoolYear.Id;
            Description = schoolYear.Description;
            StartDate = schoolYear.StartDate;
            EndDate = schoolYear.EndDate;
        }
    }
}
