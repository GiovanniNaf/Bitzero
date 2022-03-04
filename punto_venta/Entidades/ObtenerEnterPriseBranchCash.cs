using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterPriseBranchCash
    {
        [Key]
        public long Numero_de_empresa{ get; set; }
        public long Numero_de_la_sucursal { get; set; }
        public long Numero_de_caja { get; set; }
        public string Nombre_de_caja { get; set; }
    }
}
