﻿using SistemaVentas.Clientes;
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
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.oProveedor.Documento,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbbusqueda.SelectedItem != null)
            {
                int catSelected = Convert.ToInt32(((OpcionCombo)cbbusqueda.SelectedItem).value);
                string searchText = txtBusqueda.Text.Trim().ToLower();
                dgvdata.Rows.Clear();
                List<Entidades.Producto> listaProd = new N_Producto().listar();

                var filteredProd = listaProd
                .Where(p =>
                    (catSelected == 0 || p.oCategoria.IdCategoria == catSelected) && // Filtrar por categoría si no es "Todos"
                    (string.IsNullOrEmpty(searchText) || // Si no hay texto de búsqueda, no filtrar por texto
                     p.Codigo.ToLower().Contains(searchText) ||
                     p.Nombre.ToLower().Contains(searchText) ||
                     p.Descripcion.ToLower().Contains(searchText) ||
                     p.oCategoria.Descripcion.ToLower().Contains(searchText) ||
                     p.oProveedor.Documento.ToLower().Contains(searchText))
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
