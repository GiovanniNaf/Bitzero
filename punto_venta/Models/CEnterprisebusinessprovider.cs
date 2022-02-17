using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebusinessprovider
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseProvider { get; set; }
        public string FldbusinessName { get; set; }

        public virtual CEnterpriseprovider IdEnterpriseNavigation { get; set; }
    }
}
