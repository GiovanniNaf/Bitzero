using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CCustomertype
    {
        public CCustomertype()
        {
            CEnterprisecustomers = new HashSet<CEnterprisecustomer>();
        }

        public long IdCustomerType { get; set; }
        public string FldcustomerType { get; set; }

        public virtual ICollection<CEnterprisecustomer> CEnterprisecustomers { get; set; }
    }
}
