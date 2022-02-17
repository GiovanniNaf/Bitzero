using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebranch
    {
        public CEnterprisebranch()
        {
            CEnterprisebranchcashes = new HashSet<CEnterprisebranchcash>();
            CEnterprisebranchproducts = new HashSet<CEnterprisebranchproduct>();
            CEnterprisebranchusers = new HashSet<CEnterprisebranchuser>();
            PEnterprisebranchoutputs = new HashSet<PEnterprisebranchoutput>();
            PEnterprisebranchpurchases = new HashSet<PEnterprisebranchpurchase>();
            PEnterprisebranchquotes = new HashSet<PEnterprisebranchquote>();
            PEnterprisebranchsales = new HashSet<PEnterprisebranchsale>();
            PEnterprisecreditnotes = new HashSet<PEnterprisecreditnote>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldrfc { get; set; }
        public string Fldhomoclave { get; set; }
        public string Fldname { get; set; }
        public string Fldlocality { get; set; }
        public string Fldstreet { get; set; }
        public string Fldnumber { get; set; }
        public string FldpostCode { get; set; }
        public string FldphoneNumber { get; set; }
        public string FldmovilNumber { get; set; }
        public string Fldemail { get; set; }
        public string FldfiscalName { get; set; }
        public string FldpasswordFiel { get; set; }
        public string FldpasswordInvoice { get; set; }

        public virtual CMunicipality Id { get; set; }
        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual ICollection<CEnterprisebranchcash> CEnterprisebranchcashes { get; set; }
        public virtual ICollection<CEnterprisebranchproduct> CEnterprisebranchproducts { get; set; }
        public virtual ICollection<CEnterprisebranchuser> CEnterprisebranchusers { get; set; }
        public virtual ICollection<PEnterprisebranchoutput> PEnterprisebranchoutputs { get; set; }
        public virtual ICollection<PEnterprisebranchpurchase> PEnterprisebranchpurchases { get; set; }
        public virtual ICollection<PEnterprisebranchquote> PEnterprisebranchquotes { get; set; }
        public virtual ICollection<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
        public virtual ICollection<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
    }
}
