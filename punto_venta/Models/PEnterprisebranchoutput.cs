using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchoutput
    {
        public PEnterprisebranchoutput()
        {
            PEnterprisebranchoutputproducts = new HashSet<PEnterprisebranchoutputproduct>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchOutput { get; set; }
        public long IdOutputType { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }

        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual COutputtype IdOutputTypeNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
        public virtual ICollection<PEnterprisebranchoutputproduct> PEnterprisebranchoutputproducts { get; set; }
    }
}
