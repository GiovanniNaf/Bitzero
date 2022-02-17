using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class COutputtype
    {
        public COutputtype()
        {
            PEnterprisebranchoutputs = new HashSet<PEnterprisebranchoutput>();
        }

        public long IdOutputType { get; set; }
        public string FldoutputType { get; set; }

        public virtual ICollection<PEnterprisebranchoutput> PEnterprisebranchoutputs { get; set; }
    }
}
