using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerUsuario
    {
        [Key]
        public long id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Contrasena{ get; set; }
        public string Correo{ get; set; }
    }
}
