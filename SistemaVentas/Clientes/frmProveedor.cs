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
        private int selectedRowIndex = -1;
        private Proveedor selectedProveedor = null;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedProveedor == null)
            {
                MessageBox.Show("Por favor, selecciona un proveedor para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nuevoEstado = false;
            DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas dar de baja el Proveedor '{selectedProveedor.RazonSocial}'", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                bool resultado = new N_Proveedor().baja(selectedProveedor.IdProveedor, nuevoEstado);
                if (resultado)
                {
                    selectedProveedor.Estado = nuevoEstado;
                    dgvdata.Rows[selectedRowIndex].Cells["Estado"].Value = "Inactivo";

                    MessageBox.Show("Cliente dado de baja");

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado del cliente. Por favor, intente nuevamente.");
                }
            }
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
                frmAddProveedor = new frmAddProveedor(this);
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
                frmEditProveedor = new frmEditProveedor(this, selectedProveedor, selectedRowIndex);
                frmEditProveedor.Show();
            }
            else
            {
                frmEditProveedor.Focus();
            }
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
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
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                selectedRowIndex = e.RowIndex;

                if (selectedRowIndex >= 0)
                {

                    selectedProveedor = new Proveedor
                    {
                        IdProveedor = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdProveedor"].Value),
                        Documento = dgvdata.Rows[selectedRowIndex].Cells["Documento"].Value.ToString(),
                        RazonSocial = dgvdata.Rows[selectedRowIndex].Cells["RazonSocial"].Value.ToString(),
                        Correo = dgvdata.Rows[selectedRowIndex].Cells["Correo"].Value.ToString(),
                        Telefono = dgvdata.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString(),
                        Estado = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["EstadoValor"].Value) == 1
                    };

                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                var icon = Properties.Resources.check_icon;
                int iconWidth = icon.Width;
                int iconHeight = icon.Height;
                float scale = Math.Min((float)cellWidth / iconWidth, (float)cellHeight / iconHeight);

                int newWidth = (int)(iconWidth * scale);
                int newHeight = (int)(iconHeight * scale);
                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                e.Graphics.DrawImage(icon, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBusqueda.Text.Trim().ToLower();
            List<Proveedor> listaProv = new N_Proveedor().Listar();

            var filteredProv = listaProv
                .Where(c =>
                    c.Documento.ToLower().Contains(searchText) ||
                    c.RazonSocial.ToLower().Contains(searchText) ||
                    c.Correo.ToLower().Contains(searchText) ||
                    c.Telefono.ToLower().Contains(searchText))
                .ToList();
            
            dgvdata.Rows.Clear();
            foreach(var item in filteredProv)
            {
                dgvdata.Rows.Add(
                     "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            List<Proveedor> listaProv = new N_Proveedor().Listar();
            dgvdata.Rows.Clear();

            foreach(var item in listaProv)
            {
                dgvdata.Rows.Add(
                     "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                );
            }
        }
    }
}
