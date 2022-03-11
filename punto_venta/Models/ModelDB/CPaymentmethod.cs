using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CPaymentmethod
    {
        public CPaymentmethod()
        {
            PEnterprisebranchsalepayments = new HashSet<PEnterprisebranchsalepayment>();
        }

        public long IdPaymentMethod { get; set; }
        public string FldpaymentMethod { get; set; }
        public string Fldkey { get; set; }

        public virtual ICollection<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
    }
}
