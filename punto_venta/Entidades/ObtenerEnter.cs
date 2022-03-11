using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Data
{
    public class ObtenerEnter
    { 
        [Key]
        public long Numero_de_empresa { get; set; }
        public long Estado { get; set; }
        public long Municipio { get; set; }
        public string Nombre_de_la_empresa { get; set; }
        public string Ubicacion { get; set; }
        public string Calle { get; set; }
        public string Numero_exterior { get; set; }
        public string Codigo_postal { get; set; }
        public string Numero_telefonico { get; set; }
        public string Correo { get; set; }
        public string Pagina_web { get; set; }
    }

}
