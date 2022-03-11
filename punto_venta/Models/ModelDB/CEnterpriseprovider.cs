using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterpriseprovider
    {
        public CEnterpriseprovider()
        {
            PEnterprisebranchpurchases = new HashSet<PEnterprisebranchpurchase>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseProvider { get; set; }
        public long IdPersonType { get; set; }
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
        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual CPersontype IdPersonTypeNavigation { get; set; }
        public virtual CEnterprisebusinessprovider CEnterprisebusinessprovider { get; set; }
        public virtual CEnterpriseindividualprovider CEnterpriseindividualprovider { get; set; }
        public virtual ICollection<PEnterprisebranchpurchase> PEnterprisebranchpurchases { get; set; }
    }
}
