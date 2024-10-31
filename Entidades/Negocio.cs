using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        public int IdNegocio { get; set; }
        public string Nombre { get; set; }
        public string CUIT {  get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
    }
}
