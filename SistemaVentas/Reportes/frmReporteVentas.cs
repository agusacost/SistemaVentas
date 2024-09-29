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
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
            ConfigurarDateTimePicker();
        }

        private void DateFechaInicioV_ValueChanged(object sender, EventArgs e)
        {
           
        }
        private void ConfigurarDateTimePicker()
        {
            DateFechaInicioV.Format = DateTimePickerFormat.Custom;
            DateFechaInicioV.CustomFormat = "yyyy-MM-dd";
            DateFechaFinV.Format = DateTimePickerFormat.Custom;
            DateFechaFinV.CustomFormat = "yyyy-MM-dd";
        }

        private void IconoExcelC_Click(object sender, EventArgs e)
        {
           
              
        }
    }
}
