using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace Negocio
{
    public class N_User
    {
        private D_User objd_usuario = new D_User();

        public List<Usuario> Listar()
        {
            return objd_usuario.Listar();
        }

        public bool Registrar(Usuario obj)
        {
            
            return objd_usuario.Registrar(obj);
        }
    }
}
