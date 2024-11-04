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
using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Negocio;

namespace SistemaVentas.Ventas
{
    public partial class frmVentaDetalle : Form
    {
        public frmVentaDetalle()
        {
            InitializeComponent();
        }
        private void frmVentaDetalle_Load(object sender, EventArgs e)
        {
            txtBusqueda.Select();
            dgvdata.AllowUserToAddRows = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new N_Venta().ObtenerVenta(txtBusqueda.Text);


            if (oVenta.IdVenta != 0)
            {
                txtnrodoc.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodoccompra.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;

                txtDocumentoCliente.Text = oVenta.DocumentoCliente;
                txtNombreCliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach(Detalle_Venta dv in oVenta.oDetalleVenta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }
                txtMonto.Text = oVenta.MontoTotal.ToString("0.00");
                txtPago.Text = oVenta.MontoPago.ToString("0.00");
                txtCambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }

        private void BLimpiarCompra_Click(object sender, EventArgs e)
        {
            txtnrodoc.Text = "";

            txtfecha.Text = "";
            txttipodoccompra.Text = "";
            txtusuario.Text = "";
            dgvdata.Rows.Clear();
            txtDocumentoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtMonto.Text = "0.00";
            txtPago.Text = "0.00";
            txtCambio.Text = "0.00";
        }

        private void detalleBtn_Click(object sender, EventArgs e)
        {
            if (txtDocumentoCliente.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto_html = Properties.Resources.PlantillaVenta.ToString();
            Entidades.Negocio odatos = new N_Negocio().getData();

            texto_html = texto_html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            texto_html = texto_html.Replace("@docnegocio", odatos.CUIT);
            texto_html = texto_html.Replace("@dirnegocio", odatos.Direccion);

            texto_html = texto_html.Replace("@tipodocumento", txttipodoccompra.Text.ToUpper());
            texto_html = texto_html.Replace("@numerodocumento", txtnrodoc.Text);

            texto_html = texto_html.Replace("@doccliente", txtDocumentoCliente.Text);
            texto_html = texto_html.Replace("@nombrecliente", txtNombreCliente.Text);
            texto_html = texto_html.Replace("@fecharegistro", txtfecha.Text);
            texto_html = texto_html.Replace("@usuarioregistro", txtusuario.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            texto_html = texto_html.Replace("@filas", filas);
            texto_html = texto_html.Replace("@montototal", txtMonto.Text);
            texto_html = texto_html.Replace("@pagocon", txtPago.Text);
            texto_html = texto_html.Replace("@cambio", txtCambio.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnrodoc.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
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
