using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CState
    {
        public CState()
        {
            CMunicipalities = new HashSet<CMunicipality>();
        }

        public long IdState { get; set; }
        public string Fldstate { get; set; }

        public virtual ICollection<CMunicipality> CMunicipalities { get; set; }
    }
}
