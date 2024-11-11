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
        private int selectedRowIndex = -1;
        private Categoria selectedCat = null;
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
                frmEditarCategoria = new frmEditarCategoria(this, selectedCat, selectedRowIndex);
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
                item.Estado == true ? 1:0,
                item.Estado == true ? "Activo" : "Inactivo",
            });
            }
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                selectedRowIndex = e.RowIndex;

                if (selectedRowIndex >= 0)
                {
                    selectedCat = new Categoria
                    {
                        IdCategoria = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdCategoria"].Value),
                        Descripcion = dgvdata.Rows[selectedRowIndex].Cells["Descripcion"].Value.ToString(),
                        Estado = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["EstadoValor"].Value) == 1 ? true : false
                    };
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedCat == null || selectedCat.Estado == false)
            {
                MessageBox.Show("Por favor, selecciona una categoria correcta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nuevoEstado = false;
            DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas dar de baja la categoria '{selectedCat.Descripcion}'", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bool resultado = new N_Categoria().bajaCat(selectedCat.IdCategoria, nuevoEstado);
                if (resultado)
                {
                    selectedCat.Estado = nuevoEstado;
                    dgvdata.Rows[selectedRowIndex].Cells["Estado"].Value = "Inactivo";

                    MessageBox.Show("Categoria dada de baja");

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado de la categoria. Por favor, intente nuevamente.");
                }
            }
            dgvdata.Rows.Clear();
            List<Categoria> listaCat = new N_Categoria().Listar();
            foreach (Categoria item in listaCat)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCategoria,item.Descripcion,
                item.Estado == true ? 1:0,
                item.Estado == true ? "Activo" : "Inactivo",
            });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBusqueda.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                bool rowVisible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        rowVisible = true; 
                        break;
                    }
                }

                row.Visible = rowVisible;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
