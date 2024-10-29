using Entidades;
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
using SistemaVentas.Utilities;

namespace SistemaVentas.Producto
{
    public partial class frmAddProducto : Form
    {
        private frmProducto frmProducto;
        public frmAddProducto(frmProducto formProducto)
        {
            InitializeComponent();
            frmProducto = formProducto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (caracteres entre '0' y '9') y el carácter de control (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si no es número o backspace
            }
        }
        private void TPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, teclas de control (como Backspace) y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;  // Bloquea el ingreso de la tecla
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Entidades.Producto objProducto = new Entidades.Producto()
                {
                    Codigo = GenerarCodigoProducto(),
                    Nombre = TNombre.Text,
                    Descripcion = TDescripcion.Text,
                    oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)CBCategoria.SelectedItem).value) },
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1,

                };

                bool registro = new N_Producto().Registrar(objProducto);
                
                if (registro)
                {
                    frmProducto.DgvData.Rows.Add(new object[]
                    {
                    "",
                    txtId.Text,
                    objProducto.Codigo,
                    objProducto.Nombre,
                    objProducto.Descripcion,
                    ((OpcionCombo)CBCategoria.SelectedItem).value.ToString(),
                    ((OpcionCombo)CBCategoria.SelectedItem).Texto.ToString(),
                    objProducto.Stock.HasValue? objProducto.Stock.Value.ToString() : "N/A",
                    objProducto.PrecioCompra.HasValue? objProducto.PrecioCompra.Value.ToString() : "N/A",
                    objProducto.PrecioVenta.HasValue? objProducto.PrecioVenta.Value.ToString("C") : "N/A",
                    objProducto.oProveedor != null ? objProducto.oProveedor.IdProveedor : 0,
                    objProducto.oProveedor != null ? objProducto.oProveedor.Documento : "Sin Proveedor",
                    ((OpcionCombo)CBEstado.SelectedItem).value,
                    ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString()
                    });
                    limpiar();
                    MessageBox.Show("Producto agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error ");
                    limpiar();
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

        private void limpiar()
        {
            txtId.Text = "0";
            TNombre.Text = "";
            TDescripcion.Text = "";
            CBCategoria.SelectedIndex = 0;
            CBEstado.SelectedIndex = 0;
        }

        private string GenerarCodigoProducto()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper(); // Genera un código único de 10 caracteres
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProducto_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";
            CBEstado.SelectedIndex = 0; 

            List<Categoria> listaCat = new N_Categoria().Listar();

            foreach(Categoria cat in listaCat)
            {
                CBCategoria.Items.Add(new OpcionCombo()
                {
                    value = cat.IdCategoria,
                    Texto = cat.Descripcion,
                });
            }
            CBCategoria.DisplayMember = "Texto";
            CBCategoria.ValueMember = "value";
            CBCategoria.SelectedIndex = 0;

        }

    }
}
