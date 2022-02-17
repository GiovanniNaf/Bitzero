using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebranchuser
    {
        public CEnterprisebranchuser()
        {
            CEnterprisebranchuseraccessprivileges = new HashSet<CEnterprisebranchuseraccessprivilege>();
            PEnterprisebranchcashcountIdUserAuditorNavigations = new HashSet<PEnterprisebranchcashcount>();
            PEnterprisebranchcashcountIdUserCashierNavigations = new HashSet<PEnterprisebranchcashcount>();
            PEnterprisebranchcashmovements = new HashSet<PEnterprisebranchcashmovement>();
            PEnterprisebranchoutputs = new HashSet<PEnterprisebranchoutput>();
            PEnterprisebranchquotes = new HashSet<PEnterprisebranchquote>();
            PEnterprisebranchsaledeliveries = new HashSet<PEnterprisebranchsaledelivery>();
            PEnterprisebranchsalepayments = new HashSet<PEnterprisebranchsalepayment>();
            PEnterprisebranchsales = new HashSet<PEnterprisebranchsale>();
            PEnterprisecreditnotes = new HashSet<PEnterprisecreditnote>();
        }

        public long IdUser { get; set; }
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string Fldworkstation { get; set; }

        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual CUser IdUserNavigation { get; set; }
        public virtual ICollection<CEnterprisebranchuseraccessprivilege> CEnterprisebranchuseraccessprivileges { get; set; }
        public virtual ICollection<PEnterprisebranchcashcount> PEnterprisebranchcashcountIdUserAuditorNavigations { get; set; }
        public virtual ICollection<PEnterprisebranchcashcount> PEnterprisebranchcashcountIdUserCashierNavigations { get; set; }
        public virtual ICollection<PEnterprisebranchcashmovement> PEnterprisebranchcashmovements { get; set; }
        public virtual ICollection<PEnterprisebranchoutput> PEnterprisebranchoutputs { get; set; }
        public virtual ICollection<PEnterprisebranchquote> PEnterprisebranchquotes { get; set; }
        public virtual ICollection<PEnterprisebranchsaledelivery> PEnterprisebranchsaledeliveries { get; set; }
        public virtual ICollection<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
        public virtual ICollection<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
        public virtual ICollection<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
    }
}
