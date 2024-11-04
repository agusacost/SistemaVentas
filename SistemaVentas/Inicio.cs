using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FontAwesome.Sharp;
using SistemaVentas.Usuarios;
using SistemaVentas.Producto;
using SistemaVentas.Ventas;
using SistemaVentas.Compras;
using SistemaVentas.Clientes;
using SistemaVentas.Reportes;
using Negocio;

namespace SistemaVentas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioLogged;
        private static IconMenuItem MenuActivo = null;
        private static Form formActivo = null;
        public Inicio(Usuario objusuario)
        {
           usuarioLogged = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new N_Permiso().Listar(usuarioLogged.IdUsuario);

            foreach (var item in Menu.Items)
            {
                if (item is IconMenuItem iconmenu)
                {
                    bool find = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                    if (!find)
                    {
                        iconmenu.Visible = false;
                    }
                }
            }


            lbUsuario.Text = usuarioLogged.NombreCompleto.ToString();
        }

        private void openForm(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null) {
                MenuActivo.BackColor = Color.LightSlateGray;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (formActivo != null) { 
                formActivo.Close();
            }

            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            Container.Controls.Add(formulario);
            formulario.Show();

        }
        private void UserLabel_Click(object sender, EventArgs e)
        {
            openForm((IconMenuItem)sender, new frmUsuario());
        }
        private void subCategoria_Click(object sender, EventArgs e)
        {
            openForm(SettingsLabel, new frmCategoria());
        }
        private void subProducto_Click(object sender, EventArgs e)
        {
            openForm(SettingsLabel, new frmProducto());
        }

        private void subRegistrarVta_Click(object sender, EventArgs e)
        {
            openForm(VentasLabel, new frmVentas(usuarioLogged));
        }

        private void subDetalleVenta_Click(object sender, EventArgs e)
        {
            if (usuarioLogged.oRol.idRol == 1)
            {
                openForm(VentasLabel, new frmVentaDetalle());

            }
            else
            {
                openForm(VentasLabel, new frmVtasGral());
            }
        }
        private void subRegistrarCompra_Click(object sender, EventArgs e)
        {
            openForm(ComprasLabel, new frmCompras(usuarioLogged));
        }
        private void subDetalleCompra_Click(object sender, EventArgs e)
        {
            openForm(ComprasLabel, new frmCompraDetalle());
        }
        private void ClientesLabel_Click(object sender, EventArgs e)
        {
            openForm((IconMenuItem)sender, new frmCliente());
        }

        private void ProveedoresLabel_Click(object sender, EventArgs e)
        {
            openForm((IconMenuItem)sender, new frmProveedor());
        }

        private void ReportesLabel_Click(object sender, EventArgs e)
        {
            openForm((IconMenuItem)sender, new frmReporte());

        }

        private void AcercaLabel_Click(object sender, EventArgs e)
        {
            openForm((IconMenuItem)sender, new frmAcercaDe());
        }

        private void subMenuNegocio_Click(object sender, EventArgs e)
        {
            openForm(SettingsLabel, new frmNegocio());
        }
    }
}
