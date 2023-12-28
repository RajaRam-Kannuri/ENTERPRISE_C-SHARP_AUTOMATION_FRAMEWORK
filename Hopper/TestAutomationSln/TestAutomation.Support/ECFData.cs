using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class ECFData : TestData
    {
        public DateTime StudentLastDayOfClass { get; set; }

        public string ReasonForLeaving { get; set; }

        public string OtherExplanation { get; set; }

        public string IsSuspension { get; set; }

        public string SuspensionReason { get; set; }

        public string IsExpelled { get; set; }

        public string WasViolentBehavior { get; set; }

        public string StudentDestination { get; set; }

        public string NameOfNewSchool { get; set; }

        public string HasOutstandingBalance { get; set; }

        public string OutstandingBalanceAmount { get; set; }

        public string IsPaymentPlanSetUp { get; set; }

        public List<string> CompareTo(ECFData expected)
        {
            List<string> differences = new List<string>();
            if (!Compare(StudentLastDayOfClass, expected.StudentLastDayOfClass, "StudentLastDayOfClass")) differences.Add(FormattedLogMessage);
            if (!Compare(ReasonForLeaving, expected.ReasonForLeaving, "ReasonForLeaving")) differences.Add(FormattedLogMessage);
            if (!Compare(OtherExplanation, expected.OtherExplanation, "OtherExplanation")) differences.Add(FormattedLogMessage);
            if (!Compare(IsSuspension, expected.IsSuspension, "IsSuspension")) differences.Add(FormattedLogMessage);
            if (!Compare(SuspensionReason, expected.SuspensionReason, "SuspensionReason")) differences.Add(FormattedLogMessage);
            if (!Compare(IsExpelled, expected.IsExpelled, "IsExpelled")) differences.Add(FormattedLogMessage);
            if (!Compare(WasViolentBehavior, expected.WasViolentBehavior, "WasViolentBehavior")) differences.Add(FormattedLogMessage);
            if (!Compare(StudentDestination, expected.StudentDestination, "StudentDestination")) differences.Add(FormattedLogMessage);
            if (!expected.NameOfNewSchool.Contains(NameOfNewSchool)) differences.Add(String.Format("\t NameOfNewSchool did not match. Actual: {0}, Expected: {1}", NameOfNewSchool, expected.NameOfNewSchool));
            if (!Compare(HasOutstandingBalance, expected.HasOutstandingBalance, "HasOutstandingBalance")) differences.Add(FormattedLogMessage);
            if (!Compare(OutstandingBalanceAmount, expected.OutstandingBalanceAmount, "OutstandingBalanceAmount")) differences.Add(FormattedLogMessage);
            if (!Compare(IsPaymentPlanSetUp, expected.IsPaymentPlanSetUp, "IsPaymentPlanSetUp")) differences.Add(FormattedLogMessage);
            return differences;
        }
    }
}
