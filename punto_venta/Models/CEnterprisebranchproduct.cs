using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebranchproduct
    {
        public CEnterprisebranchproduct()
        {
            PEnterprisebranchoutputproducts = new HashSet<PEnterprisebranchoutputproduct>();
            PEnterprisebranchquoteproducts = new HashSet<PEnterprisebranchquoteproduct>();
            PEnterprisebranchsaleproducts = new HashSet<PEnterprisebranchsaleproduct>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldstock { get; set; }
        public decimal FldminimumStock { get; set; }
        public decimal FldmaximumStock { get; set; }
        public double FldretailSellingPrice { get; set; }
        public double FldwholesaleSellingPrice { get; set; }

        public virtual CEnterpriseproduct IdEnterprise1 { get; set; }
        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual ICollection<PEnterprisebranchoutputproduct> PEnterprisebranchoutputproducts { get; set; }
        public virtual ICollection<PEnterprisebranchquoteproduct> PEnterprisebranchquoteproducts { get; set; }
        public virtual ICollection<PEnterprisebranchsaleproduct> PEnterprisebranchsaleproducts { get; set; }
    }
}
