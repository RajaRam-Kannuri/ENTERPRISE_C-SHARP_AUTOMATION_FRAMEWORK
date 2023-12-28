using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insight.Database;

namespace TestAutomation.Support
{
    public class TuitionAndFeesPerGradeData : TestData
    {
        public decimal Tuition { get; set; }

        public decimal Books { get; set; }

        public decimal Registration { get; set; }

        public decimal Transportation { get; set; }

        public decimal Uniforms { get; set; }

        public decimal Testing { get; set; }

        public decimal Other { get; set; }

        public decimal Total { get; set; }

        public TuitionAndFeesPerGradeData()
        { }

        public TuitionAndFeesPerGradeData(List<TuitionData> tuition)
        {
            SetTuitionValues(tuition);
        }

        public TuitionAndFeesPerGradeData SetTuitionValues(List<TuitionData> tuition)
        {
            tuition.ForEach(item =>
            {
                switch (item.Type)
                {
                    case "Tuition":
                        Tuition = item.Amount;
                        break;
                    case "Books":
                        Books = item.Amount;
                        break;
                    case "Registration":
                        Registration = item.Amount;
                        break;
                    case "Testing":
                        Testing = item.Amount;
                        break;
                    case "Other":
                        Other = item.Amount;
                        break;
                    case "Transportation":
                        Transportation = item.Amount;
                        break;
                    case "Uniforms":
                        Uniforms = item.Amount;
                        break;
                }
            });

            CalculateTotal();
            return this;
        }

        public void CalculateTotal()
        {
            Total = Tuition + Books + Registration + Testing + Other + Transportation + Uniforms;
        }

        public List<string> CompareTo(TuitionAndFeesPerGradeData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(Tuition, expected.Tuition, "Tuition")) differences.Add(FormattedLogMessage);
            if (!Compare(Books, expected.Books, "Books")) differences.Add(FormattedLogMessage);
            if (!Compare(Registration, expected.Registration, "Registration")) differences.Add(FormattedLogMessage);
            if (!Compare(Transportation, expected.Transportation, "Transportation")) differences.Add(FormattedLogMessage);
            if (!Compare(Uniforms, expected.Uniforms, "Uniforms")) differences.Add(FormattedLogMessage);
            if (!Compare(Testing, expected.Testing, "Testing")) differences.Add(FormattedLogMessage);
            if (!Compare(Other, expected.Other, "Other")) differences.Add(FormattedLogMessage);
            if (!Compare(Total, expected.Total, "Total")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
