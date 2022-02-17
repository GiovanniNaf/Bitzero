using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CUserstatus
    {
        public CUserstatus()
        {
            CUsers = new HashSet<CUser>();
        }

        public long IdUserStatus { get; set; }
        public string FlduserStatus { get; set; }

        public virtual ICollection<CUser> CUsers { get; set; }
    }
}
