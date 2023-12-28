using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Support
{
    public class NoteData
    {
        /// <summary>
        /// This can be used for either a Type or Reason select list
        /// </summary>
        public string TypeOrReason { get; set; }

        /// <summary>
        /// This can be used to cover household members, children, line items
        /// or any sub-element that composes the larger entity.
        /// </summary>
        public string EntityElement { get; set; }

        public bool Sensitive { get; set; }

        public string NoteText { get; set; }

        public string Date { get; set; }

        public string Creator { get; set; }

        public NoteData()
        {
            Sensitive = false;
        }
    }
}
