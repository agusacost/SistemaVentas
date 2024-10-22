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
                // Validación de Documento (DNI)
                if (string.IsNullOrWhiteSpace(txtDoc.Text))
                {
                    MessageBox.Show("El campo Documento es obligatorio.");
                    return;
                }

                if (txtDoc.Text.Length < 8)
                {
                    MessageBox.Show("El documento debe tener 8 caracteres numéricos .");
                    return;
                }
                if (!EsSoloNumeros(txtDoc.Text))
                {
                    MessageBox.Show("El documento no debe tener caracteres alfabeticos.");
                    return;
                }
                // Validación de Nombre
                if (string.IsNullOrWhiteSpace(txtRSocial.Text))
                {
                    MessageBox.Show("El camporazon social es obligatorio.");
                    return;
                }

                if (txtRSocial.Text.Length > 50)
                {
                    MessageBox.Show("La razon social no debe tener más de 50 caracteres.");
                    return;
                }

                if (ContieneNumeros(txtRSocial.Text))
                {
                    MessageBox.Show("La razon social no puede contener números.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !EsEmailValido(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                    return;
                }


                // Validación de longitud del correo
                if (txtCorreo.Text.Length >= 50)
                {
                    MessageBox.Show("El correo no debe tener más de 50 caracteres.");
                    return;
                }

                Proveedor objProv = new Proveedor()
                {
                    Documento = txtDoc.Text,
                    RazonSocial = txtRSocial.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
                };

                bool registro = new N_Proveedor().Registro(objProv);

                if (registro)
                {
                    frmProveedor.DgvData.Rows.Add(new object[]
                    {
                        "",
                        txtId.Text,
                        txtDoc.Text,
                        txtRSocial.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
                        ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                    });
                    MessageBox.Show("Proveedor agregado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario. Por favor, intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error al agregar un proveedor");
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
