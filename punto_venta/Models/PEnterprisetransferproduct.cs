using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisetransferproduct
    {
        public long IdEnterprise { get; set; }
        public string IdEnterpriseTransfer { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldamount { get; set; }

        public virtual PEnterprisetransfer IdEnterprise1 { get; set; }
        public virtual CEnterpriseproduct IdEnterpriseNavigation { get; set; }
    }
}
