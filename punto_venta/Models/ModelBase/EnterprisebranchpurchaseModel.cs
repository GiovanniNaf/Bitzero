using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class EnterprisebranchpurchaseModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public string IdEnterpriseBranchPurchase { get; set; }
        public long IdEnterpriseProvider { get; set; }
        public DateTime FldpurchaseDate { get; set; }
        public string FldinvoiceNumber { get; set; }
        public DateTime? FldinvoiceDate { get; set; }
        public DateTime? FldentryDateToWarehouse { get; set; }
        public string Fldobservation { get; set; }
    }
}
