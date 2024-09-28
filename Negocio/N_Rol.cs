using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Rol
    {
        private D_Rol objd_permiso = new D_Rol();

        public List<Rol> Listar()
        {
            return objd_permiso.Listar();
        }
    }
}
