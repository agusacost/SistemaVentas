using Entidades;
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
        private Usuario usuario;
        private frmUsuario frmUsuario;
        private int selectedRowIndex; 
        public frmEditarUsuario(frmUsuario formUsuario, Usuario objUsuario, int RowIndex)
        {
            selectedRowIndex = RowIndex;
            frmUsuario = formUsuario;
            this.usuario = objUsuario; 
            InitializeComponent();
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {   

            CBEstadoE.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstadoE.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstadoE.DisplayMember = "Texto";
            CBEstadoE.ValueMember = "value";
            //CBEstadoE.SelectedIndex = 0;

            List<Rol> listaRol = new N_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRolE.Items.Add(new OpcionCombo() { value = item.idRol, Texto = item.Descripcion });

            }
            CBRolE.DisplayMember = "Texto";
            CBRolE.ValueMember = "value";

            txtDocumentoE.Text = usuario.Documento.ToString();
            txtNombreE.Text = usuario.NombreCompleto.ToString();
            txtCorreoE.Text = usuario.Correo.ToString();
            txtNac.Text = usuario.Nacionalidad.ToString();
            txtCiud.Text = usuario.Ciudad.ToString();
            textBoxDir.Text = usuario.Direccion.ToString();
            txtTel.Text = usuario.Telefono.ToString();
            int estadoValue = usuario.Estado ? 1 : 2;
            foreach(OpcionCombo item in CBEstadoE.Items)
            {
                if((int)item.value == estadoValue)
                {
                    CBEstadoE.SelectedItem = item;
                }
            }
            foreach (OpcionCombo item in CBRolE.Items)
            {
                if ((int)item.value == usuario.oRol.idRol)
                {
                    CBRolE.SelectedItem = item;
                    break;
                }
            }

        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario()
                {
                    IdUsuario = usuario.IdUsuario,
                    Documento = txtDocumentoE.Text,
                    NombreCompleto = txtNombreE.Text,
                    Correo = txtCorreoE.Text,
                    Clave = usuario.Clave,
                    Nacionalidad = txtNac.Text,
                    Ciudad = txtCiud.Text,
                    Direccion = textBoxDir.Text,
                    Telefono = txtTel.Text,
                    oRol = new Rol() { idRol = Convert.ToInt32(((OpcionCombo)CBRolE.SelectedItem).value) },
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstadoE.SelectedItem).value) == 1
                };
                bool editar = new N_User().Editar(objUsuario);
                if (editar)
                {
                    DataGridViewRow row = frmUsuario.DgvData.Rows[selectedRowIndex];
                    row.Cells["IdUsuario"].Value = objUsuario.IdUsuario;
                    row.Cells["NombreCompleto"].Value = objUsuario.NombreCompleto;
                    row.Cells["Documento"].Value = objUsuario.Documento;
                    row.Cells["Correo"].Value = objUsuario.Correo;
                    row.Cells["Nacionalidad"].Value = objUsuario.Nacionalidad;
                    row.Cells["Ciudad"].Value = objUsuario.Ciudad;
                    row.Cells["Direccion"].Value = objUsuario.Direccion;
                    row.Cells["Telefono"].Value = objUsuario.Telefono;
                    row.Cells["idRol"].Value = objUsuario.oRol.idRol;
                    row.Cells["Rol"].Value = ((OpcionCombo)CBRolE.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = objUsuario.Estado ? 1 : 0;
                    row.Cells["Estado"].Value = ((OpcionCombo)CBEstadoE.SelectedItem).Texto.ToString();
                    Limpiar();
                    MessageBox.Show("Usuario editado con éxito");
                    this.Close();
                }else
                {
                    MessageBox.Show("Error al actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtNombreE.Text = "";
            txtDocumentoE.Text = "";
            txtCorreoE.Text = "";
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

        private void CBEstadoE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
