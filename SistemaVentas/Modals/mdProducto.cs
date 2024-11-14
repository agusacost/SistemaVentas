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

namespace SistemaVentas.Modals
{
    public partial class mdProducto : Form
    {
        public Entidades.Producto _Producto { get; set; }
        public bool esVenta {  get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            //fetch de categorias para combobox
            cbbusqueda.Items.Add(new OpcionCombo()
            {
                value = 0,
                Texto = "Todos"
            });
            List<Categoria> listaCat = new N_Categoria().Listar();
            foreach (Categoria cat in listaCat)
            {
                cbbusqueda.Items.Add(new OpcionCombo()
                {
                    value = cat.IdCategoria,
                    Texto = cat.Descripcion,
                });
            }
            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "value";
            cbbusqueda.SelectedIndex = 0;
            List<Entidades.Producto> listaProd = new N_Producto().listar();

            if (esVenta)
            {
                listaProd = listaProd.Where(p => p.PrecioVenta != 0).ToList();
            }


            foreach (Entidades.Producto item in listaProd)
            {
                dgvdata.Rows.Add(new object[]
                {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                    item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString() : "N/A",
                    item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol >= 0)
            {
                string precioVentaString = dgvdata.Rows[iRow].Cells["PrecioVenta"].Value?.ToString()
                            .Replace("$", ""); 

                decimal precioVenta;
                if (!decimal.TryParse(precioVentaString, out precioVenta))
                {
                    precioVenta = 0; 
                }
                _Producto = new Entidades.Producto()
                {
                    IdProducto = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdProducto"].Value.ToString()),
                    Codigo = dgvdata.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvdata.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    PrecioVenta = precioVenta,
                    Stock = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
                };
                Console.WriteLine(precioVenta);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbusqueda.SelectedItem != null)
            {
                int catSelected = Convert.ToInt32(((OpcionCombo)cbbusqueda.SelectedItem).value);
                string searchText = txtBusqueda.Text.Trim().ToLower();
                dgvdata.Rows.Clear();
                List<Entidades.Producto> listaProd = new N_Producto().listar();

                if (esVenta)
                {
                    var filteredProd = listaProd
                    .Where(p =>
                        (catSelected == 0 || (p.oCategoria != null && p.oCategoria.IdCategoria == catSelected)) && // Filtrar por categoría si no es "Todos"
                        (string.IsNullOrEmpty(searchText) || // Si no hay texto de búsqueda, no filtrar por texto
                         (p.Codigo != null && p.Codigo.ToLower().Contains(searchText)) ||
                         (p.Nombre != null && p.Nombre.ToLower().Contains(searchText)) ||
                         (p.Descripcion != null && p.Descripcion.ToLower().Contains(searchText)) ||
                         (p.oCategoria != null && p.oCategoria.Descripcion.ToLower().Contains(searchText)) ||
                         (p.oProveedor != null && p.oProveedor.Documento != null && p.oProveedor.Documento.ToLower().Contains(searchText)) ||
                         (int.TryParse(searchText, out int stockValue) && p.Stock.HasValue && p.Stock.Value == stockValue)
                        ) && (p.PrecioVenta != 0)
                    ).ToList();
                    foreach (Entidades.Producto item in filteredProd)
                    {
                        dgvdata.Rows.Add(new object[]
                        {
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.oCategoria.IdCategoria,
                        item.oCategoria.Descripcion,
                        item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                        item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString() : "N/A",
                        item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                        });
                    }
                }
                else
                {
                    var filteredProd = listaProd
                    .Where(p =>
                        (catSelected == 0 || (p.oCategoria != null && p.oCategoria.IdCategoria == catSelected)) && // Filtrar por categoría si no es "Todos"
                        (string.IsNullOrEmpty(searchText) || // Si no hay texto de búsqueda, no filtrar por texto
                         (p.Codigo != null && p.Codigo.ToLower().Contains(searchText)) ||
                         (p.Nombre != null && p.Nombre.ToLower().Contains(searchText)) ||
                         (p.Descripcion != null && p.Descripcion.ToLower().Contains(searchText)) ||
                         (p.oCategoria != null && p.oCategoria.Descripcion.ToLower().Contains(searchText)) ||
                         (p.oProveedor != null && p.oProveedor.Documento != null && p.oProveedor.Documento.ToLower().Contains(searchText)) ||
                         (int.TryParse(searchText, out int stockValue) && p.Stock.HasValue && p.Stock.Value == stockValue)
                        ) 
                    ).ToList();
                    foreach (Entidades.Producto item in filteredProd)
                    {
                        dgvdata.Rows.Add(new object[]
                        {
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.oCategoria.IdCategoria,
                        item.oCategoria.Descripcion,
                        item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                        item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString() : "N/A",
                        item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                        });
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            cbbusqueda.SelectedIndex = 0;

            dgvdata.Rows.Clear();
            List<Entidades.Producto> listaProd = new N_Producto().listar();
            foreach (Entidades.Producto item in listaProd)
            {
                dgvdata.Rows.Add(new object[]
                {
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.oCategoria.IdCategoria,
                        item.oCategoria.Descripcion,
                        item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                        item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString() : "N/A",
                        item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                });
            }
        }
    }
}
