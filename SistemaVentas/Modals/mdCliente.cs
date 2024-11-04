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
using Entidades;

namespace SistemaVentas.Modals
{
    public partial class mdCliente : Form
    {
        public Cliente _Cliente { get; set; }
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbbusqueda.Items.Add(new OpcionCombo() { value = columna.Name, Texto = columna.HeaderText });

            }

            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "value";
            cbbusqueda.SelectedIndex = 0;

            List<Cliente> lista = new N_Cliente().Listar();

            foreach(Cliente item in lista)
            {
                if(item.Estado)
                    dgvdata.Rows.Add(new object[] {item.IdCliente, item.Documento, item.NombreCompleto});
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                _Cliente = new Cliente()
                {
                    IdCliente = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdCliente"].Value.ToString()),
                    Documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgvdata.Rows[iRow].Cells["Nombre"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbusqueda.SelectedItem).value.ToString();

            if(dgvdata.Rows.Count > 0 )
            {
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
