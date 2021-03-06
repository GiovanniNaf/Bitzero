using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class EnterModel
    {
        [Key]
        public long IdEnterprise { get; set; }
        public long IdState { get; set; }
        public long IdMunicipality { get; set; }
        public string Fldname { get; set; }
        public string Fldlocality { get; set; }
        public string Fldstreet { get; set; }
        public string Fldnumber { get; set; }
        public string FldpostCode { get; set; }
        public string FldphoneNumber { get; set; }
        public string Fldemail { get; set; }
        public string FldpageWeb { get; set; }
    }
}
