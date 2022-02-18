using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models
{
    public class LoginModel
    {
       [Required(ErrorMessage = "Password is required") ]
        public string Fldpassword { get; set; }

        [Required(ErrorMessage = "Username is required")]

        public string Fldname { get; set; }

    }
}
