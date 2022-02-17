using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisecreditnote
    {
        public long IdEnterprise { get; set; }
        public string IdEnterpriseCreditNote { get; set; }
        public long IdCreditNoteStatus { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public decimal Fldvalue { get; set; }
        public string Fldobservation { get; set; }

        public virtual CCreditnotestatus IdCreditNoteStatusNavigation { get; set; }
        public virtual CEnterprisebranch IdEnterprise1 { get; set; }
        public virtual CEnterprisecustomer IdEnterprise2 { get; set; }
        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
    }
}
