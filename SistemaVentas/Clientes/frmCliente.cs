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
using Negocio;
using Entidades;
using SistemaVentas.Utilities;

namespace SistemaVentas.Clientes
{
    public partial class frmCliente : Form
    {
        private int selectedRowIndex = -1;
        private frmAddCliente frmAddCliente;
        private frmEditCliente frmEditCliente;
        private Cliente selectedCliente = null;
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
                frmAddCliente = new frmAddCliente(this);
                frmAddCliente.Show();
            }
            else
            {
                frmAddCliente.Focus();
            }
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columa in dgvdata.Columns)
            {
                if (columa.Visible == true && columa.Name != "btnSeleccionar")
                {
                    cbbusqueda.Items.Add(new OpcionCombo() { value = columa.Name, Texto = columa.HeaderText });
                }
            }
            List<Cliente> listCliente = new N_Cliente().Listar();
            foreach(Cliente item in listCliente)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? "Activo" : "Inactivo",
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

                    selectedCliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdCliente"].Value),
                        Documento = dgvdata.Rows[selectedRowIndex].Cells["Documento"].Value.ToString(),
                        NombreCompleto = dgvdata.Rows[selectedRowIndex].Cells["NombreCompleto"].Value.ToString(),
                        Correo = dgvdata.Rows[selectedRowIndex].Cells["Correo"].Value.ToString(),
                        Telefono = dgvdata.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString()
                    };
                    
                }
            }
        }

        private void dgvdata_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}
