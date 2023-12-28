using System;
using System.Text;

namespace AutomationFramework
{
    public class SimpleData
    {
        protected bool CompareIfNotNull(string firstBit, string secondBit)
        {
            return (String.IsNullOrEmpty(firstBit) && String.IsNullOrEmpty(secondBit)) ? firstBit == secondBit : true;
        }
    }
}
