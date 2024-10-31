using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Negocio
    {
        private D_Negocio objNegocio = new D_Negocio();

        public Entidades.Negocio getData()
        {
            return objNegocio.GetData();
        }

        public bool GurardarDatos(Entidades.Negocio objetoNegocio, out string mensaje)
        {
            mensaje = string.Empty;
            if(objetoNegocio.Nombre == "")
            {
                mensaje += "Es necesario el nombre";
            }
            if (objetoNegocio.CUIT == "")
            {
                mensaje += "Es necesario el CUIT";
            }
            if (objetoNegocio.Direccion == "")
            {
                mensaje += "Es necesario la direccion";
            }
            if (objetoNegocio.Provincia == "")
            {
                mensaje += "Es necesario la provincia";
            }
            if (objetoNegocio.Localidad == "")
            {
                mensaje += "Es necesario la localidad";
            }
            if(mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objNegocio.Guardar(objetoNegocio, out mensaje);
            }
        }
        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objNegocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objNegocio.ActualizarLogo(imagen, out mensaje);

        }
    }
}
