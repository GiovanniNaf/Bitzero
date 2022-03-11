using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchoutputproduct
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchOutput { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldamount { get; set; }

        public virtual CEnterprisebranchproduct IdEnterprise1 { get; set; }
        public virtual PEnterprisebranchoutput IdEnterpriseNavigation { get; set; }
    }
}
