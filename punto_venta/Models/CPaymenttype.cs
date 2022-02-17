using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CPaymenttype
    {
        public CPaymenttype()
        {
            PEnterprisebranchsalepayments = new HashSet<PEnterprisebranchsalepayment>();
        }

        public long IdPaymentType { get; set; }
        public string FldpaymentType { get; set; }
        public string Fldkey { get; set; }

        public virtual ICollection<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
    }
}
