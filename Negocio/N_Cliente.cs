using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Cliente
    {
        private D_Clientes objCliente = new D_Clientes();

        public List<Cliente> Listar()
        {
            return objCliente.Listar();
        }

        public bool Registro(Cliente oCliente)
        {
            return objCliente.Registrar(oCliente);
        }
    }
}
