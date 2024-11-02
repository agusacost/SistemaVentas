using SistemaVentas.Utilities;
using System;
using System.Collections;
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
using SistemaVentas.Modals;

namespace SistemaVentas.Compras
{
    public partial class frmCompras : Form
    {
        private Usuario _usuario;
        public frmCompras(Usuario ousuario=null)
        {
            InitializeComponent();
            _usuario = ousuario;
        }

        
        
        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["Subtotal"].Value.ToString(),
                });
            }

            int idcorrelativo = new N_Compra().GetCorrelative();
            string numeroDocumento = string.Format( "{0:00000}" , idcorrelativo );
            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario},
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                TipoDocumento = ((OpcionCombo)CBFactura.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text),
            };
            string mensaje = string.Empty;
            bool respuesta = new N_Compra().Registro(oCompra, detalle_compra, out mensaje);

            if(respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada: \n" + numeroDocumento + "\n\nDesea copiar al portapapeles?", "Mensaje",
                MessageBoxButtons.YesNo ,MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtIdProveedor.Text = "0";
                txtCuit.Text = "";
                txtRazonSocial.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BLimpiarCompra_Click(object sender, EventArgs e)
        {
            
            txtRazonSocial.Clear();
            txtProducto.Clear();
            txtCodigoProducto.Clear();
            txtPrecioCompra.Clear();
            txtTotalPagar.Clear();

            CBFactura.SelectedIndex = -1; 
            txtCantidad.Value= 0;

            datepicker.Value = DateTime.Now; 
        }

        private void frmCompras_Load(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if(result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtCuit.Text = modal._Proveedor.Documento;
                    txtRazonSocial.Text = modal._Proveedor.RazonSocial;

                }
                else
                {
                    txtCuit.Select();
                }
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecioCompra.Select();
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
                Entidades.Producto oproducto = new N_Producto().listar().Where(p=> p.Codigo == txtCodigoProducto.Text && p.Estado == true).FirstOrDefault();
                if(oproducto != null)
                {
                    txtCodigoProducto.BackColor = Color.LightGreen;
                    txtIdProducto.Text = oproducto.IdProducto.ToString();
                    txtProducto.Text = oproducto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodigoProducto.BackColor= Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            int porcentajeventa = 0;
            bool productoExists = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtPrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }
            if (!int.TryParse(txtGanancia.Text, out porcentajeventa))
            {
                MessageBox.Show("Porcentaje Venta - Formato entero incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"]?.Value?.ToString() == txtIdProducto.Text)
                {
                    productoExists = true;
                    break;
                }
            }

            if (!productoExists)
            {
                precioventa = preciocompra + (preciocompra * porcentajeventa / 100);
                dgvdata.Rows.Add(new object[]
                {
                txtIdProducto.Text,
                txtProducto.Text,
                preciocompra.ToString("0.00"),
                precioventa.ToString("0.00"),
                txtCantidad.Value.ToString(),
                (txtCantidad.Value * preciocompra).ToString("0.00")
                });

                limpiarProd();
                calcularTotal();
                txtCodigoProducto.Select();
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
            txtProducto.BackColor = Color.White;
            txtProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtGanancia.Text = "";
            txtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if(dgvdata.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
                }
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 6)
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
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true ;
                }
            }
        }
    }

}

