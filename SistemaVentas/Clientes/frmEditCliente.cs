using SistemaVentas.Producto;
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
using Negocio;
using SistemaVentas.Utilities;

namespace SistemaVentas.Clientes
{
    public partial class frmEditCliente : Form
    {
        private Cliente selectedCliente;
        private frmCliente frmCliente;
        private int selectedRowIndex;
        public frmEditCliente(frmCliente formCliente, Cliente cliente, int RowIndex)
        {
            this.selectedCliente = cliente;
            frmCliente = formCliente;
            selectedRowIndex = RowIndex;
            InitializeComponent();
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                Cliente objCliente = new Cliente()
                {
                    IdCliente = selectedCliente.IdCliente,
                    Documento = txtDni.Text,
                    NombreCompleto = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
                };
                bool clienteEdited = new N_Cliente().Editar(objCliente, out mensaje);

                if (clienteEdited)
                {
                    DataGridViewRow row = frmCliente.DgvData.Rows[selectedRowIndex];
                    row.Cells["IdCliente"].Value = objCliente.IdCliente;
                    row.Cells["Documento"].Value = objCliente.Documento;
                    row.Cells["NombreCompleto"].Value = objCliente.NombreCompleto;
                    row.Cells["Correo"].Value = objCliente.Correo;
                    row.Cells["Telefono"].Value = objCliente.Telefono;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)CBEstado.SelectedItem).value;
                    row.Cells["Estado"].Value = ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString();
                    MessageBox.Show("Cliente Editado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente" + ex.Message);
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
        private bool EsSoloNumeros(string texto)
        {
            return texto.All(char.IsDigit);
        }

        // Método para verificar si una cadena contiene números
        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private void btnCancelarE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditCliente_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";

            txtNombre.Text = selectedCliente.NombreCompleto;
            txtDni.Text = selectedCliente.Documento;
            txtCorreo.Text = selectedCliente.Correo;
            txtTelefono.Text = selectedCliente.Telefono;
            //int estadoValue = selectedCliente.Estado ? 1 : 2;
            foreach (OpcionCombo item in CBEstado.Items)
            {
                if ((int)item.value == (selectedCliente.Estado ? 1 : 2))
                {
                    CBEstado.SelectedItem = item;
                }
            }
        }
    }
}
