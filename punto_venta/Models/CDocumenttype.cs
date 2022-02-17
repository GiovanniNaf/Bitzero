using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CDocumenttype
    {
        public CDocumenttype()
        {
            PEnterprisebranchcashcountdocuments = new HashSet<PEnterprisebranchcashcountdocument>();
        }

        public long IdDocumentType { get; set; }
        public string FlddocumentType { get; set; }

        public virtual ICollection<PEnterprisebranchcashcountdocument> PEnterprisebranchcashcountdocuments { get; set; }
    }
}
