using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchcashcount
    {
        public PEnterprisebranchcashcount()
        {
            PEnterprisebranchcashcountcashes = new HashSet<PEnterprisebranchcashcountcash>();
            PEnterprisebranchcashcountdocuments = new HashSet<PEnterprisebranchcashcountdocument>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public long IdEnterpriseBranchCashCount { get; set; }
        public long IdUserAuditor { get; set; }
        public long IdUserCashier { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }

        public virtual CEnterprisebranchcash IdEnterpriseNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserAuditorNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserCashierNavigation { get; set; }
        public virtual ICollection<PEnterprisebranchcashcountcash> PEnterprisebranchcashcountcashes { get; set; }
        public virtual ICollection<PEnterprisebranchcashcountdocument> PEnterprisebranchcashcountdocuments { get; set; }
    }
}
