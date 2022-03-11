using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchsale
    {
        public PEnterprisebranchsale()
        {
            PEnterprisebranchsalepayments = new HashSet<PEnterprisebranchsalepayment>();
            PEnterprisebranchsaleproducts = new HashSet<PEnterprisebranchsaleproduct>();
        }

        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchSale { get; set; }
        public long IdEnterpriseCustomer { get; set; }
        public long IdSaleStatus { get; set; }
        public long IdPaymentStatus { get; set; }
        public long IdUser { get; set; }
        public long IdUseCfdi { get; set; }
        public DateTime FldsaleDate { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string FldinvoiceName { get; set; }

        public virtual CEnterprisecustomer IdEnterprise1 { get; set; }
        public virtual CEnterprisebranch IdEnterpriseNavigation { get; set; }
        public virtual CPaymentstatus IdPaymentStatusNavigation { get; set; }
        public virtual CSalestatus IdSaleStatusNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
        public virtual PEnterprisebranchsaledelivery PEnterprisebranchsaledelivery { get; set; }
        public virtual ICollection<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
        public virtual ICollection<PEnterprisebranchsaleproduct> PEnterprisebranchsaleproducts { get; set; }
    }
}
