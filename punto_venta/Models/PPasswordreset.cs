using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PPasswordreset
    {
        public string IdPasswordReset { get; set; }
        public long IdPasswordResetStatus { get; set; }
        public long IdUser { get; set; }
        public DateTime FldeffectiveStartDate { get; set; }
        public DateTime FldeffectiveEndDate { get; set; }

        public virtual CPasswordresetstatus IdPasswordResetStatusNavigation { get; set; }
        public virtual CUser IdUserNavigation { get; set; }
    }
}
