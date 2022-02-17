using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CUser
    {
        public CUser()
        {
            PPasswordresets = new HashSet<PPasswordreset>();
        }

        public long IdUser { get; set; }
        public long IdUserType { get; set; }
        public long IdUserStatus { get; set; }
        public string FldfirstName { get; set; }
        public string FldlastName { get; set; }
        public string Fldname { get; set; }
        public string Fldpassword { get; set; }
        public string FldemailAccount { get; set; }

        public virtual CUserstatus IdUserStatusNavigation { get; set; }
        public virtual CUsertype IdUserTypeNavigation { get; set; }
        public virtual CEnterprisebranchuser CEnterprisebranchuser { get; set; }
        public virtual ICollection<PPasswordreset> PPasswordresets { get; set; }
    }
}
