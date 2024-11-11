using Entidades;
using Negocio;
using SistemaVentas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Ventas
{
    public partial class frmListaVentas : Form
    {
        private Usuario _Usuario;
        private int selectedRowIndex = -1;
        public frmListaVentas(Usuario ousuario = null)
        {
            _Usuario = ousuario;
            InitializeComponent();
        }

        private void frmListaVentas_Load(object sender, EventArgs e)
        {
           
            List<Entidades.Venta> lista = new N_Venta().ListarVentas();

            foreach(Entidades.Venta venta in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    venta.TipoDocumento,
                    venta.NumeroDocumento,
                    venta.DocumentoCliente,
                    venta.NombreCliente,
                    venta.MontoPago,
                    venta.MontoCambio,
                    venta.MontoTotal,
                    venta.FechaRegistro,
                });
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
                    MessageBox.Show("Numero de factura " + nrofac + " copiado al portapapeles", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string textoBusqueda = txtBusqueda.Text.Trim().ToLower();
            List<Entidades.Venta> lista = new N_Venta().ListarVentas();

            var listaFiltrada = lista.Where(venta =>
                venta.TipoDocumento.ToLower().Contains(textoBusqueda) ||
                venta.NumeroDocumento.ToLower().Contains(textoBusqueda) ||
                venta.DocumentoCliente.ToLower().Contains(textoBusqueda) ||
                venta.NombreCliente.ToLower().Contains(textoBusqueda) ||
                venta.MontoPago.ToString().Contains(textoBusqueda) ||
                venta.MontoCambio.ToString().Contains(textoBusqueda) ||
                venta.MontoTotal.ToString().Contains(textoBusqueda) ||
                venta.FechaRegistro.ToLower().Contains(textoBusqueda)
            ).ToList();

            dgvdata.Rows.Clear();

            foreach (Entidades.Venta venta in listaFiltrada)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    venta.TipoDocumento,
                    venta.NumeroDocumento,
                    venta.DocumentoCliente,
                    venta.NombreCliente,
                    venta.MontoPago,
                    venta.MontoCambio,
                    venta.MontoTotal,
                    venta.FechaRegistro,
                });
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            dgvdata.Rows.Clear();
            List<Entidades.Venta> lista = new N_Venta().ListarVentas();
            foreach (Entidades.Venta venta in lista)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    venta.TipoDocumento,
                    venta.NumeroDocumento,
                    venta.DocumentoCliente,
                    venta.NombreCliente,
                    venta.MontoPago,
                    venta.MontoCambio,
                    venta.MontoTotal,
                    venta.FechaRegistro,
                });
            }

            txtBusqueda.Focus();
        }

    }
}
