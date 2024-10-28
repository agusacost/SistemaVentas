using SistemaVentas.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace SistemaVentas.Compras
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarFecha()
        {
            if (DateTime.Now < DateFechaCompra.Value)
            {
                MessageBox.Show("La fecha de la venta no puede ser en el futuro.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateFechaCompra.Value = DateTime.Now; // Ajusta el valor a la fecha actual.
                return false; // Devuelve false si la fecha es inválida.
            }
            return true; // Devuelve true si la fecha es válida.
        }
        private bool ValidarTipoDocumento()
        {
            if (string.IsNullOrEmpty(CBFactura.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        private bool ValidarRazonSocial()
        {
            // Verifica que no esté vacío ni solo con espacios
            if (string.IsNullOrWhiteSpace(TRazonSocialC.Text))
            {
                MessageBox.Show("Debe ingresar la razon social.", "Razon Social", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el nombre no tenga más de 40 caracteres
            if (TRazonSocialC.Text.Length > 40)
            {
                MessageBox.Show("La razon social no puede tener más de 40 caracteres.", "Razon Social", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el nombre no contenga números
            if (TRazonSocialC.Text.Any(char.IsDigit))
            {
                MessageBox.Show("La razon social no debe contener números.", "Razon Social", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarProducto()
        {
            // Verifica que el nombre del producto no tenga más de 40 caracteres
            if (TProductoC.Text.Length > 40)
            {
                MessageBox.Show("El nombre del producto no puede tener más de 40 caracteres.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidarCodigoProducto()
        {
            if (string.IsNullOrWhiteSpace(TCodProdC.Text))
            {
                MessageBox.Show("Debe ingresar el código de producto.", "Código de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarPrecioYStock()
        {
            if (!decimal.TryParse(TPrecioCompraC.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio  venta debe ser un valor positivo.", "Precio  Venta inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(TPrecioCompraC.Text, out int stock) || stock <= 0)
            {
                MessageBox.Show("El Precio compra debe ser un número positivo.", "Precio Compra inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(CantidadC.Text, out int cantidad) || cantidad <= 0 || cantidad > stock)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0 y no mayor al stock disponible.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarPago()
        {
            if (!decimal.TryParse(TTotalAPagar.Text, out decimal total) || total <= 0)
            {
                MessageBox.Show("El total a pagar debe ser un valor positivo.", "Total inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BRegistrar_Click(object sender, EventArgs e)
        {
       

        }
        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (!ValidarFecha() ||
           !ValidarTipoDocumento() ||
           !ValidarRazonSocial() ||
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

        private void BLimpiarCompra_Click(object sender, EventArgs e)
        {
            
            TRazonSocialC.Clear();
            TProductoC.Clear();
            TCodProdC.Clear();
            TPrecioCompraC.Clear();
            TTotalAPagar.Clear();

            // Restablecer los ComboBox
            CBFactura.SelectedIndex = -1; // Si no tienes un valor predeterminado, utiliza -1
                                             // Agrega aquí otros ComboBox que necesiten ser limpiados, si los hay
            CantidadC.Value= 0;

            // Restablecer a la fecha actual
            DateFechaCompra.Value = DateTime.Now; 
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CBFactura.Items.Add(new OpcionCombo() { value = 1, Texto = "Factura A" });
            CBFactura.Items.Add(new OpcionCombo() { value = 2, Texto = "Factura B" });
            CBFactura.Items.Add(new OpcionCombo() { value = 3, Texto = "Factura C" });
            CBFactura.DisplayMember = "Texto";
            CBFactura.ValueMember = "value";
            CBFactura.SelectedIndex = 2;

            List<Proveedor> listaprov = new N_Proveedor().Listar();
            foreach(Proveedor prov in listaprov)
            {
                CbProveedor.Items.Add(new OpcionCombo()
                {
                    value = prov.IdProveedor,
                    Texto = prov.Documento,
                });
            }
            CbProveedor.DisplayMember = "Texto";
            CbProveedor.ValueMember = "value";
            CbProveedor.SelectedIndex = 0;
        }
    }

}

