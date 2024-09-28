using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Utilities;
using SistemaVentas.Usuarios;
using Entidades;
using Negocio;

namespace SistemaVentas.Usuarios
{
    public partial class frmAddUsuario : Form
    {
        private frmUsuario frmUsuario;
        public frmAddUsuario(frmUsuario formUsuario)
        {
            InitializeComponent();
            frmUsuario = formUsuario;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUsuario_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember= "value";
            CBEstado.SelectedIndex = 0;

            List<Rol> listaRol = new N_Rol().Listar();

            foreach(Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { value = item.idRol, Texto = item.Descripcion });

            }
            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "value";
            CBRol.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido.");
                return;
            }
            if (ContieneNumeros(txtNombre.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }

            // Validar DNI
            if (string.IsNullOrWhiteSpace(txtDocumento.Text) || !int.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
                return;
            }

            // **Aquí se usa la función EsEmailValido para validar el email**
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !EsEmailValido(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            // Validacion Longitudes
            if (txtClave.Text.Length <= 5)
            {
                MessageBox.Show("La clave debe tener al menos 5 caracteres.");
                return;
            }
            if (txtClave.Text.Length >= 50)
            {
                MessageBox.Show("La clave no debe tener 50 caracteres.");
                return;
            }
            if (txtClave.Text.Length >= 50)
            {
                MessageBox.Show("El Nombre y apellido no puede ser mayor a 50.");
                return;
            }
            if (txtCorreo.Text.Length >= 50)
            {
                MessageBox.Show("El email no puede ser mayor a 50.");
                return;
            }

            if (txtClave != txtClaveConf)
            {
                MessageBox.Show("La contraseñas no coinciden.");
            }


            frmUsuario.DgvData.Rows.Add(new object[] {"",txtId.Text,txtNombre.Text, txtDocumento.Text, txtCorreo.Text, txtClave.Text,
                ((OpcionCombo)CBRol.SelectedItem).value.ToString(),
                ((OpcionCombo)CBRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CBEstado.SelectedItem).value.ToString(),
            });
            Limpiar();
            
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtClaveConf.Text = "";
            CBEstado.SelectedIndex = 0;
            CBRol.SelectedIndex = 0;
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
