using Entidades;
using Negocio;
using SistemaVentas.Modals;
using SistemaVentas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaVentas.Ventas
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario ousuario = null)
        {
            InitializeComponent();
            _Usuario = ousuario;
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            if(txtdni.Text == "")
            {
                MessageBox.Show("Debe ingresar el documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos para vender", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("Subtotal", typeof(decimal));

            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["Subtotal"].Value.ToString()
                });
            }

            int idCorrelativo = new N_Venta().obtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);
            calcularCambio();

            Venta oventa = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)CBFactura.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdni.Text,
                NombreCliente = txtnombre.Text,
                MontoPago = Convert.ToDecimal(txtPaga.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalPago.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new N_Venta().Registrar(oventa,detalle_venta,out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Venta generada: \n" + numeroDocumento + "\n\nDesea copiar al portapapeles" , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtdni.Text = "";
                txtnombre.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtPaga.Text = "";
                txtCambio.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {
            CBFactura.Items.Add(new OpcionCombo() { value = 1, Texto = "Factura A" });
            CBFactura.Items.Add(new OpcionCombo() { value = 2, Texto = "Factura B" });
            CBFactura.Items.Add(new OpcionCombo() { value = 3, Texto = "Factura C" });
            CBFactura.DisplayMember = "Texto";
            CBFactura.ValueMember = "value";
            CBFactura.SelectedIndex = 2;

            datepicker.Value = DateTime.Now;
            dgvdata.AllowUserToAddRows = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    txtdni.Text = modal._Cliente.Documento;
                    txtnombre.Text = modal._Cliente.NombreCompleto;
                    txtCodigoProducto.Select();
                }
                else
                {
                    txtdni.Select();
                }
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                modal.esVenta = true;
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString();
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCantidad.Select();

                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entidades.Producto oproducto = new N_Producto().listar().Where(p => p.Codigo == txtCodigoProducto.Text && p.Estado == true).FirstOrDefault();
                if (oproducto != null)
                {
                    txtCodigoProducto.BackColor = Color.LightGreen;
                    txtIdProducto.Text = oproducto.IdProducto.ToString();
                    txtProducto.Text = oproducto.Nombre;
                    txtStock.Text = oproducto.Stock.ToString();
                    txtPrecio.Text = oproducto.PrecioVenta.ToString();
                    txtTotalPago.Select();
                }
                else
                {
                    txtCodigoProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            bool productoExists = false;
            int idProducto;

            if (!int.TryParse(txtIdProducto.Text, out idProducto) || idProducto == 0)
            {
                MessageBox.Show("Debe seleccionar un producto válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precioventa))
            {
                MessageBox.Show("Debe seleccionar un producto válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verificar si el producto ya ha sido agregado al DataGridView
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"]?.Value?.ToString() == txtIdProducto.Text)
                {
                    productoExists = true;
                    break;
                }
            }

            // Si el producto no existe, calcular el precio de venta y agregar al DataGridView
            if (!productoExists)
            {

                string mensaje = string.Empty;
                bool respuesta = new N_Venta().RestarStock(
                    Convert.ToInt32(txtIdProducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                );
                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                        txtIdProducto.Text,
                        txtProducto.Text,
                        precioventa.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precioventa).ToString("0.00")
                    });

                    limpiarProd();
                    calcularTotal();
                    txtCodigoProducto.Select();
                }
                
            }
            else
            {
                MessageBox.Show("El producto ya ha sido agregado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiarProd()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
            txtProducto.BackColor = Color.White;
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
                }
            }
            txtTotalPago.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                var icon = Properties.Resources.delete;
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
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    bool respuesta = new N_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[indice].Cells["Cantidad"].Value.ToString())
                    );

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                }
            }
        }

        

        private void calcularCambio()
        {
            if (txtTotalPago.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPago.Text);

            if (txtPaga.Text.Trim() == "")
            {
                txtPaga.Text = "0";
            }

            if(decimal.TryParse(txtPaga.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Text = "0";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }

            }
        }

        private void txtPaga_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }
    }
}
