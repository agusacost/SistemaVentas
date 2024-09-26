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

namespace SistemaVentas.Usuarios
{
    public partial class frmEditUsuario : Form
    {
        public frmEditUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreE.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido.");
                return;
            }
            if (ContieneNumeros(txtNombreE.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(txtDocumentoE.Text) || !int.TryParse(txtDocumentoE.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
                return;
            }

            // **Aquí se usa la función EsEmailValido para validar el email**
            if (string.IsNullOrWhiteSpace(txtCorreoE.Text) || !EsEmailValido(txtCorreoE.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validacion Longitudes
            if (txtClaveE.Text.Length <= 5)
            {
                MessageBox.Show("La clave debe tener al menos 5 caracteres.");
                return;
            }
            if (txtClaveE.Text.Length >= 50)
            {
                MessageBox.Show("La clave no debe tener 50 caracteres.");
                return;
            }
            if (txtClaveE.Text.Length >= 50)
            {
                MessageBox.Show("El Nombre y apellido no puede ser mayor a 50.");
                return;
            }
            if (txtCorreoE.Text.Length >= 50)
            {
                MessageBox.Show("El email no puede ser mayor a 50.");
                return;
            }

            if (txtClaveE != txtClaveConfE)
            {
                MessageBox.Show("La contraseñas no coinciden.");
            }

            // Validar que se seleccione un Estado
            if (CBEstadoE.SelectedIndex == -1 || CBEstadoE.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione un estado.");
                return;
            }

            // Validar que se seleccione un Rol
            if (CBRolE.SelectedIndex == -1 || CBRolE.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione un rol.");
                return;
            }
        }
        private void txtDocumentoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números en el campo de DNI
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                var emailDireccion = new System.Net.Mail.MailAddress(email);
                return emailDireccion.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
