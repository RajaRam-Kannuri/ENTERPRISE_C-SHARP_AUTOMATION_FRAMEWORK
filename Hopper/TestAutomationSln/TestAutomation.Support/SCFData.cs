using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class SCFData
    {
        public string StudentAwardID { get; set; }

        public DateTime StudentStartDate { get; set; }

        public decimal StudentTuition { get; set; }

        public decimal StudentBooksFee { get; set; }

        public decimal StudentRegistrationFee { get; set; }

        public decimal StudentTransportationFee { get; set; }

        public decimal StudentUniformFee { get; set; }

        public decimal StudentTestingFee { get; set; }

        public decimal OtherStudentFees { get; set; }

        public decimal TotalStudentTuitionAndFees { get; set; }

        public string CertifyGradeLevel { get; set; }

        public string CertifyNonMcKay { get; set; }

        public string CertifyAttendingFullTime { get; set; }

        public string CertifyStandardizedTest { get; set; }

        public string CertifyECF { get; set; }

        public string CertifyDoECompliance { get; set; }

        public string CertifySUFSPolicies { get; set; }

        public string CertifyPaymentConditions { get; set; }

        public string ReportDefault { get; set; }

        public SCFData()
        { }

        public SCFData(SCFData data)
        {
            StudentAwardID = data.StudentAwardID;
            StudentStartDate = data.StudentStartDate;
            StudentTuition = data.StudentTuition;
            StudentBooksFee = data.StudentBooksFee;
            StudentRegistrationFee = data.StudentRegistrationFee;
            StudentTransportationFee = data.StudentTransportationFee;
            StudentUniformFee = data.StudentUniformFee;
            StudentTestingFee = data.StudentTestingFee;
            OtherStudentFees = data.OtherStudentFees;
            TotalStudentTuitionAndFees = data.TotalStudentTuitionAndFees;
            CertifyGradeLevel = data.CertifyGradeLevel;
            CertifyNonMcKay = data.CertifyNonMcKay;
            CertifyAttendingFullTime = data.CertifyAttendingFullTime;
            CertifyStandardizedTest = data.CertifyStandardizedTest;
            CertifyECF = data.CertifyECF;
            CertifyDoECompliance = data.CertifyDoECompliance;
            CertifySUFSPolicies = data.CertifySUFSPolicies;
            CertifyPaymentConditions = data.CertifyPaymentConditions;
            ReportDefault = data.ReportDefault;
        }

        public SCFData(List<TuitionData> tuitionItems)
        {
            StudentTuition = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Tuition").Amount;
            StudentBooksFee = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Books").Amount;
            StudentRegistrationFee = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Registration").Amount;
            StudentTransportationFee = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Transportation").Amount;
            StudentUniformFee = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Uniforms").Amount;
            StudentTestingFee = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Testing").Amount;
            OtherStudentFees = tuitionItems.FirstOrDefault(tuitionItem => tuitionItem.Type == "Other").Amount;
        }

        public void CalculateTotal()
        {
            TotalStudentTuitionAndFees = StudentTuition + StudentBooksFee + StudentRegistrationFee + StudentTransportationFee + StudentUniformFee + StudentTestingFee + OtherStudentFees;
        }
    }
}
