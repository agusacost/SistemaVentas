using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Producto
    {
        private D_Producto objProducto = new D_Producto();

        public List<Producto> listar()
        {
            return objProducto.Listar();
        }

        public bool Registrar(Producto objProd)
        {
            return objProducto.Registrar(objProd);
        }
    }
}
