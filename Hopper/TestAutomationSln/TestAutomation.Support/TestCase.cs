using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAutomation.Support
{
    public class TestCase
    {
        public List<TestStep> TestSteps { get; set; }

        public TestCase(List<TestStep> testSteps)
        {
            TestSteps = testSteps;
        }

        public TestCase()
        {
            TestSteps = new List<TestStep>();
        }

        public void AddStep(TestStep step)
        {
            TestSteps.Add(step);
        }
    }
}
