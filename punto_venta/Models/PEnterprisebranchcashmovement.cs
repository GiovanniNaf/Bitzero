using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchcashmovement
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public long IdEnterpriseBranchCashMovement { get; set; }
        public long IdCashMovementStatus { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public TimeSpan FldopenTime { get; set; }
        public decimal FldopenAmount { get; set; }
        public TimeSpan? FldcloseTime { get; set; }
        public decimal FldcloseAmount { get; set; }

        public virtual CCashmovementstatus IdCashMovementStatusNavigation { get; set; }
        public virtual CEnterprisebranchcash IdEnterpriseNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
    }
}
