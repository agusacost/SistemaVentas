using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Producto
{
    public partial class frmCategoria : Form
    {
        private frmAddCategoria frmAddCategoria;
        private frmEditarCategoria frmEditarCategoria;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmEditarCategoria != null && !frmEditarCategoria.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Categoria' mientras 'Editar Categoria' está abierto.");
                frmEditarCategoria.Focus();
                return;
            }

            if (frmAddCategoria == null || frmAddCategoria.IsDisposed)
            {
                frmAddCategoria = new frmAddCategoria(this);
                frmAddCategoria.Show();
            }
            else
            {
                frmAddCategoria.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmAddCategoria != null && !frmAddCategoria.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Categoria' mientras 'Agregar Categoria' está abierto.");
                frmAddCategoria.Focus();
                return;
            }

            if (frmEditarCategoria == null || frmEditarCategoria.IsDisposed)
            {
                frmEditarCategoria = new frmEditarCategoria();
                frmEditarCategoria.Show();
            }
            else
            {
                frmEditarCategoria.Focus();
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            //Fetch Categoria
            List<Categoria> listaCat = new N_Categoria().Listar();
            foreach(Categoria item in listaCat)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCategoria,item.Descripcion,
                //item.Estado == true ? 1:0,
                item.Estado == true ? "Activo" : "Inactivo",
            });
            }
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
        }

    }
}
