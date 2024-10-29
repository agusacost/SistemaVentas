using Entidades;
using Negocio;
using SistemaVentas.Usuarios;
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

namespace SistemaVentas.Producto
{
    public partial class frmEditarCategoria : Form
    {
        private Categoria categoria;
        private frmCategoria frmCategoria;
        private int selectedRowIndex;
        public frmEditarCategoria(frmCategoria formCategoria, Categoria objCategoria, int RowIndex)
        {
            this.categoria = objCategoria;
            frmCategoria = formCategoria;
            selectedRowIndex = RowIndex;
            InitializeComponent();
        }

        private void btnAgregarCatE_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoriaEdited = new Categoria()
                {
                    IdCategoria = categoria.IdCategoria,
                    Descripcion = TDescripcionCatE.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)CBEstadoE.SelectedItem).value) == 1
                };
                bool editar = new N_Categoria().editCat(categoriaEdited);
                if (editar)
                {
                    DataGridViewRow row = frmCategoria.DgvData.Rows[selectedRowIndex];
                    row.Cells["IdCategoria"].Value = categoriaEdited.IdCategoria;
                    row.Cells["Descripcion"].Value = categoriaEdited.Descripcion;
                    row.Cells["EstadoValor"].Value = categoriaEdited.Estado ? 1 : 0;
                    row.Cells["Estado"].Value = ((OpcionCombo)CBEstadoE.SelectedItem).Texto.ToString();
                    MessageBox.Show("Categoria editada con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la categoria.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            CBEstadoE.Items.Add(new OpcionCombo() { value = 1, Texto = "Activo" });
            CBEstadoE.Items.Add(new OpcionCombo() { value = 2, Texto = "Inactivo" });
            CBEstadoE.DisplayMember = "Texto";
            CBEstadoE.ValueMember = "value";

            TDescripcionCatE.Text = categoria.Descripcion;
            int estadoValue = categoria.Estado ? 1 : 2;
            foreach (OpcionCombo item in CBEstadoE.Items)
            {
                if ((int)item.value == estadoValue)
                {
                    CBEstadoE.SelectedItem = item;
                }
            }
        }
    }
}
