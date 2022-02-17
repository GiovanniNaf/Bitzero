using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class PEnterprisebranchsalepayment
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchSale { get; set; }
        public long IdEnterpriseBranchSalePayment { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public long IdPaymentType { get; set; }
        public long IdPaymentMethod { get; set; }
        public long IdUser { get; set; }
        public decimal Fldamount { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }
        public string FldnumberAccount { get; set; }

        public virtual PEnterprisebranchsale IdEnterprise1 { get; set; }
        public virtual CEnterprisebranchcash IdEnterpriseNavigation { get; set; }
        public virtual CPaymentmethod IdPaymentMethodNavigation { get; set; }
        public virtual CPaymenttype IdPaymentTypeNavigation { get; set; }
        public virtual CEnterprisebranchuser IdUserNavigation { get; set; }
    }
}
