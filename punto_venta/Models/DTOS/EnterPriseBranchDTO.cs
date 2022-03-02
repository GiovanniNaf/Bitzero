using System;
namespace punto_venta.Models.DTOS
{
    public class EnterPriseBranchDTO
    {
        public long IdEnterprise { get; set; }
        public long IdEnterpriseBranch { get; set; }
        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldrfc { get; set; }
        public string Fldhomoclave { get; set; }
        public string Fldname { get; set; }
        public string Fldlocality { get; set; }
        public string Fldstreet { get; set; }
        public string Fldnumber { get; set; }
        public string FldpostCode { get; set; }
        public string FldphoneNumber { get; set; }
        public string FldmovilNumber { get; set; }
        public string Fldemail { get; set; }
        public string FldfiscalName { get; set; }
        public string FldpasswordFiel { get; set; }
        public string FldpasswordInvoice { get; set; }
    }
}
