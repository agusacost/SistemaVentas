﻿using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Categoria
    {
        private D_Categoria objCategoria = new D_Categoria();
        public List<Categoria> Listar()
        {
            return objCategoria.Listar();
        }

        public bool AddCat(Categoria objCat)
        {
            return objCategoria.addCategoria(objCat);
        }

        public bool editCat(Categoria objCat)
        {
            return objCategoria.editCategoria(objCat);
        }

        public bool bajaCat(int idCategoria, bool nuevoEstado)
        {
            return objCategoria.bajaCategoria(idCategoria, nuevoEstado);
        }
    }
}
