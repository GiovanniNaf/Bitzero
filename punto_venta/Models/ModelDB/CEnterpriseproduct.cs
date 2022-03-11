using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterpriseproduct
    {
        public CEnterpriseproduct()
        {
            CEnterprisebranchproducts = new HashSet<CEnterprisebranchproduct>();
            PEnterprisetransferproducts = new HashSet<PEnterprisetransferproduct>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public long IdProductType { get; set; }
        public long IdProductMeasureUnit { get; set; }
        public string Fldkey { get; set; }
        public string FldkeySat { get; set; }
        public string Fldname { get; set; }
        public string Flddescription { get; set; }
        public string Fldimage { get; set; }
        public short Fldactive { get; set; }

        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual CProductmeasureunit IdProductMeasureUnitNavigation { get; set; }
        public virtual CProducttype IdProductTypeNavigation { get; set; }
        public virtual ICollection<CEnterprisebranchproduct> CEnterprisebranchproducts { get; set; }
        public virtual ICollection<PEnterprisetransferproduct> PEnterprisetransferproducts { get; set; }
    }
}
