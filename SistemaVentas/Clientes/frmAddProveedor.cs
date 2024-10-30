using Entidades;
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
using Negocio;

namespace SistemaVentas.Clientes
{
    public partial class frmAddProveedor : Form
    {
        private frmProveedor frmProveedor;
        public frmAddProveedor(frmProveedor formProveedor)
        {
            InitializeComponent();
            frmProveedor = formProveedor;
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                Proveedor objProveedor = new Proveedor()
                {
                    Documento = txtDoc.Text,
                    RazonSocial = txtRSocial.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
                };
                if (objProveedor.IdProveedor == 0)
                {
                    int idProveedorgenerado = new N_Proveedor().Registro(objProveedor, out mensaje);
                    List<Proveedor> listProveedor = new N_Proveedor().Listar();
                    int nuevoId = listProveedor.Any() ? listProveedor.Max(c => c.IdProveedor) + 1 : 1;

                    if (idProveedorgenerado != 0)
                    {
                        frmProveedor.DgvData.Rows.Add(new object[]
                        {
                            "",
                            nuevoId,
                            txtDoc.Text,
                            txtRSocial.Text,
                            txtCorreo.Text,
                            txtTelefono.Text,
                            ((OpcionCombo)CBEstado.SelectedItem).value.ToString(),
                            ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                        });
                        MessageBox.Show("Proveedor agregado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Proveedor" + ex.Message);
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

        private void btnCancelarProv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProveedor_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";
            CBEstado.SelectedIndex = 0;
        }
    }
}
