using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CAccessprivilegetype
    {
        public CAccessprivilegetype()
        {
            CAccessprivileges = new HashSet<CAccessprivilege>();
        }

        public long IdAccessPrivilegeType { get; set; }
        public string FldaccessPrivilegeType { get; set; }

        public virtual ICollection<CAccessprivilege> CAccessprivileges { get; set; }
    }
}
