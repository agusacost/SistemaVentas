using SistemaVentas.Clientes;
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
    public partial class frmProducto : Form
    {
        private frmAddProducto frmAddProducto;
        private frmEditarProducto frmEditarProducto;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmEditarProducto != null && !frmEditarProducto.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Producto' mientras 'Editar Producto' está abierto.");
                frmEditarProducto.Focus();
                return;
            }

            if (frmAddProducto == null || frmAddProducto.IsDisposed)
            {
                frmAddProducto = new frmAddProducto();
                frmAddProducto.Show();
            }
            else
            {
                frmAddProducto.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmAddProducto != null && !frmAddProducto.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Producto' mientras 'Agregar Producto' está abierto.");
                frmAddProducto.Focus();
                return;
            }

            if (frmEditarProducto == null || frmEditarProducto.IsDisposed)
            {
                frmEditarProducto = new frmEditarProducto();
                frmEditarProducto.Show();
            }
            else
            {
                frmEditarProducto.Focus();
            }
        }


        
    }
}
