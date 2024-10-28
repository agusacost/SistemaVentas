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

        public int Registro(Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oCliente.Documento == "")
            {
                Mensaje += "Es necesario el documento del cliente";
            }
            if (oCliente.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre del cliente";
            }
            if (oCliente.Correo == "")
            {
                Mensaje += "Es necesario el correo del cliente";
            }
            if (oCliente.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del cliente";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCliente.Registrar(oCliente, out Mensaje);
            }
        }

        public bool Editar(Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oCliente.Documento == "")
            {
                Mensaje += "Es necesario el documento del cliente";
            }
            if (oCliente.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre del cliente";
            }
            if (oCliente.Correo == "")
            {
                Mensaje += "Es necesario el correo del cliente";
            }
            if (oCliente.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del cliente";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCliente.Editar(oCliente, out Mensaje);
            }
        }

        public bool baja(int idCliente, bool nuevoEstado)
        {
            return objCliente.Baja(idCliente, nuevoEstado);
        }
    }
}
