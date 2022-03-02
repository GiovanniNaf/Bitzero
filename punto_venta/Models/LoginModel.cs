using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class LoginModel
    {

        [Key]
        public string Fldname { get; set; }

        public string Fldpassword { get; set; }
        
    }
}
