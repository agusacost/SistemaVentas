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
            if (string.IsNullOrWhiteSpace(objProd.Codigo))
            {
                throw new ArgumentException("El código del producto es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(objProd.Nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(objProd.Descripcion))
            {
                throw new ArgumentException("La descripción del producto es obligatoria.");
            }
            if (objProd.oCategoria == null || objProd.oCategoria.IdCategoria == 0)
            {
                throw new ArgumentException("La categoría del producto es obligatoria.");
            }
            return objProducto.Registrar(objProd);
        }

        public bool Editar(Producto objProd)
        {
            if (string.IsNullOrWhiteSpace(objProd.Codigo))
            {
                throw new ArgumentException("El código del producto es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(objProd.Nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }
            if (string.IsNullOrWhiteSpace(objProd.Descripcion))
            {
                throw new ArgumentException("La descripción del producto es obligatoria.");
            }
            if (objProd.oCategoria == null || objProd.oCategoria.IdCategoria == 0)
            {
                throw new ArgumentException("La categoría del producto es obligatoria.");
            }
            if (objProd.oProveedor == null || objProd.oProveedor.IdProveedor == 0)
            {
                throw new ArgumentException("El proveedor del producto es obligatorio para editar.");
            }
            return objProducto.Editar(objProd);
        }

        public bool Delete(int idProducto, bool newState)
        {
            return objProducto.Baja(idProducto, newState);
        }
    }
}
