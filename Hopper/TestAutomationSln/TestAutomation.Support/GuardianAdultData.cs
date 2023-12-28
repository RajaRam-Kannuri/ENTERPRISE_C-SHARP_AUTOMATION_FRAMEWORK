using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class GuardianAdultData : SecondaryGuardianAdultData
    {
        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public bool DifferentMailingAddress { get; set; }

        public AddressData PhysicalAddress { get; set; }

        public AddressData MailingAddress { get; set; }

        public string MaritalStatus { get; set; }

        public string HouseholdLanguage { get; set; }

        public string FoodStamps { get; set; }

        public GuardianAdultData()
        {
            PhysicalAddress = new AddressData();
            MailingAddress = new AddressData();
        }

        public GuardianAdultData(GuardianAdultData adult) : base(adult)
        {
            SecurityQuestion = adult.SecurityQuestion;
            SecurityAnswer = adult.SecurityAnswer;
            DifferentMailingAddress = adult.DifferentMailingAddress;
            PhysicalAddress = new AddressData(adult.PhysicalAddress);
            MailingAddress = new AddressData(adult.MailingAddress);
            MaritalStatus = adult.MaritalStatus;
            HouseholdLanguage = adult.HouseholdLanguage;
            FoodStamps = adult.FoodStamps;
        }
    }
}
