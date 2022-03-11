using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class EnterpriseBranchOutputProductModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchOutput { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldamount { get; set; }
    }
}
