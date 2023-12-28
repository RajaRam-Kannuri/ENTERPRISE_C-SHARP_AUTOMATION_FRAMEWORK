using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class StudentData : ChildData
    {
        public string GradeLevel { get; set; }

        public string GradeLevelAbbreviation { get; set; }

        public string SSN { get; set; }

        public string VerifySSN { get; set; }

        public string EmailAddress { get; set; }

        public string HispanicOrLatino { get; set; }

        public string NativeAmerican { get; set; }

        public string Asian { get; set; }

        public string AfricanAmerican { get; set; }

        public string PacificIslander { get; set; }

        public string White { get; set; }

        public string SchoolAttended { get; set; }

        public string SchoolType { get; set; }

        public string SchoolCounty { get; set; }

        public string AttendedFloridaPublicSchoolLastYear { get; set; }

        public string ReceivedSUFSFundingLastYear { get; set; }

        public string FoodStamps { get; set; }

        public int StudentPersonID { get; set; }

        public void SetRaceFlags(List<StudentRaceFlag> raceFlags)
        {
            raceFlags.ForEach(flag =>
            {
                if (flag.Race == "Black") { HispanicOrLatino = (flag.Selected ? "true" : "false"); }
                if (flag.Race == "Hispanic") { NativeAmerican = (flag.Selected ? "true" : "false"); }
                if (flag.Race == "Native American") { Asian = (flag.Selected ? "true" : "false"); }
                if (flag.Race == "Asian") { AfricanAmerican = (flag.Selected ? "true" : "false"); }
                if (flag.Race == "Hawaiian Pacific Islander") { PacificIslander = (flag.Selected ? "true" : "false"); }
                if (flag.Race == "White") { White = (flag.Selected ? "true" : "false"); }
            });
        }

        public StudentData()
        { }

        public StudentData(StudentData student) : base(student)
        {
            GradeLevel = student.GradeLevel;
            GradeLevelAbbreviation = student.GradeLevelAbbreviation;
            SSN = student.SSN;
            VerifySSN = student.VerifySSN;
            EmailAddress = student.EmailAddress;
            HispanicOrLatino = student.HispanicOrLatino;
            NativeAmerican = student.NativeAmerican;
            Asian = student.Asian;
            AfricanAmerican = student.AfricanAmerican;
            PacificIslander = student.PacificIslander;
            White = student.White;
            SchoolAttended = student.SchoolAttended;
            SchoolType = student.SchoolType;
            SchoolCounty = student.SchoolCounty;
            AttendedFloridaPublicSchoolLastYear = student.AttendedFloridaPublicSchoolLastYear;
            ReceivedSUFSFundingLastYear = student.ReceivedSUFSFundingLastYear;
            FoodStamps = student.FoodStamps;
        }
    }
}
