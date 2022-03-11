using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CSalestatus
    {
        public CSalestatus()
        {
            PEnterprisebranchsales = new HashSet<PEnterprisebranchsale>();
        }

        public long IdSaleStatus { get; set; }
        public string FldsaleStatus { get; set; }

        public virtual ICollection<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
    }
}
