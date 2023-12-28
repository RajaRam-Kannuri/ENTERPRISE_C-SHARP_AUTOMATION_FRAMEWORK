using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class PLSAApplicationData
    {
        public string ApplicationId { get; set; }

        public SchoolYear SchoolYear { get; set; }

        public GuardianAdultData PrimaryGuardian { get; set; }

        public GuardianAdultData SecondaryGuardian { get; set; }

        public List<PLSAStudentData> Students { get; set; }

        public PLSAApplicationData()
        {
            SchoolYear = new SchoolYear();
            PrimaryGuardian = new GuardianAdultData();
            Students = new List<PLSAStudentData>();
        }

        public PLSAApplicationData(PLSAApplicationData application)
        {
            SchoolYear = new SchoolYear(application.SchoolYear);
            PrimaryGuardian = new GuardianAdultData();
            Students = new List<PLSAStudentData>();

            ApplicationId = application.ApplicationId;
            if (application.SecondaryGuardian != null)
                SecondaryGuardian = new GuardianAdultData(application.SecondaryGuardian);

            application.Students.ForEach(student =>Students.Add(new PLSAStudentData(student)) );
        }

        public List<string> ApplicationSSNs()
        {
            List<string> SSNs = new List<string>();
            SSNs.Add(PrimaryGuardian.SSN);
            if (SecondaryGuardian != null)
                SSNs.Add(SecondaryGuardian.SSN);

            SSNs.AddRange(Students.Select(student => student.SSN).ToList());
            return SSNs;
        }
    }
}
