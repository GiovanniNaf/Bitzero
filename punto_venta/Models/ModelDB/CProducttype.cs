using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CProducttype
    {
        public CProducttype()
        {
            CEnterpriseproducts = new HashSet<CEnterpriseproduct>();
        }

        public long IdProductType { get; set; }
        public string FldproductType { get; set; }

        public virtual ICollection<CEnterpriseproduct> CEnterpriseproducts { get; set; }
    }
}
