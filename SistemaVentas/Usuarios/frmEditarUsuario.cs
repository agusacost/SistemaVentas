﻿using Entidades;
using Negocio;
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

namespace SistemaVentas.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }
        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TextBox TextIndice
        {
            get { return txtIndice; }
        }
        public TextBox TextIdData
        {
            get { return txtId; }
        }
        public TextBox TextDocumentoData
        {
            get { return txtDocumentoE; }
        }
        public TextBox TextNameData
        {
            get { return txtNombreE; }
        }
        public TextBox TextCorreoData
        {
            get { return txtCorreoE; }
        }
        public TextBox TextClaveData
        {
            get { return txtClaveE; }
        }
        public TextBox TextConfirmarClaveData
        {
            get  { return txtClaveConfE; }
        }
        public ComboBox ComboRol
        {
            get { return CBRolE; }
        }
        public ComboBox ComboEstado
        {
            get { return CBEstadoE; }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            CBEstadoE.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstadoE.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstadoE.DisplayMember = "Texto";
            CBEstadoE.ValueMember = "value";
            CBEstadoE.SelectedIndex = 0;

            List<Rol> listaRol = new N_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRolE.Items.Add(new OpcionCombo() { value = item.idRol, Texto = item.Descripcion });

            }
            CBRolE.DisplayMember = "Texto";
            CBRolE.ValueMember = "value";
            CBRolE.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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


        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtNombreE.Text = "";
            txtDocumentoE.Text = "";
            txtCorreoE.Text = "";
            txtClaveE.Text = "";
            txtClaveConfE.Text = "";
            CBEstadoE.SelectedIndex = 0;
            CBRolE.SelectedIndex = 0;
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


    }
}
