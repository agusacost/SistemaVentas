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
        public frmAddProducto()
        {
            InitializeComponent();
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
                if (string.IsNullOrWhiteSpace(TNombre.Text))
                {
                    MessageBox.Show("El campo Nombre es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TDescripcion.Text))
                {
                    MessageBox.Show("El campo Descripción es obligatorio.");
                    return;
                }

                // Validación de Stock
                int stock;
                if (!int.TryParse(TCantidad.Text, out stock) || stock < 0)
                {
                    MessageBox.Show("Ingrese un valor válido para el Stock (debe ser un número positivo).");
                    return;
                }

                // Validación de Precio
                decimal precio;
                if (!decimal.TryParse(TPrecioCompra.Text, out precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un valor válido para el Precio (debe ser mayor a cero).");
                    return;
                }


                //validaciones de longitudes
                if (TNombre.Text.Length <= 5)
                {
                    MessageBox.Show("El nombre debe tener al menos 5 caracteres.");
                    return;
                }
                if (TDescripcion.Text.Length >= 50)
                {
                    MessageBox.Show("La descripcion no debe mas tener 50 caracteres.");
                    return;
                }

                // Si todas las validaciones pasan, guarda el producto
                MessageBox.Show("Producto guardado correctamente.");

                Entidades.Producto objProducto = new Entidades.Producto()
                {
                    Codigo = GenerarCodigoProducto(),
                    Nombre = TNombre.Text,
                    Descripcion = TDescripcion.Text,
                    oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)CBCategoria.SelectedItem).value) },
                    Stock = Convert.ToInt32(TCantidad.Text),
                    PrecioCompra = Convert.ToDecimal(TPrecioCompra.Text),
                    PrecioVenta = Convert.ToDecimal(TPrecioCompra.Text) + (Convert.ToDecimal(TPrecioCompra.Text) * Convert.ToDecimal(TPorcentaje.Text) / 100),
                    oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(((OpcionCombo)cbProveedor.SelectedItem).value) },
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1,

                };

                bool registro = new N_Producto().Registrar(objProducto);
                frmProducto frmProducto = new frmProducto();
                //arreglar
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
                    objProducto.Stock,
                    objProducto.PrecioCompra,
                    objProducto.PrecioVenta,
                    ((OpcionCombo)cbProveedor.SelectedItem).value.ToString(),
                    ((OpcionCombo)CBEstado.SelectedItem).value.ToString(),

                    });
                    limpiar();
                    MessageBox.Show("Producto agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al intentar agregar el producto, intente nuevamente");
                }
            }
            catch(Exception ex)
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
            TCantidad.Text = "0";
            TPrecioCompra.Text = "0";
            cbProveedor.SelectedIndex = 0;
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

            List<Proveedor> listaProv = new N_Proveedor().Listar();
            foreach(Proveedor prov in listaProv)
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
        }


    }
}
