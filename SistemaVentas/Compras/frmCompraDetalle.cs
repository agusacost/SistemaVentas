using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using Entidades;
using Negocio;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace SistemaVentas.Compras
{
    public partial class frmCompraDetalle : Form
    {
        public frmCompraDetalle()
        {
            InitializeComponent();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCompraDetalle_Load(object sender, EventArgs e)
        {
            dgvdata.AllowUserToAddRows = false;
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
                e.Graphics.DrawImage(icon, new System.Drawing.Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Entidades.Compra oCompra = new N_Compra().getCompra(txtBusqueda.Text);

            if (oCompra.IdCompra != 0 )
            {
                txtnrodoc.Text = oCompra.NumeroDocumento;

                txtfechacompra.Text = oCompra.FechaRegistro;
                txttipodoccompra.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.oUsuario.NombreCompleto;
                txtCuit.Text = oCompra.oProveedor.Documento;
                txtRazonSocial.Text = oCompra.oProveedor.RazonSocial;

                dgvdata.Rows.Clear();   
                foreach(Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                        dc.oProducto.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal
                    });
                    txtMonto.Text = oCompra.MontoTotal.ToString("0.00");
                }
            }
        }

        private void BLimpiarCompra_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            txtnrodoc.Text = "";

            txtfechacompra.Text = "";
            txttipodoccompra.Text = "";
            txtusuario.Text = "";
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            dgvdata .Rows.Clear();
            txtMonto.Text = "0.00";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto_html = Properties.Resources.PlantillaCompra.ToString();
            Entidades.Negocio odatos = new N_Negocio().getData();

            texto_html = texto_html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            texto_html = texto_html.Replace("@docnegocio", odatos.CUIT);
            texto_html = texto_html.Replace("@dirnegocio", odatos.Direccion);

            texto_html = texto_html.Replace("@tipodocumento", txttipodoccompra.Text.ToUpper());
            texto_html = texto_html.Replace("@numerodocumento", txtnrodoc.Text);

            texto_html = texto_html.Replace("@docproveedor", txtCuit.Text);
            texto_html = texto_html.Replace("@nombreproveedor", txtRazonSocial.Text);
            texto_html = texto_html.Replace("@fecharegistro", txtfechacompra.Text);
            texto_html = texto_html.Replace("@usuarioregistro", txtusuario.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            texto_html = texto_html.Replace("@filas", filas);
            texto_html = texto_html.Replace("@montototal", txtMonto.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnrodoc.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using(FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage = new N_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));

                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(texto_html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
