using System;
namespace punto_venta.Models.DTOS
{
    public class UsuarioDTO
    {
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
