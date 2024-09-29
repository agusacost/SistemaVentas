using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Clientes
{
    public partial class frmEditProveedor : Form
    {
        public frmEditProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregarProvE_Click(object sender, EventArgs e)
        {
            // Validación de Documento (DNI)
            if (string.IsNullOrWhiteSpace(TDNIProvE.Text))
            {
                MessageBox.Show("El campo Documento es obligatorio.");
                return;
            }

            if (TDNIProvE.Text.Length != 8)
            {
                MessageBox.Show("El documento debe tener 8 caracteres numéricos .");
                return;
            }
            if (!EsSoloNumeros(TDNIProvE.Text))
            {
                MessageBox.Show("El documento no debe tener caracteres alfabeticos.");
                return;
            }
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(TRazonSocialE.Text))
            {
                MessageBox.Show("El camporazon social es obligatorio.");
                return;
            }

            if (TRazonSocialE.Text.Length > 50)
            {
                MessageBox.Show("La razon social no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TRazonSocialE.Text))
            {
                MessageBox.Show("La razon social no puede contener números.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TCorreoProvE.Text) || !EsEmailValido(TCorreoProvE.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validación de Estado
            if (!RBActivoProvE.Checked && !RBInactivoProvE.Checked)
            {
                MessageBox.Show("Debe seleccionar un estado (Activo o Inactivo).");
                return;
            }

            // Validación de longitud del correo
            if (TCorreoProvE.Text.Length >= 50)
            {
                MessageBox.Show("El correo no debe tener más de 50 caracteres.");
                return;
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
        private bool EsSoloNumeros(string texto)
        {
            return texto.All(char.IsDigit);
        }

        // Método para verificar si una cadena contiene números
        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private void btnCancelarProvE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
