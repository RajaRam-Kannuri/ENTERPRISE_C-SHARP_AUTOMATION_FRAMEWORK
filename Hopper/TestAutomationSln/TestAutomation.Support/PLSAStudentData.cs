using System;
using System.Collections.Generic;

namespace TestAutomation.Support
{
    public class PLSAStudentData : StudentData
    {
        public string PlannedSchoolType { get; set; }

        public List<string> Diagnoses { get; set; }

        public string PriorYearFunding { get; set; }

        public bool HasGraduated { get; set; }

        public bool HasGED { get; set; }

        public PLSAStudentData()
        {
            Diagnoses = new List<string>();
            HasGraduated = true;
            HasGED = false;
        }

        public PLSAStudentData(PLSAStudentData student) : base(student)
        {
            PlannedSchoolType = student.PlannedSchoolType;
            Diagnoses = new List<string>(student.Diagnoses);
            PriorYearFunding = student.PriorYearFunding;
            HasGraduated = student.HasGraduated;
            HasGED = student.HasGED;
        }
    }
}
