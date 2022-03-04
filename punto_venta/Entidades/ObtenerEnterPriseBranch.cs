using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterPriseBranch
    {
        [Key]
        public long Sede { get; set; }
        public long Subsede { get; set; }
        public string Nombre { get; set; }
     }
}
