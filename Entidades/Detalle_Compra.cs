using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Compra
    {
        public int IdDetalleCompra { get; set; }
        public Producto oProducto { get; set; }
        public Proveedor oProveedor { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public int FechaRegistro { get; set; }
         
    }
}
