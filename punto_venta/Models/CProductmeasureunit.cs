using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CProductmeasureunit
    {
        public CProductmeasureunit()
        {
            CEnterpriseproducts = new HashSet<CEnterpriseproduct>();
        }

        public long IdProductMeasureUnit { get; set; }
        public string FldproductMeasureUnit { get; set; }
        public string FldunitKeySat { get; set; }

        public virtual ICollection<CEnterpriseproduct> CEnterpriseproducts { get; set; }
    }
}
