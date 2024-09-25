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
    public partial class frmAddCliente : Form
    {
        public frmAddCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de Documento (DNI)
            if (string.IsNullOrWhiteSpace(TDNICliente.Text))
            {
                MessageBox.Show("El campo Documento es obligatorio.");
                return;
            }

            if (TDNICliente.Text.Length != 8)
            {
                MessageBox.Show("El documento debe tener 8 caracteres numéricos .");
                return;
            }
            if (!EsSoloNumeros(TDNICliente.Text))
            {
                MessageBox.Show("El documento no debe tener caracteres alfabeticos.");
                return;
            }
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(TNombreCliente.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (TNombreCliente.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TNombreCliente.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TCorreoCliente.Text) || !EsEmailValido(TCorreoCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validación de Estado
            if (!RBActivoCliente.Checked && !RBInactivoCliente.Checked)
            {
                MessageBox.Show("Debe seleccionar un estado (Activo o Inactivo).");
                return;
            }

            // Validación de longitud del correo
            if (TCorreoCliente.Text.Length >= 50)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
