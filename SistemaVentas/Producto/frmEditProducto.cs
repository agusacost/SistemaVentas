using Entidades;
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
    public partial class frmEditProducto : Form
    {
        public frmEditProducto()
        {
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
        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombreE.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TDescripcionE.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio.");
                return;
            }

            // Validación de Categoría
            if (CBCategoriaE.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            // Validación de Stock
            int stock;
            if (!int.TryParse(TCantidadE.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Stock (debe ser un número positivo).");
                return;
            }

            // Validación de Precio
            decimal precio;
            if (!decimal.TryParse(TPrecioCompraE.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio (debe ser mayor a cero).");
                return;
            }

            // Validación de Estado
            if (CBEstadoE.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar un estado (Activo o Inactivo).");
                return;
            }

            //validaciones de longitudes
            if (TNombreE.Text.Length <= 5)
            {
                MessageBox.Show("La clave debe tener al menos 5 caracteres.");
                return;
            }
            if (TDescripcionE.Text.Length >= 50)
            {
                MessageBox.Show("La clave no debe tener 50 caracteres.");
                return;
            }

            // Si todas las validaciones pasan, guarda el producto
            MessageBox.Show("Producto editado correctamente.");
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
