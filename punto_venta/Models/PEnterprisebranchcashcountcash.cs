using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchcashcountcash
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public long IdEnterpriseBranchCashCount { get; set; }
        public long IdEnterpriseBranchCashCountCash { get; set; }
        public long IdCashType { get; set; }
        public long Fldamount { get; set; }
        public decimal Fldvalue { get; set; }

        public virtual CCashtype IdCashTypeNavigation { get; set; }
        public virtual PEnterprisebranchcashcount IdEnterpriseNavigation { get; set; }
    }
}
