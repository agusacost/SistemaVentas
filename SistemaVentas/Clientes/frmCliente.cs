using SistemaVentas.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Clientes
{
    public partial class frmCliente : Form
    {
        private frmAddCliente frmAddCliente;
        private frmEditCliente frmEditCliente;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmEditCliente != null && !frmEditCliente.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Cliente' mientras 'Editar Cliente' está abierto.");
                frmEditCliente.Focus();
                return;
            }

            if (frmAddCliente == null || frmAddCliente.IsDisposed)
            {
                frmAddCliente = new frmAddCliente();
                frmAddCliente.Show();
            }
            else
            {
                frmAddCliente.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmAddCliente != null && !frmAddCliente.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Cliente' mientras 'Agregar Cliente' está abierto.");
                frmAddCliente.Focus();
                return;
            }

            if (frmEditCliente == null || frmEditCliente.IsDisposed)
            {
                frmEditCliente = new frmEditCliente();
                frmEditCliente.Show();
            }
            else
            {
                frmEditCliente.Focus();
            }
        }

    }
}
