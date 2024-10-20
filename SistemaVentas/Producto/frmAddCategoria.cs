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
using Microsoft.Win32;
using SistemaVentas.Usuarios;

namespace SistemaVentas.Producto
{
    public partial class frmAddCategoria : Form
    {
        private frmCategoria frmCategoria;
        public frmAddCategoria(frmCategoria formCategoria)
        {
            InitializeComponent();
            frmCategoria = formCategoria;
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(txtDescripcion.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }

            Categoria objCat = new Categoria()
            {
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)CBEstado.SelectedItem).value) == 1
            };

            bool agregarCat = new N_Categoria().AddCat(objCat);

            if (agregarCat)
            {
                frmCategoria.DgvData.Rows.Add(new object[]
                {
                        "",
                        txtId.Text,
                        txtDescripcion.Text,
                        ((OpcionCombo)CBEstado.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)CBEstado.SelectedItem).value.ToString(),
                });
                limpiar();
                MessageBox.Show("Categoria agregada con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar la Categoria. Por favor, intente nuevamente.");
            }

        }
        private void limpiar()
        {
            txtDescripcion.Text = "";
            CBEstado.SelectedIndex = 0;
        }
        // Método para verificar si una cadena contiene números
        private bool ContieneNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCategoria_Load(object sender, EventArgs e)
        {
            CBEstado.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstado.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstado.DisplayMember = "Texto";
            CBEstado.ValueMember = "value";
            CBEstado.SelectedIndex = 0;
        }
    }
}
