using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CCashtype
    {
        public CCashtype()
        {
            PEnterprisebranchcashcountcashes = new HashSet<PEnterprisebranchcashcountcash>();
        }

        public long IdCashType { get; set; }
        public string FldcashType { get; set; }

        public virtual ICollection<PEnterprisebranchcashcountcash> PEnterprisebranchcashcountcashes { get; set; }
    }
}
