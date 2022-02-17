using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchcashcountdocument
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public long IdEnterpriseBranchCashCount { get; set; }
        public long IdEnterpriseBranchCashCountDocument { get; set; }
        public long IdDocumentType { get; set; }
        public string Fldconcept { get; set; }
        public decimal Fldvalue { get; set; }

        public virtual CDocumenttype IdDocumentTypeNavigation { get; set; }
        public virtual PEnterprisebranchcashcount IdEnterpriseNavigation { get; set; }
    }
}
