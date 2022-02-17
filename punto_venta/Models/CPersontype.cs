using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CPersontype
    {
        public CPersontype()
        {
            CEnterprisecustomers = new HashSet<CEnterprisecustomer>();
            CEnterpriseproviders = new HashSet<CEnterpriseprovider>();
        }

        public long IdPersonType { get; set; }
        public string FldpersonType { get; set; }

        public virtual ICollection<CEnterprisecustomer> CEnterprisecustomers { get; set; }
        public virtual ICollection<CEnterpriseprovider> CEnterpriseproviders { get; set; }
    }
}
