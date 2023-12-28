using System.Collections.Generic;

namespace KWDT.Core
{
    public class StepControlType
    {
        public string Type { get; set; }

        public List<string> Methods { get; set; }

        public StepControlType()
        {
            Methods = new List<string>();
        }
    }
}
