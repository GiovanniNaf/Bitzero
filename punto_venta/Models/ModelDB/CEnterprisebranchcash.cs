using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebranchcash
    {
        public CEnterprisebranchcash()
        {
            PEnterprisebranchcashcounts = new HashSet<PEnterprisebranchcashcount>();
            PEnterprisebranchcashmovements = new HashSet<PEnterprisebranchcashmovement>();
            PEnterprisebranchsalepayments = new HashSet<PEnterprisebranchsalepayment>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public string Fldname { get; set; }

        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual ICollection<PEnterprisebranchcashcount> PEnterprisebranchcashcounts { get; set; }
        public virtual ICollection<PEnterprisebranchcashmovement> PEnterprisebranchcashmovements { get; set; }
        public virtual ICollection<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
    }
}
