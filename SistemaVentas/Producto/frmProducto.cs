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
using SistemaVentas.Utilities;
using SistemaVentas.Usuarios;

namespace SistemaVentas.Producto
{
    public partial class frmProducto : Form
    {
        private frmAddProducto frmAddProducto;
        private frmEditarProducto frmEditarProducto;
        private int selectedRowIndex = -1;
        private Entidades.Producto selectedProduct = null;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configurar las propiedades del SaveFileDialog
                saveFileDialog.Filter = "Excel Files|*.xlsx"; // Solo mostrar archivos .xlsx
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "Productos.xlsx"; // Nombre sugerido por defecto

                // Si el usuario selecciona una ubicación y da clic en Guardar
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear el archivo Excel
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        // Crear una hoja de cálculo
                        var worksheet = workbook.Worksheets.Add("Productos");

                        // Agregar el encabezado de las columnas (basado en las columnas de tu DataGridView)
                        for (int i = 0; i < dgvdata.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvdata.Columns[i].HeaderText;
                        }

                        // Agregar los datos de las filas del DataGridView al archivo Excel
                        for (int i = 0; i < dgvdata.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvdata.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dgvdata.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                            }
                        }

                        // Guardar el archivo Excel en la ubicación seleccionada por el usuario
                        try
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Archivo Excel descargado con éxito en " + saveFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                        }
                    }
                }
            }
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
                frmAddProducto = new frmAddProducto(this);
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
                frmEditarProducto = new frmEditarProducto(this, selectedProduct, selectedRowIndex);
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
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                    item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString() : "N/A",
                    item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                    item.oProveedor != null ? item.oProveedor.IdProveedor : 0,
                    item.oProveedor != null ? item.oProveedor.Documento : "Sin Proveedor",
                    item.Estado == true ? 1:0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        //preguntar si se agrega doble filtro
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbusqueda.SelectedItem != null)
            {
                int catSelected = Convert.ToInt32(((OpcionCombo)cbbusqueda.SelectedItem).value);
                string searchText = txtBusqueda.Text.Trim().ToLower();
                dgvdata.Rows.Clear();
                List<Entidades.Producto> listaProd = new N_Producto().listar();

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
                        "",
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.Descripcion,
                        item.oCategoria != null ? item.oCategoria.IdCategoria : 0,
                        item.oCategoria != null ? item.oCategoria.Descripcion : "Sin Categoría",
                        item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                        item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString("C") : "N/A",
                        item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                        item.oProveedor != null ? item.oProveedor.IdProveedor : 0,
                        item.oProveedor != null ? item.oProveedor.Documento : "Sin Proveedor",
                        item.Estado ? 1 : 0,
                        item.Estado ? "Activo" : "Inactivo",
                    });
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
                        "",
                        item.IdProducto,
                        item.Codigo,
                        item.Nombre,
                        item.Descripcion,
                        item.oCategoria != null ? item.oCategoria.IdCategoria : 0,
                        item.oCategoria != null ? item.oCategoria.Descripcion : "Sin Categoría",
                        item.Stock.HasValue ? item.Stock.Value.ToString() : "N/A",
                        item.PrecioCompra.HasValue ? item.PrecioCompra.Value.ToString("C") : "N/A",
                        item.PrecioVenta.HasValue ? item.PrecioVenta.Value.ToString("C") : "N/A",
                        item.oProveedor != null ? item.oProveedor.IdProveedor : 0,
                        item.oProveedor != null ? item.oProveedor.Documento : "Sin Proveedor",
                        item.Estado ? 1 : 0,
                        item.Estado ? "Activo" : "Inactivo",
                });
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var cellWidth = e.CellBounds.Width;
                var cellHeight = e.CellBounds.Height;
                var icon = Properties.Resources.check_icon;
                int iconWidth = icon.Width;
                int iconHeight = icon.Height;
                float scale = Math.Min((float)cellWidth / iconWidth, (float)cellHeight / iconHeight);

                int newWidth = (int)(iconWidth * scale);
                int newHeight = (int)(iconHeight * scale);
                var x = e.CellBounds.Left + (cellWidth - newWidth) / 2;
                var y = e.CellBounds.Top + (cellHeight - newHeight) / 2;
                e.Graphics.DrawImage(icon, new Rectangle(x, y, newWidth, newHeight));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                selectedRowIndex = e.RowIndex;

                if (selectedRowIndex >= 0)
                {
                    selectedProduct = new Entidades.Producto
                    {
                        IdProducto = dgvdata.Rows[selectedRowIndex].Cells["IdProducto"].Value != null ? Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdProducto"].Value) : 0,
                        Codigo = dgvdata.Rows[selectedRowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty,
                        Nombre = dgvdata.Rows[selectedRowIndex].Cells["Nombre"].Value?.ToString() ?? string.Empty,
                        Descripcion = dgvdata.Rows[selectedRowIndex].Cells["Descripcion"].Value?.ToString() ?? string.Empty,
                        Stock = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["Stock"].Value) == 0 ? 0 : Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["Stock"].Value),
                        oCategoria = new Categoria()
                        {
                            IdCategoria = dgvdata.Rows[selectedRowIndex].Cells["IdCategoria"].Value != null ? Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdCategoria"].Value) : 0,
                            Descripcion = dgvdata.Rows[selectedRowIndex].Cells["Categoria"].Value?.ToString() ?? string.Empty
                        },
                        oProveedor = new Proveedor()
                        {
                            IdProveedor = dgvdata.Rows[selectedRowIndex].Cells["IdProveedor"].Value != null ? Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdProveedor"].Value) : 0,
                            Documento = dgvdata.Rows[selectedRowIndex].Cells["Proveedor"].Value?.ToString() ?? "Sin Proveedor"
                        },
                        Estado = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["EstadoValor"].Value) == 1
                    };
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Por favor, selecciona un Producto para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nuevoEstado = false;
            DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas dar de baja el producto '{selectedProduct.Nombre}'", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                
                bool resultado = new N_Producto().Delete(selectedProduct.IdProducto, nuevoEstado);
                if (resultado)
                {
                    selectedProduct.Estado = nuevoEstado;
                    dgvdata.Rows[selectedRowIndex].Cells["Estado"].Value = "Inactivo";

                    MessageBox.Show("Producto dado de baja");

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado del producto. Por favor, intente nuevamente.");
                }
            }
        }
    }
}
