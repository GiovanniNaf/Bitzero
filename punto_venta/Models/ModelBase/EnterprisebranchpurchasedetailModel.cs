using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class EnterprisebranchpurchasedetailModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchPurchase { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal FldunitAmount { get; set; }
        public double Fldprice { get; set; }
    }
}
