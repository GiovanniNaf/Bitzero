using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CEnterprise
    {
        public CEnterprise()
        {
            CEnterprisebranches = new HashSet<CEnterprisebranch>();
            CEnterprisecustomers = new HashSet<CEnterprisecustomer>();
            CEnterpriseproducts = new HashSet<CEnterpriseproduct>();
            CEnterpriseproviders = new HashSet<CEnterpriseprovider>();
            PEnterprisecreditnotes = new HashSet<PEnterprisecreditnote>();
            PEnterprisetransfers = new HashSet<PEnterprisetransfer>();
        }

        public long IdEnterprise { get; set; }
        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldname { get; set; }
        public string Fldlocality { get; set; }
        public string Fldstreet { get; set; }
        public string Fldnumber { get; set; }
        public string FldpostCode { get; set; }
        public string FldphoneNumber { get; set; }
        public string Fldemail { get; set; }
        public string FldpageWeb { get; set; }

        public virtual CMunicipality Id { get; set; }
        public virtual ICollection<CEnterprisebranch> CEnterprisebranches { get; set; }
        public virtual ICollection<CEnterprisecustomer> CEnterprisecustomers { get; set; }
        public virtual ICollection<CEnterpriseproduct> CEnterpriseproducts { get; set; }
        public virtual ICollection<CEnterpriseprovider> CEnterpriseproviders { get; set; }
        public virtual ICollection<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
        public virtual ICollection<PEnterprisetransfer> PEnterprisetransfers { get; set; }
    }
}
