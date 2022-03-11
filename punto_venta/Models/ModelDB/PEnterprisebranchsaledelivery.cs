using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchsaledelivery
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchSale { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }

        public virtual PEnterprisebranchsale IdEnterpriseNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
    }
}
