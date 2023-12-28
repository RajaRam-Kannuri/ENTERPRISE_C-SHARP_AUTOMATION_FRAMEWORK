using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class SecondaryGuardianAdultData : AdultData
    {
        public string SSN { get; set; }

        public string VerifySSN { get; set; }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public string MobilePhone { get; set; }

        public void SetPhoneNumbers(List<PhoneNumber> numbers)
        {
            numbers.ForEach(number =>
                {
                    if (number.Type == "Home") HomePhone = number.Number;
                    if (number.Type == "Work") WorkPhone = number.Number;
                    if (number.Type == "Mobile") MobilePhone = number.Number;
                });
        }

        public SecondaryGuardianAdultData()
        { }

        public SecondaryGuardianAdultData(SecondaryGuardianAdultData adult) : base(adult)
        {
            SSN = adult.SSN;
            VerifySSN = adult.VerifySSN;
            HomePhone = adult.HomePhone;
            WorkPhone = adult.WorkPhone;
            MobilePhone = adult.MobilePhone;
        }
    }
}
