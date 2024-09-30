using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Ventas
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void userlabel_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarFecha()
        {
            if (DateTime.Now < DateFecha.Value)
            {
                MessageBox.Show("La fecha de la venta no puede ser en el futuro.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateFecha.Value = DateTime.Now; // Ajusta el valor a la fecha actual.
                return false; // Devuelve false si la fecha es inválida.
            }
            return true; // Devuelve true si la fecha es válida.
        }
        private bool ValidarTipoDocumento()
        {
            if (string.IsNullOrEmpty(CBTipoDoc.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarNumeroDocumento()
        {
            if (string.IsNullOrWhiteSpace(TDNICliente.Text))
            {
                MessageBox.Show("Debe ingresar el número de documento.", "Número de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!long.TryParse(TDNICliente.Text, out _) || TDNICliente.Text.Length != 8)
            {
                MessageBox.Show("El número de documento debe ser numérico y debe tener 8 digitos.", "Número de documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarNombreCliente()
        {
            // Verifica que no esté vacío ni solo con espacios
            if (string.IsNullOrWhiteSpace(TNombreCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Nombre de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el nombre no tenga más de 40 caracteres
            if (TNombreCliente.Text.Length > 40)
            {
                MessageBox.Show("El nombre del cliente no puede tener más de 40 caracteres.", "Nombre de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el nombre no contenga números
            if (TNombreCliente.Text.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre del cliente no debe contener números.", "Nombre de Cliente inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarProducto()
        {
            if (string.IsNullOrWhiteSpace(TProd.Text))
            {
                MessageBox.Show("Debe seleccionar un producto.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el nombre del producto no tenga más de 40 caracteres
            if (TProd.Text.Length > 40)
            {
                MessageBox.Show("El nombre del producto no puede tener más de 40 caracteres.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarCodigoProducto()
        {
            if (string.IsNullOrWhiteSpace(TCodProd.Text))
            {
                MessageBox.Show("Debe ingresar el código de producto.", "Código de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarPrecioYStock()
        {
            if (!decimal.TryParse(TPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un valor positivo.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(TStock.Text, out int stock) || stock <= 0)
            {
                MessageBox.Show("El stock debe ser un número positivo.", "Stock inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(TCantidadProd.Text, out int cantidad) || cantidad <= 0 || cantidad > stock)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0 y no mayor al stock disponible.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarPago()
        {
            if (!decimal.TryParse(TTotal.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("El total a pagar debe ser un valor positivo.", "Total inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(TPaga.Text, out decimal pago) || pago < total)
            {
                MessageBox.Show("El monto pagado debe ser mayor o igual al total a pagar.", "Pago insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Calcular el cambio
            TCambio.Text = (pago - total).ToString("F2");
            return true;
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarFecha() ||
        !ValidarTipoDocumento() ||
        !ValidarNumeroDocumento() ||
        !ValidarNombreCliente() ||
        !ValidarCodigoProducto() ||
        !ValidarProducto() || 
        !ValidarPrecioYStock() ||
        !ValidarPago())
            {
                
                return;
            }

            // agregar el código para registrar la venta en la base de datos
            MessageBox.Show("Venta registrada con éxito.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
