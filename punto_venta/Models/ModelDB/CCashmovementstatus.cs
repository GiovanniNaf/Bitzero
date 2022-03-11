using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CCashmovementstatus
    {
        public CCashmovementstatus()
        {
            PEnterprisebranchcashmovements = new HashSet<PEnterprisebranchcashmovement>();
        }

        public long IdCashMovementStatus { get; set; }
        public string FldcashMovementStatus { get; set; }

        public virtual ICollection<PEnterprisebranchcashmovement> PEnterprisebranchcashmovements { get; set; }
    }
}
