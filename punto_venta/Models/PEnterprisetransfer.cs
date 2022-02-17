using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisetransfer
    {
        public PEnterprisetransfer()
        {
            PEnterprisetransferproducts = new HashSet<PEnterprisetransferproduct>();
        }

        public long IdEnterprise { get; set; }
        public string IdEnterpriseTransfer { get; set; }
        public long IdTransferType { get; set; }
        public long IdTransferStatus { get; set; }
        public long IdEnterpriseBranchSource { get; set; }
        public long IdEnterpriseBranchDestination { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }

        public virtual CEnterprise IdEnterpriseNavigation { get; set; }
        public virtual ICollection<PEnterprisetransferproduct> PEnterprisetransferproducts { get; set; }
    }
}
