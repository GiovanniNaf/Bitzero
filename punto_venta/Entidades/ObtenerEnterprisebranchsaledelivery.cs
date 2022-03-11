using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterprisebranchsaledelivery
    {
        [Key]
        public long Numero_de_empresa { get; set; }
        public long Numero_de_sucursal { get; set; }
        public string Numero_de_rebaja { get; set; }
        public long Numero_de_cliente { get; set; }
        public DateTime fecha_de_compra { get; set; }
        public string observaciones { get; set; }
    }
}
