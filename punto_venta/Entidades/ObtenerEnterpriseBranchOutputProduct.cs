using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterpriseBranchOutputProduct
    {
        [Key]
        public long Numero_de_empresa { get; set; }
        public long Numero_de_la_rama_de_la_empresa { get; set; }
        public long Numero_de_salida_de_sucursal { get; set; }
        public long Numero_del_producto_de_la_empresa { get; set; }
        public decimal Cantidad { get; set; }
    }
}
