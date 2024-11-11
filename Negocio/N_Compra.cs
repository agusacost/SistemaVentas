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
    public class N_Compra
    {
        private D_Compra objCompra = new D_Compra();

        public int GetCorrelative()
        {
            return objCompra.getCorrelativo();
        }

        public bool Registro(Compra oCompra,DataTable detalleCompra ,out string Mensaje)
        {
           return objCompra.registrar(oCompra, detalleCompra, out Mensaje);

        }

        public List<Compra> listarCompras()
        {
            return objCompra.listarCompras();  
        }


        public Compra getCompra(string numero)
        {
            Compra oCompra = objCompra.obtenerCompra(numero);
            if(oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objCompra.ObtenerDetalleCompra(oCompra.IdCompra);
                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }

    }
}
