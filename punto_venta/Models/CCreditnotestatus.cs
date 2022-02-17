using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CCreditnotestatus
    {
        public CCreditnotestatus()
        {
            PEnterprisecreditnotes = new HashSet<PEnterprisecreditnote>();
        }

        public long IdCreditNoteStatus { get; set; }
        public string FldcreditNoteStatus { get; set; }

        public virtual ICollection<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
    }
}
