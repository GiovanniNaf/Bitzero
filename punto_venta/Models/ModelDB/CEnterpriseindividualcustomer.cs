using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterpriseindividualcustomer
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public string Fldname { get; set; }
        public string FldfirstName { get; set; }
        public string FldlastName { get; set; }

        public virtual CEnterprisecustomer IdEnterpriseNavigation { get; set; }
    }
}
