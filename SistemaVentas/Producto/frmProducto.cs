using SistemaVentas.Clientes;
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
using Entidades;

namespace SistemaVentas.Producto
{
    public partial class frmProducto : Form
    {
        private frmAddProducto frmAddProducto;
        private frmEditarProducto frmEditarProducto;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmEditarProducto != null && !frmEditarProducto.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Producto' mientras 'Editar Producto' está abierto.");
                frmEditarProducto.Focus();
                return;
            }

            if (frmAddProducto == null || frmAddProducto.IsDisposed)
            {
                frmAddProducto = new frmAddProducto();
                frmAddProducto.Show();
            }
            else
            {
                frmAddProducto.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (frmAddProducto != null && !frmAddProducto.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Producto' mientras 'Agregar Producto' está abierto.");
                frmAddProducto.Focus();
                return;
            }

            if (frmEditarProducto == null || frmEditarProducto.IsDisposed)
            {
                frmEditarProducto = new frmEditarProducto();
                frmEditarProducto.Show();
            }
            else
            {
                frmEditarProducto.Focus();
            }
        }

        public DataGridView DgvData { 
            get { return dgvdata; }
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            //fetch de productos
            List<Entidades.Producto> listaProd = new N_Producto().listar();
            foreach (Entidades.Producto item in listaProd)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.oProveedor.Documento,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }
    }
}
