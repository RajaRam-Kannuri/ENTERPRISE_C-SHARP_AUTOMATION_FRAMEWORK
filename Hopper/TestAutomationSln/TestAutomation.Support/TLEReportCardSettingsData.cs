using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class TLEReportCardSettingsData
    {
        public SchoolYear SchoolYear { get; set; }

        public string Description { get; set; }

        public List<string> GradeLevels { get; set; }

        public List<string> AdditionalFields { get; set; }

        public string LogoPath { get; set; }

        public string LogoAlignment { get; set; }

        public TLEReportCardSettingsData()
        {
            SchoolYear = new SchoolYear();
            GradeLevels = new List<string>();
            AdditionalFields = new List<string>();
        }
    }
}
