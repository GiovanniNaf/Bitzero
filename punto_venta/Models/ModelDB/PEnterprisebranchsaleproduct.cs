using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchsaleproduct
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchSale { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldamount { get; set; }
        public double Fldprice { get; set; }
        public double FldpriceSale { get; set; }

        public virtual CEnterprisebranchproduct IdEnterprise1 { get; set; }
        public virtual PEnterprisebranchsale IdEnterpriseNavigation { get; set; }
    }
}
