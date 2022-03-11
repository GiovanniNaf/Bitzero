using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterprisebranchpurchasedetail
    {
        [Key]
        public long Numero_de_la_empresa { get; set; }
        public long Numero_de_sucursal { get; set; }
        public string Numero_de_la_sucursal_comprada { get; set; }
        public long Producto_de_la_empresa { get; set; }
        public decimal Unidad_de_importe { get; set; }
        public double Precio { get; set; }
    }
}
