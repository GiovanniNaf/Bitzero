using System;
namespace punto_venta.Models.DTOS
{
    public class EnterpriseBranchOutputProductDTO
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchOutput { get; set; }
        public long IdEnterpriseProduct { get; set; }
        public decimal Fldamount { get; set; }
    }
}
