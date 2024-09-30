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
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TextBox TextIdData
        {
            get { return txtId; }
        }
        public TextBox TextDocumentoData
        {
            get { return txtDocumento; }
        }
        public TextBox TextNameData
        {
            get { return txtNombre; }
        }
        public TextBox TextCorreoData
        {
            get { return txtCorreo; }
        }
        public TextBox TextClaveData
        {
            get { return txtClave; }
        }
        public TextBox TextConfirmarClaveData
        {
            get  { return txtClaveConf; }
        }
        public ComboBox ComboRol
        {
            get { return CBRol; }
        }
        public ComboBox ComboEstado
        {
            get { return CBEstado; }
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";
            CBEstado.SelectedIndex = 0;

            List<Rol> listaRol = new N_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CBRol.Items.Add(new OpcionCombo() { value = item.idRol, Texto = item.Descripcion });

            }
            CBRol.DisplayMember = "Texto";
            CBRol.ValueMember = "value";
            CBRol.SelectedIndex = 0;
        }
    }
}
