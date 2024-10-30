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

namespace SistemaVentas.Clientes
{
    public partial class frmEditProveedor : Form
    {
        private Proveedor selectedProveedor;
        private frmProveedor frmProveedor;
        private int selectedRowIndex;
        public frmEditProveedor(frmProveedor formProveedor, Proveedor proveedor, int RowIndex)
        {
            this.selectedProveedor = proveedor;
            frmProveedor = formProveedor;
            selectedRowIndex = RowIndex;
            InitializeComponent();
        }

        private void btnAgregarProvE_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                Proveedor objprov = new Proveedor()
                {
                    IdProveedor = selectedProveedor.IdProveedor,
                    Documento = txtDocumento.Text,
                    RazonSocial = txtRsocial.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
                };
                bool provEdited = new N_Proveedor().Editar(objprov, out mensaje);

                if (provEdited)
                {
                    DataGridViewRow row = frmProveedor.DgvData.Rows[selectedRowIndex];
                    row.Cells["IdProveedor"].Value = objprov.IdProveedor;
                    row.Cells["Documento"].Value = objprov.Documento;
                    row.Cells["RazonSocial"].Value = objprov.RazonSocial;
                    row.Cells["Correo"].Value = objprov.Correo;
                    row.Cells["Telefono"].Value = objprov.Telefono;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).value;
                    row.Cells["Estado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                    MessageBox.Show("Proveedor Editado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar Proveedor" + ex.Message);
            }
        }
        
        private void btnCancelarProvE_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditProveedor_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";

            txtDocumento.Text = selectedProveedor.Documento;
            txtRsocial.Text = selectedProveedor.RazonSocial;
            txtCorreo.Text = selectedProveedor.Correo;
            txtTelefono.Text = selectedProveedor.Telefono;
            foreach (OpcionCombo item in CBEstado.Items)
            {
                if ((int)item.value == (selectedProveedor.Estado ? 1 : 2))
                {
                    CBEstado.SelectedItem = item;
                }
            }

        }
    }
}
