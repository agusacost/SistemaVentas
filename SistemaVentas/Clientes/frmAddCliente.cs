using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmAddCliente : Form
    {
        private frmCliente frmCliente;
        public frmAddCliente(frmCliente formCliente)
        {
            InitializeComponent();
            frmCliente = formCliente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                Cliente objCliente = new Cliente()
                {
                    Documento = txtDocumento.Text,
                    NombreCompleto = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
                };
                if(objCliente.IdCliente == 0)
                {
                    int idusuariogenerado = new N_Cliente().Registro(objCliente,out mensaje);

                    if (idusuariogenerado != 0)
                    {
                        frmCliente.DgvData.Rows.Add(new object[]
                        {
                            "",
                            "",
                            txtDocumento.Text,
                            txtNombre.Text,
                            txtCorreo.Text,
                            txtTelefono.Text,
                            ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                        });
                        MessageBox.Show("Cliente agregado con exito");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCliente_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";
            CBEstado.SelectedIndex = 0;
        }
    }
}
