using Entidades;
using Negocio;
using SistemaVentas.Producto;
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
    public partial class frmUsuario : Form
    {
        private frmAddUsuario frmAddUsuario;
        private frmEditarUsuario frmEditarUsuario;
        private int selectedRowIndex = -1;
        private Usuario selectedUser = null;
        private int selectedIdComboRol = 0;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmarclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAddUsuario form = new frmAddUsuario(this);
            form.Show();
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn columa in dgvdata.Columns) {
                if (columa.Visible == true && columa.Name != "btnSeleccionar") {
                    cbbusqueda.Items.Add(new OpcionCombo() { value = columa.Name, Texto = columa.HeaderText });
                }
            }
            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "value";
            cbbusqueda.SelectedIndex = 0;
            //Fetch usuarios
            List<Usuario> listaUsers = new N_User().Listar();
            foreach(Usuario item in listaUsers)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento, item.NombreCompleto, item.Correo,item.Nacionalidad,item.Ciudad,item.Direccion,item.Telefono,
                item.Clave,
                item.oRol.idRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1:0,
                item.Estado == true ? "Activo" : "Inactivo",
            });
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                var icon = Properties.Resources.check_icon;
                int iconWidth = icon.Width;
                int iconHeight = icon.Height;
                float scale = Math.Min((float)cellWidth / iconWidth, (float)cellHeight / iconHeight);

                int newWidth = (int)(iconWidth * scale);
                int newHeight = (int)(iconHeight * scale);
                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                e.Graphics.DrawImage(icon, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (frmEditarUsuario != null && !frmEditarUsuario.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Usuario' mientras 'Editar Usuario' está abierto.");
                frmEditarUsuario.Focus();
                return;
            }

            if (frmAddUsuario == null || frmAddUsuario.IsDisposed)
            {
                frmAddUsuario = new frmAddUsuario(this);
                frmAddUsuario.Show();
            }
            else
            {
                frmAddUsuario.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                
                MessageBox.Show("Por favor, selecciona un usuario para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (frmAddUsuario != null && !frmAddUsuario.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Usuario' mientras 'Agregar Usuario' está abierto.");
                frmAddUsuario.Focus();
                return;
            }

            if (frmEditarUsuario == null || frmEditarUsuario.IsDisposed)
            {
                frmEditarUsuario = new frmEditarUsuario();
                frmEditarUsuario.TextIdData.Text = selectedUser.IdUsuario.ToString();
                frmEditarUsuario.TextDocumentoData.Text = selectedUser.Documento;
                frmEditarUsuario.TextNameData.Text = selectedUser.NombreCompleto;
                frmEditarUsuario.TextCorreoData.Text = selectedUser.Correo;
                frmEditarUsuario.TextNac.Text = selectedUser.Nacionalidad;
                frmEditarUsuario.TextCiud.Text = selectedUser.Ciudad;
                frmEditarUsuario.TextDir.Text = selectedUser.Direccion;
                frmEditarUsuario.TextTel.Text = selectedUser.Telefono;
                frmEditarUsuario.TextIndice.Text = selectedRowIndex.ToString();
                frmEditarUsuario.Show();
            }
            else
            {
                frmEditarUsuario.Focus();
            }
        }

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                 selectedRowIndex = e.RowIndex;

                if (selectedRowIndex >= 0)
                {
                    selectedUser = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdUsuario"].Value),
                        Documento = dgvdata.Rows[selectedRowIndex].Cells["Documento"].Value.ToString(),
                        NombreCompleto = dgvdata.Rows[selectedRowIndex].Cells["NombreCompleto"].Value.ToString(),
                        Correo = dgvdata.Rows[selectedRowIndex].Cells["Correo"].Value.ToString(),
                        Telefono = dgvdata.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString(),
                        Nacionalidad = dgvdata.Rows[selectedRowIndex].Cells["Nacionalidad"].Value.ToString(),
                        Ciudad = dgvdata.Rows[selectedRowIndex].Cells["Ciudad"].Value.ToString(),
                        Direccion = dgvdata.Rows[selectedRowIndex].Cells["Direccion"].Value.ToString(),
                        Clave = dgvdata.Rows[selectedRowIndex].Cells["Clave"].Value.ToString(),
                        Estado = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["EstadoValor"].Value) == 1
                    };
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(selectedUser == null)
            {
                MessageBox.Show("Por favor, selecciona un usuario para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            bool nuevoEstado = false;
            DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas dar de baja al usuario '{selectedUser.NombreCompleto}'", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                bool resultado = new N_User().Baja(selectedUser.IdUsuario, nuevoEstado);
                if (resultado)
                {
                    selectedUser.Estado = nuevoEstado;
                    dgvdata.Rows[selectedRowIndex].Cells["Estado"].Value = "Inactivo";

                    MessageBox.Show("Usuario dado de baja");

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado del usuario. Por favor, intente nuevamente.");
                }
            }
           

            }

        private void backLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

