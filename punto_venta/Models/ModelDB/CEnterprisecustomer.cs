using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisecustomer
    {
        public CEnterprisecustomer()
        {
            PEnterprisebranchquotes = new HashSet<PEnterprisebranchquote>();
            PEnterprisebranchsales = new HashSet<PEnterprisebranchsale>();
            PEnterprisecreditnotes = new HashSet<PEnterprisecreditnote>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public long IdPersonType { get; set; }
        public long IdCustomerType { get; set; }
        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldkey { get; set; }
        public string Fldrfc { get; set; }
        public string Fldhomoclave { get; set; }
        public string Fldlocality { get; set; }
        public string Fldstreet { get; set; }
        public string Fldnumber { get; set; }
        public string FldpostCode { get; set; }
        public string FldphoneNumber { get; set; }
        public string Fldemail { get; set; }
        public short Fldactive { get; set; }

        public virtual CMunicipality Id { get; set; }
        public virtual CCustomertype IdCustomerTypeNavigation { get; set; }
        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual CPersontype IdPersonTypeNavigation { get; set; }
        public virtual CEnterprisebusinesscustomer CEnterprisebusinesscustomer { get; set; }
        public virtual CEnterpriseindividualcustomer CEnterpriseindividualcustomer { get; set; }
        public virtual ICollection<PEnterprisebranchquote> PEnterprisebranchquotes { get; set; }
        public virtual ICollection<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
        public virtual ICollection<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
    }
}
