﻿using SistemaVentas.Usuarios;
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

namespace SistemaVentas.Clientes
{
    public partial class frmCliente : Form
    {
        private int selectedRowIndex = -1;
        private frmAddCliente frmAddCliente;
        private frmEditCliente frmEditCliente;
        private Cliente selectedCliente = null;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedCliente == null || selectedCliente.Estado == false)
            {
                MessageBox.Show("Por favor, selecciona un cliente para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nuevoEstado = false;
            DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas dar de baja el cliente '{selectedCliente.NombreCompleto}'", "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                bool resultado = new N_Cliente().baja(selectedCliente.IdCliente, nuevoEstado);
                if (resultado)
                {
                    selectedCliente.Estado = nuevoEstado;
                    dgvdata.Rows[selectedRowIndex].Cells["Estado"].Value = "Inactivo";

                    MessageBox.Show("Cliente dado de baja");

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado del cliente. Por favor, intente nuevamente.");
                }
            }
            dgvdata.Rows.Clear();
            List<Cliente> listCliente = new N_Cliente().Listar();
            foreach (Cliente item in listCliente)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmEditCliente != null && !frmEditCliente.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Agregar Cliente' mientras 'Editar Cliente' está abierto.");
                frmEditCliente.Focus();
                return;
            }

            if (frmAddCliente == null || frmAddCliente.IsDisposed)
            {
                frmAddCliente = new frmAddCliente(this);
                frmAddCliente.Show();
            }
            else
            {
                frmAddCliente.Focus();
            }
        }

        public DataGridView DgvData
        {
            get { return dgvdata; }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(selectedCliente == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (frmAddCliente != null && !frmAddCliente.IsDisposed)
            {
                MessageBox.Show("No se puede abrir 'Editar Cliente' mientras 'Agregar Cliente' está abierto.");
                frmAddCliente.Focus();
                return;
            }

            if (frmEditCliente == null || frmEditCliente.IsDisposed)
            {
                frmEditCliente = new frmEditCliente(this, selectedCliente, selectedRowIndex);
                frmEditCliente.Show();
            }
            else
            {
                frmEditCliente.Focus();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

            List<Cliente> listCliente = new N_Cliente().Listar();
            foreach(Cliente item in listCliente)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "Inactivo",
                });
            }

            
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                selectedRowIndex = e.RowIndex;

                if (selectedRowIndex >= 0)
                {

                    selectedCliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["IdCliente"].Value),
                        Documento = dgvdata.Rows[selectedRowIndex].Cells["Documento"].Value.ToString(),
                        NombreCompleto = dgvdata.Rows[selectedRowIndex].Cells["NombreCompleto"].Value.ToString(),
                        Correo = dgvdata.Rows[selectedRowIndex].Cells["Correo"].Value.ToString(),
                        Telefono = dgvdata.Rows[selectedRowIndex].Cells["Telefono"].Value.ToString(),
                        Estado = Convert.ToInt32(dgvdata.Rows[selectedRowIndex].Cells["EstadoValor"].Value) == 1
                    };
                    
                }
            }
        }

        private void dgvdata_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchText = txtBusqueda.Text.Trim().ToLower();

            List<Cliente> listaClientes = new N_Cliente().Listar();

            var clientesFiltrados = listaClientes
                .Where(c =>
                    c.Documento.ToLower().Contains(searchText) ||
                    c.NombreCompleto.ToLower().Contains(searchText) ||
                    c.Correo.ToLower().Contains(searchText) ||
                    c.Telefono.ToLower().Contains(searchText))
                .ToList();

            dgvdata.Rows.Clear();

            foreach (var cliente in clientesFiltrados)
            {
                dgvdata.Rows.Add(
                    "",
                    cliente.IdCliente,
                    cliente.Documento,
                    cliente.NombreCompleto,
                    cliente.Correo,
                    cliente.Telefono,
                    cliente.Estado ? 1 : 0,
                    cliente.Estado ? "Activo" : "Inactivo"
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;

            List<Cliente> listaClientes = new N_Cliente().Listar();

            dgvdata.Rows.Clear();

            foreach (var cliente in listaClientes)
            {
                dgvdata.Rows.Add(
                    "",
                    cliente.IdCliente,
                    cliente.Documento,
                    cliente.NombreCompleto,
                    cliente.Correo,
                    cliente.Telefono,
                    cliente.Estado ? 1 : 0,
                    cliente.Estado ? "Activo" : "Inactivo"
                );
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el cuadro de diálogo para guardar el archivo Excel
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    // Configurar el filtro para archivos Excel
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo Excel";
                    saveFileDialog.FileName = "Clientes.xlsx"; // Nombre sugerido para el archivo Excel

                    // Si el usuario selecciona una ubicación y hace clic en Guardar
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crear un libro de Excel usando ClosedXML
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            // Crear una hoja de cálculo llamada "Clientes"
                            var worksheet = workbook.Worksheets.Add("Clientes");

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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
