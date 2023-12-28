using System.Collections.Generic;

namespace KWDT.Core
{
    public class StepProgram
    {
        public string Name { get; set; }

        public List<StepPage> Pages { get; set; }

        public StepProgram()
        {
            Pages = new List<StepPage>();
        }
    }

    public class StepPage
    {
        public string Name { get; set; }

        public List<StepControl> Controls { get; set; }

        public StepPage()
        {
            Controls = new List<StepControl>();
        }
    }

    public class StepControl
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}
