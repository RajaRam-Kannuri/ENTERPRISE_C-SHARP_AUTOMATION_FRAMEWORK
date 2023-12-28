using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class ApplicationProcessingData
    {
        public ApplicationDetails ApplicationDetails { get; set; }

        public HouseholdDetails HouseholdDetails { get; set; }

        public CategoricalEligibility CategoricalEligibility { get; set; }

        public HouseholdAddress HouseholdAddress { get; set; }

        public Authorizations Authorizations { get; set; }

        public WorkflowStatus WorkflowStatus { get; set; }

        public Notes Notes { get; set; }

        public Student Student { get; set; }

        public HouseholdComposition HouseholdComposition { get; set; }

        public Income Income { get; set; }

        public RequiredDocuments RequiredDocuments { get; set; }

        public ContactLog ContactLog { get; set; }

        public Transactions Transactions { get; set; }

        public HistoricalDocuments HistoricalDocuments { get; set; }

        public ApplicationProcessingData()
        {
            ApplicationDetails = new ApplicationDetails();
            HouseholdDetails = new HouseholdDetails();
            CategoricalEligibility = new CategoricalEligibility();
            HouseholdAddress = new HouseholdAddress();
            Authorizations = new Authorizations();
            WorkflowStatus = new WorkflowStatus();
            Notes = new Notes();
            Student = new Student();
            HouseholdComposition = new HouseholdComposition();
            Income = new Income();
            RequiredDocuments = new RequiredDocuments();
            ContactLog = new ContactLog();
            Transactions = new Transactions();
            HistoricalDocuments = new HistoricalDocuments();
        }
    }

    public class ApplicationDetails
    {
        public string Id { get; set; }

        public string Year { get; set; }

        public string SubmissionDate { get; set; }

        public string ApplicationType { get; set; }
    }

    public class HouseholdDetails
    {
        public string Language { get; set; }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }
    }

    public class CategoricalEligibility
    {
        public string DirectCertificationHousehold { get; set; }

        public string AssistanceProgramHousehold { get; set; }
    }

    public class HouseholdAddress
    {
        public string PhysicalAddress { get; set; }

        public string PhysicalAddressCity { get; set; }

        public string PhysicalAddressState { get; set; }

        public string PhysicalAddressZip { get; set; }

        public string MailingAddress { get; set; }

        public string MailingAddressCity { get; set; }

        public string MailingAddressState { get; set; }

        public string MailingAddressZip { get; set; }
    }

    public class Authorizations
    {
        public string AuthorizationToCheckAgencies { get; set; }
    }

    public class WorkflowStatus
    {
        public string CurrentWorkflowStatus { get; set; }
    }

    public class Notes
    {
        public string NoteType { get; set; }

        public string HouseholdMember { get; set; }

        public string SensitiveNote { get; set; }

        public string NoteText { get; set; }
    }

    public class Student
    {

    }

    public class HouseholdComposition
    {
    }

    public class Income
    {
    }

    public class RequiredDocuments
    {
    }

    public class ContactLog
    {
    }

    public class Transactions
    {
    }

    public class HistoricalDocuments
    {
    }
}
