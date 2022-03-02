using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Models.Viewmodel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "El usuario es obligatorio.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "La clave es obligatoria.")]
        public string Clave { get; set; }
    }
}
