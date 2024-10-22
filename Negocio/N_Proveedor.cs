using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace Negocio
{
    public class N_Proveedor
    {
        private D_Proveedor objProveedor = new D_Proveedor();

        public List<Proveedor> Listar()
        {
            return objProveedor.Listar();
        }

        public bool Registro(Proveedor oproveedor)
        {
            return objProveedor.Registrar(oproveedor);
        }
    }
}
