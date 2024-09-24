using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Permiso
    {
        private D_PERMISO objd_permiso = new D_PERMISO();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objd_permiso.Listar(IdUsuario);
        }
    }
}
