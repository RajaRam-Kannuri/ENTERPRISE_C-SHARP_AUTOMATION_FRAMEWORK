using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAutomation.Support
{
    public class TestStep
    {
        public string Entity { get; set; }

        public string Element { get; set; }

        public string ElementType { get; set; }

        public string Action { get; set; }

        public string Data { get; set; }

        public string Note { get; set; }

        public bool? Passed { get; set; }
    }
}
