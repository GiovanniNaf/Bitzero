using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class EnterprisebranchcashModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdEnterpriseBranchCash { get; set; }
        public string Fldname { get; set; }
    }
}
