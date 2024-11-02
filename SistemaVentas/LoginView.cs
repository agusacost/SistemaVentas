using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidades;

namespace SistemaVentas
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new N_User().Listar();
            Usuario ousuario = new N_User().Listar().Where(u => (u.Documento == txtDocumento.Text) && (u.Clave == txtClave.Text)).FirstOrDefault();
            
            if (ousuario != null && ousuario.Estado)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else if(ousuario != null && !ousuario.Estado) 
            {
                MessageBox.Show("Este usuario está inactivo. No puede iniciar sesión.", "Usuario Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtClave.Text = "";
            this.Show();
        }

    }
}
