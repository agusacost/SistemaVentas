using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace SistemaVentas.Clientes
{
    public partial class frmProveedor : Form
    {
        private frmAddProveedor frmAddProveedor;
        private frmEditProveedor frmEditProveedor;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(frmEditProveedor != null && !frmEditProveedor.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Proveedor' mientras 'Editar Proveedor' está abierto.");
                frmEditProveedor.Focus();
                return;
            }

            if(frmAddProveedor == null || frmAddProveedor.IsDisposed)
            {
                frmAddProveedor = new frmAddProveedor();
                frmAddProveedor.Show();
            }
            else 
            {
                frmAddProveedor.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmAddProveedor != null && !frmAddProveedor.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Proveedor' mientras 'Agregar Proveedor' está abierto.");
                frmAddProveedor.Focus();
                return;
            }

            if (frmEditProveedor == null || frmEditProveedor.IsDisposed)
            {
                frmEditProveedor = new frmEditProveedor();
                frmEditProveedor.Show();
            }
            else
            {
                frmEditProveedor.Focus();
            }
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            List<Proveedor> listProv = new N_Proveedor().Listar();
            foreach(Proveedor item in listProv)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }
    }
}
