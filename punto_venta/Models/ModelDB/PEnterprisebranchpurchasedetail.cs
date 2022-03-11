using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchpurchasedetail
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchPurchase { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal FldunitAmount { get; set; }
        public double Fldprice { get; set; }
    }
}
