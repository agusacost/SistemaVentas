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

namespace SistemaVentas.Compras
{
    public partial class frmListaCompras : Form
    {
        private Usuario _Usuario;
        private int selectedRowIndex = -1;
        public frmListaCompras(Usuario ousuario = null)
        {
            _Usuario = ousuario;    
            InitializeComponent();
        }

        private void frmListaCompras_Load(object sender, EventArgs e)
        {
            List<Compra> compras = new N_Compra().listarCompras();


            foreach (Compra compra in compras)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    compra.IdCompra,
                    compra.oUsuario.Documento,
                    compra.oProveedor.RazonSocial,
                    compra.TipoDocumento,
                    compra.NumeroDocumento,
                    compra.MontoTotal,
                    compra.FechaRegistro
                });
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nrofac = string.Empty;
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                selectedRowIndex = e.RowIndex;
                if (selectedRowIndex >= 0)
                {
                    nrofac = dgvdata.Rows[selectedRowIndex].Cells["Documento"].Value.ToString();
                    Clipboard.SetText(nrofac);
                    MessageBox.Show("Numero de compra " + nrofac + " copiado al portapapeles", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            string textoBusqueda = txtBusqueda.Text.ToLower();
            List<Compra> compras = new N_Compra().listarCompras();

            List<Compra> comprasFiltradas = compras.Where(compra =>
                compra.oUsuario.Documento.ToLower().Contains(textoBusqueda) ||
                compra.oProveedor.RazonSocial.ToLower().Contains(textoBusqueda) ||
                compra.TipoDocumento.ToLower().Contains(textoBusqueda) ||
                compra.NumeroDocumento.ToLower().Contains(textoBusqueda) ||
                compra.MontoTotal.ToString().Contains(textoBusqueda) ||
                compra.FechaRegistro.ToString().Contains(textoBusqueda)
            ).ToList();

            dgvdata.Rows.Clear();

            foreach (Compra compra in comprasFiltradas)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    compra.IdCompra,
                    compra.oUsuario.Documento,
                    compra.oProveedor.RazonSocial,
                    compra.TipoDocumento,
                    compra.NumeroDocumento,
                    compra.MontoTotal,
                    compra.FechaRegistro
                });
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            dgvdata.Rows.Clear();
            List<Compra> compras = new N_Compra().listarCompras();

            foreach (Compra compra in compras)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    compra.IdCompra,
                    compra.oUsuario.Documento,
                    compra.oProveedor.RazonSocial,
                    compra.TipoDocumento,
                    compra.NumeroDocumento,
                    compra.MontoTotal,
                    compra.FechaRegistro
                });
            }

            txtBusqueda.Focus();
        }
    }
}
