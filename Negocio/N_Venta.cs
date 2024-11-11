using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Venta
    {
        private D_Venta objVenta = new D_Venta();

        public  List<Venta> ListarVentas()
        {
            return objVenta.ListaVentas();
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            return objVenta.restarStock(idProducto, cantidad);
        }
        public bool SumarStock(int idProducto, int cantidad)
        {
            return objVenta.sumarStock(idProducto, cantidad);
        }

        public int obtenerCorrelativo()
        {
            return objVenta.getCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string mensaje)
        {
            return objVenta.registrar(obj, DetalleVenta, out mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = objVenta.ObtenerVenta(numero);

            if(oVenta.IdVenta != 0)
            {
                List<Detalle_Venta> oDetalleVenta = objVenta.ObtenerDetalleVenta(oVenta.IdVenta);
                oVenta.oDetalleVenta = oDetalleVenta;
            }

            return oVenta;
        }
        public List<BackupV> BackupV()
        {
            return objVenta.ListarBackup();
        }

    }
}
