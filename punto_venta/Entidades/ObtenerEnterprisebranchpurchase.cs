using System;
using System.ComponentModel.DataAnnotations;

namespace punto_venta.Entidades
{
    public class ObtenerEnterprisebranchpurchase
    {
        [Key]
        public long Numero_de_la_empresa{ get; set; }
        public long Numero_de_la_sucursal { get; set; }
        public string Tipo_de_empresa_sucursal_comprada { get; set; }
        public long numero_de_proveedor { get; set; }
        public DateTime Fecha_de_compra { get; set; }
        public string Numero_de_factura { get; set; }
        public DateTime? Fecha_de_la_factura { get; set; }
        public DateTime? Fecha_de_entrada_del_almacen { get; set; }
        public string Observacion { get; set; }
    }
}
