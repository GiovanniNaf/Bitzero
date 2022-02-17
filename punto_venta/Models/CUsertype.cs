using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CUsertype
    {
        public CUsertype()
        {
            CUsers = new HashSet<CUser>();
        }

        public long IdUserType { get; set; }
        public string FlduserType { get; set; }

        public virtual ICollection<CUser> CUsers { get; set; }
    }
}
