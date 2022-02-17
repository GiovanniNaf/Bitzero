using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CPaymentstatus
    {
        public CPaymentstatus()
        {
            PEnterprisebranchsales = new HashSet<PEnterprisebranchsale>();
        }

        public long IdPaymentStatus { get; set; }
        public string FldpaymentStatus { get; set; }

        public virtual ICollection<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
    }
}
