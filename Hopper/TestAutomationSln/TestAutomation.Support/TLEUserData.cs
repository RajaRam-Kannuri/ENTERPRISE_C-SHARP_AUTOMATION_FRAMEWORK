using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public abstract class TLEUserData
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LastCommaFirst
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
