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
    public partial class frmEditarCategoria : Form
    {
        public frmEditarCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCatE_Click(object sender, EventArgs e)
        {
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(TNombreCatE.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (TNombreCatE.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TNombreCatE.Text))
            {
                MessageBox.Show("El Nombre no puede contener números.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TDescripcionCatE.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return;
            }

            if (TDescripcionCatE.Text.Length > 50)
            {
                MessageBox.Show("El Nombre no debe tener más de 50 caracteres.");
                return;
            }

            if (ContieneNumeros(TDescripcionCatE.Text))
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

        private void btnCancelarCatE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
