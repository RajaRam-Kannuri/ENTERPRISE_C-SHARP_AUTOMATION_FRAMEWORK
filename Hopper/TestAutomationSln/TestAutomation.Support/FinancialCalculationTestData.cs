using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class FTCFinancialCalculationTestData
    {
        public decimal AwardPercentage { get; set; }
        public FTCApplicationData Application { get; set; }

        public int DOESchoolCode { get; set; }

        public SASStudentDetails StudentDetails { get; set; }

        public SCFData FirstSchoolSCF { get; set; }

        public ECFData FirstSchoolECF { get; set; }

        public SCFData SecondSchoolSCF { get; set; }

        public ECFData SecondSchoolECF { get; set; }

        public TuitionAndFeesData TuitionAndFeesData { get; set; }

        public List<TuitionData> TuitionAndFeesValues { get; set; }
    }
}
