using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchquote
    {
        public PEnterprisebranchquote()
        {
            PEnterprisebranchquoteproducts = new HashSet<PEnterprisebranchquoteproduct>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchQuote { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public long IdUser { get; set; }
        public string Fldquotient { get; set; }
        public DateTime FldrecordDate { get; set; }

        public virtual CEnterprisecustomer IdEnterprise1 { get; set; }
        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
        public virtual ICollection<PEnterprisebranchquoteproduct> PEnterprisebranchquoteproducts { get; set; }
    }
}
