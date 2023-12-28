using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class PLSAReimbursementItemData
    {
        public string Category { get; set; }

        public string Type { get; set; }

        public string Detail { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public decimal TaxRate { get; set; }

        public decimal Total { get; set; }

        public int Id { get; set; }

        public string Status { get; set; }

        public PLSAReimbursementItemData()
        {
        }

        public PLSAReimbursementItemData(PLSAPreAuthorizationItemData lineItem)
        {
            Category = lineItem.Category;
            Type = lineItem.Type;
            Detail = lineItem.Detail;
            Description = lineItem.Description;
            Amount = lineItem.Amount;
        }
    }
}
