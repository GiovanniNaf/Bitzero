using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprisebranchuseraccessprivilege
    {
        public long IdUser { get; set; }
        public long IdAccessPrivilege { get; set; }

        public virtual CAccessprivilege IdAccessPrivilegeNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
    }
}
