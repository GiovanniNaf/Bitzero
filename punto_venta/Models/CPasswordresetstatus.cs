using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CPasswordresetstatus
    {
        public CPasswordresetstatus()
        {
            PPasswordresets = new HashSet<PPasswordreset>();
        }

        public long IdPasswordResetStatus { get; set; }
        public string FldpasswordResetStatus { get; set; }

        public virtual ICollection<PPasswordreset> PPasswordresets { get; set; }
    }
}
