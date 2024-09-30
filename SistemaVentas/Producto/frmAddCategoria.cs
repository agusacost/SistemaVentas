using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Producto
{
    public partial class frmAddCategoria : Form
    {
        public frmAddCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(TNombreCat.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (TNombreCat.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TNombreCat.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TDescripcionCat.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (TDescripcionCat.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TDescripcionCat.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }

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

    }
}
