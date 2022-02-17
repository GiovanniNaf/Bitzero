using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebusinesscustomer
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public string FldbusinessName { get; set; }

        public virtual CEnterprisecustomer IdEnterpriseNavigation { get; set; }
    }
}
