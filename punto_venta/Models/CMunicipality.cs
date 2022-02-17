using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CMunicipality
    {
        public CMunicipality()
        {
            CEnterprisebranches = new HashSet<CEnterprisebranch>();
            CEnterprisecustomers = new HashSet<CEnterprisecustomer>();
            CEnterpriseproviders = new HashSet<CEnterpriseprovider>();
            CEnterprises = new HashSet<CEnterprise>();
        }

        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldmunicipality { get; set; }

        public virtual CState IdStateNavigation { get; set; }
        public virtual ICollection<CEnterprisebranch> CEnterprisebranches { get; set; }
        public virtual ICollection<CEnterprisecustomer> CEnterprisecustomers { get; set; }
        public virtual ICollection<CEnterpriseprovider> CEnterpriseproviders { get; set; }
        public virtual ICollection<CEnterprise> CEnterprises { get; set; }
    }
}
