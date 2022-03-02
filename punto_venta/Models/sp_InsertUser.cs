using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class sp_InsertUser
    {
        [Key]
        public long IdUser { get; set; }
        public long IdUserType { get; set; }
        public long IdUserStatus { get; set; }
        public string Fldpassword { get; set; }
        public string FldemailAccount { get; set; }
        public string Fldname { get; set; }
        public string FldlastName { get; set; }
        public string FldfirstName { get; set; }
    }
}
