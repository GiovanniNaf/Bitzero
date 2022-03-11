using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CAccessprivilege
    {
        public CAccessprivilege()
        {
            CEnterprisebranchuseraccessprivileges = new HashSet<CEnterprisebranchuseraccessprivilege>();
        }

        public long IdAccessPrivilege { get; set; }
        public long IdAccessPrivilegeType { get; set; }
        public string FldaccessPrivilege { get; set; }
        public string Fldlevel1 { get; set; }
        public string Fldlevel2 { get; set; }
        public string Fldlevel3 { get; set; }
        public string Fldlevel4 { get; set; }
        public string Fldurl { get; set; }
        public string FldiconName { get; set; }

        public virtual CAccessprivilegetype IdAccessPrivilegeTypeNavigation { get; set; }
        public virtual ICollection<CEnterprisebranchuseraccessprivilege> CEnterprisebranchuseraccessprivileges { get; set; }
    }
}
