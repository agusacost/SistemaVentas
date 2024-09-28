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
    public partial class frmUsuario : Form
    {
        private frmAddUsuario frmAddUsuario;
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if(frmAddUsuario == null || frmAddUsuario.IsDisposed)
            {
                frmAddUsuario = new frmAddUsuario(this);
            frmAddUsuario.Show();
            }
            else
            {
                frmAddUsuario.Focus();
            }
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
                dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                item.oRol.idRol,
                item.oRol.Descripcion,
                //item.Estado == true ? 1:0,
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;

                if(index >= 0)
                {
                    
                }
            }

        }
    }
}
