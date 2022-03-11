using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models.ModelBase
{
    public class EnterprisebranchsaledeliveryModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchSale { get; set; }
        public long IdUser { get; set; }
        public DateTime FldrecordDate { get; set; }
        public string Fldobservation { get; set; }
    }
}
