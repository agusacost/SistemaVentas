using Entidades;
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
    public partial class frmMuestra : Form
    {
        private Usuario _Usuario;
        public frmMuestra(Usuario user = null)
        {   
            _Usuario = user;
            InitializeComponent();
        }

        public Image ByteToImage(byte[] Imagebytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(Imagebytes, 0, Imagebytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmMuestra_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] Imagebytes = new N_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                picLogo.Image = ByteToImage(Imagebytes);
            lblusuario.Text = _Usuario.NombreCompleto.ToString();
            lbldiafecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
