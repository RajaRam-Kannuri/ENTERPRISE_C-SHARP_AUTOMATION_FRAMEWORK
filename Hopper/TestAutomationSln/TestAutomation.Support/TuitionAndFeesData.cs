using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TuitionAndFeesData : TestData
    {
        public TuitionAndFeesPerGradeData Kindergarten { get; set; }

        public TuitionAndFeesPerGradeData FirstGrade { get; set; }

        public TuitionAndFeesPerGradeData SecondGrade { get; set; }

        public TuitionAndFeesPerGradeData ThirdGrade { get; set; }

        public TuitionAndFeesPerGradeData FourthGrade { get; set; }

        public TuitionAndFeesPerGradeData FifthGrade { get; set; }

        public TuitionAndFeesPerGradeData SixthGrade { get; set; }

        public TuitionAndFeesPerGradeData SeventhGrade { get; set; }

        public TuitionAndFeesPerGradeData EighthGrade { get; set; }

        public TuitionAndFeesPerGradeData NinthGrade { get; set; }

        public TuitionAndFeesPerGradeData TenthGrade { get; set; }

        public TuitionAndFeesPerGradeData EleventhGrade { get; set; }

        public TuitionAndFeesPerGradeData TwelfthGrade { get; set; }

        public DateTime SchoolStartDate { get; set; }

        public DateTime SchoolEndDate { get; set; }

        public DateTime SchoolComplianceDate { get; set; }

        public string StandardizedTestGiven { get; set; }

        public DateTime StandardizedTestStartDate { get; set; }

        public DateTime StandardizedTestEndDate { get; set; }

        public string MultiSiblingDiscount { get; set; }

        public string AffiliationDiscount { get; set; }

        public TuitionAndFeesData()
        {
            Kindergarten = new TuitionAndFeesPerGradeData();
            FirstGrade = new TuitionAndFeesPerGradeData();
            SecondGrade = new TuitionAndFeesPerGradeData();
            ThirdGrade = new TuitionAndFeesPerGradeData();
            FourthGrade = new TuitionAndFeesPerGradeData();
            FifthGrade = new TuitionAndFeesPerGradeData();
            SixthGrade = new TuitionAndFeesPerGradeData();
            SeventhGrade = new TuitionAndFeesPerGradeData();
            EighthGrade = new TuitionAndFeesPerGradeData();
            NinthGrade = new TuitionAndFeesPerGradeData();
            TenthGrade = new TuitionAndFeesPerGradeData();
            EleventhGrade = new TuitionAndFeesPerGradeData();
            TwelfthGrade = new TuitionAndFeesPerGradeData();
        }

        public void SetTuitionAndFees(List<TuitionAndFeesPerGradeData> grades)
        {
            Kindergarten = grades[0];
            FirstGrade = grades[1];
            SecondGrade = grades[2];
            ThirdGrade = grades[3];
            FourthGrade = grades[4];
            FifthGrade = grades[5];
            SixthGrade = grades[6];
            SeventhGrade = grades[7];
            EighthGrade = grades[8];
            NinthGrade = grades[9];
            TenthGrade = grades[10];
            EleventhGrade = grades[11];
            TwelfthGrade = grades[12];
        }

        public List<string> CompareTo(TuitionAndFeesData expected)
        {
            List<string> differences = new List<string>();
            differences.AddRange(Kindergarten.CompareTo(expected.Kindergarten));
            differences.AddRange(FirstGrade.CompareTo(expected.FirstGrade));
            differences.AddRange(SecondGrade.CompareTo(expected.SecondGrade));
            differences.AddRange(ThirdGrade.CompareTo(expected.ThirdGrade));
            differences.AddRange(FourthGrade.CompareTo(expected.FourthGrade));
            differences.AddRange(FifthGrade.CompareTo(expected.FifthGrade));
            differences.AddRange(SixthGrade.CompareTo(expected.SixthGrade));
            differences.AddRange(SeventhGrade.CompareTo(expected.SeventhGrade));
            differences.AddRange(EighthGrade.CompareTo(expected.EighthGrade));
            differences.AddRange(NinthGrade.CompareTo(expected.NinthGrade));
            differences.AddRange(TenthGrade.CompareTo(expected.TenthGrade));
            differences.AddRange(EleventhGrade.CompareTo(expected.EleventhGrade));
            differences.AddRange(TwelfthGrade.CompareTo(expected.TwelfthGrade));
            if (!Compare(SchoolStartDate, expected.SchoolStartDate, "SchoolStartDate")) differences.Add(FormattedLogMessage);
            if (!Compare(SchoolEndDate, expected.SchoolEndDate, "SchoolEndDate")) differences.Add(FormattedLogMessage);
            //if (!Compare(SchoolComplianceDate, expected.SchoolComplianceDate, "SchoolComplianceDate")) differences.Add(FormattedLogMessage);
            if (!Compare(StandardizedTestGiven, expected.StandardizedTestGiven, "StandardizedTestGiven")) differences.Add(FormattedLogMessage);
            if (!Compare(StandardizedTestStartDate, expected.StandardizedTestStartDate, "StandardizedTestStartDate")) differences.Add(FormattedLogMessage);
            if (!Compare(StandardizedTestEndDate, expected.StandardizedTestEndDate, "StandardizedTestEndDate")) differences.Add(FormattedLogMessage);
            if (!Compare(MultiSiblingDiscount, expected.MultiSiblingDiscount, "MultiSiblingDiscount")) differences.Add(FormattedLogMessage);
            if (!Compare(AffiliationDiscount, expected.AffiliationDiscount, "AffiliationDiscount")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
