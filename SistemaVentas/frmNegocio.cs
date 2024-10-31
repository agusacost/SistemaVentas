using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] Imagebytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(Imagebytes, 0, Imagebytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] Imagebytes = new N_Negocio().ObtenerLogo(out obtenido);

            if(obtenido)
                picLogo.Image = ByteToImage(Imagebytes);

            Entidades.Negocio datos = new N_Negocio().getData();

            txtNombre.Text = datos.Nombre;
            txtCuit.Text = datos.CUIT;   
            txtDireccion.Text = datos.Direccion;
            txtProvincia.Text = datos.Provincia;
            txtLocalidad.Text = datos.Localidad;

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpeg;*.jpg;*.png";

            if(oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new N_Negocio().ActualizarLogo(byteimage,out mensaje);

                if (respuesta)
                {
                    picLogo.Image = ByteToImage(byteimage);

                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty ;
            Entidades.Negocio obj = new Entidades.Negocio()
            {
                Nombre = txtNombre.Text,
                CUIT = txtCuit.Text,
                Direccion = txtDireccion.Text,
                Provincia = txtProvincia.Text,
                Localidad = txtLocalidad.Text
            };
            bool respuesta = new N_Negocio().GurardarDatos(obj,out  mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("No fueron guardados los cambios ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
