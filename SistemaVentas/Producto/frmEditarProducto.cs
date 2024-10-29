using DocumentFormat.OpenXml.Wordprocessing;
using Entidades;
using Negocio;
using SistemaVentas.Usuarios;
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

namespace SistemaVentas.Producto
{
    public partial class frmEditarProducto : Form
    {
        private Entidades.Producto selectedProducto;
        private frmProducto frmProducto;
        private int selectedRowIndex;
        public frmEditarProducto(frmProducto formProducto, Entidades.Producto selectedProd, int RowIndex)
        {
            this.selectedProducto = selectedProd;
            frmProducto = formProducto;
            selectedRowIndex = RowIndex;
            InitializeComponent();
        }

        private void TCantidadE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (caracteres entre '0' y '9') y el carácter de control (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si no es número o backspace
            }
        }
        private void TPrecioCompraE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Cancela el evento si no es número, backspace o punto
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Si ya hay un punto, no permitir otro
            }
        }

        private void TNombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, teclas de control (como Backspace) y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;  // Bloquea el ingreso de la tecla
            }
        }


        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CBEstadoE.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstadoE.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstadoE.DisplayMember = "Texto";
            CBEstadoE.ValueMember = "value";
            List<Categoria> listaCat = new N_Categoria().Listar();

            foreach (Categoria cat in listaCat)
            {
                CBCategoriaE.Items.Add(new OpcionCombo()
                {
                    value = cat.IdCategoria,
                    Texto = cat.Descripcion,
                });
            }
            CBCategoriaE.DisplayMember = "Texto";
            CBCategoriaE.ValueMember = "value";
            CBCategoriaE.SelectedIndex = 0;

            List<Proveedor> listaProv = new N_Proveedor().Listar();

            foreach (Proveedor prov in listaProv)
            {
                cbProveedor.Items.Add(new OpcionCombo()
                {
                    value = prov.IdProveedor,
                    Texto = prov.Documento,
                });
            }
            cbProveedor.DisplayMember = "Texto";
            cbProveedor.ValueMember = "value";
            cbProveedor.SelectedIndex = 0;

            TNombreE.Text = selectedProducto.Nombre;
            TDescripcionE.Text = selectedProducto.Descripcion;
            foreach(OpcionCombo item in CBCategoriaE.Items)
            {
                if((int)item.value == selectedProducto.oCategoria.IdCategoria)
                {
                    CBCategoriaE.SelectedItem = item;
                    break;
                }
            }
            foreach(OpcionCombo item in cbProveedor.Items)
            {
                if((int)item.value == selectedProducto.oProveedor.IdProveedor)
                {
                    cbProveedor.SelectedItem = item;
                    break;
                }
            }
            int estadoValue = selectedProducto.Estado ? 1 : 2;
            foreach (OpcionCombo item in CBEstadoE.Items)
            {
                if ((int)item.value == estadoValue)
                {
                    CBEstadoE.SelectedItem = item;
                }
            }

        }

        private void btnCancelarProdE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProdE_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Producto objProducto = new Entidades.Producto()
                {
                    IdProducto = selectedProducto.IdProducto,
                    Codigo = selectedProducto.Codigo,
                    Nombre = TNombreE.Text,
                    Descripcion = TDescripcionE.Text,
                    oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)CBCategoriaE.SelectedItem).value) },
                    oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(((OpcionCombo)cbProveedor.SelectedItem).value)},
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstadoE.SelectedItem).value) == 1,

                };

                bool editar = new N_Producto().Editar(objProducto);

                if (editar)
                {
                    DataGridViewRow row = frmProducto.DgvData.Rows[selectedRowIndex];
                    row.Cells["IdProducto"].Value = objProducto.IdProducto;
                    row.Cells["Codigo"].Value = objProducto.Codigo;
                    row.Cells["Nombre"].Value = objProducto.Nombre;
                    row.Cells["Descripcion"].Value = objProducto.Descripcion;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)CBCategoriaE.SelectedItem).value.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)CBCategoriaE.SelectedItem).Texto.ToString();
                    row.Cells["Stock"].Value = row.Cells["Stock"].Value;
                    row.Cells["PrecioCompra"].Value = row.Cells["PrecioCompra"].Value;
                    row.Cells["PrecioVenta"].Value = row.Cells["PrecioVenta"].Value;
                    row.Cells["IdProveedor"].Value = ((OpcionCombo)cbProveedor.SelectedItem).value.ToString();
                    row.Cells["Proveedor"].Value = ((OpcionCombo)cbProveedor.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)CBEstadoE.SelectedItem).value;
                    row.Cells["Estado"].Value = ((OpcionCombo)CBEstadoE.SelectedItem).Texto.ToString();

                    MessageBox.Show("Producto Actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error ");
                }
            }
            catch (ArgumentException ex)
            {
                // Muestra el mensaje de error en la interfaz de usuario
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex.Message);
            }
        }
    }
}
