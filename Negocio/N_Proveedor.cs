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

        public int Registro(Proveedor oproveedor, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oproveedor.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }
            if (oproveedor.RazonSocial == "")
            {
                Mensaje += "Es necesario el nombre del Proveedor\n";
            }
            if (oproveedor.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            if (oproveedor.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objProveedor.Registrar(oproveedor, out Mensaje);
            }
        }

        public bool Editar(Proveedor oproveedor, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (oproveedor.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }
            if (oproveedor.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }
            if (oproveedor.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            if (oproveedor.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objProveedor.Editar(oproveedor, out Mensaje);
            }
        }

        public bool baja(int idProveedor, bool nuevoEstado)
        {
            return objProveedor.Baja(idProveedor, nuevoEstado);
        }
    }
}
