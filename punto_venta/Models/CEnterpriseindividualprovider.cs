using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterpriseindividualprovider
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseProvider { get; set; }
        public string Fldname { get; set; }
        public string FldfirstName { get; set; }
        public string FldlastName { get; set; }

        public virtual CEnterpriseprovider IdEnterpriseNavigation { get; set; }
    }
}
