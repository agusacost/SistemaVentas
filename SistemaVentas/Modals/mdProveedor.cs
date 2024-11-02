using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Modals
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor {  get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            List<Proveedor> listProv = new N_Proveedor().Listar();
            foreach (Proveedor item in listProv)
            {
                dgvdata.Rows.Add(new object[]
                {
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial
                });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if(iRow >= 0 && iCol > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdProveedor"].Value.ToString()),
                    Documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBusqueda.Text.Trim().ToLower();
            List<Proveedor> listaProv = new N_Proveedor().Listar();

            var filteredProv = listaProv
                .Where(c =>
                    c.Documento.ToLower().Contains(searchText) ||
                    c.RazonSocial.ToLower().Contains(searchText))
                .ToList();

            dgvdata.Rows.Clear();
            foreach (var item in filteredProv)
            {
                dgvdata.Rows.Add(
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            List<Proveedor> listaProv = new N_Proveedor().Listar();
            dgvdata.Rows.Clear();

            foreach (var item in listaProv)
            {
                dgvdata.Rows.Add(
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial
                );
            }
        }
    }
}
