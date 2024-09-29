using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Reportes
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
            ConfigurarDateTimePicker();
        }

        private void DateFechaFinC_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ConfigurarDateTimePicker()
        {
            DateFechaInicioC.Format = DateTimePickerFormat.Custom;
            DateFechaInicioC.CustomFormat = "yyyy-MM-dd";
            DateFechaFinC.Format = DateTimePickerFormat.Custom;
            DateFechaFinC.CustomFormat = "yyyy-MM-dd";
        }
    }
}
